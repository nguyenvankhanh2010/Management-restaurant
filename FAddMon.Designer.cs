namespace DoAnDBMS
{
    partial class FAddMon
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
            nudSoLuong = new NumericUpDown();
            lblName = new Label();
            label3 = new Label();
            btnAdd = new NewButton();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            SuspendLayout();
            // 
            // nudSoLuong
            // 
            nudSoLuong.Location = new Point(280, 21);
            nudSoLuong.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(31, 23);
            nudSoLuong.TabIndex = 0;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(32, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Tên món ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 23);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Số lượng";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.BackgroundColor = Color.MediumSeaGreen;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 40;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(336, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(119, 40);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm món";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // FAddMon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(477, 66);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(lblName);
            Controls.Add(nudSoLuong);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FAddMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Xác nhận thêm món ";
            Load += FAddMon_Load;
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudSoLuong;
        private Label lblName;
        private Label label3;
        private NewButton btnAdd;
    }
}