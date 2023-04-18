namespace XPSAnalyzingTool
{
    partial class DataManipulationForm
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
            this.zedGraphControlBefore = new ZedGraph.ZedGraphControl();
            this.zedGraphControlAfter = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_y_off = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxNoise = new System.Windows.Forms.CheckBox();
            this.btnNoise = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.checkBoxBackground = new System.Windows.Forms.CheckBox();
            this.tb_y_min = new System.Windows.Forms.TextBox();
            this.tb_y_max = new System.Windows.Forms.TextBox();
            this.tb_y_scale = new System.Windows.Forms.TextBox();
            this.tb_x_off = new System.Windows.Forms.TextBox();
            this.tb_x_min = new System.Windows.Forms.TextBox();
            this.tb_x_max = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_newName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zedGraphControlBefore
            // 
            this.zedGraphControlBefore.Location = new System.Drawing.Point(13, 12);
            this.zedGraphControlBefore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControlBefore.Name = "zedGraphControlBefore";
            this.zedGraphControlBefore.ScrollGrace = 0D;
            this.zedGraphControlBefore.ScrollMaxX = 0D;
            this.zedGraphControlBefore.ScrollMaxY = 0D;
            this.zedGraphControlBefore.ScrollMaxY2 = 0D;
            this.zedGraphControlBefore.ScrollMinX = 0D;
            this.zedGraphControlBefore.ScrollMinY = 0D;
            this.zedGraphControlBefore.ScrollMinY2 = 0D;
            this.zedGraphControlBefore.Size = new System.Drawing.Size(788, 351);
            this.zedGraphControlBefore.TabIndex = 0;
            this.zedGraphControlBefore.UseExtendedPrintDialog = true;
            // 
            // zedGraphControlAfter
            // 
            this.zedGraphControlAfter.Location = new System.Drawing.Point(13, 369);
            this.zedGraphControlAfter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControlAfter.Name = "zedGraphControlAfter";
            this.zedGraphControlAfter.ScrollGrace = 0D;
            this.zedGraphControlAfter.ScrollMaxX = 0D;
            this.zedGraphControlAfter.ScrollMaxY = 0D;
            this.zedGraphControlAfter.ScrollMaxY2 = 0D;
            this.zedGraphControlAfter.ScrollMinX = 0D;
            this.zedGraphControlAfter.ScrollMinY = 0D;
            this.zedGraphControlAfter.ScrollMinY2 = 0D;
            this.zedGraphControlAfter.Size = new System.Drawing.Size(788, 377);
            this.zedGraphControlAfter.TabIndex = 1;
            this.zedGraphControlAfter.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "y-offset";
            // 
            // tb_y_off
            // 
            this.tb_y_off.Location = new System.Drawing.Point(907, 22);
            this.tb_y_off.Name = "tb_y_off";
            this.tb_y_off.Size = new System.Drawing.Size(100, 23);
            this.tb_y_off.TabIndex = 3;
            this.tb_y_off.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_y_off.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "y-scale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "x-offset";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(826, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "y-min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "y-max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(826, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "x-min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(826, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "x-max";
            // 
            // checkBoxNoise
            // 
            this.checkBoxNoise.AutoSize = true;
            this.checkBoxNoise.Location = new System.Drawing.Point(992, 230);
            this.checkBoxNoise.Name = "checkBoxNoise";
            this.checkBoxNoise.Size = new System.Drawing.Size(15, 14);
            this.checkBoxNoise.TabIndex = 10;
            this.checkBoxNoise.UseVisualStyleBackColor = true;
            this.checkBoxNoise.CheckedChanged += new System.EventHandler(this.checkBoxNoise_CheckedChanged);
            // 
            // btnNoise
            // 
            this.btnNoise.Location = new System.Drawing.Point(826, 225);
            this.btnNoise.Name = "btnNoise";
            this.btnNoise.Size = new System.Drawing.Size(160, 23);
            this.btnNoise.TabIndex = 12;
            this.btnNoise.Text = "Noise reduction...";
            this.btnNoise.UseVisualStyleBackColor = true;
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(826, 254);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(160, 23);
            this.btnBackground.TabIndex = 13;
            this.btnBackground.Text = "Background substraction...";
            this.btnBackground.UseVisualStyleBackColor = true;
            // 
            // checkBoxBackground
            // 
            this.checkBoxBackground.AutoSize = true;
            this.checkBoxBackground.Location = new System.Drawing.Point(992, 259);
            this.checkBoxBackground.Name = "checkBoxBackground";
            this.checkBoxBackground.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBackground.TabIndex = 14;
            this.checkBoxBackground.UseVisualStyleBackColor = true;
            this.checkBoxBackground.CheckedChanged += new System.EventHandler(this.checkBoxBackground_CheckedChanged);
            // 
            // tb_y_min
            // 
            this.tb_y_min.Location = new System.Drawing.Point(907, 80);
            this.tb_y_min.Name = "tb_y_min";
            this.tb_y_min.Size = new System.Drawing.Size(100, 23);
            this.tb_y_min.TabIndex = 15;
            this.tb_y_min.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_y_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_y_max
            // 
            this.tb_y_max.Location = new System.Drawing.Point(907, 109);
            this.tb_y_max.Name = "tb_y_max";
            this.tb_y_max.Size = new System.Drawing.Size(100, 23);
            this.tb_y_max.TabIndex = 16;
            this.tb_y_max.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_y_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_y_scale
            // 
            this.tb_y_scale.Location = new System.Drawing.Point(907, 51);
            this.tb_y_scale.Name = "tb_y_scale";
            this.tb_y_scale.Size = new System.Drawing.Size(100, 23);
            this.tb_y_scale.TabIndex = 17;
            this.tb_y_scale.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_y_scale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_x_off
            // 
            this.tb_x_off.Location = new System.Drawing.Point(907, 138);
            this.tb_x_off.Name = "tb_x_off";
            this.tb_x_off.Size = new System.Drawing.Size(100, 23);
            this.tb_x_off.TabIndex = 18;
            this.tb_x_off.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_x_off.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_x_min
            // 
            this.tb_x_min.Location = new System.Drawing.Point(907, 167);
            this.tb_x_min.Name = "tb_x_min";
            this.tb_x_min.Size = new System.Drawing.Size(51, 23);
            this.tb_x_min.TabIndex = 19;
            this.tb_x_min.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_x_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // tb_x_max
            // 
            this.tb_x_max.Location = new System.Drawing.Point(907, 196);
            this.tb_x_max.Name = "tb_x_max";
            this.tb_x_max.Size = new System.Drawing.Size(51, 23);
            this.tb_x_max.TabIndex = 20;
            this.tb_x_max.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tb_x_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(826, 340);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 21;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(932, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(826, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "new name";
            // 
            // tb_newName
            // 
            this.tb_newName.Location = new System.Drawing.Point(907, 298);
            this.tb_newName.Name = "tb_newName";
            this.tb_newName.Size = new System.Drawing.Size(100, 23);
            this.tb_newName.TabIndex = 24;
            this.tb_newName.TextChanged += new System.EventHandler(this.tb_TextChanged);
            // 
            // DataManipulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 777);
            this.Controls.Add(this.tb_newName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tb_x_max);
            this.Controls.Add(this.tb_x_min);
            this.Controls.Add(this.tb_x_off);
            this.Controls.Add(this.tb_y_scale);
            this.Controls.Add(this.tb_y_max);
            this.Controls.Add(this.tb_y_min);
            this.Controls.Add(this.checkBoxBackground);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnNoise);
            this.Controls.Add(this.checkBoxNoise);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_y_off);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zedGraphControlAfter);
            this.Controls.Add(this.zedGraphControlBefore);
            this.Name = "DataManipulationForm";
            this.Text = "DataManipulationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraphControlBefore;
        private ZedGraph.ZedGraphControl zedGraphControlAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_y_off;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxNoise;
        private System.Windows.Forms.Button btnNoise;
        private System.Windows.Forms.Button btnBackground;
        private System.Windows.Forms.CheckBox checkBoxBackground;
        private System.Windows.Forms.TextBox tb_y_min;
        private System.Windows.Forms.TextBox tb_y_max;
        private System.Windows.Forms.TextBox tb_y_scale;
        private System.Windows.Forms.TextBox tb_x_off;
        private System.Windows.Forms.TextBox tb_x_min;
        private System.Windows.Forms.TextBox tb_x_max;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_newName;
    }
}