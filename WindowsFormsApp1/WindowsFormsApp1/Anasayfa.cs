using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carikart form2 = new Carikart();
            form2.Show();
            this.Hide();
        }
        

        private void buttonska_Click(object sender, EventArgs e)
        {
            Stokkarti formska = new Stokkarti();
            formska.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SiparisMenu formtree = new SiparisMenu();
            formtree.Show();
            this.Hide();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Kullanicigiris formcikis = new Kullanicigiris();
            formcikis.Show();
            this.Hide();
        }
    }
}
