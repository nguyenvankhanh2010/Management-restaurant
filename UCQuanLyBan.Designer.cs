namespace DoAnDBMS
{
    partial class UCQuanLyBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyBan));
            flpBan = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpBan
            // 
            flpBan.AutoScroll = true;
            flpBan.BackColor = Color.WhiteSmoke;
            flpBan.BackgroundImage = (Image)resources.GetObject("flpBan.BackgroundImage");
            flpBan.BackgroundImageLayout = ImageLayout.Stretch;
            flpBan.Location = new Point(0, 0);
            flpBan.Name = "flpBan";
            flpBan.Size = new Size(811, 587);
            flpBan.TabIndex = 0;
            // 
            // UCQuanLyBan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpBan);
            Name = "UCQuanLyBan";
            Size = new Size(811, 587);
            Load += UCQuanLyBan_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpBan;
    }
}
