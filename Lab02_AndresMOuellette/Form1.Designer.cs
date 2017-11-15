namespace Lab02_AndresMOuellette
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TSLoadButton = new System.Windows.Forms.ToolStripButton();
            this.TSAnalyzeButton = new System.Windows.Forms.ToolStripButton();
            this.TSAlgorithmComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.TSListViewComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.listView = new System.Windows.Forms.ListView();
            this.Package = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dependencies = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.SSLoadedStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSInstallableStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SSUninstallableStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSLoadButton,
            this.TSAnalyzeButton,
            this.TSAlgorithmComboBox,
            this.TSListViewComboBox});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(804, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // TSLoadButton
            // 
            this.TSLoadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSLoadButton.Image = ((System.Drawing.Image)(resources.GetObject("TSLoadButton.Image")));
            this.TSLoadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSLoadButton.Name = "TSLoadButton";
            this.TSLoadButton.Size = new System.Drawing.Size(58, 22);
            this.TSLoadButton.Text = "Load File";
            this.TSLoadButton.Click += new System.EventHandler(this.TSLoadButton_Click);
            // 
            // TSAnalyzeButton
            // 
            this.TSAnalyzeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TSAnalyzeButton.Image = ((System.Drawing.Image)(resources.GetObject("TSAnalyzeButton.Image")));
            this.TSAnalyzeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSAnalyzeButton.Name = "TSAnalyzeButton";
            this.TSAnalyzeButton.Size = new System.Drawing.Size(52, 22);
            this.TSAnalyzeButton.Text = "Analyze";
            this.TSAnalyzeButton.Click += new System.EventHandler(this.TSAnalyzeButton_Click);
            // 
            // TSAlgorithmComboBox
            // 
            this.TSAlgorithmComboBox.Items.AddRange(new object[] {
            "Raw List Access",
            "Library Helpers",
            "Binary Search"});
            this.TSAlgorithmComboBox.Name = "TSAlgorithmComboBox";
            this.TSAlgorithmComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // TSListViewComboBox
            // 
            this.TSListViewComboBox.Items.AddRange(new object[] {
            "All Packages",
            "Loadable Packages",
            "Unloadable Packages"});
            this.TSListViewComboBox.Name = "TSListViewComboBox";
            this.TSListViewComboBox.Size = new System.Drawing.Size(121, 25);
            this.TSListViewComboBox.SelectedIndexChanged += new System.EventHandler(this.TSListViewComboBox_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Package,
            this.Dependencies});
            this.listView.Location = new System.Drawing.Point(0, 29);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(804, 479);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            // 
            // Package
            // 
            this.Package.Text = "Package";
            this.Package.Width = 315;
            // 
            // Dependencies
            // 
            this.Dependencies.Text = "Dependancies";
            this.Dependencies.Width = 222;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SSLoadedStatusLabel,
            this.SSInstallableStatusLabel,
            this.SSUninstallableStatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 511);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(804, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // SSLoadedStatusLabel
            // 
            this.SSLoadedStatusLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SSLoadedStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SSLoadedStatusLabel.Name = "SSLoadedStatusLabel";
            this.SSLoadedStatusLabel.Size = new System.Drawing.Size(112, 17);
            this.SSLoadedStatusLabel.Text = "X Packages Loaded";
            // 
            // SSInstallableStatusLabel
            // 
            this.SSInstallableStatusLabel.BackColor = System.Drawing.Color.LightGreen;
            this.SSInstallableStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SSInstallableStatusLabel.Name = "SSInstallableStatusLabel";
            this.SSInstallableStatusLabel.Size = new System.Drawing.Size(128, 17);
            this.SSInstallableStatusLabel.Text = "X Packages Installable";
            // 
            // SSUninstallableStatusLabel
            // 
            this.SSUninstallableStatusLabel.BackColor = System.Drawing.Color.Tomato;
            this.SSUninstallableStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SSUninstallableStatusLabel.Name = "SSUninstallableStatusLabel";
            this.SSUninstallableStatusLabel.Size = new System.Drawing.Size(143, 17);
            this.SSUninstallableStatusLabel.Text = "X Packages Uninstallable";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 533);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.ToolStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton TSLoadButton;
        private System.Windows.Forms.ToolStripButton TSAnalyzeButton;
        private System.Windows.Forms.ToolStripComboBox TSAlgorithmComboBox;
        private System.Windows.Forms.ToolStripComboBox TSListViewComboBox;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel SSLoadedStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SSInstallableStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel SSUninstallableStatusLabel;
        private System.Windows.Forms.ColumnHeader Package;
        private System.Windows.Forms.ColumnHeader Dependencies;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

