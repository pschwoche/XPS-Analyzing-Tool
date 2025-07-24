using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace XPSAnalyzingTool.Funktionen
{
    public class Gaussian : Funktion
    {
        public Gaussian()
        {
            this.Name = "Gaussian";
            Parameter Pos = new Parameter("Pos", 0);
            Parameter FWHM = new Parameter("FWHM", 1.0);
            Parameter Int = new Parameter("Int", 100.0);
            this.Params = new Parameter[] { Pos, FWHM, Int };
        }
    }
}
