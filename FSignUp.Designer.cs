namespace DoAnDBMS
{
    partial class FSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSignUp));
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbEnPass = new TextBox();
            tbMaNV = new TextBox();
            tbMK = new TextBox();
            tbTK = new TextBox();
            btnLogin = new NewButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tbEnPass);
            panel1.Controls.Add(tbMaNV);
            panel1.Controls.Add(tbMK);
            panel1.Controls.Add(tbTK);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(208, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 340);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 202);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 11;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 146);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 10;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 86);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "Tài khoản";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 8;
            label1.Text = "Mã nhân viên";
            // 
            // tbEnPass
            // 
            tbEnPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbEnPass.Location = new Point(39, 220);
            tbEnPass.Name = "tbEnPass";
            tbEnPass.Size = new Size(150, 27);
            tbEnPass.TabIndex = 7;
            tbEnPass.UseSystemPasswordChar = true;
            // 
            // tbMaNV
            // 
            tbMaNV.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMaNV.Location = new Point(39, 49);
            tbMaNV.Name = "tbMaNV";
            tbMaNV.Size = new Size(150, 27);
            tbMaNV.TabIndex = 6;
            // 
            // tbMK
            // 
            tbMK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMK.Location = new Point(39, 164);
            tbMK.Name = "tbMK";
            tbMK.Size = new Size(150, 27);
            tbMK.TabIndex = 5;
            tbMK.UseSystemPasswordChar = true;
            // 
            // tbTK
            // 
            tbTK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTK.Location = new Point(39, 104);
            tbTK.Name = "tbTK";
            tbTK.Size = new Size(150, 27);
            tbTK.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DodgerBlue;
            btnLogin.BackgroundColor = Color.DodgerBlue;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 40;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(39, 264);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Đăng ký";
            btnLogin.TextColor = Color.Black;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // FSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(636, 408);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quán lẩu SQLC# - Đăng ký tài khoản nội bộ";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbEnPass;
        private TextBox tbMaNV;
        private TextBox tbMK;
        private TextBox tbTK;
        private NewButton btnLogin;
    }
}