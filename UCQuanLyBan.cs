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
    public partial class UCQuanLyBan : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<UCBan> listBan = new List<UCBan>();
        public static UCQuanLyBan instance;
        public UCQuanLyBan()
        {
            InitializeComponent();
            instance = this;
        }

        private void getBan()
        {
            listBan.Clear();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From Ban");
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        UCBan b = new UCBan();
                        b.maBan = rdr.GetString(0);
                        b.SoLuong = rdr.GetInt32(2).ToString();
                        b.TinhTrang = rdr.GetString(3);
                        listBan.Add(b);
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

        internal void UCQuanLyBan_Load(object sender, EventArgs e)
        {
            flpBan.Controls.Clear();
            getBan();
            foreach(UCBan b in listBan)
            {
                flpBan.Controls.Add(b);
            }
        }
    }
}
