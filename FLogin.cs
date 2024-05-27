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
    public partial class FLogin : Form
    {
        public string ID;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static FLogin instance;
        public FLogin()
        {
            InitializeComponent();
            instance = this;
        }

        public int checkRole(string id, string pass)
        {
            int r = 0;
            try
            {
                conn.Open();
                string sqlStr = string.Format("select dbo.func_checkLogin('{0}','{1}')", id, pass);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    r = (int)result;
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
            return r;
        }

        public string getID(string id, string pass)
        {
            string r = "test";
            try
            {
                conn.Open();
                string sqlStr = string.Format("select dbo.func_getID('{0}','{1}')", id, pass);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    r = (string)result;
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
            return r;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbTK.Text) && !string.IsNullOrEmpty(tbTK.Text))
            {
                ID = getID(tbTK.Text, tbMK.Text);
                if (checkRole(tbTK.Text, tbMK.Text) == 1)
                {
                    FNhanVien f = new FNhanVien();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                if (checkRole(tbTK.Text, tbMK.Text) == 2)
                {
                    FQuanLy f = new FQuanLy();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
        }

        private void rbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (rbShowPass.Checked)
            {
                tbMK.UseSystemPasswordChar = false;
            }
            if (!rbShowPass.Checked)
            {
                tbMK.UseSystemPasswordChar = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FSignUp f = new FSignUp();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
