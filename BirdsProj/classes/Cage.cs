using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdsProj.classes
{
    public class Cage
    {
        public string serialNUmber { get; set; }
        public string length { get; set; }
        public string height { get; set; }
        public string width { get; set; }
        public string matirial { get; set; }


        public Cage(string s,string l,string h,string w,string m) 
        {
            serialNUmber = s;
            length = l;
            height = h;
            width = w;
            matirial = m;
        }
    }
}
