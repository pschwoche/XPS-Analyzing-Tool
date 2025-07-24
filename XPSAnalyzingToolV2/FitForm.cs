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
using XPSAnalyzingTool.Funktionen;

namespace XPSAnalyzingTool
{
    public partial class FitForm : Form
    {

        private DataEntry dataEntry;

        private FitEntry fitEntry;

        public FitForm(DataEntry DataEntry)
        {
            this.dataEntry = DataEntry;
            this.fitEntry = new FitEntry();
            InitializeComponent();

            InitFitFunk();

            UpdateDataGridView();





            this.Visible = true;


            
        }

        private void InitFitFunk()
        {

            Funktion f1 = new Gaussian();
            Funktion f2 = new Gaussian();
            Funktion f3 = new Gaussian();

            fitEntry.AddFunktion(f1);
            fitEntry.AddFunktion(f2);
            fitEntry.AddFunktion(f3);
        }


        private void UpdateDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns["Name"].ReadOnly = true;

            foreach (var funktion in fitEntry.Fitfunktionen)
            {
                foreach (var parameter in funktion.Params)
                {
                    if (!dataGridView1.Columns.Contains(parameter.Name))
                    {
                        dataGridView1.Columns.Add(parameter.Name, parameter.Name);
                    }
                }
            }

            foreach (var function in fitEntry.Fitfunktionen)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = function.Name;
                foreach (var parameter in function.Params)
                {
                    dataGridView1.Rows[rowIndex].Cells[parameter.Name].Value = parameter.Value;
                }
            }
            /*
            foreach (Funktion f in _fitFunction.funktionen) {
                foreach (Parameter p in  f.parameters)
                {
                    Console.Write($"{p.name}: {p.value} ");
                }
                Console.WriteLine();
            }*/
        }

        private void FitForm_Load(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double newValue;
            this.BeginInvoke(new MethodInvoker(() =>
            {
                if (double.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out newValue))
                {
                    string funktionName = dataGridView1[0, e.RowIndex].Value.ToString();
                    string parameterName = dataGridView1.Columns[e.ColumnIndex].Name;

                    Funktion funktion = fitEntry.Fitfunktionen.Find(f => f.Name == funktionName);
                    Parameter parameter = Array.Find(funktion.Params, p => p.Name == parameterName);
                    parameter.Value = Convert.ToDouble(newValue);
                    // _fitFunction.funktionen[e.RowIndex].parameters[e.ColumnIndex - 1].value = newValue;
                    UpdateDataGridView();
                }
            }));

        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    // Wenn die Zelle leer ist, deaktivieren Sie das Bearbeiten
                    e.Cancel = true;
                }
            }));
        }
    }



}