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
    public partial class UCQLyNV : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public static UCQLyNV instance;
        string cv;
        string cn;
        string sex;
        string fileImage;
        byte[] data;
        int soCa;
        public UCQLyNV()
        {
            InitializeComponent();
            instance = this;
        }


        private void cbbCongViec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCongViec.Text == "Đầu bếp")
            {
                cv = "cv01";
            }
            if (cbbCongViec.Text == "Phục vụ")
            {
                cv = "cv02";
            }
            if (cbbCongViec.Text == "Thu ngân")
            {
                cv = "cv03";
            }
            if (cbbCongViec.Text == "Quản lý")
            {
                cv = "cv04";
            }
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbChiNhanh.Text == "Chi nhánh 1")
            {
                cn = "cn01";
            }
            if (cbbChiNhanh.Text == "Chi nhánh 2")
            {
                cn = "cn02";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                sex = "Nữ";
            }
            if (rbMale.Checked)
            {
                sex = "Nam";
            }
            if(string.IsNullOrEmpty(fileImage))
            {
                MessageBox.Show("Vui lòng thêm ảnh!");
                return;
            }
            db.themNV(tbMaNV.Text, cv, cn, tbHoTen.Text, tbCCCD.Text, tbDiaChi.Text, sex, dtpDOB.Value, dtpDateStart.Value, convertImageToBytes(), tbSDT.Text);
            UCQuanLyNV_Load(sender, e);
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

        internal void UCQuanLyNV_Load(object sender, EventArgs e)
        {
            dgvDMNV.DataSource = db.dmNhanVien();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMaNV.Text))
            {
                tbMaNV.Focus();
                return;
            }
            db.XoaNV(tbMaNV.Text);
            UCQuanLyNV_Load(sender, e);
        }


        private void dgvDMNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDMNV.Rows[e.RowIndex];
            tbMaNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
            tbHoTen.Text = Convert.ToString(row.Cells["HoTen"].Value);
            tbDiaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            tbSDT.Text = Convert.ToString(row.Cells["SDT"].Value);
            tbThuong.Text = Convert.ToString(row.Cells["Thuong"].Value);
            cbbCongViec.Text = Convert.ToString(row.Cells["NoiDungCV"].Value);
            tbCCCD.Text = Convert.ToString(row.Cells["CCCD"].Value);
            dtpDOB.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            dtpDateStart.Value = Convert.ToDateTime(row.Cells["NgayBatDauLam"].Value);
            sex = Convert.ToString(row.Cells["GioiTinh"].Value);
            soCa = Convert.ToInt32(row.Cells["SoCa"].Value);
            if (sex == "Nam")
            {
                rbMale.Checked = true;
            }
            if (sex == "Nữ")
            {
                rbFemale.Checked = true;
            }
            if (!string.IsNullOrEmpty(tbMaNV.Text))
            {
                pbImagePro.Image = getImage(tbMaNV.Text);
            }
        }


        private Image getImage(string id)
        {
            string sqlStr = string.Format("Select HinhAnh From NhanVien Where MaNV = '{0}'", id);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
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

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (rbFemale.Checked)
            {
                sex = "Nữ";
            }
            if (rbMale.Checked)
            {
                sex = "Nam";
            }
            db.SuaNV(tbMaNV.Text, cv, tbHoTen.Text, tbDiaChi.Text, sex, dtpDOB.Value, dtpDateStart.Value, imageToByteArray(pbImagePro.Image), tbSDT.Text, soCa, (int)Convert.ToInt32(tbThuong.Text));
            UCQuanLyNV_Load(sender, e);
        }
    }
}
