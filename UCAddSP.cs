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
    public partial class UCAddSP : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        string fileImage;
        byte[] data;
        public UCAddSP()
        {
            InitializeComponent();
        }

        private void ccbTenNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ccbTenNhomSP.Text == "Lẩu")
            {
                tbMaNhomSP.Text = "LAU";
            }
            if (ccbTenNhomSP.Text == "Mì cay")
            {
                tbMaNhomSP.Text = "MI";
            }
            if (ccbTenNhomSP.Text == "Nước uống")
            {
                tbMaNhomSP.Text = "NUOC";
            }
            if (ccbTenNhomSP.Text == "Ăn vặt")
            {
                tbMaNhomSP.Text = "ANVAT";
            }
        }

        private void pbImagePro_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = op.Filter = "Image files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png|All files (*.*)|*.*";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbImagePro.ImageLocation = op.FileName;
                fileImage = op.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fileImage))
            {
                MessageBox.Show("Vui lòng thêm ảnh!");
                return;
            }
            if (string.IsNullOrEmpty(tbDonGia.Text))
            {
                MessageBox.Show("Vui lòng don gia!");
                return;
            }
            if (string.IsNullOrEmpty(tbMaSP.Text))
            {
                MessageBox.Show("Vui lòng thêm ma san pham!");
                return;
            }
            if (string.IsNullOrEmpty(tbTenSP.Text))
            {
                MessageBox.Show("Vui lòng thêm ten san pham!");
                return;
            }
            if (cbbTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chon tinh trang san pham!");
                return;
            }
            if (ccbTenNhomSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chon nhom san pham!");
                return;
            }
            db.themSanPham(tbMaSP.Text, tbMaNhomSP.Text, tbTenSP.Text, ccbTenNhomSP.Text, (float)Convert.ToDouble(tbDonGia.Text), cbbTinhTrang.Text, convertImageToBytes());
            UCAddSP_Load(sender, e);
            FQuanLy.instance.FQuanLy_Load(sender, e);
        }

        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(fileImage, FileMode.Open, FileAccess.Read);
            byte[] picByte = new byte[fs.Length];
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picByte;

        }

        private byte[] imageToByteArray(Image img)
        {
            var ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
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
                MessageBox.Show("Ko co Anh");
                return null;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.xoaSanPham(tbMaSP.Text);
            UCAddSP_Load(sender, e);
            FQuanLy.instance.FQuanLy_Load(sender, e);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDonGia.Text))
            {
                MessageBox.Show("Vui lòng don gia!");
                return;
            }
            if (string.IsNullOrEmpty(tbMaSP.Text))
            {
                MessageBox.Show("Vui lòng thêm ma san pham!");
                return;
            }
            if (string.IsNullOrEmpty(tbTenSP.Text))
            {
                MessageBox.Show("Vui lòng thêm ten san pham!");
                return;
            }
            if (cbbTinhTrang.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chon tinh trang san pham!");
                return;
            }
            if (ccbTenNhomSP.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chon nhom san pham!");
                return;
            }
            db.suaSanPham(tbMaSP.Text, tbTenSP.Text, (float)Convert.ToDouble(tbDonGia.Text), cbbTinhTrang.Text, imageToByteArray(pbImagePro.Image));
            UCAddSP_Load(sender, e);
            FQuanLy.instance.FQuanLy_Load(sender, e);
        }

        private void UCAddSP_Load(object sender, EventArgs e)
        {
            dgvProList.DataSource = db.dmSanPham();
            if(!string.IsNullOrEmpty(tbMaSP.Text))
            {
                pbImagePro.Image = getImage(tbMaSP.Text);
            }
        }

        private void dgvProList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvProList.Rows[e.RowIndex];
            tbDonGia.Text = Convert.ToString(row.Cells["Giá"].Value);
            tbMaSP.Text = Convert.ToString(row.Cells["Mã món"].Value);
            tbTenSP.Text = Convert.ToString(row.Cells["Tên món"].Value);
            cbbTinhTrang.Text = Convert.ToString(row.Cells["Tình trạng"].Value);
            ccbTenNhomSP.Text = Convert.ToString(row.Cells["Nhóm món"].Value);
            UCAddSP_Load(sender, e);
        }

        private Image getImage(string id)
        {
            string sqlStr = string.Format("Select HinhAnh From SanPham Where MaSP = '{0}'", id);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr,conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows) 
                {
                    rdr.Read();
                    data = (byte[])(rdr["HinhAnh"]);
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
            return convertByteToImage(data);
        }
    }
}