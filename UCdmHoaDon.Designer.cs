namespace DoAnDBMS
{
    partial class UCdmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCdmHoaDon));
            dataGridView1 = new DataGridView();
            newButton1 = new NewButton();
            newButton2 = new NewButton();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(115, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 293);
            dataGridView1.TabIndex = 0;
            // 
            // newButton1
            // 
            newButton1.BackColor = Color.DodgerBlue;
            newButton1.BackgroundColor = Color.DodgerBlue;
            newButton1.BorderColor = Color.PaleVioletRed;
            newButton1.BorderRadius = 0;
            newButton1.BorderSize = 0;
            newButton1.FlatAppearance.BorderSize = 0;
            newButton1.FlatStyle = FlatStyle.Flat;
            newButton1.ForeColor = Color.White;
            newButton1.Location = new Point(115, 63);
            newButton1.Name = "newButton1";
            newButton1.Size = new Size(111, 23);
            newButton1.TabIndex = 1;
            newButton1.Text = "Làm mới";
            newButton1.TextColor = Color.White;
            newButton1.UseVisualStyleBackColor = false;
            newButton1.Click += newButton1_Click;
            // 
            // newButton2
            // 
            newButton2.BackColor = Color.Gold;
            newButton2.BackgroundColor = Color.Gold;
            newButton2.BorderColor = Color.PaleVioletRed;
            newButton2.BorderRadius = 0;
            newButton2.BorderSize = 0;
            newButton2.FlatAppearance.BorderSize = 0;
            newButton2.FlatStyle = FlatStyle.Flat;
            newButton2.ForeColor = Color.Black;
            newButton2.Location = new Point(495, 63);
            newButton2.Name = "newButton2";
            newButton2.Size = new Size(67, 23);
            newButton2.TabIndex = 2;
            newButton2.Text = "Tìm";
            newButton2.TextColor = Color.Black;
            newButton2.UseVisualStyleBackColor = false;
            newButton2.Click += newButton2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(291, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(291, 45);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Mã đơn";
            // 
            // UCdmHoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(newButton2);
            Controls.Add(textBox1);
            Controls.Add(newButton1);
            Controls.Add(dataGridView1);
            Name = "UCdmHoaDon";
            Size = new Size(693, 440);
            Load += UCdmHoaDon_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private NewButton newButton1;
        private NewButton newButton2;
        private TextBox textBox1;
        private Label label1;
    }
}
