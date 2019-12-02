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
    public partial class Stokkarti : Form
    {
        public Stokkarti()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        SqlConnection baglanti1 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");


           

        private void button9_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("insert into stokkarti(stokkodu,stokadi,stokadet,ölcübirimi,kdvorani,birimucret) values (@s1,@s2,@s3,@s4,@s5,@s6)", baglanti1);
            komut.Parameters.AddWithValue("@s1", textBox1.Text);
            komut.Parameters.AddWithValue("@s2", textBox2.Text);
            komut.Parameters.AddWithValue("@s3", textBox6.Text);
            komut.Parameters.AddWithValue("@s4", textBox3.Text);
            komut.Parameters.AddWithValue("@s5", textBox4.Text);
            komut.Parameters.AddWithValue("@s6", textBox5.Text);
            komut.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Stok Eklendi");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.stokkartiTableAdapter.Fill(this.projeDataSet15.stokkarti);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox6.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutguncelle = new SqlCommand("UPDATE stokkarti SET stokadi=@a2,stokadet=@a3,ölcübirimi=@a4,birimucret=@a5,kdvorani=@a6 where stokkodu=@a1", baglanti1);
            komutguncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a3", textBox6.Text);
            komutguncelle.Parameters.AddWithValue("@a4", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a5", textBox5.Text);
            komutguncelle.Parameters.AddWithValue("@a6", textBox4.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Stok Kaydınız Güncellendi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutsil = new SqlCommand("Delete from stokkarti where stokkodu=@k1", baglanti1);
            komutsil.Parameters.AddWithValue("@k1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Stok Kaydınız Silindi");
        }

        private void Stokkarti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projeDataSet15.stokkarti' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'projeDataSet14.stokkarti' table. You can move, or remove it, as needed.


        }
    }
}
