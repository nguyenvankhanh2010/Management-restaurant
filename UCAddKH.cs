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
    public partial class UCAddKH : UserControl
    {

        DBConnection db = new DBConnection();
        public UCAddKH()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.themKH(tbMaKH.Text, tbTenKH.Text, tbSDT.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           tbSearchName.Text = db.timKH(tbSearchKH.Text.Trim());
        }
    }
}
