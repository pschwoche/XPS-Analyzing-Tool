using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XPSAnalyzingTool.Funktionen;

namespace XPSAnalyzingTool
{
    public class FitEntry
    {

        public List<Funktion> Fitfunktionen { get; set; }


        public FitEntry()
        {
            Fitfunktionen= new List<Funktion>();



        }

        public void AddFunktion(Funktion newFunk)
        {
            string newFunkName = newFunk.Name;
            int i = 0;
            bool properNameFound = false;
            while (!properNameFound)
            {
                properNameFound= true;
                foreach (Funktion f in Fitfunktionen)
                {
                    if (f.Name.Equals($"{newFunkName}-{i}"))
                    {
                        i++;
                        properNameFound= false;
                        break;
                    }
                }
            }
            newFunk.Name = $"{newFunkName}-{i}";

            this.Fitfunktionen.Add(newFunk);

        }


    }
}
