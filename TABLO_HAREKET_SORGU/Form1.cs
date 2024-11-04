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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=SERHATDEMIR\SQLEXPRESS;Initial Catalog=proje6;Integrated Security=True;");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'proje6DataSet5.proje6' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.proje6TableAdapter1.Fill(this.proje6DataSet5.proje6);

            SqlDataAdapter da = new SqlDataAdapter("execute proje6 ",baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmekleme fr = new Frmekleme();
            fr.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Frmekleme fr = new Frmekleme();
            fr.Show();
        }
    }
}
