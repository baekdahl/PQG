using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCG
{
    class ReadTxt
    {
        public string[] motivationText = System.IO.File.ReadAllLines(@"motivationText.txt");
        public string[] ruleText = System.IO.File.ReadAllLines(@"ruleText.txt");
    }
}
