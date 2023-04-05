using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;
using XPSAnalyzingTool;

namespace XPSAnalyzingTool
{
    public partial class LoadFileForm : Form
    {
        private const string DEFAULTPATH = @"C:\";
        private string PATH2FOLDERICON = $"{Directory.GetCurrentDirectory()}\\Foldericon.ico";
        private string currentPath;
        ImageList imageList1;
        MainForm mainForm;

        private string[] FILTERS =
        {
            "All Files (\".\")",
            "*.txt",
            "*.dat"
        };
        private string[] assosiatedFileExtensions =
        {
            "",
            "txt",
            "dat"
        };

        public LoadFileForm(MainForm mainForm)
        {
            InitializeComponent();
            Init();

            this.Visible = true;
            this.mainForm = mainForm;
        }

        private void Init()
        {
            currentPath = DEFAULTPATH;
            radioButtonSigmaColumn.Checked = true;
            foreach (string filter in FILTERS)
            {
                this.comboBoxFileFilter.Items.Add(filter);
            }
            comboBoxFileFilter.SelectedIndex = 0;


            UpdateExplorer();
        }

        private void UpdateExplorer()
        {
            this.labelPath.Text = currentPath;
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(currentPath);

            this.listViewExplorer.Items.Clear();

            ListViewItem item;
            imageList1 = new ImageList();

            listViewExplorer.SmallImageList = imageList1;

            if (!currentPath.Equals(DEFAULTPATH))
            {
                item = new ListViewItem("..", 1);
                Icon dirIcon;
                if (!imageList1.Images.ContainsKey("directory"))
                {
                    // If not, add the image to the image list.
                    dirIcon = new Icon(PATH2FOLDERICON, 48, 48);
                    imageList1.Images.Add("directory", dirIcon);
                }
                item.ImageKey = "directory";
                listViewExplorer.Items.Add(item);
            }

            foreach (System.IO.DirectoryInfo directory in dir.GetDirectories())
            {
                // Set a default icon for the file.
                Icon iconForFile = SystemIcons.WinLogo;

                item = new ListViewItem(directory.Name, 1);

                // Check to see if the image collection contains an image
                // for this extension, using the extension as a key.
                if (!imageList1.Images.ContainsKey("directory"))
                {
                    // If not, add the image to the image list.
                    iconForFile = new Icon(PATH2FOLDERICON, 48, 48);
                    imageList1.Images.Add("directory", iconForFile);
                }
                item.ImageKey = "directory";
                listViewExplorer.Items.Add(item);
            }

            // For each file in the c:\ directory, create a ListViewItem
            // and set the icon to the icon extracted from the file.
            foreach (System.IO.FileInfo file in dir.GetFiles())
            {

                string filename = file.FullName.Split('\\')[file.FullName.Split('\\').Length - 1];
                string filterstring = assosiatedFileExtensions[this.comboBoxFileFilter.SelectedIndex];

                if (filename.Split(".")[filename.Split(".").Length - 1].Equals(filterstring) || filterstring.Equals(""))
                {
                    // Set a default icon for the file.
                    Icon iconForFile = SystemIcons.WinLogo;

                    item = new ListViewItem(file.Name, 1);

                    // Check to see if the image collection contains an image
                    // for this extension, using the extension as a key.
                    if (!imageList1.Images.ContainsKey(file.Extension))
                    {
                        // If not, add the image to the image list.
                        iconForFile = System.Drawing.Icon.ExtractAssociatedIcon(file.FullName);
                        imageList1.Images.Add(file.Extension, iconForFile);
                    }
                    item.ImageKey = file.Extension;
                    listViewExplorer.Items.Add(item);
                }
            }
        }

