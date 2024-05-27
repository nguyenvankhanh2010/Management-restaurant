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
    public partial class FAddMon : Form
    {
        DBConnection db = new DBConnection();
        public string idDH;
        public string id;
        public string name;
        public double price;
        public FAddMon(string id, string name, double price, string idDH)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.price = price;
            this.idDH = idDH;
        }

        private void FAddMon_Load(object sender, EventArgs e)
        {
            lblName.Text = name;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(db.ThemMonAn(idDH, id, Convert.ToInt32(nudSoLuong.Value), price)) 
                this.Close();
            FBanView.instance.getMonAn();
        }
    }
}
