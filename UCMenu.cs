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
    public partial class UCMenu : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static UCMenu instance;
        List<Product> menuPro = new List<Product>();
        byte[] imageData;

        public UCMenu()
        {
            InitializeComponent();
            instance = this;
        }

        private void getProduct()
        {
            menuPro.Clear();
            string sqlStr = string.Format("Select * from SanPham");
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
                        p.pnlAdd.Visible = false;
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

        internal void UCMenu_Load(object sender, EventArgs e)
        {
            flpProduct.Controls.Clear();
            getProduct();
            foreach (Product p in menuPro)
            {
                flpProduct.Controls.Add(p);
            }
        }
    }
}
