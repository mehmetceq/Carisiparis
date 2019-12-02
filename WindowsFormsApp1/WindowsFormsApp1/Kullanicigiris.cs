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
    public partial class Kullanicigiris : Form
    {
        public Kullanicigiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DELL-BILGISAYAR\MERHABA;Initial Catalog=proje;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select*from Parola where ad=@adi and sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("adi", textBox1.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", textBox2.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count>0)
                {
                    Anasayfa fr = new Anasayfa();
                    fr.Show();
                    this.Hide();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giris");
                baglanti.Close();

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
    }
}
