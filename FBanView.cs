using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class FBanView : Form
    {
        DBConnection db = new DBConnection();
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static FBanView instance;
        List<Product> menuPro = new List<Product>();
        List<UCProInCartcs> listCart = new List<UCProInCartcs>();
        string typeProduct = "";
        byte[] imageData;
        public string maBan;
        string idDH;
        string idKH;
        double total;


        public FBanView(string maBan)
        {
            InitializeComponent();
            instance = this;
            btnSelectTable.Text = this.Text;
            this.maBan = maBan;
            getDonHang(maBan);
            btnAddCus.Text = idKH;
        }

        private void getDonHang(string id)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select MaDH, MaKH From DonHang inner join Ban on DonHang.MaBan = Ban.MaBan Where Ban.MaBan = '{0}' and DonHang.TriGiaDH = 0 and Ban.TinhTrang = N'Đang phục vụ'", id);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);  
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    idDH = sqlDataReader.GetString(0);
                    idKH = sqlDataReader.GetString(1);
                    sqlDataReader.Close();
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
        }

        public void getMonAn()
        {
            total = 0;
            listCart.Clear();
            flpProInCart.Controls.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select ChiTietDonHang.SoLuong, ChiTietDonHang.TongTien, SanPham.HinhAnh From ChiTietDonHang inner join SanPham on ChiTietDonHang.MaSP = SanPham.MaSP Where ChiTietDonHang.MaDH = '{0}'", idDH);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        UCProInCartcs p = new UCProInCartcs();
                        p.SoLuong = rdr.GetInt32(0);
                        p.Gia = rdr.GetDouble(1);
                        total += rdr.GetDouble(1);
                        imageData = (byte[])rdr["HinhAnh"];
                        p.Anh = convertByteToImage(imageData);
                        listCart.Add(p);
                    }
                    rdr.Close();
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            foreach (UCProInCartcs p in listCart)
            {
                flpProInCart.Controls.Add(p);
            }
           lblTotal.Text = total.ToString() + " VND";
        }

        private void UCHomeNV_Load(object sender, EventArgs e)
        {
            getProduct();
            getMonAn();
            btnSelectTable.Text = maBan;
        }

        private void getProduct()
        {
            menuPro.Clear();
            flpProduct.Controls.Clear();
            string sqlStr;

            if (typeProduct == "")
            {
                sqlStr = string.Format("Select * from SanPham");
            }
            else
            {
                sqlStr = string.Format("Select * from SanPham Where MaNhomSP = '{0}'", typeProduct);
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Product p = new Product();
                        p.ID = rdr.GetString(0);
                        p.DH = idDH;
                        p.namePro = rdr.GetString(2);
                        imageData = (byte[])(rdr["HinhAnh"]);
                        p.imagePro = convertByteToImage(imageData);
                        if (rdr.GetString(4).Trim() == "Hết")
                        {
                            p.Price = rdr.GetString(4).Trim();
                        }
                        else
                        {
                            p.Price = rdr.GetDouble(3).ToString();
                        }
                        menuPro.Add(p);
                    }
                    rdr.Close();
                }
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            foreach (Product p in menuPro)
            {
                flpProduct.Controls.Add(p);
            }
        }

        private Image convertByteToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream ms = new MemoryStream(byteArray);
                Image returnIMG = Image.FromStream(ms);
                return returnIMG;
            }
            else
            {
                return null;
            }
        }

        private void setColorBTN()
        {
            btnAll.BackColor = Color.White;
            btnType1.BackColor = Color.White;
            btnType2.BackColor = Color.White;
            btnType3.BackColor = Color.White;
            btnType4.BackColor = Color.White;
            btnAll.BorderColor = Color.White;
            btnType1.BorderColor = Color.White;
            btnType2.BorderColor = Color.White;
            btnType3.BorderColor = Color.White;
            btnType4.BorderColor = Color.White;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnAll.BorderColor = Color.DarkOrange;
            btnAll.BackColor = Color.FloralWhite;
            typeProduct = "";
            getProduct();
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType1.BorderColor = Color.DarkOrange;
            btnType1.BackColor = Color.FloralWhite;
            typeProduct = "LAU";
            getProduct();
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType2.BorderColor = Color.DarkOrange;
            btnType2.BackColor = Color.FloralWhite;
            typeProduct = "MI";
            getProduct();
        }

        private void btnType3_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType3.BorderColor = Color.DarkOrange;
            btnType3.BackColor = Color.FloralWhite;
            typeProduct = "ANVAT";
            getProduct();
        }

        private void btnType4_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType4.BorderColor = Color.DarkOrange;
            btnType4.BackColor = Color.FloralWhite;
            typeProduct = "NUOC";
            getProduct();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            db.xuatHoaDon(idDH, maBan);
            UCQuanLyBan.instance.UCQuanLyBan_Load(sender, e);
            this.Close();
        }
    }
}