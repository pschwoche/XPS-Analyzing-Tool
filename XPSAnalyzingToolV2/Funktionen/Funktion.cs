using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPSAnalyzingTool.Funktionen
{
    public abstract class Funktion
    {
        public string Name { get; set; }
        public Parameter[] Params { get; set; }

        public Funktion() { this.Name = ""; }

        public Funktion(string name, Parameter[] parameters)
        {
            this.Name = name;
            this.Params = parameters;
        }

        public Funktion(string name, int num)
        {
            this.Name = name;
            this.Params = new Parameter[num];
        }
    }
}