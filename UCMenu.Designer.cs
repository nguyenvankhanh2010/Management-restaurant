namespace DoAnDBMS
{
    partial class UCMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMenu));
            flpProduct = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpProduct
            // 
            flpProduct.AutoScroll = true;
            flpProduct.BackColor = Color.WhiteSmoke;
            flpProduct.BackgroundImage = (Image)resources.GetObject("flpProduct.BackgroundImage");
            flpProduct.BackgroundImageLayout = ImageLayout.Stretch;
            flpProduct.Location = new Point(0, 0);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(801, 483);
            flpProduct.TabIndex = 2;
            // 
            // UCMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            Controls.Add(flpProduct);
            Name = "UCMenu";
            Size = new Size(801, 483);
            Load += UCMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpProduct;
    }
}
