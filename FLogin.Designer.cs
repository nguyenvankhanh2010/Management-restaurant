namespace DoAnDBMS
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            panel1 = new Panel();
            rbShowPass = new RadioButton();
            tbMK = new TextBox();
            tbTK = new TextBox();
            btnLogin = new NewButton();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(rbShowPass);
            panel1.Controls.Add(tbMK);
            panel1.Controls.Add(tbTK);
            panel1.Controls.Add(btnLogin);
            panel1.Location = new Point(154, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 336);
            panel1.TabIndex = 0;
            // 
            // rbShowPass
            // 
            rbShowPass.AutoSize = true;
            rbShowPass.Location = new Point(41, 224);
            rbShowPass.Name = "rbShowPass";
            rbShowPass.Size = new Size(103, 19);
            rbShowPass.TabIndex = 3;
            rbShowPass.TabStop = true;
            rbShowPass.Text = "Hiện mật khẩu";
            rbShowPass.UseVisualStyleBackColor = true;
            rbShowPass.CheckedChanged += rbShowPass_CheckedChanged;
            // 
            // tbMK
            // 
            tbMK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbMK.Location = new Point(41, 191);
            tbMK.Name = "tbMK";
            tbMK.PlaceholderText = "Mật khẩu";
            tbMK.Size = new Size(150, 27);
            tbMK.TabIndex = 2;
            tbMK.UseSystemPasswordChar = true;
            // 
            // tbTK
            // 
            tbTK.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTK.Location = new Point(41, 131);
            tbTK.Name = "tbTK";
            tbTK.PlaceholderText = "Tài khoản";
            tbTK.Size = new Size(150, 27);
            tbTK.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gold;
            btnLogin.BackgroundColor = Color.Gold;
            btnLogin.BorderColor = Color.PaleVioletRed;
            btnLogin.BorderRadius = 40;
            btnLogin.BorderSize = 0;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(41, 255);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 40);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.TextColor = Color.Black;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(60, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(108, 100);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(88, 323);
            label1.Name = "label1";
            label1.Size = new Size(46, 13);
            label1.TabIndex = 5;
            label1.Text = "Đăng ký";
            label1.Click += label1_Click;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(543, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quán lẩu SQLC# - Đăng nhập";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbMK;
        private TextBox tbTK;
        private NewButton btnLogin;
        private RadioButton rbShowPass;
        private Label label1;
        private Panel panel2;
    }
}