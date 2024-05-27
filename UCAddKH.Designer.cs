namespace DoAnDBMS
{
    partial class UCAddKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCAddKH));
            tbMaKH = new TextBox();
            tbTenKH = new TextBox();
            tbSDT = new TextBox();
            tbSearchKH = new TextBox();
            tbSearchName = new TextBox();
            btnAdd = new NewButton();
            btnSearch = new NewButton();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tbMaKH
            // 
            tbMaKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaKH.Location = new Point(33, 55);
            tbMaKH.Name = "tbMaKH";
            tbMaKH.Size = new Size(183, 29);
            tbMaKH.TabIndex = 0;
            // 
            // tbTenKH
            // 
            tbTenKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbTenKH.Location = new Point(33, 120);
            tbTenKH.Name = "tbTenKH";
            tbTenKH.Size = new Size(183, 29);
            tbTenKH.TabIndex = 1;
            // 
            // tbSDT
            // 
            tbSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSDT.Location = new Point(33, 191);
            tbSDT.Name = "tbSDT";
            tbSDT.Size = new Size(183, 29);
            tbSDT.TabIndex = 2;
            // 
            // tbSearchKH
            // 
            tbSearchKH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchKH.Location = new Point(23, 43);
            tbSearchKH.Name = "tbSearchKH";
            tbSearchKH.Size = new Size(183, 29);
            tbSearchKH.TabIndex = 3;
            // 
            // tbSearchName
            // 
            tbSearchName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchName.Location = new Point(23, 108);
            tbSearchName.Name = "tbSearchName";
            tbSearchName.Size = new Size(183, 29);
            tbSearchName.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.BackgroundColor = Color.DodgerBlue;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 0;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(53, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.TextColor = Color.White;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumSlateBlue;
            btnSearch.BackgroundColor = Color.MediumSlateBlue;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 0;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(42, 168);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm";
            btnSearch.TextColor = Color.White;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbMaKH);
            panel1.Controls.Add(tbTenKH);
            panel1.Controls.Add(tbSDT);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(105, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 319);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbSearchKH);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(tbSearchName);
            panel2.Location = new Point(465, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(228, 245);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 31);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 6;
            label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 102);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 7;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 173);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 8;
            label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 24);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 9;
            label4.Text = "Nhập số điện thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 90);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 10;
            label5.Text = "Tên khách hàng";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(105, 72);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 9;
            label6.Text = "Tạo mới khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(465, 72);
            label7.Name = "label7";
            label7.Size = new Size(155, 20);
            label7.TabIndex = 10;
            label7.Text = "Tìm kiếm khách hàng";
            // 
            // UCAddKH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCAddKH";
            Size = new Size(801, 483);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMaKH;
        private TextBox tbTenKH;
        private TextBox tbSDT;
        private TextBox tbSearchKH;
        private TextBox tbSearchName;
        private NewButton btnAdd;
        private NewButton btnSearch;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}
