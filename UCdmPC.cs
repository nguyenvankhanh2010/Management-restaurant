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
    public partial class UCdmPC : UserControl
    {
        DBConnection db = new DBConnection();
        public static UCdmPC instance;
        public UCdmPC()
        {
            InitializeComponent();
            instance = this;
        }

        internal void UCdmPC_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmPhieuChi("");
        }

        private void newButton2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmPhieuChi(textBox1.Text);
        }
    }
}
