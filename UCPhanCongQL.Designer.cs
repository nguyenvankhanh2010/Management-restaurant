namespace DoAnDBMS
{
    partial class UCPhanCongQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPhanCongQL));
            dgvPhanCong = new DataGridView();
            dtpNgayLamViec = new DateTimePicker();
            cbbCaLamViec = new ComboBox();
            tbMaNV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAdd = new NewButton();
            btnDel = new NewButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).BeginInit();
            SuspendLayout();
            // 
            // dgvPhanCong
            // 
            dgvPhanCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhanCong.Location = new Point(22, 57);
            dgvPhanCong.Name = "dgvPhanCong";
            dgvPhanCong.RowTemplate.Height = 25;
            dgvPhanCong.Size = new Size(535, 303);
            dgvPhanCong.TabIndex = 0;
            dgvPhanCong.CellClick += dgvPhanCong_CellClick;
            // 
            // dtpNgayLamViec
            // 
            dtpNgayLamViec.Location = new Point(597, 209);
            dtpNgayLamViec.Name = "dtpNgayLamViec";
            dtpNgayLamViec.Size = new Size(200, 23);
            dtpNgayLamViec.TabIndex = 1;
            // 
            // cbbCaLamViec
            // 
            cbbCaLamViec.FormattingEnabled = true;
            cbbCaLamViec.Items.AddRange(new object[] { "Ca 1", "Ca 2", "Ca 3" });
            cbbCaLamViec.Location = new Point(597, 79);
            cbbCaLamViec.Name = "cbbCaLamViec";
            cbbCaLamViec.Size = new Size(200, 23);
            cbbCaLamViec.TabIndex = 2;
            cbbCaLamViec.SelectedIndexChanged += cbbCaLamViec_SelectedIndexChanged;
            // 
            // tbMaNV
            // 
            tbMaNV.Location = new Point(597, 141);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(200, 23);
            tbMaNV.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(597, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 4;
            label1.Text = "Chọn ca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(597, 186);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 5;
            label2.Text = "Ngày làm việc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(597, 118);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 6;
            label3.Text = "Mã nhân viên";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.BackgroundColor = Color.MediumSeaGreen;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 0;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(620, 261);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm phân công";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.OrangeRed;
            btnDel.BackgroundColor = Color.OrangeRed;
            btnDel.BorderColor = Color.PaleVioletRed;
            btnDel.BorderRadius = 0;
            btnDel.BorderSize = 0;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = Color.Black;
            btnDel.Location = new Point(620, 319);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 40);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xóa phân công";
            btnDel.TextColor = Color.Black;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(22, 363);
            label4.Name = "label4";
            label4.Size = new Size(137, 15);
            label4.TabIndex = 9;
            label4.Text = "Ca 1: từ  7 giờ đến 12 giờ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(217, 363);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 10;
            label5.Text = "Ca 2: từ  12 giờ đến 17 giờ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(414, 363);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 11;
            label6.Text = "Ca 3: từ  17 giờ đến 22 giờ";
            // 
            // UCPhanCongQL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbMaNV);
            Controls.Add(cbbCaLamViec);
            Controls.Add(dtpNgayLamViec);
            Controls.Add(dgvPhanCong);
            Name = "UCPhanCongQL";
            Size = new Size(842, 483);
            Load += UCPhanCongQL_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPhanCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPhanCong;
        private DateTimePicker dtpNgayLamViec;
        private ComboBox cbbCaLamViec;
        private TextBox tbMaNV;
        private Label label1;
        private Label label2;
        private Label label3;
        private NewButton btnAdd;
        private NewButton btnDel;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
