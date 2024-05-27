namespace DoAnDBMS
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            pbProduct = new PictureBox();
            lblNameProduct = new Label();
            lblPrice = new Label();
            pnlAdd = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbProduct).BeginInit();
            SuspendLayout();
            // 
            // pbProduct
            // 
            pbProduct.BackgroundImage = (Image)resources.GetObject("pbProduct.BackgroundImage");
            pbProduct.BackgroundImageLayout = ImageLayout.Stretch;
            pbProduct.Location = new Point(0, 0);
            pbProduct.Name = "pbProduct";
            pbProduct.Size = new Size(126, 126);
            pbProduct.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProduct.TabIndex = 0;
            pbProduct.TabStop = false;
            // 
            // lblNameProduct
            // 
            lblNameProduct.AutoSize = true;
            lblNameProduct.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameProduct.Location = new Point(3, 129);
            lblNameProduct.Name = "lblNameProduct";
            lblNameProduct.Size = new Size(89, 17);
            lblNameProduct.TabIndex = 1;
            lblNameProduct.Text = "Ten san pham";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrice.Location = new Point(3, 160);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(24, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Gia";
            // 
            // pnlAdd
            // 
            pnlAdd.BackgroundImage = (Image)resources.GetObject("pnlAdd.BackgroundImage");
            pnlAdd.BackgroundImageLayout = ImageLayout.Center;
            pnlAdd.Location = new Point(78, 146);
            pnlAdd.Name = "pnlAdd";
            pnlAdd.Size = new Size(48, 38);
            pnlAdd.TabIndex = 3;
            pnlAdd.Click += pnlAdd_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(pnlAdd);
            Controls.Add(lblPrice);
            Controls.Add(lblNameProduct);
            Controls.Add(pbProduct);
            Name = "Product";
            Size = new Size(126, 184);
            Load += Product_Load;
            ((System.ComponentModel.ISupportInitialize)pbProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProduct;
        private Label lblNameProduct;
        private Label lblPrice;
        internal Panel pnlAdd;
    }
}
