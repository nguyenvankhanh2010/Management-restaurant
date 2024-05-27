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
    public partial class FNhanVien : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        string id = FLogin.instance.ID;
        byte[] imageData;
        public FNhanVien()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Goldenrod;
            btnInfor.BackColor = Color.Gold;
            btnViewCLV.BackColor = Color.Gold;
            btnBan.BackColor = Color.Gold;
            btnKH.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpMenu"];
        }

        private void btnViewCLV_Click(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Gold;
            btnInfor.BackColor = Color.Gold;
            btnViewCLV.BackColor = Color.Goldenrod;
            btnBan.BackColor = Color.Gold;
            btnKH.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpPhanCong"];
        }

        private void btnInfor_Click(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Gold;
            btnInfor.BackColor = Color.Goldenrod;
            btnViewCLV.BackColor = Color.Gold;
            btnBan.BackColor = Color.Gold;
            btnKH.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpCaNhan"];
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Gold;
            btnInfor.BackColor = Color.Gold;
            btnViewCLV.BackColor = Color.Gold;
            btnBan.BackColor = Color.Goldenrod;
            btnKH.BackColor = Color.Gold;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpBan"];
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.Gold;
            btnInfor.BackColor = Color.Gold;
            btnViewCLV.BackColor = Color.Gold;
            btnBan.BackColor = Color.Gold;
            btnKH.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpKH"];
        }

        private void setInfor(string maNV)
        {
            lblID.Text = maNV;
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT HoTen, NhanVien.DiaChi, SDT, GioiTinh, TenCN, NoiDungCV, HinhAnh  FROM NhanVien inner join ChiNhanh on NhanVien.MaCN = ChiNhanh.MaCN inner join CongViec on NhanVien.MaCV  = CongViec.MaCV Where MaNV  ='{0}'", maNV);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    lblHoTen.Text = rdr.GetString(0);
                    lblDiaChi.Text = rdr.GetString(1);
                    lblSDT.Text = rdr.GetString(2);
                    lblGioiTinh.Text = rdr.GetString(3);
                    lblChiNhanh.Text = rdr.GetString(4);
                    lblCongViec.Text = rdr.GetString(5);
                    imageData = (byte[])rdr["HinhAnh"];
                    pbAvatar.BackgroundImage = convertByteToImage(imageData);
                }
                rdr.Close();
            }
            catch { }
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

        internal void UCInfor_Load(object sender, EventArgs e)
        {
            setInfor(id.Trim());
            lblSoCa.Text = db.soCa(id).ToString();
            lblLuong.Text = db.luong1NV(id).ToString() + " VND";
            UCPhanCongNV_Load(sender, e);
        }

        private DataTable getPhanCong()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From v_dmPhanCong Where MaNV = '{0}'", id);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                sqlDataAdapter.Fill(dt);
            }
            catch { }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        internal void UCPhanCongNV_Load(object sender, EventArgs e)
        {
            dgvPhanCong.DataSource = getPhanCong();
        }
    }
}
