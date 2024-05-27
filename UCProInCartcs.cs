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
    public partial class UCProInCartcs : UserControl
    {

        private int _soLuong;
        private double _price;
        private Image _img;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; lblSoLuong.Text = value.ToString(); }
        }

        public double Gia
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value.ToString() + " VND"; }
        }

        public Image Anh
        {
            set { _img = value; pbProduct.BackgroundImage = value; }
        }
        public UCProInCartcs()
        {
            InitializeComponent();
        }
    }
}
