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
    public partial class Product : UserControl
    {
        private string _dh;
        private string _id;
        private string _name;
        private string _price;
        private Image _image;

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string DH
        {
            get { return _dh; }
            set { _dh = value; }
        }
        public string namePro
        {
            get { return _name; }
            set { _name = value; lblNameProduct.Text = value; }
        }

        public string Price
        {
            get { return _price; }
            set 
            { 
                _price = value; 
                if(value == "Hết")
                {
                    lblPrice.Text = value;
                }
                else
                {
                    lblPrice.Text = value + " VND"; 
                }
            }
        }

        public Image imagePro
        {
            get { return _image; }
            set { _image = value; pbProduct.BackgroundImage = value; }
        }

        public Product()
        {
            InitializeComponent();
        }

        private void pnlAdd_Click(object sender, EventArgs e)
        {
            FAddMon fAddMon = new FAddMon(ID, namePro, (double)Convert.ToDouble(Price), DH);
            fAddMon.ShowDialog();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            if(Price == "Hết") pnlAdd.Visible=false;
        }
    }
}
