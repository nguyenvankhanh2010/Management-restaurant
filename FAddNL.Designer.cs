namespace DoAnDBMS
{
    partial class FAddNL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAddNL));
            tbMaNL = new TextBox();
            tbTenNL = new TextBox();
            tbSoLuong = new TextBox();
            tbMaDNH = new TextBox();
            tbDonGia = new TextBox();
            tbMaPC = new TextBox();
            cbbNSX = new ComboBox();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            btnAdd = new NewButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbMaNL
            // 
            tbMaNL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaNL.Location = new Point(27, 43);
            tbMaNL.Name = "tbMaNL";
            tbMaNL.Size = new Size(166, 25);
            tbMaNL.TabIndex = 0;
            // 
            // tbTenNL
            // 
            tbTenNL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbTenNL.Location = new Point(27, 108);
            tbTenNL.Name = "tbTenNL";
            tbTenNL.Size = new Size(166, 25);
            tbTenNL.TabIndex = 1;
            // 
            // tbSoLuong
            // 
            tbSoLuong.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbSoLuong.Location = new Point(27, 231);
            tbSoLuong.Name = "tbSoLuong";
            tbSoLuong.Size = new Size(166, 25);
            tbSoLuong.TabIndex = 3;
            // 
            // tbMaDNH
            // 
            tbMaDNH.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaDNH.Location = new Point(31, 49);
            tbMaDNH.Name = "tbMaDNH";
            tbMaDNH.Size = new Size(166, 25);
            tbMaDNH.TabIndex = 4;
            // 
            // tbDonGia
            // 
            tbDonGia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbDonGia.Location = new Point(31, 111);
            tbDonGia.Name = "tbDonGia";
            tbDonGia.Size = new Size(166, 25);
            tbDonGia.TabIndex = 5;
            // 
            // tbMaPC
            // 
            tbMaPC.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaPC.Location = new Point(31, 179);
            tbMaPC.Name = "tbMaPC";
            tbMaPC.Size = new Size(166, 25);
            tbMaPC.TabIndex = 6;
            // 
            // cbbNSX
            // 
            cbbNSX.FormattingEnabled = true;
            cbbNSX.Items.AddRange(new object[] { "NSX01", "NSX02", "NSX03", "NSX04", "NSX05" });
            cbbNSX.Location = new Point(27, 170);
            cbbNSX.Name = "cbbNSX";
            cbbNSX.Size = new Size(166, 23);
            cbbNSX.TabIndex = 7;
            cbbNSX.SelectedIndexChanged += cbbNSX_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbMaNL);
            panel1.Controls.Add(tbTenNL);
            panel1.Controls.Add(cbbNSX);
            panel1.Controls.Add(tbSoLuong);
            panel1.Location = new Point(60, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 296);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(27, 213);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 11;
            label4.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(27, 152);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 10;
            label3.Text = "Chọn nhà sản xuất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(27, 90);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 9;
            label2.Text = "Tên nguyên liệu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 8;
            label1.Text = "Mã nguyên liệu";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbMaDNH);
            panel2.Controls.Add(tbDonGia);
            panel2.Controls.Add(tbMaPC);
            panel2.Location = new Point(334, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(227, 248);
            panel2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 161);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 14;
            label7.Text = "Mã phiếu chi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 93);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 13;
            label6.Text = "Đơn giá";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(31, 31);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 12;
            label5.Text = "Mã đơn nhập hàng";
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
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(334, 294);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(227, 40);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FAddNL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(626, 388);
            Controls.Add(btnAdd);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FAddNL";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm nguyên liệu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbMaNL;
        private TextBox tbTenNL;
        private TextBox tbSoLuong;
        private TextBox tbMaDNH;
        private TextBox tbDonGia;
        private TextBox tbMaPC;
        private ComboBox cbbNSX;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label7;
        private Label label6;
        private Label label5;
        private NewButton btnAdd;
    }
}