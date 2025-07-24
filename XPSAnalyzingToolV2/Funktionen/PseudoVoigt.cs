using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace XPSAnalyzingTool.Funktionen
{
    public class PseudoVoigt : Funktion
    {
        public PseudoVoigt()
        {
            this.Name = "PseudoVoigt";
            Parameter Pos = new Parameter("Pos", 0);
            Parameter FWHM = new Parameter("FWHM", 1.0);
            Parameter Int = new Parameter("Int", 100.0);
            Parameter Gamma = new Parameter("Gamma", 0.5);
            this.Params = new Parameter[] { Pos, FWHM, Int, Gamma };
        }
    }
}
