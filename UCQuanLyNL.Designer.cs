namespace DoAnDBMS
{
    partial class UCQuanLyNL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCQuanLyNL));
            dgvNL = new DataGridView();
            btnAdd = new NewButton();
            btnSearch = new NewButton();
            tbTenNL = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvNL).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNL
            // 
            dgvNL.BackgroundColor = Color.Gainsboro;
            dgvNL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNL.Location = new Point(77, 50);
            dgvNL.Name = "dgvNL";
            dgvNL.RowTemplate.Height = 25;
            dgvNL.Size = new Size(443, 364);
            dgvNL.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Gold;
            btnAdd.BackgroundColor = Color.Gold;
            btnAdd.BorderColor = Color.PaleVioletRed;
            btnAdd.BorderRadius = 0;
            btnAdd.BorderSize = 0;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(609, 313);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm nguyên liệu";
            btnAdd.TextColor = Color.Black;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Gold;
            btnSearch.BackgroundColor = Color.Gold;
            btnSearch.BorderColor = Color.PaleVioletRed;
            btnSearch.BorderRadius = 0;
            btnSearch.BorderSize = 0;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(18, 111);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(150, 40);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm nguyên liệu";
            btnSearch.TextColor = Color.Black;
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbTenNL
            // 
            tbTenNL.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbTenNL.Location = new Point(18, 58);
            tbTenNL.Name = "tbTenNL";
            tbTenNL.Size = new Size(150, 27);
            tbTenNL.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(18, 40);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 4;
            label1.Text = "Tên nguyên liệu";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbTenNL);
            panel1.Location = new Point(591, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 187);
            panel1.TabIndex = 5;
            // 
            // UCQuanLyNL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(btnAdd);
            Controls.Add(dgvNL);
            Name = "UCQuanLyNL";
            Size = new Size(842, 483);
            Load += UCQuanLyNL_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNL).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvNL;
        private NewButton btnAdd;
        private NewButton btnSearch;
        private TextBox tbTenNL;
        private Label label1;
        private Panel panel1;
    }
}
