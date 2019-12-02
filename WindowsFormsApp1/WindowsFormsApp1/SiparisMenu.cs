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
using System.Net.Mail;
using System.Net;



namespace WindowsFormsApp1
{
    public partial class SiparisMenu : Form
    {
        public SiparisMenu()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa form1 = new Anasayfa();
            form1.Show();
            this.Hide();
        }

        private void SiparisMenu_Load(object sender, EventArgs e)
        {

            SqlConnection baglanti2 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            baglanti2.Open();
            komut.Connection = baglanti2;
            komut.CommandText = "Select * from caricari";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())

            //if (dr.Read())
            {
                comboBox1.Items.Add(dr["Carikod"].ToString());

            }

            baglanti2.Dispose();
            baglanti2.Close();


            SqlConnection baglanti3 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut1 = new SqlCommand();
            baglanti3.Open();
            komut1.Connection = baglanti3;
            komut1.CommandText = "Select * from stokkarti";
            komut1.ExecuteNonQuery();
            SqlDataReader dr2 = komut1.ExecuteReader();
            while (dr2.Read())

            //if (dr.Read())
            {
                comboBox2.Items.Add(dr2["stokkodu"].ToString());

            }

            baglanti3.Dispose();
            baglanti3.Close();

                     
        

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti5 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut5 = new SqlCommand();
            baglanti5.Open();
            komut5.Connection = baglanti5;
            komut5.CommandText = "Select * from caricari where carikod = '" + comboBox1.Text.ToString() + "'";
            SqlDataReader dr5 = komut5.ExecuteReader();
            if (dr5.Read())

        
            {
                textBox7.Text = dr5["Cariunvan"].ToString();
                textBox8.Text = dr5["mail"].ToString();

            }

            baglanti5.Dispose();
            baglanti5.Close();

                                 
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti7 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut7 = new SqlCommand();
            baglanti7.Open();
            komut7.Connection = baglanti7;
            //komut7.CommandText = "Select * from stokkarti where stokkodu = '" + comboBox2.Text.ToString() + "'";
            komut7.CommandText = "Select * from stokkarti where stokkodu = '" + comboBox2.SelectedItem + "'";

            SqlDataReader dr7 = komut7.ExecuteReader();
            if (dr7.Read())


            {
                textBox2.Text = dr7["stokadi"].ToString();
                textBox9.Text = dr7["ölcübirimi"].ToString();
                textBox1.Text = dr7["birimucret"].ToString();
                textBox13.Text = dr7["kdvorani"].ToString();
                textBox4.Text = dr7["stokadet"].ToString();
            }

