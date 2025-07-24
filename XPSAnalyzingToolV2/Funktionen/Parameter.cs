using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPSAnalyzingTool.Funktionen
{
    public class Parameter
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public Parameter(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}
