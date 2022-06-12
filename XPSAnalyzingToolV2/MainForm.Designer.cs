
namespace XPSAnalyzingTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.groupBoxGraphVisuals = new System.Windows.Forms.GroupBox();
            this.checkBoxVisibleData = new System.Windows.Forms.CheckBox();
            this.btnColorData = new System.Windows.Forms.Button();
            this.btnMarker = new System.Windows.Forms.Button();
            this.numericUpDownHeightOffsetData = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.dataGridViewFit = new System.Windows.Forms.DataGridView();
            this.groupBoxFitVisuals = new System.Windows.Forms.GroupBox();
            this.checkBoxVisibleFit = new System.Windows.Forms.CheckBox();
            this.btnColorFit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownHeightOffsetFit = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveFit = new System.Windows.Forms.Button();
            this.btnSaveFit = new System.Windows.Forms.Button();
            this.btnRenameData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.groupBoxGraphVisuals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightOffsetData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFit)).BeginInit();
            this.groupBoxFitVisuals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightOffsetFit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 28);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1033, 501);
            this.zedGraphControl1.TabIndex = 1;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AllowUserToAddRows = false;
            this.dataGridViewData.AllowUserToDeleteRows = false;
            this.dataGridViewData.AllowUserToResizeRows = false;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewData.Location = new System.Drawing.Point(1053, 28);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.ReadOnly = true;
            this.dataGridViewData.RowTemplate.Height = 25;
            this.dataGridViewData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewData.Size = new System.Drawing.Size(303, 225);
            this.dataGridViewData.TabIndex = 2;
            // 
            // groupBoxGraphVisuals
            // 
            this.groupBoxGraphVisuals.Controls.Add(this.btnRenameData);
            this.groupBoxGraphVisuals.Controls.Add(this.btnSaveData);
            this.groupBoxGraphVisuals.Controls.Add(this.btnRemoveData);
            this.groupBoxGraphVisuals.Controls.Add(this.label1);
            this.groupBoxGraphVisuals.Controls.Add(this.btnMarker);
            this.groupBoxGraphVisuals.Controls.Add(this.checkBoxVisibleData);
            this.groupBoxGraphVisuals.Controls.Add(this.numericUpDownHeightOffsetData);
            this.groupBoxGraphVisuals.Controls.Add(this.btnColorData);
            this.groupBoxGraphVisuals.Location = new System.Drawing.Point(1053, 259);
            this.groupBoxGraphVisuals.Name = "groupBoxGraphVisuals";
            this.groupBoxGraphVisuals.Size = new System.Drawing.Size(302, 126);
            this.groupBoxGraphVisuals.TabIndex = 3;
            this.groupBoxGraphVisuals.TabStop = false;
            this.groupBoxGraphVisuals.Text = "Graph Visuals";
            // 
            // checkBoxVisibleData
            // 
            this.checkBoxVisibleData.AutoSize = true;
            this.checkBoxVisibleData.Location = new System.Drawing.Point(6, 22);
            this.checkBoxVisibleData.Name = "checkBoxVisibleData";
            this.checkBoxVisibleData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxVisibleData.Size = new System.Drawing.Size(60, 19);
            this.checkBoxVisibleData.TabIndex = 0;
            this.checkBoxVisibleData.Text = "Visible";
            this.checkBoxVisibleData.UseVisualStyleBackColor = true;
            // 
            // btnColorData
            // 
            this.btnColorData.Location = new System.Drawing.Point(108, 19);
            this.btnColorData.Name = "btnColorData";
            this.btnColorData.Size = new System.Drawing.Size(75, 23);
            this.btnColorData.TabIndex = 1;
            this.btnColorData.Text = "Color...";
            this.btnColorData.UseVisualStyleBackColor = true;
            // 
            // btnMarker
            // 
            this.btnMarker.Location = new System.Drawing.Point(203, 19);
            this.btnMarker.Name = "btnMarker";
            this.btnMarker.Size = new System.Drawing.Size(75, 23);
            this.btnMarker.TabIndex = 2;
            this.btnMarker.Text = "Marker...";
            this.btnMarker.UseVisualStyleBackColor = true;
            // 
            // numericUpDownHeightOffsetData
            // 
            this.numericUpDownHeightOffsetData.Location = new System.Drawing.Point(108, 48);
            this.numericUpDownHeightOffsetData.Name = "numericUpDownHeightOffsetData";
            this.numericUpDownHeightOffsetData.Size = new System.Drawing.Size(41, 23);
            this.numericUpDownHeightOffsetData.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Visible Offset:";
            // 
            // btnRemoveData
            // 
            this.btnRemoveData.Location = new System.Drawing.Point(10, 88);
            this.btnRemoveData.Name = "btnRemoveData";
            this.btnRemoveData.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveData.TabIndex = 5;
            this.btnRemoveData.Text = "Remove";
            this.btnRemoveData.UseVisualStyleBackColor = true;
            // 
            // btnSaveData
            // 
            this.btnSaveData.Location = new System.Drawing.Point(203, 88);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveData.TabIndex = 6;
            this.btnSaveData.Text = "Save Data...";
            this.btnSaveData.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(13, 535);
            this.zedGraphControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(1033, 173);
            this.zedGraphControl2.TabIndex = 4;
            this.zedGraphControl2.UseExtendedPrintDialog = true;
            // 
            // dataGridViewFit
            // 
            this.dataGridViewFit.AllowUserToAddRows = false;
            this.dataGridViewFit.AllowUserToDeleteRows = false;
            this.dataGridViewFit.AllowUserToResizeRows = false;
            this.dataGridViewFit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFit.Location = new System.Drawing.Point(1053, 392);
            this.dataGridViewFit.Name = "dataGridViewFit";
            this.dataGridViewFit.ReadOnly = true;
            this.dataGridViewFit.RowTemplate.Height = 25;
            this.dataGridViewFit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFit.Size = new System.Drawing.Size(302, 199);
            this.dataGridViewFit.TabIndex = 5;
            // 
            // groupBoxFitVisuals
            // 
            this.groupBoxFitVisuals.Controls.Add(this.button1);
            this.groupBoxFitVisuals.Controls.Add(this.btnSaveFit);
            this.groupBoxFitVisuals.Controls.Add(this.btnRemoveFit);
            this.groupBoxFitVisuals.Controls.Add(this.numericUpDownHeightOffsetFit);
            this.groupBoxFitVisuals.Controls.Add(this.label2);
            this.groupBoxFitVisuals.Controls.Add(this.checkBoxVisibleFit);
            this.groupBoxFitVisuals.Controls.Add(this.btnColorFit);
            this.groupBoxFitVisuals.Location = new System.Drawing.Point(1053, 598);
            this.groupBoxFitVisuals.Name = "groupBoxFitVisuals";
            this.groupBoxFitVisuals.Size = new System.Drawing.Size(303, 110);
            this.groupBoxFitVisuals.TabIndex = 6;
            this.groupBoxFitVisuals.TabStop = false;
            this.groupBoxFitVisuals.Text = "Fit Visuals";
            // 
            // checkBoxVisibleFit
            // 
            this.checkBoxVisibleFit.AutoSize = true;
            this.checkBoxVisibleFit.Location = new System.Drawing.Point(10, 23);
            this.checkBoxVisibleFit.Name = "checkBoxVisibleFit";
            this.checkBoxVisibleFit.Size = new System.Drawing.Size(60, 19);
            this.checkBoxVisibleFit.TabIndex = 0;
            this.checkBoxVisibleFit.Text = "Visible";
            this.checkBoxVisibleFit.UseVisualStyleBackColor = true;
            // 
            // btnColorFit
            // 
            this.btnColorFit.Location = new System.Drawing.Point(108, 19);
            this.btnColorFit.Name = "btnColorFit";
            this.btnColorFit.Size = new System.Drawing.Size(75, 23);
            this.btnColorFit.TabIndex = 7;
            this.btnColorFit.Text = "Color...";
            this.btnColorFit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Visible Offset:";
            // 
            // numericUpDownHeightOffsetFit
            // 
            this.numericUpDownHeightOffsetFit.Location = new System.Drawing.Point(108, 49);
            this.numericUpDownHeightOffsetFit.Name = "numericUpDownHeightOffsetFit";
            this.numericUpDownHeightOffsetFit.Size = new System.Drawing.Size(41, 23);
            this.numericUpDownHeightOffsetFit.TabIndex = 7;
            // 
            // btnRemoveFit
            // 
            this.btnRemoveFit.Location = new System.Drawing.Point(6, 81);
            this.btnRemoveFit.Name = "btnRemoveFit";
            this.btnRemoveFit.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFit.TabIndex = 9;
            this.btnRemoveFit.Text = "Remove";
            this.btnRemoveFit.UseVisualStyleBackColor = true;
            // 
            // btnSaveFit
            // 
            this.btnSaveFit.Location = new System.Drawing.Point(203, 81);
            this.btnSaveFit.Name = "btnSaveFit";
            this.btnSaveFit.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFit.TabIndex = 10;
            this.btnSaveFit.Text = "Save Fit...";
            this.btnSaveFit.UseVisualStyleBackColor = true;
            // 
            // btnRenameData
            // 
            this.btnRenameData.Location = new System.Drawing.Point(108, 88);
            this.btnRenameData.Name = "btnRenameData";
            this.btnRenameData.Size = new System.Drawing.Size(75, 23);
            this.btnRenameData.TabIndex = 7;
            this.btnRenameData.Text = "Rename...";
            this.btnRenameData.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Rename...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 772);
            this.Controls.Add(this.groupBoxFitVisuals);
            this.Controls.Add(this.dataGridViewFit);
            this.Controls.Add(this.zedGraphControl2);
            this.Controls.Add(this.groupBoxGraphVisuals);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.groupBoxGraphVisuals.ResumeLayout(false);
            this.groupBoxGraphVisuals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightOffsetData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFit)).EndInit();
            this.groupBoxFitVisuals.ResumeLayout(false);
            this.groupBoxFitVisuals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeightOffsetFit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.GroupBox groupBoxGraphVisuals;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnRemoveData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownHeightOffsetData;
        private System.Windows.Forms.Button btnMarker;
        private System.Windows.Forms.Button btnColorData;
        private System.Windows.Forms.CheckBox checkBoxVisibleData;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private System.Windows.Forms.DataGridView dataGridViewFit;
        private System.Windows.Forms.GroupBox groupBoxFitVisuals;
        private System.Windows.Forms.CheckBox checkBoxVisibleFit;
        private System.Windows.Forms.Button btnColorFit;
        private System.Windows.Forms.NumericUpDown numericUpDownHeightOffsetFit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveFit;
        private System.Windows.Forms.Button btnRenameData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveFit;
    }
}

