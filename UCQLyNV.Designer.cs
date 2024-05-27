namespace DoAnDBMS
{
    partial class UCQLyNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQLyNV));
            cbbChiNhanh = new ComboBox();
            cbbCongViec = new ComboBox();
            dtpDateStart = new DateTimePicker();
            tbSDT = new TextBox();
            tbThuong = new TextBox();
            tbDiaChi = new TextBox();
            tbCCCD = new TextBox();
            tbHoTen = new TextBox();
            tbMaNV = new TextBox();
            label12 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            rbFemale = new RadioButton();
            rbMale = new RadioButton();
            dtpDOB = new DateTimePicker();
            pbImagePro = new PictureBox();
            dgvDMNV = new DataGridView();
            btnChange = new NewButton();
            btnDel = new NewButton();
            btnAdd = new NewButton();
            ((System.ComponentModel.ISupportInitialize)pbImagePro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDMNV).BeginInit();
            SuspendLayout();
            // 
            // cbbChiNhanh
            // 
            cbbChiNhanh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbChiNhanh.FormattingEnabled = true;
            cbbChiNhanh.Items.AddRange(new object[] { "Chi nhánh 1", "Chi nhánh 2" });
            cbbChiNhanh.Location = new Point(280, 258);
            cbbChiNhanh.Name = "cbbChiNhanh";
            cbbChiNhanh.Size = new Size(200, 29);
            cbbChiNhanh.TabIndex = 33;
            cbbChiNhanh.SelectedIndexChanged += cbbChiNhanh_SelectedIndexChanged;
            // 
            // cbbCongViec
            // 
            cbbCongViec.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbCongViec.FormattingEnabled = true;
            cbbCongViec.Items.AddRange(new object[] { "Đầu bếp", "Phục vụ", "Thu ngân", "Quản lý" });
            cbbCongViec.Location = new Point(280, 208);
            cbbCongViec.Name = "cbbCongViec";
            cbbCongViec.Size = new Size(200, 29);
            cbbCongViec.TabIndex = 32;
            cbbCongViec.SelectedIndexChanged += cbbCongViec_SelectedIndexChanged;
            // 
            // dtpDateStart
            // 
            dtpDateStart.Location = new Point(280, 308);
            dtpDateStart.Name = "dtpDateStart";
            dtpDateStart.Size = new Size(200, 23);
            dtpDateStart.TabIndex = 31;
            // 
            // tbSDT
            // 
            tbSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSDT.Location = new Point(42, 364);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(200, 29);
            tbSDT.TabIndex = 30;
            // 
            // tbThuong
            // 
            tbThuong.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbThuong.Location = new Point(280, 364);
            tbThuong.Name = "tbThuong";
            tbThuong.Size = new Size(200, 29);
            tbThuong.TabIndex = 29;
            // 
            // tbDiaChi
            // 
            tbDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbDiaChi.Location = new Point(281, 141);
            tbDiaChi.Name = "tbDiaChi";
            tbDiaChi.Size = new Size(200, 29);
            tbDiaChi.TabIndex = 28;
            // 
            // tbCCCD
            // 
            tbCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbCCCD.Location = new Point(42, 208);
            tbCCCD.Name = "tbCCCD";
            tbCCCD.Size = new Size(200, 29);
            tbCCCD.TabIndex = 27;
            // 
            // tbHoTen
            // 
            tbHoTen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbHoTen.Location = new Point(42, 141);
            tbHoTen.Name = "tbHoTen";
            tbHoTen.Size = new Size(200, 29);
            tbHoTen.TabIndex = 26;
            // 
            // tbMaNV
            // 
            tbMaNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaNV.Location = new Point(42, 79);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(200, 29);
            tbMaNV.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(280, 346);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 43;
            label12.Text = "Thưởng";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(280, 190);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 42;
            label10.Text = "Chọn công việc";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(280, 240);
            label9.Name = "label9";
            label9.Size = new Size(92, 15);
            label9.TabIndex = 41;
            label9.Text = "Chọn chi nhánh";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(280, 290);
            label7.Name = "label7";
            label7.Size = new Size(125, 15);
            label7.TabIndex = 40;
            label7.Text = "Ngày bắt đầu làm việc";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(46, 290);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 39;
            label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(46, 346);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 38;
            label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(285, 123);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 37;
            label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(46, 190);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 36;
            label3.Text = "CCCD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(42, 123);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 35;
            label2.Text = "Họ tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(42, 61);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 34;
            label1.Text = "Mã nhân viên";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(46, 264);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 46;
            label8.Text = "Giới tính";
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.BackColor = Color.Transparent;
            rbFemale.Location = new Point(194, 262);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(41, 19);
            rbFemale.TabIndex = 45;
            rbFemale.TabStop = true;
            rbFemale.Text = "Nữ";
            rbFemale.UseVisualStyleBackColor = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.BackColor = Color.Transparent;
            rbMale.Location = new Point(113, 262);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 44;
            rbMale.TabStop = true;
            rbMale.Text = "Nam";
            rbMale.UseVisualStyleBackColor = false;
            // 
            // dtpDOB
            // 
            dtpDOB.Location = new Point(42, 308);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 47;
            // 
            // pbImagePro
            // 
            pbImagePro.BackgroundImageLayout = ImageLayout.Stretch;
            pbImagePro.Image = (Image)resources.GetObject("pbImagePro.Image");
            pbImagePro.Location = new Point(314, 15);
            pbImagePro.Name = "pbImagePro";
            pbImagePro.Size = new Size(135, 105);
            pbImagePro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagePro.TabIndex = 48;
            pbImagePro.TabStop = false;
            pbImagePro.Click += pbImagePro_Click;
            // 
            // dgvDMNV
            // 
            dgvDMNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDMNV.Location = new Point(512, 29);
            dgvDMNV.Name = "dgvDMNV";
            dgvDMNV.RowTemplate.Height = 25;
            dgvDMNV.Size = new Size(440, 364);
            dgvDMNV.TabIndex = 49;
            dgvDMNV.CellClick += dgvDMNV_CellClick;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.Gold;
            btnChange.BackgroundColor = Color.Gold;
            btnChange.BorderColor = Color.PaleVioletRed;
            btnChange.BorderRadius = 0;
            btnChange.BorderSize = 0;
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.FlatStyle = FlatStyle.Flat;
            btnChange.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnChange.ForeColor = Color.Black;
            btnChange.Location = new Point(391, 422);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(200, 40);
            btnChange.TabIndex = 52;
            btnChange.Text = "Sửa";
            btnChange.TextColor = Color.Black;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnDel
            // 
            btnDel.BackColor = Color.Tomato;
            btnDel.BackgroundColor = Color.Tomato;
            btnDel.BorderColor = Color.PaleVioletRed;
            btnDel.BorderRadius = 0;
            btnDel.BorderSize = 0;
            btnDel.FlatAppearance.BorderSize = 0;
            btnDel.FlatStyle = FlatStyle.Flat;
            btnDel.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(706, 422);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(200, 40);
            btnDel.TabIndex = 51;
            btnDel.Text = "Xóa";
            btnDel.TextColor = Color.White;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
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
            btnAdd.Location = new Point(68, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(200, 40);
            btnAdd.TabIndex = 50;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // UCQLyNV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnChange);
            Controls.Add(btnDel);
            Controls.Add(btnAdd);
            Controls.Add(dgvDMNV);
            Controls.Add(pbImagePro);
            Controls.Add(dtpDOB);
            Controls.Add(label8);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbbChiNhanh);
            Controls.Add(cbbCongViec);
            Controls.Add(dtpDateStart);
            Controls.Add(tbSDT);
            Controls.Add(tbThuong);
            Controls.Add(tbDiaChi);
            Controls.Add(tbCCCD);
            Controls.Add(tbHoTen);
            Controls.Add(tbMaNV);
            Name = "UCQLyNV";
            Size = new Size(978, 483);
            Load += UCQuanLyNV_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagePro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDMNV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbChiNhanh;
        private ComboBox cbbCongViec;
        private DateTimePicker dtpDateStart;
        private TextBox tbSDT;
        private TextBox tbThuong;
        private TextBox tbDiaChi;
        private TextBox tbCCCD;
        private TextBox tbHoTen;
        private TextBox tbMaNV;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private RadioButton rbFemale;
        private RadioButton rbMale;
        private DateTimePicker dtpDOB;
        private PictureBox pbImagePro;
        private DataGridView dgvDMNV;
        private NewButton btnChange;
        private NewButton btnDel;
        private NewButton btnAdd;
    }
}
