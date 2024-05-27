namespace DoAnDBMS
{
    partial class UCBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBan));
            pnlPic = new Panel();
            label1 = new Label();
            label2 = new Label();
            lblSoGhe = new Label();
            btnCreate = new NewButton();
            lblidBan = new Label();
            SuspendLayout();
            // 
            // pnlPic
            // 
            pnlPic.BackgroundImage = (Image)resources.GetObject("pnlPic.BackgroundImage");
            pnlPic.BackgroundImageLayout = ImageLayout.Zoom;
            pnlPic.Location = new Point(0, 0);
            pnlPic.Name = "pnlPic";
            pnlPic.Size = new Size(153, 107);
            pnlPic.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 16);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 1;
            label1.Text = "Bàn ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 45);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "Số ghế";
            // 
            // lblSoGhe
            // 
            lblSoGhe.AutoSize = true;
            lblSoGhe.Location = new Point(210, 45);
            lblSoGhe.Name = "lblSoGhe";
            lblSoGhe.Size = new Size(13, 15);
            lblSoGhe.TabIndex = 3;
            lblSoGhe.Text = "0";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.MediumSeaGreen;
            btnCreate.BackgroundColor = Color.MediumSeaGreen;
            btnCreate.BorderColor = Color.PaleVioletRed;
            btnCreate.BorderRadius = 0;
            btnCreate.BorderSize = 0;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreate.ForeColor = Color.Black;
            btnCreate.Location = new Point(159, 63);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(92, 35);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Thêm khách";
            btnCreate.TextColor = Color.Black;
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblidBan
            // 
            lblidBan.AutoSize = true;
            lblidBan.Location = new Point(206, 18);
            lblidBan.Name = "lblidBan";
            lblidBan.Size = new Size(17, 15);
            lblidBan.TabIndex = 5;
            lblidBan.Text = "id";
            // 
            // UCBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblidBan);
            Controls.Add(btnCreate);
            Controls.Add(lblSoGhe);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pnlPic);
            Name = "UCBan";
            Size = new Size(258, 107);
            Click += UCBan_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlPic;
        private Label label1;
        private Label label2;
        private Label lblSoGhe;
        private NewButton btnCreate;
        private Label lblidBan;
    }
}
