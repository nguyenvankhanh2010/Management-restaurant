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
    public partial class UCPhanCongQL : UserControl
    {
        DBConnection db = new DBConnection();
        public static UCPhanCongQL instance;
        string maCa;
        public UCPhanCongQL()
        {
            InitializeComponent();
            instance = this;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.phanCong(maCa, tbMaNV.Text, dtpNgayLamViec.Value);
            db.capNhatSoCa(tbMaNV.Text);
            UCPhanCongQL_Load(sender, e);
            FQuanLy.instance.FQuanLy_Load(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.xoaPhanCong(maCa, tbMaNV.Text, dtpNgayLamViec.Value);
            db.capNhatSoCa(tbMaNV.Text);
            UCPhanCongQL_Load(sender, e);
        }


        private void cbbCaLamViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCaLamViec.SelectedIndex == 0)
            {
                maCa = "CA1";
            }
            if (cbbCaLamViec.SelectedIndex == 1)
            {
                maCa = "CA2";
            }
            if (cbbCaLamViec.SelectedIndex == 2)
            {
                maCa = "CA3";
            }
        }

        internal void UCPhanCongQL_Load(object sender, EventArgs e)
        {
            dgvPhanCong.DataSource = db.dmPhanCong();
        }

        private void dgvPhanCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvPhanCong.Rows[e.RowIndex];
            tbMaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
            maCa = Convert.ToString(row.Cells["MaCa"].Value).Trim();
            dtpNgayLamViec.Value = Convert.ToDateTime(row.Cells["NgayLamViec"].Value);
            getCa();
        }

        public void getCa()
        {
            if(maCa == "CA1")
            {
                cbbCaLamViec.Text = "Ca 1";
            }
            if (maCa == "CA2")
            {
                cbbCaLamViec.Text = "Ca 2";
            }
            if (maCa == "CA3")
            {
                cbbCaLamViec.Text = "Ca 3";
            }
        }
    }
}
