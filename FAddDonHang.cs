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
    public partial class FAddDonHang : Form
    {
        DBConnection db = new DBConnection();
        public string maBan;
        string id;
        public FAddDonHang(string maBan)
        {
            InitializeComponent();
            this.maBan = maBan;
            tbMaBan.Text = maBan;
            id = FLogin.instance.ID;
            tbMaNV.Text = id;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(db.taoDonHang(tbMaDH.Text, tbMaKH.Text, tbMaNV.Text, tbMaBan.Text))
                this.Close();
            UCQuanLyBan.instance.UCQuanLyBan_Load(sender, e);
        }
    }
}
