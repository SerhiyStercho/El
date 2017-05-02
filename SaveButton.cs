using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicCircles
{
    [Serializable]
    class SaveButton
    {
       public  List<bool> one = new List<bool>();
       public List<bool> two = new List<bool>();
       public List<bool> three = new List<bool>();
       public List<bool> four = new List<bool>();
       public List<bool> five = new List<bool>();
       public int numberInList;
       public SaveButton() {
            
       }

        public void addButton(bool on, bool tw, bool thr, bool fou, bool fiv) {
            one.Add(on);
            two.Add(tw);
            three.Add(thr);
            four.Add(fou);
            five.Add(fiv);
        }

        public void addIndex(int numberInList) {
            this.numberInList = numberInList;
        }

        public bool[] getArrayOfBool() {
            TestPage test = new TestPage();
            bool[] barr = new bool[5];
            //if (one.Count!=0) {
                barr[0] = one[numberInList];
                barr[1] = two[numberInList];
                barr[2] = three[numberInList];
                barr[3] = four[numberInList];
                barr[4] = five[numberInList];
            //}
            return barr;
        }

        public void cleanList() {
            one.Clear();
            two.Clear();
            three.Clear();
            four.Clear();
            five.Clear();
        }
    }
}
