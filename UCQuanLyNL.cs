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
    public partial class UCQuanLyNL : UserControl
    {
        DBConnection db = new DBConnection();
        public static UCQuanLyNL instance;
        public UCQuanLyNL()
        {
            InitializeComponent();
            instance = this;
        }

        internal void UCQuanLyNL_Load(object sender, EventArgs e)
        {
            dgvNL.DataSource = db.timNguyenLieu("");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FAddNL f = new FAddNL();
            f.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNL.DataSource = db.timNguyenLieu(tbTenNL.Text);
        }
    }
}
