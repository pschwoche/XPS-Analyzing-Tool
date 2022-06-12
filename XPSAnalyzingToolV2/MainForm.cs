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
    public partial class MainForm : Form
    {

        public List<DataEntry> dataEntries;

        private ZedGraph.GraphPane bigGraphPane;
        private ZedGraph.GraphPane smallGraphPane;




        public MainForm()
        {
            InitializeComponent();


            InitDataViewGrids();

        }

        private void InitDataViewGrids()
        {

        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFileForm lfform = new LoadFileForm();
        }
    }
}
