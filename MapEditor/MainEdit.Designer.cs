namespace MapEditor
{
    partial class MainEdit
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
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.SaveCSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NowChip = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NowChip)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(12, 9);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 18);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "幅";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(159, 9);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(38, 18);
            this.labelY.TabIndex = 2;
            this.labelY.Text = "高さ";
            // 
            // SaveCSV
            // 
            this.SaveCSV.Location = new System.Drawing.Point(15, 383);
            this.SaveCSV.Name = "SaveCSV";
            this.SaveCSV.Size = new System.Drawing.Size(182, 34);
            this.SaveCSV.TabIndex = 3;
            this.SaveCSV.Text = "CSV書き出し";
            this.SaveCSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "選択中の素材";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NowChip
            // 
            this.NowChip.Location = new System.Drawing.Point(332, 385);
            this.NowChip.Name = "NowChip";
            this.NowChip.Size = new System.Drawing.Size(32, 32);
            this.NowChip.TabIndex = 5;
            this.NowChip.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 339);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NowChip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveCSV);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Name = "MainEdit";
            this.Text = "MainEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainEdit_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainEdit_FormClosed);
            this.Load += new System.EventHandler(this.MainEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NowChip)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Button SaveCSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox NowChip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}