using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Subro.Controls;

namespace XPSAnalyzingTool
{
    public partial class FitForm : Form
    {

        private DataEntry dataEntry;

        DataGridViewGrouper grouper;
        public FitForm(DataEntry DataEntry)
        {
            this.dataEntry = DataEntry;
            InitializeComponent();
            grouper = new DataGridViewGrouper(dataGridView1);




            this.Visible = true;
            List<Test> testData = new List<Test>
            {
                new Test { Name = "Name1"}.AddProp("Prop-1a").AddProp("Prop-1b"),
                new Test { Name = "Name2"}.AddProp("Prop-2a").AddProp("Prop-2b"),
                // Weitere Test-Objekte hinzufügen
            };
            
            grouper.SetGroupOn<Test>(t => t.Name);
        }


        private void FitForm_Load(object sender, EventArgs e)
        {
          

        }


    }

    public class Test
    {
        public string Name { get; set; }
        public List<string> Props { get; set; }


        public Test()
        {
            Props = new List<string>();
        }
        public Test AddProp(String str)
        {
            Props.Add(str);
            return this;
        }


    }


}