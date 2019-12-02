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
    public partial class Carikart : Form
    {
        public Carikart()
        {
            InitializeComponent();
        }

        SqlConnection baglanti1 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");

            private void button1_Click(object sender, EventArgs e)
        {

            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komut = new SqlCommand("insert into caricari(Carikod,Cariunvan,Yetkiliadisoyadi,Vergidairesi,Vergino,Bankaibanno,adres,iletisim,mail) values (@c1,@c2,@c3,@c4,@c5,@c6,@c7,@c8,@c9)", baglanti1);
            komut.Parameters.AddWithValue("@c1", textBox1.Text);
            komut.Parameters.AddWithValue("@c2", textBox2.Text);
            komut.Parameters.AddWithValue("@c3", textBox3.Text);
            komut.Parameters.AddWithValue("@c4", textBox5.Text);
            komut.Parameters.AddWithValue("@c5", maskedTextBox3.Text);
            komut.Parameters.AddWithValue("@c6", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@c7", richTextBox1.Text);
            komut.Parameters.AddWithValue("@c8", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@c9", textBox10.Text);
            komut.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Firma Cari Bilgileri Eklendi");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox2.Text = "";
            richTextBox1.Text = "";
            maskedTextBox1.Text = "";
            textBox10.Text = "";
                                                     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.caricariTableAdapter.Fill(this.projeDataSet8.caricari);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox3.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            textBox10.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutsil = new SqlCommand("Delete from caricari where Carikod=@k1", baglanti1);
            komutsil.Parameters.AddWithValue("@k1", textBox1.Text);
            komutsil.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Firma Kaydınız Silindi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti1.Open();
            SqlCommand komutguncelle = new SqlCommand("UPDATE caricari SET Cariunvan=@a2,Yetkiliadisoyadi=@a3,Vergidairesi=@a4,Vergino=@a5,Bankaibanno=@a6,adres=@a7,iletisim=@a8,mail=@a9 where Carikod=@a1", baglanti1);
            komutguncelle.Parameters.AddWithValue("@a1", textBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a2", textBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a3", textBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a4", textBox5.Text);
            komutguncelle.Parameters.AddWithValue("@a5", maskedTextBox3.Text);
            komutguncelle.Parameters.AddWithValue("@a6", maskedTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a7", richTextBox1.Text);
            komutguncelle.Parameters.AddWithValue("@a8", maskedTextBox2.Text);
            komutguncelle.Parameters.AddWithValue("@a9", textBox10.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti1.Close();
            MessageBox.Show("Firma Kaydınız Güncellendi");
        }
    }
}
