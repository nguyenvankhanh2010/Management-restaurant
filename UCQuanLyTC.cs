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
    public partial class UCQuanLyTC : UserControl
    {
        DBConnection db = new DBConnection();
        public static UCQuanLyTC instance;
        public UCQuanLyTC()
        {
            InitializeComponent();
            instance = this;
            lblDoanhThu.Text = "";
            lblChiPhi.Text = "";
        }

        private void btnViewDoanhThu_Click(object sender, EventArgs e)
        {
            if (cbbDoanhThu.SelectedIndex == 0)
            {
                lblDoanhThu.Text = db.doanhThuNam((int)Convert.ToInt32(tbYear.Text.Trim())).ToString() + " VND";
            }
            if (cbbDoanhThu.SelectedIndex == 1)
            {
                lblDoanhThu.Text = db.doanhThuThang((int)Convert.ToInt32(tbYear.Text), (int)Convert.ToInt32(nudMonth.Value)).ToString() + " VND";
            }
            if (cbbDoanhThu.SelectedIndex == 2)
            {
                lblDoanhThu.Text = db.doanhThuNgay((int)Convert.ToInt32(tbYear.Text), (int)Convert.ToInt32(nudMonth.Value), (int)Convert.ToInt32(nudDay.Value)).ToString() + " VND";
            }
        }

        private void btnViewChiPhi_Click(object sender, EventArgs e)
        {
            if (cbbChiPhi.SelectedIndex == 0)
            {
                lblChiPhi.Text = db.chiPhiNam((int)Convert.ToInt32(tbYear.Text.Trim())).ToString() + " VND";
            }
            if (cbbChiPhi.SelectedIndex == 1)
            {
                lblChiPhi.Text = db.chiPhiThang((int)Convert.ToInt32(tbYear.Text.Trim()), (int)Convert.ToInt32(nudMonth.Value)).ToString() + " VND";
            }
        }
    }
}
