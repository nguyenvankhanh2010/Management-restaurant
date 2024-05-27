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
using System.Xml.Linq;

namespace DoAnDBMS
{
    public partial class FSignUp : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FSignUp()
        {
            InitializeComponent();
        }

        private void dangKy(string tk, string mk, string maNV)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("proc_TaoTK");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@TaiKhoan", SqlDbType.NChar).Value = tk;
                cmd.Parameters.Add("@MatKhau", SqlDbType.NChar).Value = mk;
                cmd.Parameters.Add("@MaNV", SqlDbType.NChar).Value = maNV;
                if(cmd.ExecuteNonQuery() > 0) 
                {
                    MessageBox.Show("Tao tai khoan thanh cong!");
                }
                else
                {
                    MessageBox.Show("Tao tai khoan that bai!");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbMK.Text == tbEnPass.Text )
            {
                dangKy(tbTK.Text,tbMK.Text,tbMaNV.Text);
                this.Close();
            }
            if (tbMK.Text != tbEnPass.Text)
            {
                MessageBox.Show("Mat khau khong khop!");
            }
        }
    }
}
