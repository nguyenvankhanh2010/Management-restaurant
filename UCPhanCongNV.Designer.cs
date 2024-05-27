namespace DoAnDBMS
{
    partial class UCPhanCongNV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPhanCongNV));
            dgvPhanCong = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
            SuspendLayout();
            // 
            // dgvPhanCong
            // 
            dgvPhanCong.BackgroundColor = Color.WhiteSmoke;
            dgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhanCong.Location = new Point(125, 79);
            dgvPhanCong.Name = "dgvPhanCong";
            dgvPhanCong.RowTemplate.Height = 25;
            dgvPhanCong.Size = new Size(535, 303);
            dgvPhanCong.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(517, 385);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 14;
            label6.Text = "Ca 3: từ  17 giờ đến 22 giờ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(319, 385);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 13;
            label5.Text = "Ca 2: từ  12 giờ đến 17 giờ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(125, 385);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 12;
            label4.Text = "Ca 1: từ  7 giờ đến 12 giờ";
            // 
            // UCPhanCongNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dgvPhanCong);
            Name = "UCPhanCongNV";
            Size = new Size(801, 483);
            Load += UCPhanCongNV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhanCong;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
