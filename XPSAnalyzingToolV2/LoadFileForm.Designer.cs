
namespace XPSAnalyzingTool
{
    partial class LoadFileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewExplorer = new System.Windows.Forms.ListView();
            this.comboBoxFileFilter = new System.Windows.Forms.ComboBox();
            this.textBoxLastFile = new System.Windows.Forms.TextBox();
            this.labelPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSeparator = new System.Windows.Forms.TextBox();
            this.checkBoxComma = new System.Windows.Forms.CheckBox();
            this.groupBoxColumns = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownSigma = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.radioButtonSigmaColumn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewExplorer);
            this.groupBox1.Controls.Add(this.comboBoxFileFilter);
            this.groupBox1.Controls.Add(this.textBoxLastFile);
            this.groupBox1.Controls.Add(this.labelPath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // listViewExplorer
            // 
            this.listViewExplorer.HideSelection = false;
            this.listViewExplorer.Location = new System.Drawing.Point(7, 38);
            this.listViewExplorer.Name = "listViewExplorer";
            this.listViewExplorer.Size = new System.Drawing.Size(464, 214);
            this.listViewExplorer.TabIndex = 6;
            this.listViewExplorer.UseCompatibleStateImageBehavior = false;
            this.listViewExplorer.View = System.Windows.Forms.View.List;
            this.listViewExplorer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewExplorer_MouseClick);
            this.listViewExplorer.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewExplorer_MouseDoubleClick);
            // 
            // comboBoxFileFilter
            // 
            this.comboBoxFileFilter.FormattingEnabled = true;
            this.comboBoxFileFilter.Location = new System.Drawing.Point(7, 288);
            this.comboBoxFileFilter.Name = "comboBoxFileFilter";
            this.comboBoxFileFilter.Size = new System.Drawing.Size(464, 23);
            this.comboBoxFileFilter.TabIndex = 5;
            this.comboBoxFileFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileFilter_SelectedIndexChanged);
            // 
            // textBoxLastFile
            // 
            this.textBoxLastFile.Location = new System.Drawing.Point(7, 258);
            this.textBoxLastFile.Name = "textBoxLastFile";
            this.textBoxLastFile.ReadOnly = true;
            this.textBoxLastFile.Size = new System.Drawing.Size(464, 23);
            this.textBoxLastFile.TabIndex = 4;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(6, 19);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(31, 15);
            this.labelPath.TabIndex = 0;
            this.labelPath.Text = "Path";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Separator:";
            // 
            // textBoxSeparator
            // 
            this.textBoxSeparator.Location = new System.Drawing.Point(86, 336);
            this.textBoxSeparator.Name = "textBoxSeparator";
            this.textBoxSeparator.Size = new System.Drawing.Size(42, 23);
            this.textBoxSeparator.TabIndex = 3;
            // 
            // checkBoxComma
            // 
            this.checkBoxComma.AutoSize = true;
            this.checkBoxComma.Location = new System.Drawing.Point(20, 365);
            this.checkBoxComma.Name = "checkBoxComma";
            this.checkBoxComma.Size = new System.Drawing.Size(112, 19);
            this.checkBoxComma.TabIndex = 5;
            this.checkBoxComma.Text = "decimal comma";
            this.checkBoxComma.UseVisualStyleBackColor = true;
            // 
            // groupBoxColumns
            // 
            this.groupBoxColumns.Controls.Add(this.radioButton3);
            this.groupBoxColumns.Controls.Add(this.label4);
            this.groupBoxColumns.Controls.Add(this.numericUpDownSigma);
            this.groupBoxColumns.Controls.Add(this.numericUpDownY);
            this.groupBoxColumns.Controls.Add(this.radioButton2);
            this.groupBoxColumns.Controls.Add(this.numericUpDownX);
            this.groupBoxColumns.Controls.Add(this.radioButtonSigmaColumn);
            this.groupBoxColumns.Controls.Add(this.label3);
            this.groupBoxColumns.Controls.Add(this.label2);
            this.groupBoxColumns.Location = new System.Drawing.Point(13, 390);
            this.groupBoxColumns.Name = "groupBoxColumns";
            this.groupBoxColumns.Size = new System.Drawing.Size(480, 68);
            this.groupBoxColumns.TabIndex = 1;
            this.groupBoxColumns.TabStop = false;
            this.groupBoxColumns.Text = "Select columns:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(419, 34);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 19);
            this.radioButton3.TabIndex = 11;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "σ = 1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "or";
            // 
            // numericUpDownSigma
            // 
            this.numericUpDownSigma.Location = new System.Drawing.Point(218, 32);
            this.numericUpDownSigma.Name = "numericUpDownSigma";
            this.numericUpDownSigma.Size = new System.Drawing.Size(47, 23);
            this.numericUpDownSigma.TabIndex = 13;
            this.numericUpDownSigma.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownSigma.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(116, 32);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(47, 23);
            this.numericUpDownY.TabIndex = 12;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(295, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 19);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "σ = max(√Y, 1) or";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(29, 32);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(47, 23);
            this.numericUpDownX.TabIndex = 11;
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // radioButtonSigmaColumn
            // 
            this.radioButtonSigmaColumn.AutoSize = true;
            this.radioButtonSigmaColumn.Location = new System.Drawing.Point(180, 34);
            this.radioButtonSigmaColumn.Name = "radioButtonSigmaColumn";
            this.radioButtonSigmaColumn.Size = new System.Drawing.Size(32, 19);
            this.radioButtonSigmaColumn.TabIndex = 9;
            this.radioButtonSigmaColumn.TabStop = true;
            this.radioButtonSigmaColumn.Text = "σ";
            this.radioButtonSigmaColumn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "X:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(81, 464);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(412, 23);
            this.textBoxTitle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 468);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "data title:";
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(6, 225);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(326, 220);
            this.zedGraphControl1.TabIndex = 8;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(326, 183);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.zedGraphControl1);
            this.groupBox2.Location = new System.Drawing.Point(499, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 474);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(462, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LoadFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.checkBoxComma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSeparator);
            this.Controls.Add(this.groupBoxColumns);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoadFileForm";
            this.Text = "LoadFileForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxColumns.ResumeLayout(false);
            this.groupBoxColumns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLastFile;
        private System.Windows.Forms.TextBox textBoxSeparator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.ComboBox comboBoxFileFilter;
        private System.Windows.Forms.CheckBox checkBoxComma;
        private System.Windows.Forms.GroupBox groupBoxColumns;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownSigma;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.RadioButton radioButtonSigmaColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label5;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewExplorer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}