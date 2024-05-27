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
    public partial class FQuanLy : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public static FQuanLy instance;
        string id = FLogin.instance.ID;
        byte[] imageData;
        public FQuanLy()
        {
            InitializeComponent();
            instance = this;
        }

        private void setBtn()
        {
            btnMenu.BackColor = Color.Gold;
            btnCaNhan.BackColor = Color.Gold;
            btnHD.BackColor = Color.Gold;
            btnNL.BackColor = Color.Gold;
            btnNV.BackColor = Color.Gold;
            btnPC.BackColor = Color.Gold;
            btnTC.BackColor = Color.Gold;
            btnPhanCa.BackColor = Color.Gold;
            btnBan.BackColor = Color.Gold;
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            setBtn();
            tabControl1.SelectedTab = tabControl1.TabPages["tbThemSP"];
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            setBtn();
            btnMenu.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpMenu"];
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            setBtn();
            btnHD.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpHD"];
            UCdmHoaDon.instance.UCdmHoaDon_Load(sender, e);
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            setBtn();
            btnPC.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbPC"];
            UCdmPC.instance.UCdmPC_Load(sender, e);
        }

        private void btnTC_Click(object sender, EventArgs e)
        {
            setBtn();
            btnTC.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpTC"];
        }

        private void btnBan_Click(object sender, EventArgs e)
        {
            setBtn();
            btnBan.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpBan"];
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            setBtn();
            btnNV.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpdmNV"];
            UCdmNV.instance.UCdmPC_Load(sender, e);
        }

        private void btnNL_Click(object sender, EventArgs e)
        {
            setBtn();
            btnNL.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpNL"];
            UCQuanLyNL.instance.UCQuanLyNL_Load(sender, e);
        }

        private void btnPhanCa_Click(object sender, EventArgs e)
        {
            setBtn();
            btnPhanCa.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbpPhanCa"];
            UCPhanCongQL.instance.UCPhanCongQL_Load(sender, e);
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            setBtn();
            btnCaNhan.BackColor = Color.Goldenrod;
            tabControl1.SelectedTab = tabControl1.TabPages["tbCaNhan"];
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            setBtn();
            tabControl1.SelectedTab = tabControl1.TabPages["tbpThemNV"];
            UCQLyNV.instance.UCQuanLyNV_Load(sender, e);
        }

        internal void FQuanLy_Load(object sender, EventArgs e)
        {
            UCMenu.instance.UCMenu_Load(sender, e);
            UCInfor_Load(sender, e);
            dataGridView1.DataSource = db.bangLuongNV();
            label16.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString();
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

        private void newButton1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpCLV"];
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tbpLuong"];
            FQuanLy_Load(sender, e);
        }
    }
}
