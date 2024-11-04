using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TABLO_HAREKET_SORGU
{
    public partial class Frmekleme : Form
    {
        public Frmekleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SERHATDEMIR\SQLEXPRESS;Initial Catalog=proje6;Integrated Security=True;");
        private void Frmekleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje6DataSet4.URUNLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uRUNLERTableAdapter1.Fill(this.proje6DataSet4.URUNLER);
            // TODO: Bu kod satırı 'proje6DataSet3.PERSONELLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.pERSONELLERTableAdapter.Fill(this.proje6DataSet3.PERSONELLER);
            // TODO: Bu kod satırı 'proje6DataSet2.MUSTERILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.mUSTERILERTableAdapter.Fill(this.proje6DataSet2.MUSTERILER);
            // TODO: Bu kod satırı 'proje6DataSet1.URUNLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.uRUNLERTableAdapter.Fill(this.proje6DataSet1.URUNLER);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into MUSTERILER(ADSOYAD) values(@P1) ", baglanti);
            komut.Parameters.AddWithValue("@P1", txtmusterıad.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("müşteri Başarıyla Eklendi ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into PERSONELLER(AD) values(@P1) ", baglanti);
            komut.Parameters.AddWithValue("@P1", txtpersonelad.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Başarıyla Eklendi ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into URUNLER(AD,STOK,ALISFIYAT,SATISFIYAT) values(@P1,@P2,@P3,@P4) ", baglanti);
            komut.Parameters.AddWithValue("@P1", txturunad.Text);
            komut.Parameters.AddWithValue("@P2", txtstok.Text);
            komut.Parameters.AddWithValue("@P3", txtalıs.Text);
            komut.Parameters.AddWithValue("@P4", txtsatıs.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Urun Başarıyla Eklendi ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into HAREKETLER(URUNAD,MUSTERI,PERSONEL,FIYAT) values(@P1,@P2,@P3,@P4) ", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBox1.Text);
            komut.Parameters.AddWithValue("@P2", comboBox2.Text);
            komut.Parameters.AddWithValue("@P3", comboBox3.Text);
            komut.Parameters.AddWithValue("@P4", comboBox4.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hareket Başarıyla Eklendi ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
