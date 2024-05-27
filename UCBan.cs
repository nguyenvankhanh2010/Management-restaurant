using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class UCBan : UserControl
    {
        public static UCBan instance;
        private string id;
        private string soluong;
        private string tinhtrang;
        private string idDH;

        public UCBan()
        {
            InitializeComponent();
            instance = this;
        }

        public string maBan
        {
            get { return id; }
            set { id = value; lblidBan.Text = value; }
        }

        public string SoLuong
        {
            get { return soluong; }
            set { soluong = value; lblSoGhe.Text = value; }
        }

        public string TinhTrang
        {
            get { return tinhtrang; }
            set
            {
                tinhtrang = value;
                if (value == "Đang phục vụ")
                {
                    btnCreate.Enabled = false;
                    btnCreate.Text = "Bận";
                    btnCreate.BackColor = Color.Tomato;
                }
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (btnCreate.Text == "Thêm khách")
            {
                FAddDonHang fAddDonHang = new FAddDonHang(maBan);
                fAddDonHang.Text = maBan;
                fAddDonHang.ShowDialog();
            }
        }

        private void UCBan_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(id) && !string.IsNullOrEmpty(tinhtrang) && tinhtrang == "Đang phục vụ") 
            { 
                FBanView fBanView = new FBanView(maBan);
                fBanView.Text = maBan;
                fBanView.ShowDialog();
            }
        }
    }
}
