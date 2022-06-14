using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public List<DataEntry> dataEntries;

        private ZedGraph.GraphPane bigGraphPane;
        private ZedGraph.GraphPane smallGraphPane;


        ContextMenuStrip contextMenuStrip_DataGridViewData;
        ToolStripMenuItem tsmi_DataGridView_Background, tsmi_DataGridView_Fit, tsmi_DataGridView_Info;


        public MainForm()
        {
            InitializeComponent();

            this.dataEntries = new List<DataEntry>();

            this.groupBoxGraphVisuals.Enabled = false;
            this.groupBoxFitVisuals.Enabled = false;


            InitDataGridViews();
            InitContextMenu__DataGridViewData();
            InitZedGraphs();

        }

        private void InitZedGraphs()
        {
            this.bigGraphPane = this.zedGraphControl1.GraphPane;

            bigGraphPane.Title.Text = "";
            bigGraphPane.XAxis.Title.Text = $"Binding energy [eV]";
            bigGraphPane.YAxis.Title.Text = $"Intensity [a.u.]";
            updateGraphs();
        }


        private void InitContextMenu__DataGridViewData()
        {
            contextMenuStrip_DataGridViewData = new ContextMenuStrip();

            tsmi_DataGridView_Background = new ToolStripMenuItem("Background Substraction...");
            tsmi_DataGridView_Background.Click += tsmi_DataGridView_Background_Click;
            contextMenuStrip_DataGridViewData.Items.Add(tsmi_DataGridView_Background);

            tsmi_DataGridView_Fit = new ToolStripMenuItem("Fit...");
            tsmi_DataGridView_Fit.Click += tsmi_DataGridView_Fit_Click;
            contextMenuStrip_DataGridViewData.Items.Add(tsmi_DataGridView_Fit);

            tsmi_DataGridView_Info = new ToolStripMenuItem("Info");
            tsmi_DataGridView_Info.Click += tsmi_DataGridView_Info_Click;
            contextMenuStrip_DataGridViewData.Items.Add(tsmi_DataGridView_Info);


        }


        private void tsmi_DataGridView_Info_Click(object sender, EventArgs e)
        {
            DataGridViewCell currentCell = this.dataGridViewData.CurrentCell;
            System.Diagnostics.Debug.WriteLine(this.dataEntries[currentCell.RowIndex].GraphProperties.LineItem.Label.Text);
           
        }


        private void tsmi_DataGridView_Fit_Click(object sender, EventArgs e)
        {

        }


        private void tsmi_DataGridView_Background_Click(object sender, EventArgs e)
        {

        }


        private void InitDataGridViews()
        {
            InitDataGridViewData();
        }


        private void InitDataGridViewData()
        {

            DataGridViewTextBoxColumn dataGridViewColumnID = new DataGridViewTextBoxColumn();
            dataGridViewColumnID.HeaderText = "ID";
            dataGridViewColumnID.Name = "dgvID";
            this.dataGridViewData.Columns.Add(dataGridViewColumnID);


            DataGridViewTextBoxColumn dataGridViewColumnName = new DataGridViewTextBoxColumn();
            dataGridViewColumnName.HeaderText = "Name";
            dataGridViewColumnName.Name = "dgvName";
            this.dataGridViewData.Columns.Add(dataGridViewColumnName);

           /* DataGridViewCheckBoxColumn dgvChb1 = new DataGridViewCheckBoxColumn();
            dgvChb1.HeaderText = "Lower Limited";
            dgvChb1.Name = "dgvLowerLimited";
            dgvChb1.Width = 60;
            this.dataGridViewData.Columns.Add(dgvChb1);
           */

            updateDataGridViewData();
        }


        private void updateGraphs()
        {

            System.Diagnostics.Debug.WriteLine($"counts: {this.dataEntries.Count}");
            bigGraphPane.CurveList.Clear();
            for (int i = 0; i < this.dataEntries.Count; i++)
            {
                AddData2Plot(dataEntries[i]);

            }
            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();
        }

        private void AddData2Plot(DataEntry dataEntry)
        {
            if (dataEntry.GraphProperties.IsVisible)
            {
                PointPairList temp_ppl_data = new PointPairList();
                PointPairList temp_ppl_error = new PointPairList();

                for (int i = 0; i < dataEntry.PPL_data.Count; i++)
                {
                    temp_ppl_data.Add(new PointPair(dataEntry.Data.X[i], dataEntry.Data.Y[i] + dataEntry.GraphProperties.VisibleOffset));
                    double temp_err_minus = dataEntry.Data.Y[i] - dataEntry.Data.Error[i] + dataEntry.GraphProperties.VisibleOffset;
                    double temp_err_plus = dataEntry.Data.Y[i] + dataEntry.Data.Error[i] + dataEntry.GraphProperties.VisibleOffset;
                    temp_ppl_error.Add(new PointPair(dataEntry.Data.X[i], temp_err_minus, temp_err_plus));
                }

                LineItem lineItemHandle = bigGraphPane.AddCurve($"{dataEntry.GraphProperties.LineItem.Label.Text}", temp_ppl_data, dataEntry.GraphProperties.LineItem.Line.Color, SymbolType.None);
                ErrorBarItem errorBarItemHandle = bigGraphPane.AddErrorBar($"{dataEntry.GraphProperties.Errorbaritem.Label.Text}", temp_ppl_error, dataEntry.GraphProperties.Errorbaritem.Color);

                lineItemHandle.Line = dataEntry.GraphProperties.LineItem.Line;
                lineItemHandle.Symbol = dataEntry.GraphProperties.LineItem.Symbol;

                errorBarItemHandle.IsVisible = dataEntry.GraphProperties.Errorbaritem.IsVisible;
                errorBarItemHandle.Color = dataEntry.GraphProperties.Errorbaritem.Color;
                errorBarItemHandle.Bar.Color = dataEntry.GraphProperties.Errorbaritem.Bar.Color;
                errorBarItemHandle.Bar.PenWidth = dataEntry.GraphProperties.Errorbaritem.Bar.PenWidth;
                errorBarItemHandle.Bar.IsVisible = dataEntry.GraphProperties.Errorbaritem.Bar.IsVisible;
                errorBarItemHandle.Bar.Symbol = dataEntry.GraphProperties.Errorbaritem.Bar.Symbol;
                errorBarItemHandle.Label = dataEntry.GraphProperties.Errorbaritem.Label;

            }
        }

        private void updateDataGridViewData()
        {
            this.dataGridViewData.Rows.Clear();
            for (int i = 0; i < this.dataEntries.Count; i++)
            {
                this.dataGridViewData.Rows.Add(getEntryViewData(dataEntries[i],i));

            }
        }


        private object[] getEntryViewData(DataEntry dataEntry, int i)
        {
            object[] data2return = new object[2];
            data2return[0] = i;
            data2return[1] = dataEntry.GraphProperties.LineItem.Label.Text;

            return data2return;
        }


        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFileForm lfform = new LoadFileForm(this);
        }


        public void AddDataEntry(DataEntry dataEntry)
        {
            if (dataEntry != null) { 
                this.dataEntries.Add(dataEntry);
                updateDataGridViewData();
                updateGraphs();
            }
        }

        private void dataGridViewData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //select the item under the mouse pointer
                int currentMouseOverRow = this.dataGridViewData.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverColumn = this.dataGridViewData.HitTest(e.X, e.Y).ColumnIndex;
                if (currentMouseOverRow != -1 && currentMouseOverColumn != -1)
                {
                    this.checkBoxVisibleData.Checked = this.dataEntries[currentMouseOverRow].GraphProperties.IsVisible;

                    this.numericUpDownHeightOffsetData.Value = this.dataEntries[currentMouseOverRow].GraphProperties.VisibleOffset;
                    this.groupBoxGraphVisuals.Enabled = true;

                    }
            }

            if (e.Button == MouseButtons.Right)
            {
                //select the item under the mouse pointer
                int currentMouseOverRow = dataGridViewData.HitTest(e.X, e.Y).RowIndex;
                int currentMouseOverColumn = dataGridViewData.HitTest(e.X, e.Y).ColumnIndex;
                if (currentMouseOverRow != -1 && currentMouseOverColumn != -1)
                {
                    dataGridViewData.ClearSelection();
                    dataGridViewData.Rows[currentMouseOverRow].Selected = true;
                    dataGridViewData.CurrentCell = dataGridViewData.Rows[currentMouseOverRow].Cells[currentMouseOverColumn];
                   // dataGridViewData.Rows[currentMouseOverRow].Cells[currentMouseOverColumn].Selected = true;
                    contextMenuStrip_DataGridViewData.Show(dataGridViewData, dataGridViewData.PointToClient(Cursor.Position));
                }
            }


        }

        private void btnRemoveData_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.CurrentCell.RowIndex != -1)
            {
                this.dataEntries.RemoveAt(this.dataGridViewData.CurrentCell.RowIndex);
                this.updateDataGridViewData();
                this.updateGraphs();

                if (this.dataEntries.Count == 0){
                    this.groupBoxGraphVisuals.Enabled = false;
                }
            }
        }

        private void checkBoxVisibleData_Click(object sender, EventArgs e)
        {

            if (this.dataGridViewData.CurrentCell.RowIndex != -1)
            {
                this.dataEntries[this.dataGridViewData.CurrentCell.RowIndex].GraphProperties.IsVisible = this.checkBoxVisibleData.Checked;
                //this.updateDataGridViewData();
                this.updateGraphs();
            }
        }

        private void numericUpDownHeightOffsetData_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewData.CurrentCell.RowIndex != -1)
            {
                this.dataEntries[this.dataGridViewData.CurrentCell.RowIndex].GraphProperties.VisibleOffset = Decimal.ToInt32(this.numericUpDownHeightOffsetData.Value);
                this.updateGraphs();
            }
        }

        private void numericUpDownHeightOffsetData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridViewData.CurrentCell.RowIndex != -1)
            {
                this.dataEntries[this.dataGridViewData.CurrentCell.RowIndex].GraphProperties.VisibleOffset = Decimal.ToInt32(this.numericUpDownHeightOffsetData.Value);
                this.updateGraphs();
            }
        }




    }
}
