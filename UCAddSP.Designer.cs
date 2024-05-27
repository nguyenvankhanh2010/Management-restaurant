namespace DoAnDBMS
{
    partial class UCAddSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddSP));
            tbTenSP = new TextBox();
            tbMaSP = new TextBox();
            tbDonGia = new TextBox();
            ccbTenNhomSP = new ComboBox();
            tbMaNhomSP = new TextBox();
            lblTenNhomSP = new Label();
            lblMaSP = new Label();
            lblTenSP = new Label();
            lblDonGia = new Label();
            lblTinhTrang = new Label();
            lblMaNhomSP = new Label();
            cbbTinhTrang = new ComboBox();
            pbImagePro = new PictureBox();
            lblImagePro = new Label();
            btnAdd = new NewButton();
            btnChange = new NewButton();
            btnDel = new NewButton();
            dgvProList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbImagePro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProList).BeginInit();
            SuspendLayout();
            // 
            // tbTenSP
            // 
            tbTenSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTenSP.Location = new Point(557, 280);
            tbTenSP.Name = "tbTenSP";
            tbTenSP.Size = new Size(189, 27);
            tbTenSP.TabIndex = 0;
            // 
            // tbMaSP
            // 
            tbMaSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaSP.Location = new Point(557, 210);
            tbMaSP.Name = "tbMaSP";
            tbMaSP.Size = new Size(189, 27);
            tbMaSP.TabIndex = 1;
            // 
            // tbDonGia
            // 
            tbDonGia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbDonGia.Location = new Point(769, 210);
            tbDonGia.Name = "tbDonGia";
            tbDonGia.Size = new Size(189, 27);
            tbDonGia.TabIndex = 2;
            // 
            // ccbTenNhomSP
            // 
            ccbTenNhomSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ccbTenNhomSP.FormattingEnabled = true;
            ccbTenNhomSP.Items.AddRange(new object[] { "Lẩu", "Mì", "Nước uống" });
            ccbTenNhomSP.Location = new Point(557, 69);
            ccbTenNhomSP.Name = "ccbTenNhomSP";
            ccbTenNhomSP.Size = new Size(189, 28);
            ccbTenNhomSP.TabIndex = 4;
            ccbTenNhomSP.SelectedIndexChanged += ccbTenNhomSP_SelectedIndexChanged;
            ccbTenNhomSP.TextChanged += ccbTenNhomSP_SelectedIndexChanged;
            // 
            // tbMaNhomSP
            // 
            tbMaNhomSP.Enabled = false;
            tbMaNhomSP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaNhomSP.Location = new Point(557, 135);
            tbMaNhomSP.Name = "tbMaNhomSP";
            tbMaNhomSP.Size = new Size(189, 27);
            tbMaNhomSP.TabIndex = 5;
            // 
            // lblTenNhomSP
            // 
            lblTenNhomSP.AutoSize = true;
            lblTenNhomSP.BackColor = Color.Transparent;
            lblTenNhomSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenNhomSP.Location = new Point(557, 51);
            lblTenNhomSP.Name = "lblTenNhomSP";
            lblTenNhomSP.Size = new Size(96, 15);
            lblTenNhomSP.TabIndex = 6;
            lblTenNhomSP.Text = "Nhóm sản phẩm";
            // 
            // lblMaSP
            // 
            lblMaSP.AutoSize = true;
            lblMaSP.BackColor = Color.Transparent;
            lblMaSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaSP.Location = new Point(557, 192);
            lblMaSP.Name = "lblMaSP";
            lblMaSP.Size = new Size(79, 15);
            lblMaSP.TabIndex = 7;
            lblMaSP.Text = "Mã sản phẩm";
            // 
            // lblTenSP
            // 
            lblTenSP.AutoSize = true;
            lblTenSP.BackColor = Color.Transparent;
            lblTenSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenSP.Location = new Point(555, 262);
            lblTenSP.Name = "lblTenSP";
            lblTenSP.Size = new Size(81, 15);
            lblTenSP.TabIndex = 8;
            lblTenSP.Text = "Tên sản phẩm";
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.BackColor = Color.Transparent;
            lblDonGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDonGia.Location = new Point(769, 192);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(49, 15);
            lblDonGia.TabIndex = 9;
            lblDonGia.Text = "Đơn giá";
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.BackColor = Color.Transparent;
            lblTinhTrang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTinhTrang.Location = new Point(769, 261);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(62, 15);
            lblTinhTrang.TabIndex = 10;
            lblTinhTrang.Text = "Tình trạng";
            // 
            // lblMaNhomSP
            // 
            lblMaNhomSP.AutoSize = true;
            lblMaNhomSP.BackColor = Color.Transparent;
            lblMaNhomSP.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaNhomSP.Location = new Point(557, 117);
            lblMaNhomSP.Name = "lblMaNhomSP";
            lblMaNhomSP.Size = new Size(59, 15);
            lblMaNhomSP.TabIndex = 11;
            lblMaNhomSP.Text = "Mã nhóm";
            // 
            // cbbTinhTrang
            // 
            cbbTinhTrang.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbTinhTrang.FormattingEnabled = true;
            cbbTinhTrang.Items.AddRange(new object[] { "Còn", "Hết" });
            cbbTinhTrang.Location = new Point(769, 279);
            cbbTinhTrang.Name = "cbbTinhTrang";
            cbbTinhTrang.Size = new Size(189, 28);
            cbbTinhTrang.TabIndex = 12;
            // 
            // pbImagePro
            // 
            pbImagePro.BackgroundImageLayout = ImageLayout.Stretch;
            pbImagePro.Image = (Image)resources.GetObject("pbImagePro.Image");
            pbImagePro.Location = new Point(806, 69);
            pbImagePro.Name = "pbImagePro";
            pbImagePro.Size = new Size(115, 94);
            pbImagePro.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImagePro.TabIndex = 13;
            pbImagePro.TabStop = false;
            pbImagePro.Click += pbImagePro_Click;
            // 
            // lblImagePro
            // 
            lblImagePro.AutoSize = true;
            lblImagePro.BackColor = Color.Transparent;
            lblImagePro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblImagePro.Location = new Point(806, 51);
            lblImagePro.Name = "lblImagePro";
            lblImagePro.Size = new Size(84, 15);
            lblImagePro.TabIndex = 14;
            lblImagePro.Text = "Ảnh sản phẩm";
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
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(29, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Thêm ";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            btnChange.Location = new Point(205, 357);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(150, 40);
            btnChange.TabIndex = 16;
            btnChange.Text = "Sửa";
            btnChange.TextColor = Color.Black;
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
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
            btnDel.ForeColor = Color.White;
            btnDel.Location = new Point(378, 357);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(150, 40);
            btnDel.TabIndex = 17;
            btnDel.Text = "Xóa";
            btnDel.TextColor = Color.White;
            btnDel.UseVisualStyleBackColor = false;
            btnDel.Click += btnDel_Click;
            // 
            // dgvProList
            // 
            dgvProList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProList.Location = new Point(27, 51);
            dgvProList.Margin = new Padding(3, 2, 3, 2);
            dgvProList.Name = "dgvProList";
            dgvProList.RowHeadersWidth = 51;
            dgvProList.RowTemplate.Height = 29;
            dgvProList.Size = new Size(499, 280);
            dgvProList.TabIndex = 18;
            dgvProList.CellClick += dgvProList_CellClick;
            // 
            // UCAddSP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(dgvProList);
            Controls.Add(btnDel);
            Controls.Add(btnChange);
            Controls.Add(btnAdd);
            Controls.Add(lblImagePro);
            Controls.Add(pbImagePro);
            Controls.Add(cbbTinhTrang);
            Controls.Add(lblMaNhomSP);
            Controls.Add(lblTinhTrang);
            Controls.Add(lblDonGia);
            Controls.Add(lblTenSP);
            Controls.Add(lblMaSP);
            Controls.Add(lblTenNhomSP);
            Controls.Add(tbMaNhomSP);
            Controls.Add(ccbTenNhomSP);
            Controls.Add(tbDonGia);
            Controls.Add(tbMaSP);
            Controls.Add(tbTenSP);
            Name = "UCAddSP";
            Size = new Size(978, 483);
            Load += UCAddSP_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagePro).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTenSP;
        private TextBox tbMaSP;
        private TextBox tbDonGia;
        private ComboBox ccbTenNhomSP;
        private TextBox tbMaNhomSP;
        private Label lblTenNhomSP;
        private Label lblMaSP;
        private Label lblTenSP;
        private Label lblDonGia;
        private Label lblTinhTrang;
        private Label lblMaNhomSP;
        private ComboBox cbbTinhTrang;
        private PictureBox pbImagePro;
        private Label lblImagePro;
        private NewButton btnAdd;
        private NewButton btnChange;
        private NewButton btnDel;
        private DataGridView dgvProList;
    }
}
