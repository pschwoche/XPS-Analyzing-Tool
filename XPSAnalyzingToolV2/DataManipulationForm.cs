using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ZedGraph;
using System.Collections;

namespace XPSAnalyzingTool
{
    public partial class DataManipulationForm : Form
    {

        DataEntry dataEntry_old;
        DataEntry dataEntry_new;
        MainForm mainForm;

        private ZedGraph.GraphPane GraphPaneBefore;
        private ZedGraph.GraphPane GraphPaneAfter;

        public DataManipulationForm(DataEntry dataEntry, MainForm main)
        {

            this.mainForm = main;
            InitializeComponent();
            this.dataEntry_old = dataEntry.Clone();
            this.dataEntry_new = dataEntry.Clone();
            InitZedGraphs();
            updateZedGraphBefore();
            updateZedGraphAfter();
            setDefaults();
            this.Visible = true;
        }

        private void setDefaults()
        {
            this.tb_y_off.Text = "0";
            this.tb_y_scale.Text = "1";
            this.tb_y_min.Text = "0";
            this.tb_y_max.Text = "100000";
            this.tb_x_off.Text = "0";
            this.tb_x_min.Text = "0";
            this.tb_x_max.Text = "10000";
            this.tb_newName.Text = dataEntry_old.Name;
        }

        private void InitZedGraphs()
        {
            InitZedGraphBefore();
            InitZedGraphAfter();
        }

        private void InitZedGraphBefore()
        {
            this.GraphPaneBefore = this.zedGraphControlBefore.GraphPane;
        }

        private void InitZedGraphAfter()
        {
            this.GraphPaneAfter = this.zedGraphControlAfter.GraphPane;
        }

        private void updateZedGraphBefore()
        {
            GraphPaneBefore.CurveList.Clear();
            LineItem lineitem = this.GraphPaneBefore.AddCurve(dataEntry_old.GraphProperties.LineItem.Label.Text, dataEntry_old.PPL_data, Color.OrangeRed);
            lineitem.Line = dataEntry_old.GraphProperties.LineItem.Line;
            lineitem.Symbol = dataEntry_old.GraphProperties.LineItem.Symbol;

            zedGraphControlBefore.AxisChange();
            zedGraphControlBefore.Invalidate();
            zedGraphControlBefore.Refresh();
        }

        private void updateZedGraphAfter()
        {
            GraphPaneAfter.CurveList.Clear();
            LineItem lineitem = this.GraphPaneAfter.AddCurve(dataEntry_new.GraphProperties.LineItem.Label.Text, dataEntry_new.PPL_data, Color.OrangeRed);
            lineitem.Line = dataEntry_new.GraphProperties.LineItem.Line;
            lineitem.Symbol = dataEntry_new.GraphProperties.LineItem.Symbol;

            zedGraphControlAfter.AxisChange();
            zedGraphControlAfter.Invalidate();
            zedGraphControlAfter.Refresh();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            NumberStyles numberStyles = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowLeadingSign;
            CultureInfo germanCulture = CultureInfo.GetCultureInfo("de-DE");
            CultureInfo englishCulture = CultureInfo.GetCultureInfo("en-US");

            string y_offsetText = tb_y_off.Text;
            string y_scaleText = tb_y_scale.Text;
            string y_minText = tb_y_min.Text;
            string y_maxText = tb_y_max.Text;
            string x_offsetText = tb_x_off.Text;
            string x_minText = tb_x_min.Text;
            string x_maxText = tb_x_max.Text;
            double y_offset;
            double y_scale;
            double y_min;
            double y_max;
            double x_offset;
            double x_min;
            double x_max;


            string new_name = tb_newName.Text;


            if (double.TryParse(y_offsetText, numberStyles, germanCulture, out y_offset) &&
            double.TryParse(y_scaleText, numberStyles, germanCulture, out y_scale) &&
            double.TryParse(y_minText, numberStyles, germanCulture, out y_min) &&
            double.TryParse(y_maxText, numberStyles, germanCulture, out y_max) &&
            double.TryParse(x_offsetText, numberStyles, germanCulture, out x_offset) &&
            double.TryParse(x_minText, numberStyles, germanCulture, out x_min) &&
            double.TryParse(x_maxText, numberStyles, germanCulture, out x_max))
            {
                dataEntry_new = dataEntry_old.Clone();

                for (int i = 0; i < dataEntry_old.Data.Y.Length; i++)
                {
                    dataEntry_new.Data.Y[i] = dataEntry_old.Data.Y[i] * y_scale + y_offset;
                    dataEntry_new.Data.Error[i] = dataEntry_old.Data.Error[i] * y_scale;
                    dataEntry_new.Data.X[i] = dataEntry_old.Data.X[i] + x_offset;

                }
                List<double> xList = dataEntry_new.Data.X.ToList();
                List<double> yList = dataEntry_new.Data.Y.ToList();
                List<double> errorList = dataEntry_new.Data.Error.ToList();
                for (int i = 0; i < yList.Count; i++)
                {
                    if (yList[i] < y_min || yList[i] > y_max || xList[i] < x_min || xList[i] > x_max)
                    {
                        // Remove the elements at the corresponding index in all three arrays
                        xList.RemoveAt(i);
                        yList.RemoveAt(i);
                        errorList.RemoveAt(i);
                        i--;
                    }
                }
                double[] x = xList.ToArray();
                double[] y = yList.ToArray();
                double[] error = errorList.ToArray();
                dataEntry_new = new DataEntry(new Data(x, y, error),new_name);
                dataEntry_new.Update();
                updateZedGraphAfter();
            }
            else 
            {
            }

            

        }


        private void checkBoxNoise_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void checkBoxBackground_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '-' && e.KeyChar != '\b')
            {
                // If the key pressed is not a valid character, ignore the input
                e.Handled = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.mainForm.AddDataEntry(dataEntry_new);
            this.Close();
        }
    }


}
