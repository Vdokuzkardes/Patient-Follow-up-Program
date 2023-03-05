using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace veritabanı_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
           
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=uyeler.mdb");
        
        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select *from bilgiler where k_adi='" + tbkadi.Text + "' and sifre='" + tbsifre.Text + "'", baglanti) ;
            OleDbDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                Form1 frm1 = new Form1();
                this.Hide();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı  Lütfen Kontrol Ediniz !!!");
            }
            baglanti.Close();
        }
        //FORMDAN/PROGRAMDAN TAMAMEN ÇIKIŞ YAPMAK İÇİN 
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
