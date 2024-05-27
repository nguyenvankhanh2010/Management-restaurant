namespace DoAnDBMS
{
    partial class FAddDonHang
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
            tbMaBan = new TextBox();
            tbMaNV = new TextBox();
            tbMaKH = new TextBox();
            tbMaDH = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label = new Label();
            btnCreate = new NewButton();
            SuspendLayout();
            // 
            // tbMaBan
            // 
            tbMaBan.Enabled = false;
            tbMaBan.Location = new Point(39, 231);
            tbMaBan.Name = "tbMaBan";
            tbMaBan.Size = new Size(202, 23);
            tbMaBan.TabIndex = 7;
            // 
            // tbMaNV
            // 
            tbMaNV.Enabled = false;
            tbMaNV.Location = new Point(39, 175);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(202, 23);
            tbMaNV.TabIndex = 6;
            // 
            // tbMaKH
            // 
            tbMaKH.Location = new Point(39, 110);
            tbMaKH.Name = "tbMaKH";
            tbMaKH.Size = new Size(202, 23);
            tbMaKH.TabIndex = 5;
            // 
            // tbMaDH
            // 
            tbMaDH.Location = new Point(41, 49);
            tbMaDH.Name = "tbMaDH";
            tbMaDH.Size = new Size(202, 23);
            tbMaDH.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 213);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 11;
            label3.Text = "Bàn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 157);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 10;
            label2.Text = "Mã nhân viên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 92);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 9;
            label1.Text = "Mã khách hàng";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(41, 31);
            label.Name = "label";
            label.Size = new Size(78, 15);
            label.TabIndex = 8;
            label.Text = "Mã đơn hàng";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Gold;
            btnCreate.BackgroundColor = Color.Gold;
            btnCreate.BorderColor = Color.PaleVioletRed;
            btnCreate.BorderRadius = 40;
            btnCreate.BorderSize = 0;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(65, 279);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 40);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Tạo đơn ";
            btnCreate.TextColor = Color.Black;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // FAddDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 362);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label);
            Controls.Add(tbMaBan);
            Controls.Add(tbMaNV);
            Controls.Add(tbMaKH);
            Controls.Add(tbMaDH);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FAddDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAddDonHang";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMaBan;
        private TextBox tbMaNV;
        private TextBox tbMaKH;
        private TextBox tbMaDH;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label;
        private NewButton btnCreate;
    }
}