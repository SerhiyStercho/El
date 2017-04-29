using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicCircles
{
     
    class SaveButton
    {
       public List<bool> one = new List<bool>();
       public List<bool> two = new List<bool>();
       public List<bool> three = new List<bool>();
       public List<bool> four = new List<bool>();
       public List<bool> five = new List<bool>();
      

        public SaveButton(bool on,bool tw,bool thr,bool fou,bool fiv){
            one.Add(on);
            two.Add(tw);
            three.Add(thr);
            four.Add(fou);
            five.Add(fiv);
        }
    }
}
