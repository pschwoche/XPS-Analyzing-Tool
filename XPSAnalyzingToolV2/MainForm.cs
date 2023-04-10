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
using ZedGraph;

namespace XPSAnalyzingTool
{
    public partial class MainForm : Form
    {

        private List<DataEntry> dataEntries;

        private ZedGraph.GraphPane bigGraphPane;
        private ZedGraph.GraphPane smallGraphPane;
        BindingList<DataEntry> blist_data;
        BindingList<Person> people;

        private int selectedDataEntryIndex = -1;



        public MainForm()
        {
            this.dataEntries = new List<DataEntry>();
            people = new BindingList<Person>();
            blist_data = new BindingList<DataEntry>();
            blist_data.ListChanged += DataListChanged;
            //blist_data.ListChanged += updateZedGraphBig;

            InitializeComponent();
            this.numericUpDownHeightOffsetData.Maximum = Decimal.MaxValue;

            CheckSelectedGraphIndex();
            InitDataViewGrids();


            InitZedGraphs();
            people.ListChanged += FitListChanged;

        }

        private void InitDataViewGrids()
        {
            InitDataGridViewData();
            InitDataGridViewFit();
        }


        private void InitZedGraphs()
        {
            InitZedGraphBig();
            InitZedGraphSmall();
        }

        private void InitZedGraphBig()
        {
            this.bigGraphPane = this.zedGraphControlBig.GraphPane;
        }

        private void InitZedGraphSmall()
        {
            this.smallGraphPane = this.zedGraphControlSmall.GraphPane;
        }

        private PointPairList GetModifiedPPL(DataEntry dataEntry)
        {
            PointPairList ppl_mod = new PointPairList();    
            foreach( PointPair pp in dataEntry.PPL_data)
            {
                ppl_mod.Add(new PointPair(pp.X,pp.Y+dataEntry.GraphProperties.Offset));
            }
            return ppl_mod;

        }

        private void updateZedGraphBig()
        {
            bigGraphPane.CurveList.Clear();
            foreach (DataEntry dataEntry in dataEntries)
            {
                if (dataEntry.GraphProperties.IsVisible)
                {
                    LineItem lineitem = this.bigGraphPane.AddCurve(dataEntry.GraphProperties.LineItem.Label.Text, GetModifiedPPL(dataEntry), Color.OrangeRed);
                    lineitem.Line = dataEntry.GraphProperties.LineItem.Line;
                    lineitem.Symbol = dataEntry.GraphProperties.LineItem.Symbol;
                }
            }
            zedGraphControlBig.AxisChange();
            zedGraphControlBig.Invalidate();
            zedGraphControlBig.Refresh();
        }




        private void InitDataGridViewData()
        {
            dataGridViewData.AutoGenerateColumns = false;
            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Name";
            nameColumn.DataPropertyName = "Name";
            dataGridViewData.Columns.Add(nameColumn);

            dataGridViewData.DataSource = blist_data;

        }
        private void InitDataGridViewFit()
        {
            dataGridViewFit.AutoGenerateColumns = false;
            people.Add(new Person("Alice", "Smith", 25));
            people.Add(new Person("Bob", "Jones", 30));
            people.Add(new Person("Charlie", "Johnson", 35));


            DataGridViewTextBoxColumn fullNameColumn = new DataGridViewTextBoxColumn();
            fullNameColumn.HeaderText = "Full Name";
            fullNameColumn.DataPropertyName = "FullName";
            dataGridViewFit.Columns.Add(fullNameColumn);

            DataGridViewTextBoxColumn ageCategoryColumn = new DataGridViewTextBoxColumn();
            ageCategoryColumn.HeaderText = "Age Category";
            ageCategoryColumn.DataPropertyName = "AgeCategory";
            dataGridViewFit.Columns.Add(ageCategoryColumn);

            dataGridViewFit.DataSource = people;

        }

        private void DataListChanged(object sender, ListChangedEventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = blist_data;
        }
        private void FitListChanged(object sender, ListChangedEventArgs e)
        {
            dataGridViewFit.DataSource = null;
            dataGridViewFit.DataSource = people;
        }

        private void CheckSelectedGraphIndex()
        {
            if (selectedDataEntryIndex >= 0 || selectedDataEntryIndex < this.dataEntries.Count)
            {
                this.groupBoxGraphVisuals.Enabled = true;
            } else
            {
                this.groupBoxGraphVisuals.Enabled = false;

            }
        }