        private void listViewExplorer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewExplorer.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                if (item.ImageKey.Equals("directory"))
                {
                    if (item.Text.Equals(".."))
                    {
                        this.currentPath = Directory.GetParent(currentPath).FullName;
                        UpdateExplorer();

                    }
                    else
                    {
                        try
                        {
                            this.currentPath += $"\\{item.Text}";
                            UpdateExplorer();
                        }
                        catch (UnauthorizedAccessException ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"{ex.Message}");
                            this.currentPath = Directory.GetParent(currentPath).FullName;
                            UpdateExplorer();
                        }
                    }
                }
            }
        }

        private void listViewExplorer_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewExplorer.GetItemAt(e.X, e.Y);
            if (item != null)
            {
                if (!item.ImageKey.Equals("directory"))
                {
                    textBoxLastFile.Text = item.Text;
                    //System.Diagnostics.Debug.WriteLine($"{currentPath}\\{item.Text}");
                    PreviewFile($"{currentPath}\\{item.Text}");

                    int indx = Decimal.ToInt32(this.numericUpDownX.Value);
                    int indy = Decimal.ToInt32(this.numericUpDownY.Value);
                    int indsigma = Decimal.ToInt32(this.numericUpDownSigma.Value);

                    textBoxTitle.Text = $"{item.Text.Split(".")[0]}-{indx}:{indy}:{indsigma}";

                    PointPairList ppl = this.ParseFileToPPL($"{currentPath}\\{item.Text}", "\t", indx, indy, indsigma);
                    PreviewGraph(ppl);
                }
            }
        }

        private int GetRadioButtonIndex()
        {
            if (radioButtonSigmaColumn.Checked)
            {
                return 1;
            }
            else if (radioButton2.Checked)
            {
                return 2;
            }
            else if (radioButton3.Checked)
            {
                return 2;
            } else
            {
                return 2;
            }
        }

        private void PreviewFile(string path)
        {
            richTextBox1.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string zeile;
                    for(int i = 0; i< 11; i++)
                    {
                        if((zeile = sr.ReadLine()) != null)
                        {
                            richTextBox1.Text += $"{zeile}\n";
                        }
                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{ex.Message}");
            }
        }

        private void comboBoxFileFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateExplorer();
        }

        private void PreviewGraph(PointPairList ppl)
        {
            this.zedGraphControl1.GraphPane.CurveList.Clear();
            if (ppl != null)
            {

                LineItem lineItemHandle = this.zedGraphControl1.GraphPane.AddCurve($"", ReducePPL(ppl), Color.Black, SymbolType.None);

            }

            zedGraphControl1.Invalidate();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Refresh();

        }

        private PointPairList ReducePPL(PointPairList ppl)
        {
            PointPairList erg = new PointPairList();

            foreach (PointPair pp in ppl)
            {
                erg.Add(new PointPair(pp.X, pp.Y));
            }
            erg.Sort();
            return erg;
        }
        
        private PointPairList ParseFileToPPL(string path, string delimiter, int indX, int indY, int indSigma)
        {
            PointPairList ppl = new PointPairList();
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    string zeile;

                    while ((zeile = sr.ReadLine()) != null)
                    {
                        double x, y;
                        string[] strValues = zeile.Split(delimiter);

                        if(indX >= strValues.Length || indY >= strValues.Length || indSigma >= strValues.Length)
                        {
                            throw new Exception("Index out of range!");
                        }
                        Double.TryParse(strValues[indX].Replace('.',','), out x);
                        Double.TryParse(strValues[indY].Replace('.', ','), out y);

                       
                        PointPair pp = new PointPair(x, y);
                        ppl.Add(pp);


                    }

                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{ex.Message}");
                return null;
            }
            ppl.Sort();
            return ppl;

        }

        private Data ParseFileToData(string path, string delimiter, int indX, int indY, int indSigma, int sigmamode)
        {
            try
            {
                List<double> xlist = new List<double>();
                List<double> ylist = new List<double>();
                List<double> errorlist = new List<double>();

                using (StreamReader sr = new StreamReader(path))
                {
                    string zeile;

                    while ((zeile = sr.ReadLine()) != null)
                    {
                        double x, y, sigma;
                        string[] strValues = zeile.Split(delimiter);

                        if (indX >= strValues.Length || indY >= strValues.Length || indSigma >= strValues.Length)
                        {
                            throw new Exception("Index out of range!");
                        }
                        Double.TryParse(strValues[indX].Replace('.', ','), out x);
                        Double.TryParse(strValues[indY].Replace('.', ','), out y);

                        switch (sigmamode)
                        {
                            case 1:
                                Double.TryParse(strValues[indSigma].Replace('.', ','), out sigma);
                                break;

                            case 2:
                                sigma = Math.Max(Math.Sqrt(Math.Abs(y)), 1);
                                break;

                            case 3:
                                sigma = 1;
                                break;

                            default:
                                throw new Exception("sigmamode is strange...");
                        }
                        xlist.Add(x);
                        ylist.Add(y);
                        errorlist.Add(sigma);
                    }
                    sr.Close();

                }

                double[] xarray = xlist.ToArray();
                double[] yarray = ylist.ToArray();
                double[] errorarray = errorlist.ToArray();

                return new Data(xarray, yarray, errorarray);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"{ex.Message}");
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
                {
                int indx = Decimal.ToInt32(this.numericUpDownX.Value);
                int indy = Decimal.ToInt32(this.numericUpDownY.Value);
                int indsigma = Decimal.ToInt32(this.numericUpDownSigma.Value);

                int sigmaMode = GetRadioButtonIndex();
                string path = $"{currentPath}\\{textBoxLastFile.Text}";

                Data data = this.ParseFileToData(path, "\t", indx, indy, indsigma, sigmaMode);
                if(data == null)
                {
                    throw new Exception($"Data is null.");
                }
                string name = this.textBoxTitle.Text;

                this.mainForm.AddDataEntry(new DataEntry(data, name));
                this.Close();
            } 
            catch(Exception ex)
            {
               var result = MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {

            PreviewFile($"{currentPath}\\{textBoxLastFile.Text}");

            int indx = Decimal.ToInt32(this.numericUpDownX.Value);
            int indy = Decimal.ToInt32(this.numericUpDownY.Value);
            int indsigma = Decimal.ToInt32(this.numericUpDownSigma.Value);

            textBoxTitle.Text = $"{textBoxLastFile.Text.Split(".")[0]}-{indx}:{indy}:{indsigma}";
            PointPairList ppl = this.ParseFileToPPL($"{currentPath}\\{textBoxLastFile.Text}", "\t", indx, indy, indsigma);
            PreviewGraph(ppl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
