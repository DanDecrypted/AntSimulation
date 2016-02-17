namespace AntSimulation
{
    partial class FrmSettings
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
            this.txtAntCount = new System.Windows.Forms.NumericUpDown();
            this.txtCellSize = new System.Windows.Forms.NumericUpDown();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodPiles = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAntVisionRange = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chkViewingRectangle = new System.Windows.Forms.CheckBox();
            this.txtFamiles = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAntCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCellSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAntVisionRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamiles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAntCount
            // 
            this.txtAntCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntCount.Location = new System.Drawing.Point(106, 12);
            this.txtAntCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtAntCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAntCount.Name = "txtAntCount";
            this.txtAntCount.Size = new System.Drawing.Size(127, 20);
            this.txtAntCount.TabIndex = 0;
            this.txtAntCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txtCellSize
            // 
            this.txtCellSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCellSize.Location = new System.Drawing.Point(106, 39);
            this.txtCellSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.txtCellSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCellSize.Name = "txtCellSize";
            this.txtCellSize.Size = new System.Drawing.Size(127, 20);
            this.txtCellSize.TabIndex = 1;
            this.txtCellSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(15, 167);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(75, 23);
            this.btnLaunch.TabIndex = 2;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ant Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cell Size";
            // 
            // txtFoodPiles
            // 
            this.txtFoodPiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodPiles.Location = new System.Drawing.Point(106, 66);
            this.txtFoodPiles.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.txtFoodPiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFoodPiles.Name = "txtFoodPiles";
            this.txtFoodPiles.Size = new System.Drawing.Size(127, 20);
            this.txtFoodPiles.TabIndex = 6;
            this.txtFoodPiles.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Food Piles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Vision Range";
            // 
            // txtAntVisionRange
            // 
            this.txtAntVisionRange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAntVisionRange.Location = new System.Drawing.Point(106, 92);
            this.txtAntVisionRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtAntVisionRange.Name = "txtAntVisionRange";
            this.txtAntVisionRange.Size = new System.Drawing.Size(127, 20);
            this.txtAntVisionRange.TabIndex = 9;
            this.txtAntVisionRange.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cells";
            // 
            // chkViewingRectangle
            // 
            this.chkViewingRectangle.AutoSize = true;
            this.chkViewingRectangle.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkViewingRectangle.Location = new System.Drawing.Point(12, 144);
            this.chkViewingRectangle.Name = "chkViewingRectangle";
            this.chkViewingRectangle.Size = new System.Drawing.Size(145, 17);
            this.chkViewingRectangle.TabIndex = 11;
            this.chkViewingRectangle.Text = "Show Viewing Rectangle";
            this.chkViewingRectangle.UseVisualStyleBackColor = true;
            // 
            // txtFamiles
            // 
            this.txtFamiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFamiles.Location = new System.Drawing.Point(106, 118);
            this.txtFamiles.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtFamiles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtFamiles.Name = "txtFamiles";
            this.txtFamiles.Size = new System.Drawing.Size(127, 20);
            this.txtFamiles.TabIndex = 13;
            this.txtFamiles.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ant Families";
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 208);
            this.Controls.Add(this.txtFamiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkViewingRectangle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAntVisionRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodPiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.txtCellSize);
            this.Controls.Add(this.txtAntCount);
            this.Name = "FrmSettings";
            this.Text = "FrmSettings";
            ((System.ComponentModel.ISupportInitialize)(this.txtAntCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCellSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodPiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAntVisionRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFamiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtAntCount;
        private System.Windows.Forms.NumericUpDown txtCellSize;
        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtFoodPiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtAntVisionRange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkViewingRectangle;
        private System.Windows.Forms.NumericUpDown txtFamiles;
        private System.Windows.Forms.Label label6;
    }
}