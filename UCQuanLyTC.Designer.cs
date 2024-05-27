namespace DoAnDBMS
{
    partial class UCQuanLyTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyTC));
            tbYear = new TextBox();
            panel1 = new Panel();
            nudMonth = new NumericUpDown();
            nudDay = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnViewDoanhThu = new NewButton();
            pnl = new Panel();
            lblDoanhThu = new Label();
            cbbDoanhThu = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            lblChiPhi = new Label();
            cbbChiPhi = new ComboBox();
            label6 = new Label();
            btnViewChiPhi = new NewButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            pnl.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbYear
            // 
            tbYear.Location = new Point(341, 38);
            tbYear.Name = "tbYear";
            tbYear.Size = new Size(66, 23);
            tbYear.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nudMonth);
            panel1.Controls.Add(nudDay);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbYear);
            panel1.Location = new Point(166, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(486, 100);
            panel1.TabIndex = 3;
            // 
            // nudMonth
            // 
            nudMonth.Location = new Point(229, 39);
            nudMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            nudMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMonth.Name = "nudMonth";
            nudMonth.Size = new Size(38, 23);
            nudMonth.TabIndex = 7;
            nudMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudDay
            // 
            nudDay.Location = new Point(113, 39);
            nudDay.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            nudDay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(38, 23);
            nudDay.TabIndex = 6;
            nudDay.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(302, 41);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Năm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(182, 41);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Tháng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 41);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 3;
            label1.Text = "Ngày";
            // 
            // btnViewDoanhThu
            // 
            btnViewDoanhThu.BackColor = Color.DodgerBlue;
            btnViewDoanhThu.BackgroundColor = Color.DodgerBlue;
            btnViewDoanhThu.BorderColor = Color.PaleVioletRed;
            btnViewDoanhThu.BorderRadius = 0;
            btnViewDoanhThu.BorderSize = 0;
            btnViewDoanhThu.FlatAppearance.BorderSize = 0;
            btnViewDoanhThu.FlatStyle = FlatStyle.Flat;
            btnViewDoanhThu.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewDoanhThu.ForeColor = Color.White;
            btnViewDoanhThu.Location = new Point(32, 139);
            btnViewDoanhThu.Name = "btnViewDoanhThu";
            btnViewDoanhThu.Size = new Size(165, 40);
            btnViewDoanhThu.TabIndex = 4;
            btnViewDoanhThu.Text = "Hiển thị";
            btnViewDoanhThu.TextColor = Color.White;
            btnViewDoanhThu.UseVisualStyleBackColor = false;
            btnViewDoanhThu.Click += btnViewDoanhThu_Click;
            // 
            // pnl
            // 
            pnl.BackColor = Color.White;
            pnl.Controls.Add(lblDoanhThu);
            pnl.Controls.Add(cbbDoanhThu);
            pnl.Controls.Add(label4);
            pnl.Controls.Add(btnViewDoanhThu);
            pnl.Location = new Point(166, 178);
            pnl.Name = "pnl";
            pnl.Size = new Size(226, 215);
            pnl.TabIndex = 5;
            // 
            // lblDoanhThu
            // 
            lblDoanhThu.AutoSize = true;
            lblDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDoanhThu.Location = new Point(35, 48);
            lblDoanhThu.Name = "lblDoanhThu";
            lblDoanhThu.Size = new Size(57, 21);
            lblDoanhThu.TabIndex = 7;
            lblDoanhThu.Text = "label5";
            // 
            // cbbDoanhThu
            // 
            cbbDoanhThu.BackColor = SystemColors.Window;
            cbbDoanhThu.FormattingEnabled = true;
            cbbDoanhThu.Items.AddRange(new object[] { "Theo năm", "Theo tháng", "Theo ngày" });
            cbbDoanhThu.Location = new Point(32, 92);
            cbbDoanhThu.Name = "cbbDoanhThu";
            cbbDoanhThu.Size = new Size(165, 23);
            cbbDoanhThu.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 20);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 5;
            label4.Text = "DOANH THU";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblChiPhi);
            panel2.Controls.Add(cbbChiPhi);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnViewChiPhi);
            panel2.Location = new Point(426, 178);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 215);
            panel2.TabIndex = 8;
            // 
            // lblChiPhi
            // 
            lblChiPhi.AutoSize = true;
            lblChiPhi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblChiPhi.Location = new Point(35, 48);
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Size = new Size(57, 21);
            lblChiPhi.TabIndex = 7;
            lblChiPhi.Text = "label5";
            // 
            // cbbChiPhi
            // 
            cbbChiPhi.BackColor = SystemColors.Window;
            cbbChiPhi.FormattingEnabled = true;
            cbbChiPhi.Items.AddRange(new object[] { "Theo năm", "Theo tháng" });
            cbbChiPhi.Location = new Point(32, 92);
            cbbChiPhi.Name = "cbbChiPhi";
            cbbChiPhi.Size = new Size(165, 23);
            cbbChiPhi.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 20);
            label6.Name = "label6";
            label6.Size = new Size(56, 17);
            label6.TabIndex = 5;
            label6.Text = "CHI PHÍ";
            // 
            // btnViewChiPhi
            // 
            btnViewChiPhi.BackColor = Color.Gold;
            btnViewChiPhi.BackgroundColor = Color.Gold;
            btnViewChiPhi.BorderColor = Color.PaleVioletRed;
            btnViewChiPhi.BorderRadius = 0;
            btnViewChiPhi.BorderSize = 0;
            btnViewChiPhi.FlatAppearance.BorderSize = 0;
            btnViewChiPhi.FlatStyle = FlatStyle.Flat;
            btnViewChiPhi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewChiPhi.ForeColor = Color.Black;
            btnViewChiPhi.Location = new Point(32, 139);
            btnViewChiPhi.Name = "btnViewChiPhi";
            btnViewChiPhi.Size = new Size(165, 40);
            btnViewChiPhi.TabIndex = 4;
            btnViewChiPhi.Text = "Hiển thị";
            btnViewChiPhi.TextColor = Color.Black;
            btnViewChiPhi.UseVisualStyleBackColor = false;
            btnViewChiPhi.Click += btnViewChiPhi_Click;
            // 
            // UCQuanLyTC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(pnl);
            Controls.Add(panel1);
            Name = "UCQuanLyTC";
            Size = new Size(842, 483);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            pnl.ResumeLayout(false);
            pnl.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbYear;
        private Panel panel1;
        private NumericUpDown nudMonth;
        private NumericUpDown nudDay;
        private Label label3;
        private Label label2;
        private Label label1;
        private NewButton btnViewDoanhThu;
        private Panel pnl;
        private Label label4;
        private Label lblDoanhThu;
        private ComboBox cbbDoanhThu;
        private Panel panel2;
        private Label lblChiPhi;
        private ComboBox cbbChiPhi;
        private Label label6;
        private NewButton btnViewChiPhi;
    }
}
