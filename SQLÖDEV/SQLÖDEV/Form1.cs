using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLÖDEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        NpgsqlConnection baglantı = new NpgsqlConnection("server=localHost;port=5432;Database=tursirketi;user ID=postgres;password=omer5434");

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from bilet ";
            NpgsqlDataAdapter  data= new NpgsqlDataAdapter(sorgu, baglantı);
            DataSet set = new DataSet();
            data.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
        }

        private void Btnarama_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand istek1 = new NpgsqlCommand("Select * from bilet where ülke like '%" +Txtülke.Text + "%'", baglantı);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(istek1);
            DataSet set = new DataSet();
            data.Fill(set);
            dataGridView1.DataSource = set.Tables[0];
            baglantı.Close();
            MessageBox.Show("arama yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Btnekleme_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand istek2 = new NpgsqlCommand("insert into bilet(biletno,müşterino,ülke,şehir)values (@p1,@p2,@p3,@p4)", baglantı);
            istek2.Parameters.AddWithValue("@p1", int.Parse(Txtbiletno.Text));
            istek2.Parameters.AddWithValue("@p2", int.Parse(Txtmüsterino.Text));
            istek2.Parameters.AddWithValue("@p3", Txtülke.Text);
            istek2.Parameters.AddWithValue("@p4", Txtşehir.Text);
            istek2.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("kayıt başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btnsilme_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand istek3 = new NpgsqlCommand("Delete from bilet where biletno=@p1", baglantı);
            istek3.Parameters.AddWithValue("@p1", int.Parse(Txtbiletno.Text));
            istek3.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btngüncelleme_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            NpgsqlCommand istek4 = new NpgsqlCommand("update bilet set müşterino=@p2,ülke=@p3,şehir=@p4 where biletno=@p1", baglantı);
            istek4.Parameters.AddWithValue("@p1", int.Parse(Txtbiletno.Text));
            istek4.Parameters.AddWithValue("@p2", int.Parse(Txtmüsterino.Text));
            istek4.Parameters.AddWithValue("@p3", Txtülke.Text);
            istek4.Parameters.AddWithValue("@p4", Txtşehir.Text);
            istek4.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("güncelleme başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
