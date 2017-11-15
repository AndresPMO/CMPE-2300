using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_AndresMOuellette
{
    class Package : IComparable
    {
        public string _name { get; set; }
        private List<string> _lPackDependencies = new List<string>();
        public List<string> lPackDependencies { get { return _lPackDependencies.GetRange(0, _lPackDependencies.Count); } }

        public Package(string[] sArray) //gotta think about this more
        {
            _name = sArray[0];
            for(int x = 1; x < sArray.Length; x++)
            {
                if (!(lPackDependencies.Contains(sArray[x])))
                {
                    lPackDependencies.Add(sArray[x]);
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Package)) return false;
            else
            {
                Package tempPackage = obj as Package;
                return this._name.Equals(tempPackage._name);
            }
        }
        public override int GetHashCode()
        {
            return 1;
        }

        public override string ToString()
        {
            string tempString = "";
            for(int i = 0; i < lPackDependencies.Count - 1; i++)
            {
                if(i == lPackDependencies.Count - 1)
                {
                    tempString += lPackDependencies[i];
                }
                tempString += $"{lPackDependencies[i]}, ";
            }
            return tempString;
        }

        public int CompareTo(object obj)
        {
            if(!(obj is string))
            {
                throw new ArgumentException("Not a valid name or null.");
            }
            else
            {
                string tempName = obj as string;
                return _name.CompareTo(tempName);
            }
        }
        public static int CompareCountbyName(Package pack1, Package pack2)
        {
            if(pack1._name.CompareTo(pack2._name) == 0)
            {
                return pack1.lPackDependencies.Count.CompareTo(pack2.lPackDependencies.Count);
            }
            else
            {
                return pack1._name.CompareTo(pack2._name);
            }
        }
        public static int CompareNamebyCount(Package pack1, Package pack2)
        {
            if (pack1.lPackDependencies.Count.CompareTo(pack2.lPackDependencies.Count) == 0)
            {
                return pack1._name.CompareTo(pack2._name);
            }
            else
            {
                return pack1.lPackDependencies.Count.CompareTo(pack2.lPackDependencies.Count);
            }
        }

        public void MergePackage(Package inPack)
        {
            if(this._name.CompareTo(inPack._name) != 0)
            {
                throw new ArgumentException("Names are not the same.");
            }
            else
            {
                for (int x = 1; x < inPack.lPackDependencies.Count; x++)
                {
                    if (!(lPackDependencies.Contains(inPack.lPackDependencies[x])))
                    {
                        lPackDependencies.Add(inPack.lPackDependencies[x]);
                    }
                }
            }
        }
    }
}
