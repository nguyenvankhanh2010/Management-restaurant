namespace DoAnDBMS
{
    partial class UCProInCartcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCProInCartcs));
            lbl = new Label();
            label1 = new Label();
            lblSoLuong = new Label();
            lblPrice = new Label();
            pbProduct = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl.Location = new Point(103, 26);
            lbl.Name = "lbl";
            lbl.Size = new Size(55, 15);
            lbl.TabIndex = 0;
            lbl.Text = "Số lượng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(196, 26);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 1;
            label1.Text = "Giá";
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(163, 26);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(13, 15);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "1";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(235, 26);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(52, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "100 VND";
            // 
            // pbProduct
            // 
            pbProduct.BackgroundImage = (Image)resources.GetObject("pbProduct.BackgroundImage");
            pbProduct.BackgroundImageLayout = ImageLayout.Zoom;
            pbProduct.Location = new Point(0, 0);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(73, 69);
            pbProduct.TabIndex = 4;
            pbProduct.TabStop = false;
            // 
            // UCProInCartcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            Controls.Add(pbProduct);
            Controls.Add(lblPrice);
            Controls.Add(lblSoLuong);
            Controls.Add(label1);
            Controls.Add(lbl);
            Name = "UCProInCartcs";
            Size = new Size(341, 69);
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl;
        private Label label1;
        private Label lblSoLuong;
        private Label lblPrice;
        private PictureBox pbProduct;
    }
}