            baglanti7.Dispose();
            baglanti7.Close();
        }

              

        private void button4_Click(object sender, EventArgs e)
        {

           
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("umitt9259@gmail.com", "deneme35");

            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("umitt9259@gmail.com", "Deneme");

            string mailadres = textBox8.Text;


            mail.To.Add(textBox8.Text);

            mail.Subject = "Konu : Sipariş Bilgisi"; mail.IsBodyHtml = true; mail.Body = "Sayın Müsteri Toplam Siparis ücretiniz"+" " + label19.Text+" " +"TL";

            sc.Send(mail);

            MessageBox.Show("Sipariş Maili Gönderildi");
        }

            private void button3_Click(object sender, EventArgs e)
        {


            double birimfiyatt = Convert.ToDouble(textBox1.Text);
            double siparismiktar = Convert.ToDouble(textBox10.Text);
            double indirim = Convert.ToDouble(textBox6.Text);
            double kdv = Convert.ToDouble(textBox13.Text);
            double tutar;
            tutar = (birimfiyatt * siparismiktar * kdv / 100) * (100 - indirim) / 100;
            label22.Text = Convert.ToString(tutar);
                       
            SqlConnection baglanti10 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            baglanti10.Open();
            SqlCommand komut10 = new SqlCommand("insert into Satiskarti(Carifirma,Stokadı,Siparismiktari,Stokbirimi,Stokbirimfiyati,KdvYuzdesi,indirimYuzdesi,Odenecektutar,Carikod,Stokkodu,Stokmiktari,Mailadresi) values (@x1,@x2,@x3,@x4,@x5,@x6,@x7,@x8,@x9,@x10,@x11,@x12)", baglanti10);
            komut10.Parameters.AddWithValue("@x1", textBox7.Text);
            komut10.Parameters.AddWithValue("@x2", textBox2.Text);
            komut10.Parameters.AddWithValue("@x3", textBox10.Text);
            komut10.Parameters.AddWithValue("@x4", textBox9.Text);
            komut10.Parameters.AddWithValue("@x5", textBox1.Text);
            komut10.Parameters.AddWithValue("@x6", textBox13.Text);
            komut10.Parameters.AddWithValue("@x7", textBox6.Text);
            komut10.Parameters.AddWithValue("@x8", label22.Text);
            komut10.Parameters.AddWithValue("@x9", comboBox1.Text);
            komut10.Parameters.AddWithValue("@x10", comboBox2.Text);
            komut10.Parameters.AddWithValue("@x11", textBox4.Text);
            komut10.Parameters.AddWithValue("@x12", textBox8.Text);
            komut10.ExecuteNonQuery();
            baglanti10.Close();
            MessageBox.Show("Sipariş Eklendi");

            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox10.Text);
            double sonuc = a - b;
            label13.Text = sonuc.ToString();
            if (sonuc<0)
            {
                MessageBox.Show("Lütfen Siparişi Güncelleyiniz");
            }
            /*else if (sonuc>0)
            {
                SqlConnection baglanti19 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
                baglanti19.Open();
                SqlCommand komut19 = new SqlCommand("update stokkarti set(stokadet) values (@z1)", baglanti19);
                komut19.Parameters.AddWithValue("@z1", label13.Text);
                komut19.ExecuteNonQuery();
                baglanti19.Close();
             
            } */
          
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti52 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut52 = new SqlCommand();
            baglanti52.Open();
            komut52.Connection = baglanti52;
            komut52.CommandText = "  SELECT Sum(Odenecektutar) as[birimtoplami] FROM Satiskarti     ";
            komut52.ExecuteNonQuery();
            SqlDataReader dr52 = komut52.ExecuteReader();
            while (dr52.Read())

            //if (dr.Read())
            {
                // comboBox2.Items.Add(dr2["stokkodu"].ToString());
                label19.Text = dr52["birimtoplami"].ToString();

                // textBox1.Text = dr["Cariunvan"].ToString();
            }

            baglanti52.Dispose();
            baglanti52.Close();
        }

   
        private void button7_Click(object sender, EventArgs e)
        {
            this.satiskartiTableAdapter.Fill(this.projeDataSet13.Satiskarti);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            comboBox2.Text = "";
            textBox2.Text = "";
            textBox9.Text = "";
            textBox1.Text = "";
            textBox13.Text = "";
            textBox4.Text = "";
            textBox10.Text = "";
            textBox6.Text = "";
            label22.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Text = "";
            textBox8.Text = "";


        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti10 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            SqlCommand komut10 = new SqlCommand();
            baglanti10.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Satiskarti where Stokkodu=@x1", baglanti10);
            komutsil.Parameters.AddWithValue("@x1", comboBox2.Text);
            komutsil.ExecuteNonQuery();
            baglanti10.Close();
            MessageBox.Show("Siparis Kaydınız Sepetten Çıkarıldı");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                textBox7.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                textBox10.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                textBox9.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                textBox1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
                textBox13.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
                textBox6.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
                label22.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
                comboBox1.Text= dataGridView1.Rows[secilen].Cells[8].Value.ToString();
                comboBox2.Text= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
                textBox4.Text= dataGridView1.Rows[secilen].Cells[10].Value.ToString();
                textBox8.Text=dataGridView1.Rows[secilen].Cells[11].Value.ToString();

            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            SqlConnection baglanti11 = new SqlConnection("Data Source=DELL-BILGISAYAR\\MERHABA;Initial Catalog=proje;Integrated Security=True");
            baglanti11.Open();
            SqlCommand komut10 = new SqlCommand("UPDATE Satiskarti SET Carikod=@x9,Siparismiktari=@x3,indirimYuzdesi=@x7 where Stokkodu=@x10", baglanti11);
            komut10.Parameters.AddWithValue("@x3", textBox10.Text);
            komut10.Parameters.AddWithValue("@x7", textBox6.Text);
            komut10.Parameters.AddWithValue("@x10", comboBox2.Text);
            komut10.Parameters.AddWithValue("@x9", comboBox1.Text);
            komut10.ExecuteNonQuery();
            baglanti11.Close();
            MessageBox.Show("Firma Kaydınız Güncellendi");
           
        }

        


       
      
    }
}
