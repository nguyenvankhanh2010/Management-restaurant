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
    public partial class UCdmNV : UserControl
    {

        DBConnection db = new DBConnection();
        public static UCdmNV instance;
        public UCdmNV()
        {
            InitializeComponent();
            instance = this;
        }

        internal void UCdmPC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmNhanVien();
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) { UCdmPC_Load(sender, e); }
            else dataGridView1.DataSource = db.TimNV(comboBox1.Text,textBox1.Text);
        }
    }
}