        private void dataGridViewData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the current cell and select it
                dataGridViewData.CurrentCell = dataGridViewData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dataGridViewData.Rows[e.RowIndex].Selected = true;
                selectedDataEntryIndex = e.RowIndex;
                CheckSelectedGraphIndex();
                // Show the context menu at the location of the mouse click

                DataEntry selectedDataEntry = dataGridViewData.Rows[e.RowIndex].DataBoundItem as DataEntry;

                if (selectedDataEntry != null)
                {
                    // Create a new ContextMenuStrip and add items to it
                    var contextMenuStrip = new ContextMenuStrip();

                    contextMenuStrip.Items.Add("Fit", null, (s, ev) =>
                    {
                        string str = selectedDataEntry.Name;
                        System.Diagnostics.Debug.WriteLine($"Fit: {str}");
                    });



                    contextMenuStrip.Items.Add("Delete", null, (s, ev) =>
                    {
                        string str = selectedDataEntry.Name;
                        System.Diagnostics.Debug.WriteLine($"Delete: {str}");
                    });



                    // Show the context menu at the location of the mouse click
                    contextMenuStrip.Show(dataGridViewData, e.Location);
                }
            }
            if ((e.Button == MouseButtons.Left || e.Button == MouseButtons.Right) && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                // Get the current cell and select it
                dataGridViewData.CurrentCell = dataGridViewData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dataGridViewData.Rows[e.RowIndex].Selected = true;
                selectedDataEntryIndex = e.RowIndex;
                
                // Show the context menu at the location of the mouse click

                DataEntry selectedDataEntry = dataGridViewData.Rows[e.RowIndex].DataBoundItem as DataEntry;

                this.selectedDataEntryIndex = e.RowIndex;
                CheckSelectedGraphIndex();


                this.checkBoxVisibleData.Enabled = true;
                this.checkBoxVisibleData.Checked = selectedDataEntry.GraphProperties.IsVisible;
                this.numericUpDownHeightOffsetData.Value = (decimal) selectedDataEntry.GraphProperties.Offset;



            }

        }


        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFileForm lfform = new LoadFileForm(this);
        }


        public void AddDataEntry(DataEntry entry)
        {
            this.dataEntries.Add(entry);
            blist_data.Add(entry);
            updateZedGraphBig();



        }


        public class Person
        {
            private string firstName;
            private string lastName;
            private int age;


            public Person(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }

            public string FullName
            {
                get { return $"{firstName} {lastName}"; }
            }

            public string AgeCategory
            {
                get
                {
                    if (age < 18)
                    {
                        return "Under 18";
                    }
                    else if (age < 65)
                    {
                        return "18-64";
                    }
                    else
                    {
                        return "65 or over";
                    }
                }
            }

            public string FirstName
            {
                get { return firstName; }
                set
                {
                    if (firstName != value)
                    {
                        firstName = value;
                    }
                }
            }

            public string LastName
            {
                get { return lastName; }
                set
                {
                    if (lastName != value)
                    {
                        lastName = value;
                    }
                }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    if (age != value)
                    {
                        age = value;
                    }
                }
            }
        }

        private void btnColorData_Click(object sender, EventArgs e)
        {
            if (selectedDataEntryIndex != -1 && selectedDataEntryIndex < dataEntries.Count)
            { 
                DialogResult dr = colorDialog.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    // Get the selected color from the ColorDialog
                    this.dataEntries[selectedDataEntryIndex].GraphProperties.LineItem.Color = colorDialog.Color;
                }

                updateZedGraphBig();
            }


            people.Add(new Person("Data", "D", 75));
           

        }

        private void checkBoxVisibleData_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedDataEntryIndex != -1 && selectedDataEntryIndex < dataEntries.Count)
            {
                this.dataEntries[selectedDataEntryIndex].GraphProperties.IsVisible = this.checkBoxVisibleData.Checked;
                updateZedGraphBig();
            }
        }

        private void numericUpDownHeightOffsetData_ValueChanged(object sender, EventArgs e)
        {

            if (selectedDataEntryIndex != -1 && selectedDataEntryIndex < dataEntries.Count)
            {
                this.dataEntries[selectedDataEntryIndex].GraphProperties.Offset = (double) this.numericUpDownHeightOffsetData.Value;
                updateZedGraphBig();
            }
        }
    }
}
