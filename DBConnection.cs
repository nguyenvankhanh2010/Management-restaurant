using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;

namespace DoAnDBMS
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);


        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public string name;
        //2.1
        public DataTable dmNhanVien()
        {
            DataTable dt = new DataTable();
            try 
            { 
                conn.Open();
                string sqlStr = "Select * From v_dmNhanVien";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            } 
            catch 
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.2
        public DataTable dmPhanCong()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmPhanCong";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.3
        public DataTable dmCaLamViec()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmCaLamViec";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.4
        public DataTable dmSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select TenNhomSP as 'Nhóm món', MaSP as 'Mã món', TenSP as 'Tên món'" +
                ", DonGia as 'Giá', TinhTrang as 'Tình trạng' From v_dmSanPham";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.5
        public DataTable dmNSX()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmNSX";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.6
        public DataTable dmPhieuChi(string s)
        {
            DataTable dt = new DataTable();
            string sqlStr;
            try
            {
                conn.Open();
                if(string.IsNullOrEmpty(s))
                {
                    sqlStr = "Select * From v_dmPhieuChi";
                }
                else
                {
                    sqlStr = string.Format("Select * From v_dmPhieuChi Where MaPC = '{0}'",s);
                }
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.7
        public DataTable dmHoaDon(string s)
        {
            string sqlStr;
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(s))
                {
                    sqlStr = "Select * From v_dmHoaDon";
                }
                else
                {
                    sqlStr = string.Format("Select * From v_dmHoaDon Where MaDH = '{0}'",s);
                }
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }


        //3.1
        public string timKH(string sdt)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_TimKH(@SDT)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                object result = cmd.ExecuteScalar();

                if(result != DBNull.Value && result != null)
                {
                   name = (string)result;
                }
                else
                {
                    MessageBox.Show("Chua ton tai khach hang co so dien thoai nay!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close ();
            }
            return name;
        }

        //3.2
        public void themKH(string id, string name, string sdt)
        {
            if(string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Vui long nhap ma khach hang!");
                return;
            }

            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_ThemKH");
                SqlCommand cmd = new SqlCommand(sqlStr,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = id;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = sdt;
                if(cmd.ExecuteNonQuery() > 0) 
                {
                    MessageBox.Show("Them khach hang thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them khach hang that bai!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
        }

        //4.1
        public DataTable TimNV(string searchType, string id)
        {
            DataTable dt = new DataTable();
            string sqlStr;
            try
            {
                conn.Open();
                if (searchType == "Số điện thoại")
                {
                    sqlStr = string.Format("Select * From dbo.func_TimBangSDT(@SDT)");
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@SDT", id.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                if (searchType == "Tên nhân viên")
                {
                    sqlStr = string.Format("Select * From dbo.func_TimBangTenNV(@TenNV)");
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@TenNV", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                if (searchType == "Tên công việc")
                {
                    sqlStr = string.Format("Select * From dbo.func_TimBangTenCV(@TenCV)");
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@TenCV", id);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
                if (searchType == "Mã nhân viên")
                {
                    sqlStr = string.Format("Select * From dbo.func_TimBangMaNV(@MaNV)");
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.Parameters.AddWithValue("@MaNV", id.Trim());
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
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
            return dt;
        }

        //4.2
        public void themNV(string maNV, string maCV, string maCN, string name, string cccd, string diaChi,
        string gioiTinh, DateTime dob, DateTime ngayLamViec, byte[] anh, string sdt)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_ThemNV");
                SqlCommand cmd = new SqlCommand( sqlStr,conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = maNV;
                cmd.Parameters.Add("@MaCV", SqlDbType.NChar).Value = maCV;
                cmd.Parameters.Add("@MaCN", SqlDbType.NChar).Value = maCN;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@CCCD", SqlDbType.NChar).Value = cccd;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.Add("@Thuong", SqlDbType.Int).Value = 0;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = gioiTinh;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = sdt;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dob;
                cmd.Parameters.Add("@NgayBatDauLam", SqlDbType.Date).Value = ngayLamViec;
                cmd.Parameters.Add("@HinhAnh", SqlDbType.Binary).Value = anh;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them nhan vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them nhan vien that bai!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
        }

        //4.3
        public void XoaNV(string id)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                    "Remove employee", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes) 
                { 
                    conn.Open();
                    string sqlStr = string.Format("proc_XoaNV");
                    SqlCommand cmd = new SqlCommand(sqlStr, conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = id;
                    if (cmd.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Xoa nhan vien thanh cong!");
                    }
                    else
                    {
                    MessageBox.Show("Xoa nhan vien that bai!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
        }

        //4.4
        public void SuaNV(string maNV,string maCV, string name, string diaChi, string gioiTinh, 
            DateTime dob, DateTime ngayLamViec, byte[] anh, string sdt, int soCa, int thuong)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_SuaNV");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@manv", SqlDbType.NChar).Value = maNV;
                cmd.Parameters.Add("@macv", SqlDbType.NChar).Value = maCV;
                cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = diaChi;
                cmd.Parameters.Add("@thuong", SqlDbType.Int).Value = thuong;
                cmd.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = gioiTinh;
                cmd.Parameters.Add("@sdt", SqlDbType.NChar).Value = sdt;
                cmd.Parameters.Add("@ngaysinh", SqlDbType.Date).Value = dob;
                cmd.Parameters.Add("@ngaytuyendung", SqlDbType.Date).Value = ngayLamViec;
                cmd.Parameters.Add("@hinhanh", SqlDbType.Binary).Value = anh;
                cmd.Parameters.Add("@soca", SqlDbType.Int).Value = soCa;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Sua thong tin nhan vien thanh cong!");
                }
                else
                {
                    MessageBox.Show("Sua thong tin nhan vien that bai!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
        }

        //4.5
        public int soCa(string maNV)
        {
            int s = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_SoCaTrongThang(@MaNV)");
                SqlCommand cmd= new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@MaNV",maNV);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    s = (int)r;
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
            return s;
        }


        //4.6
        public double luong1NV(string maNV)
        {
            double s = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_luongTrongThang(@MaNV)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    s = (double)r;
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
            return s;
        }

        //4.7
        public void capNhatSoCa(string maNV)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_CapNhatSoCa");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = maNV.Trim();
                cmd.ExecuteNonQuery();
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

        //4.8
        public DataTable bangLuongNV()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From dbo.func_luongTatCaNV()");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //5.1 
        public bool taoDonHang(string maDH, string maKH, string maNV, string maBan)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_TaoDH");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaHD", SqlDbType.NChar).Value = maDH;
                cmd.Parameters.Add("@MaKH", SqlDbType.NChar).Value = maKH;
                cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = maNV;
                cmd.Parameters.Add("@MaBan", SqlDbType.NChar).Value = maBan;
                cmd.Parameters.Add("@NgayDatHang", SqlDbType.DateTime).Value = DateTime.Now;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Tao don hang thanh cong!");
                    check = true;
                }
                else
                {
                    MessageBox.Show("Tao don hang that bai!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
            return check;
        }


        //5.2
        public bool ThemMonAn(string maDH, string maSP, int soLuong, double donGia)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_ThemMon");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDH", SqlDbType.NChar).Value = maDH;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = maSP;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = donGia;
                cmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = soLuong * donGia;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them mon thanh cong!");
                    check = true;
                }
                else
                {
                    MessageBox.Show("Them mon that bai!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
            return check;
        }

        //5.3
        public void xuatHoaDon(string maDH, string maBan)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_XuatHD");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaDH", SqlDbType.NChar).Value = maDH;
                cmd.Parameters.Add("@MaBan", SqlDbType.NChar).Value = maBan;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thanh toan thanh cong!");
                }
                else
                {
                    MessageBox.Show("Thanh toan that bai!");
                }
            }
            catch
            {
                MessageBox.Show("Loi!");
            }
            finally
            {
                conn.Close();
            }
        }

        //6.1
        public DataTable timNguyenLieu(string str)
        {
            DataTable dt = new DataTable();
            string sqlStr;
            try
            {
                conn.Open();
                if(string.IsNullOrEmpty(str))
                {
                    sqlStr = string.Format("Select * From NguyenLieu");
                } 
                else
                {
                    sqlStr = string.Format("Select * From func_TimNL('{0}')", str);
                }
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //6.2
        public void themNguyenLieu(string MaNL, string TenNL, string MaNSX, int SoLuong)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_ThemNL";
                SqlCommand cmd = new SqlCommand( sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNL", SqlDbType.NChar).Value = MaNL;
                cmd.Parameters.Add("@TenNL", SqlDbType.NVarChar).Value = TenNL;
                cmd.Parameters.Add("@MaNSX", SqlDbType.NChar).Value = MaNSX;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
                cmd.ExecuteNonQuery();
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

        //7.1
        public void themSanPham(string MaSP, string MaNhomSP, string TenSP, string TenNhomSP, float DonGia, 
            string TinhTrang, byte[] HinhAnh)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_themSanPhamMoi";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;
                cmd.Parameters.Add("@MaNhomSP", SqlDbType.NChar).Value = MaNhomSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = TenSP;
                cmd.Parameters.Add("@TenNhomSP", SqlDbType.NVarChar).Value = TenNhomSP;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = DonGia;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = TinhTrang;
                cmd.Parameters.Add("@HinhAnh", SqlDbType.Binary).Value = HinhAnh;
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Luu thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
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

        //7.2
        public void suaSanPham(string MaSP, string TenSP, float DonGia, string TinhTrang, byte[] HinhAnh)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_SuaSanPham";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = TenSP;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = DonGia;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = TinhTrang;
                cmd.Parameters.Add("@HinhAnh", SqlDbType.Binary).Value = HinhAnh;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Luu thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
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

        //7.3 
        public void xoaSanPham(string MaSP)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_XoaSanPham";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP.Trim();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
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

        //7.4
        public DataTable timSanPham(string str)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From func_TimSP('{0}')", str);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //8.1
        public double doanhThuNam(int year)
        {
            double t = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_doanhThuNam(@y)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@y", year);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    t = (double)r;
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
            return t;
        }

        public double doanhThuThang(int year, int month)
        {
            double t = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_doanhThuThang(@y, @m)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@y", year);
                cmd.Parameters.AddWithValue("@m", month);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    t = (double)r;
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
            return t;
        }

        public double doanhThuNgay(int year, int month, int day)
        {
            double t = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_doanhThuNgay(@y, @m, @d)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@y", year);
                cmd.Parameters.AddWithValue("@m", month);
                cmd.Parameters.AddWithValue("@d", day);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    t = (double)r;
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
            return t;
        }


        //8.2
        public double chiPhiNam(int year)
        {
            double t = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_chiPhiNam(@y)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@y", year);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    t = (double)r;
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
            return t;
        }

        public double chiPhiThang(int year, int month)
        {
            double t = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select dbo.func_chiPhiThang(@y, @m)");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@y", year);
                cmd.Parameters.AddWithValue("@m", month);
                object r = cmd.ExecuteScalar();
                if (r != DBNull.Value && r != null)
                {
                    t = (double)r;
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
            return t;
        }

        //9.1
        public bool themPC(string maNL, string maDNH, double giaNhap, int soLuong, string maPC)
        {
            bool check = false;
            try
            {
                conn.Open();
                string sqlStr = "proc_ThemPhieuChi";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNL", SqlDbType.NChar).Value = maNL;
                cmd.Parameters.Add("@MaDNH", SqlDbType.NChar).Value = maDNH;
                cmd.Parameters.Add("@NgayNhap", SqlDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("@GiaNhap", SqlDbType.Float).Value = giaNhap;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = soLuong;
                cmd.Parameters.Add("@MaPC", SqlDbType.NChar).Value = maPC;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    check = true;
                    MessageBox.Show("Them nguyen lieu thanh cong!");
                }
                else
                {
                    MessageBox.Show("Them nguyen lieu that bai!");
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
            return check;
        }

        //10.1
        public void phanCong(string idCa, string idNV, DateTime date)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_PhanCa";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maca", SqlDbType.NChar).Value = idCa;
                cmd.Parameters.Add("manv", SqlDbType.NChar).Value = idNV;
                cmd.Parameters.Add("@ngaylamviec", SqlDbType.Date).Value = date;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Phan ca thanh cong!");
                }
                else
                {
                    MessageBox.Show("Phan ca that bai!");
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

        //10.2
        public void xoaPhanCong(string idCa, string idNV, DateTime date)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_XoaPhanCa";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maca", SqlDbType.NChar).Value = idCa;
                cmd.Parameters.Add("manv", SqlDbType.NChar).Value = idNV;
                cmd.Parameters.Add("@ngay", SqlDbType.Date).Value = date;
                if (cmd.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
