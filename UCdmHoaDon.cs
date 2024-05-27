using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class UCdmHoaDon : UserControl
    {
        DBConnection db = new DBConnection();
        public static UCdmHoaDon instance;
        public UCdmHoaDon()
        {
            InitializeComponent();
            instance = this;
        }

        internal void UCdmHoaDon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmHoaDon("");
        }

        private void newButton1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmHoaDon("");
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmHoaDon(textBox1.Text);
        }
    }
}
