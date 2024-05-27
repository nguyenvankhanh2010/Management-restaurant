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
    public partial class FAddNL : Form
    {
        DBConnection db = new DBConnection();
        string idNSX;
        public FAddNL()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(idNSX))
            {
                MessageBox.Show("Vui long chon nha san xuat!");
                return;
            }
            db.themNguyenLieu(tbMaNL.Text, tbTenNL.Text, cbbNSX.Text, (int)Convert.ToInt32(tbSoLuong.Text));
            if (db.themPC(tbMaNL.Text, tbMaDNH.Text, (double)Convert.ToDouble(tbDonGia.Text), (int)Convert.ToInt32(tbSoLuong.Text), tbMaPC.Text))
            {
                UCQuanLyNL.instance.UCQuanLyNL_Load(sender, e);
                this.Close();
            }
        }

        private void cbbNSX_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbNSX.SelectedIndex == -1) 
            {
                idNSX = "";
            }
            else
            {
                idNSX = "Co";
            }
        }
    }
}
