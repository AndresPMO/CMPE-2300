using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_AndresMOuellette
{
    public partial class Form1 : Form
    {
        List<Package> lLoadedPacks = new List<Package>(); //A list of all our Packs, loaded from the selected file
        List<Package> lInstallablePacks = new List<Package>(); //A list of all our installable Packs
        List<Package> lUninstallablePacks = new List<Package>(); //A list of all our uninstallable Packs

        private enum SortType { eRawListAccess, eLibraryListHelpers, eBinarySearch }
        
        // Create Form, Inform user of the project's name, set the default search to "RawListAccess"
        //set the list view to show "All Packages" by default
        public Form1()
        {
            InitializeComponent();
            Text = "Lab02 - Install-o-tron";
            TSListViewComboBox.SelectedIndex = 0;
            TSAlgorithmComboBox.SelectedIndex = 0;
        }
        
        private void Form1_Resize(object sender, EventArgs e)
        {
            //keeps the byte size column filling the width of the window
            listView.Columns[1].AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        
        private void TSLoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Start afresh
                lLoadedPacks.Clear();
                lInstallablePacks.Clear();
                lUninstallablePacks.Clear();

                //Split all lines in file, then split package dependancies from said lines
                //If pack doesnt exist, make anew one. If it does, add non-existant dependancies
                //to already existing dependancies
                string[] allLines = System.IO.File.ReadAllLines(openFileDialog.FileName);
                string[] packInput;
                Package tempPack; 
                foreach (string line in allLines)
                {
                    packInput = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    tempPack = new Package(packInput);

                    if (!(lLoadedPacks.Contains(tempPack)))
                    {
                        lLoadedPacks.Add(tempPack);
                    }
                    else
                    {
                        lLoadedPacks[lLoadedPacks.IndexOf(tempPack)].MergePackage(tempPack);
                    }
                }

                TSListViewComboBox.SelectedIndex = 0;
                ShowSelectedLoad();
            }
        }

        /// <summary>
        /// Clear the ListView to begin anew, then iterate through every loaded Package
        /// and add them to the "new" ListView.
        /// </summary>
        private void ShowSelectedLoad()
        {
            listView.Items.Clear();
            List<Package> lTempPacks;
            int selection = TSListViewComboBox.SelectedIndex;
            switch (selection)
            {
                case 0:
                    lTempPacks = lLoadedPacks;
                    break;
                case 1:
                    lTempPacks = lLoadedPacks;
                    break;
                case 2:
                    lTempPacks = lUninstallablePacks;
                    break;
                default:
                    lTempPacks = null;
                    break;
            }
            foreach (Package pack in lTempPacks)
            {
                ListViewItem tempItem = new ListViewItem(new[] { pack._name, pack.ToString() });
                listView.Items.Add(tempItem);
            }
            SSLoadedStatusLabel.Text = $"{lLoadedPacks.Count} Packages Loaded";
            SSInstallableStatusLabel.Text = $"{lInstallablePacks.Count} Packages Installable";
            SSUninstallableStatusLabel.Text = $"{lUninstallablePacks.Count} Packages UnInstallable";
        }

        /// <summary>
        /// (1)Starting off fresh by making every loaded pack uninstallable, clear the previous
        ///    installed packs, (2)and install depending on the selected algorithm in the form. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TSAnalyzeButton_Click(object sender, EventArgs e)
        {
            //(1)
            if (lLoadedPacks.Count > 0)
            {
                lUninstallablePacks = new List<Package>(lLoadedPacks);
                lInstallablePacks = new List<Package>();
            }
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();

            //(2)
            SortType sortType = (SortType)TSAlgorithmComboBox.SelectedIndex;
            stopwatch.Restart();
            switch (sortType)
            {
                case SortType.eRawListAccess:
                    RawListInstall();
                    break;
                case SortType.eLibraryListHelpers:
                    LibraryListInstall();
                    break;
                case SortType.eBinarySearch:
                    SortedListInstall();
                    break;
            }
            stopwatch.Stop();
            Text = stopwatch.Elapsed.TotalSeconds.ToString("F4");

            TSListViewComboBox.SelectedIndex = 1;

            ShowSelectedLoad();
        }

        /// <summary>
        /// (1)Repeatedly iterate through all uninstalled packs to eventually find all the installable
        ///    ones, and move them into the list of installed packs. Do this by checking for each
        ///    uninstalled Pack's dependancies if (2)it has none then, (3)call upon RawListInstall(Pack)
        ///    helper method, checking with each installed Pack if it already has been installed.
        /// </summary>
        private void RawListInstall()
        {
            //(1)
            bool install; //has there been an install
            do
            {
                install = false;
                foreach (Package uninstallablePack in lUninstallablePacks)
                {
                    //(2)
                    if (uninstallablePack.lPackDependencies.Count == 0)
                    {
                        lInstallablePacks.Add(uninstallablePack);
                        lUninstallablePacks.Remove(uninstallablePack);
                        install = true;
                        break;
                    }
                    
                    //(3)
                    else if (RawListInstall(uninstallablePack))
                    {
                        lInstallablePacks.Add(uninstallablePack);
                        install = true;
                        lUninstallablePacks.Remove(uninstallablePack);
                        break;
                    }
                }
                 
            }
            while (install == true);
        }

        /// <summary>
        /// Look through all uninstalled Packages, installing the ones who can be by checking
        /// their dependancies, calling upon LibraryListInstall(Package) helper method.
        /// </summary>
        private void LibraryListInstall()
        {
            bool install;
            do
            {
                install = false;
                foreach (Package uninstallablePack in lUninstallablePacks)
                {
                    if (uninstallablePack.lPackDependencies.Count == 0)
                    {
                        lInstallablePacks.Add(uninstallablePack);
                        lUninstallablePacks.Remove(uninstallablePack);
                        install = true;
                        break;
                    }
                    else if (LibraryListInstall(uninstallablePack))
                    {
                        lInstallablePacks.Add(uninstallablePack);
                        lUninstallablePacks.Remove(uninstallablePack);
                        install = true;
                        break;
                    }
                }
            }
            while (install);
        }

        /// <summary>
        /// Look through all uninstalled Packages, installing the ones who can be by checking
        /// their dependancies, calling upon SortedListInstall(Package) helper method.
        /// </summary>
        private void SortedListInstall()
        {
            bool install;
            do
            {
                install = false;
                foreach (Package uninstallablePack in lUninstallablePacks)
                {
                    if (uninstallablePack.lPackDependencies.Count == 0)
                    {
                        lInstallablePacks.Add(uninstallablePack);
                        lUninstallablePacks.Remove(uninstallablePack);
                        install = true;
                        break;
                    }
                    else if (SortedListInstall(uninstallablePack))
                    {
                        lInstallablePacks.Add(uninstallablePack);
                        lUninstallablePacks.Remove(uninstallablePack);
                        install = true;
                        break;
                    }
                }
            }
            while (install);
        }

        //Update what the list view shows us each time a new selection in the ListViewCombobox chages
        private void TSListViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowSelectedLoad();
        }

        /// <summary>
        /// Iterate through each dependancy of the input Package, checking with each installable Package
        /// if the dependancy is the same as the installable Package's name.
        /// </summary>
        /// <param name="pack">input Package with whom to check dependancies</param>
        /// <returns>If input Package can be installed</returns>
        bool RawListInstall(Package pack)
        {
            bool canInstall = false; //can you install it
            foreach (string dependantPack in pack.lPackDependencies)
            {
                canInstall = false;
                foreach (Package installablePack in lInstallablePacks)
                {
                    if (dependantPack != installablePack._name)
                    {
                        canInstall = false;
                    }
                    else
                    {
                        canInstall = true;
                        break;
                    }
                }
                if (!canInstall)
                {
                    break;
                }
            }
            return canInstall;
        }

        /// <summary>
        /// Check to see if every dependancy exists in the installable Packs by using a Contains()
        /// for the installable Packs, within a TrueForAll() for the input Package's dependancies.
        /// </summary>
        /// <param name="pack">input Package with whom to check dependancies</param>
        /// <returns>If input Package can be installed</returns>
        bool LibraryListInstall(Package pack)
        {
            return pack.lPackDependencies.TrueForAll(dependancy => lInstallablePacks.Contains(new Package(new[] { dependancy })));
        }

        /// <summary>
        /// Sort the list of installable Packages, then check to see if every dependancy exists in the installable Packs by using a 
        /// BinarySearch() for the installable Packs, within a TrueForAll() for the input Package's dependancies.
        /// </summary>
        /// <param name="pack">input Package with whom to check dependancies</param>
        /// <returns>If input Package can be installed</returns>
        bool SortedListInstall(Package pack)
        {
            lInstallablePacks.Sort();
            return pack.lPackDependencies.TrueForAll(dependancy => lInstallablePacks.BinarySearch(new Package(new[] { dependancy })) >= 0);
        }

        private void listView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column == 0)
            {
                if(TSListViewComboBox.SelectedIndex == 0)
                {
                    lLoadedPacks.Sort(); //Package.CompareCountbyName
                }
                else if(TSListViewComboBox.SelectedIndex == 1)
                {
                    lInstallablePacks.Sort(); //Package.CompareCountbyName
                }
                else
                {
                    lUninstallablePacks.Sort(); //Package.CompareCountbyName
                }
            }
            else if(e.Column == 1)
            {
                if (TSListViewComboBox.SelectedIndex == 0)
                {
                    lLoadedPacks.Sort(); //Package.CompareNamebyCount
                }
                else if (TSListViewComboBox.SelectedIndex == 1)
                {
                    lInstallablePacks.Sort(); //Package.CompareNamebyCount
                }
                else
                {
                    lUninstallablePacks.Sort(); //Package.CompareNamebyCount
                }
            }
            ShowSelectedLoad();
        }
    }
}
