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
    public partial class UCPhanCongNV : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public static UCPhanCongNV instance;
        string id = FLogin.instance.ID;
        public UCPhanCongNV()
        {
            InitializeComponent();
            instance = this;

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
