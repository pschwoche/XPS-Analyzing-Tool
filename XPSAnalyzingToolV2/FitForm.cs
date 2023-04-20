using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPSAnalyzingTool
{
    public partial class FitForm : Form
    {

        public FitForm()
        {
            InitializeComponent();
            this.Visible = true;
            List<Test> testData = new List<Test>
            {
                new Test { Name = "Name1", Prop1 = "Prop1_1", Prop2 = "Prop2_1" },
                new Test { Name = "Name2", Prop1 = "Prop1_2", Prop2 = "Prop2_2" },
                // Weitere Test-Objekte hinzufügen
            };
        }


        private void FitForm_Load(object sender, EventArgs e)
        {



        }
    }




        public class Test
        {
            public string Name { get; set; }
            public string Prop1 { get; set; }
            public string Prop2 { get; set; }
        }
   




}