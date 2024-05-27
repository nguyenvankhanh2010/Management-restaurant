namespace DoAnDBMS
{
    partial class FBanView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBanView));
            flpProduct = new FlowLayoutPanel();
            pnlTypeBar = new Panel();
            btnType3 = new NewButton();
            btnType4 = new NewButton();
            btnType2 = new NewButton();
            btnType1 = new NewButton();
            btnAll = new NewButton();
            pnlCusNOrder = new Panel();
            btnSelectTable = new NewButton();
            btnAddCus = new NewButton();
            flpProInCart = new FlowLayoutPanel();
            btnCheckOut = new NewButton();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlTypeBar.SuspendLayout();
            pnlCusNOrder.SuspendLayout();
            SuspendLayout();
            // 
            // flpProduct
            // 
            flpProduct.AutoScroll = true;
            flpProduct.BackColor = Color.WhiteSmoke;
            flpProduct.BackgroundImage = (Image)resources.GetObject("flpProduct.BackgroundImage");
            flpProduct.BackgroundImageLayout = ImageLayout.Stretch;
            flpProduct.Location = new Point(1, 78);
            flpProduct.Name = "flpProduct";
            flpProduct.Size = new Size(542, 618);
            flpProduct.TabIndex = 1;
            // 
            // pnlTypeBar
            // 
            pnlTypeBar.BackColor = SystemColors.Window;
            pnlTypeBar.Controls.Add(btnType3);
            pnlTypeBar.Controls.Add(btnType4);
            pnlTypeBar.Controls.Add(btnType2);
            pnlTypeBar.Controls.Add(btnType1);
            pnlTypeBar.Controls.Add(btnAll);
            pnlTypeBar.Location = new Point(1, 1);
            pnlTypeBar.Name = "pnlTypeBar";
            pnlTypeBar.Size = new Size(529, 71);
            pnlTypeBar.TabIndex = 2;
            // 
            // btnType3
            // 
            btnType3.BackColor = Color.White;
            btnType3.BackgroundColor = Color.White;
            btnType3.BorderColor = Color.White;
            btnType3.BorderRadius = 20;
            btnType3.BorderSize = 2;
            btnType3.FlatAppearance.BorderSize = 0;
            btnType3.FlatStyle = FlatStyle.Flat;
            btnType3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnType3.ForeColor = Color.Black;
            btnType3.Location = new Point(300, 14);
            btnType3.Name = "btnType3";
            btnType3.Size = new Size(90, 45);
            btnType3.TabIndex = 3;
            btnType3.Text = "Ăn vặt";
            btnType3.TextColor = Color.Black;
            btnType3.UseVisualStyleBackColor = false;
            btnType3.Click += btnType3_Click;
            // 
            // btnType4
            // 
            btnType4.BackColor = Color.White;
            btnType4.BackgroundColor = Color.White;
            btnType4.BorderColor = Color.White;
            btnType4.BorderRadius = 20;
            btnType4.BorderSize = 2;
            btnType4.FlatAppearance.BorderSize = 0;
            btnType4.FlatStyle = FlatStyle.Flat;
            btnType4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnType4.ForeColor = Color.Black;
            btnType4.Location = new Point(406, 14);
            btnType4.Name = "btnType4";
            btnType4.Size = new Size(83, 45);
            btnType4.TabIndex = 4;
            btnType4.Text = "Nước";
            btnType4.TextColor = Color.Black;
            btnType4.UseVisualStyleBackColor = false;
            btnType4.Click += btnType4_Click;
            // 
            // btnType2
            // 
            btnType2.BackColor = Color.White;
            btnType2.BackgroundColor = Color.White;
            btnType2.BorderColor = Color.White;
            btnType2.BorderRadius = 20;
            btnType2.BorderSize = 2;
            btnType2.FlatAppearance.BorderSize = 0;
            btnType2.FlatStyle = FlatStyle.Flat;
            btnType2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnType2.ForeColor = Color.Black;
            btnType2.Location = new Point(191, 14);
            btnType2.Name = "btnType2";
            btnType2.Size = new Size(90, 44);
            btnType2.TabIndex = 2;
            btnType2.Text = "Mì cay";
            btnType2.TextColor = Color.Black;
            btnType2.UseVisualStyleBackColor = false;
            btnType2.Click += btnType2_Click;
            // 
            // btnType1
            // 
            btnType1.BackColor = Color.White;
            btnType1.BackgroundColor = Color.White;
            btnType1.BorderColor = Color.White;
            btnType1.BorderRadius = 20;
            btnType1.BorderSize = 2;
            btnType1.FlatAppearance.BorderSize = 0;
            btnType1.FlatStyle = FlatStyle.Flat;
            btnType1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnType1.ForeColor = Color.Black;
            btnType1.Location = new Point(92, 14);
            btnType1.Name = "btnType1";
            btnType1.Size = new Size(84, 44);
            btnType1.TabIndex = 1;
            btnType1.Text = "Lẩu";
            btnType1.TextColor = Color.Black;
            btnType1.UseVisualStyleBackColor = false;
            btnType1.Click += btnType1_Click;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.FloralWhite;
            btnAll.BackgroundColor = Color.FloralWhite;
            btnAll.BorderColor = Color.DarkOrange;
            btnAll.BorderRadius = 20;
            btnAll.BorderSize = 2;
            btnAll.FlatAppearance.BorderSize = 0;
            btnAll.FlatStyle = FlatStyle.Flat;
            btnAll.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.ForeColor = Color.Black;
            btnAll.Location = new Point(12, 13);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(63, 46);
            btnAll.TabIndex = 0;
            btnAll.Text = "Tất cả";
            btnAll.TextColor = Color.Black;
            btnAll.UseVisualStyleBackColor = false;
            btnAll.Click += btnAll_Click;
            // 
            // pnlCusNOrder
            // 
            pnlCusNOrder.BackColor = SystemColors.Window;
            pnlCusNOrder.Controls.Add(btnSelectTable);
            pnlCusNOrder.Controls.Add(btnAddCus);
            pnlCusNOrder.Location = new Point(536, 1);
            pnlCusNOrder.Name = "pnlCusNOrder";
            pnlCusNOrder.Size = new Size(360, 71);
            pnlCusNOrder.TabIndex = 4;
            // 
            // btnSelectTable
            // 
            btnSelectTable.BackColor = Color.Gold;
            btnSelectTable.BackgroundColor = Color.Gold;
            btnSelectTable.BorderColor = Color.PaleVioletRed;
            btnSelectTable.BorderRadius = 32;
            btnSelectTable.BorderSize = 0;
            btnSelectTable.FlatAppearance.BorderSize = 0;
            btnSelectTable.FlatStyle = FlatStyle.Flat;
            btnSelectTable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectTable.ForeColor = Color.Black;
            btnSelectTable.Image = (Image)resources.GetObject("btnSelectTable.Image");
            btnSelectTable.ImageAlign = ContentAlignment.MiddleLeft;
            btnSelectTable.Location = new Point(21, 14);
            btnSelectTable.Name = "btnSelectTable";
            btnSelectTable.Padding = new Padding(12, 0, 5, 0);
            btnSelectTable.Size = new Size(119, 44);
            btnSelectTable.TabIndex = 1;
            btnSelectTable.Text = "Chọn bàn";
            btnSelectTable.TextAlign = ContentAlignment.MiddleRight;
            btnSelectTable.TextColor = Color.Black;
            btnSelectTable.UseVisualStyleBackColor = false;
            // 
            // btnAddCus
            // 
            btnAddCus.BackColor = Color.Gold;
            btnAddCus.BackgroundColor = Color.Gold;
            btnAddCus.BorderColor = Color.PaleVioletRed;
            btnAddCus.BorderRadius = 32;
            btnAddCus.BorderSize = 0;
            btnAddCus.FlatAppearance.BorderSize = 0;
            btnAddCus.FlatStyle = FlatStyle.Flat;
            btnAddCus.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCus.ForeColor = Color.Black;
            btnAddCus.Image = (Image)resources.GetObject("btnAddCus.Image");
            btnAddCus.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddCus.Location = new Point(158, 13);
            btnAddCus.Name = "btnAddCus";
            btnAddCus.Padding = new Padding(12, 0, 5, 0);
            btnAddCus.Size = new Size(170, 46);
            btnAddCus.TabIndex = 0;
            btnAddCus.Text = "Thêm khách hàng";
            btnAddCus.TextAlign = ContentAlignment.MiddleRight;
            btnAddCus.TextColor = Color.Black;
            btnAddCus.UseVisualStyleBackColor = false;
            // 
            // flpProInCart
            // 
            flpProInCart.AutoScroll = true;
            flpProInCart.BackColor = SystemColors.Window;
            flpProInCart.Location = new Point(549, 100);
            flpProInCart.Name = "flpProInCart";
            flpProInCart.Size = new Size(347, 466);
            flpProInCart.TabIndex = 5;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.MediumSeaGreen;
            btnCheckOut.BackgroundColor = Color.MediumSeaGreen;
            btnCheckOut.BorderColor = Color.PaleVioletRed;
            btnCheckOut.BorderRadius = 32;
            btnCheckOut.BorderSize = 0;
            btnCheckOut.FlatAppearance.BorderSize = 0;
            btnCheckOut.FlatStyle = FlatStyle.Flat;
            btnCheckOut.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckOut.ForeColor = Color.Black;
            btnCheckOut.Image = (Image)resources.GetObject("btnCheckOut.Image");
            btnCheckOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnCheckOut.Location = new Point(589, 635);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Padding = new Padding(88, 0, 66, 0);
            btnCheckOut.Size = new Size(269, 46);
            btnCheckOut.TabIndex = 6;
            btnCheckOut.Text = "Thanh toán";
            btnCheckOut.TextAlign = ContentAlignment.MiddleRight;
            btnCheckOut.TextColor = Color.Black;
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(788, 586);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 21);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "$ 1000.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(573, 586);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 7;
            label1.Text = "Tổng tiền ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(549, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 17);
            label2.TabIndex = 9;
            label2.Text = "Các món đã gọi";
            // 
            // FBanView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(898, 695);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(label1);
            Controls.Add(btnCheckOut);
            Controls.Add(flpProInCart);
            Controls.Add(pnlCusNOrder);
            Controls.Add(pnlTypeBar);
            Controls.Add(flpProduct);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FBanView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FBanView";
            Load += UCHomeNV_Load;
            pnlTypeBar.ResumeLayout(false);
            pnlCusNOrder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpProduct;
        private Panel pnlTypeBar;
        private NewButton btnType3;
        private NewButton btnType4;
        private NewButton btnType2;
        private NewButton btnType1;
        private NewButton btnAll;
        private Panel pnlCusNOrder;
        private NewButton btnSelectTable;
        private NewButton btnAddCus;
        private FlowLayoutPanel flpProInCart;
        private NewButton btnCheckOut;
        private Label lblTotal;
        private Label label1;
        private Label label2;
    }
}