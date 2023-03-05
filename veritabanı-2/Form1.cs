using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb; //ACCESS BAĞLANTISI

namespace veritabanı_2
{
    public partial class Form1 : Form
    {
        //VERİ TABANINA BAĞLANMA
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=doktor.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();

        }
        //ACCESS DEKİ VERİLERİ DATAGRİDVİEWDE GÖSTERME
        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("Select * from hastalar", baglanti);
            adtr.Fill(ds, "hastalar");
            dataGridView1.DataSource = ds.Tables["hastalar"];
            adtr.Dispose();
            baglanti.Close();
        }

        //KAYITLARI LİSTELEME
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        bool durum = true;
        private void mukerrer()
        {
            durum = true;
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("select * from hastalar where hasta_tc", baglanti);

            OleDbDataReader read;
            read = komut2.ExecuteReader();
            while (read.Read())
            {
                if (tbno.Text == read["hasta_tc"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        //KAYIT EKLEME 
        private void button1_Click(object sender, EventArgs e)
        {
            {
                    mukerrer();
                if (durum == true)
                {
                    komut.Connection = baglanti;
                    komut.CommandText = "Insert Into hastalar(hasta_tc,hasta_ad,hasta_soyad,hasta_tel,hasta_mail,hasta_adres,eski_kilo,yeni_kilo,hasta_teshis,hasta_ilac) Values ('" + tbno.Text + "','" + tbadi.Text + "','" + tbsoyadi.Text + "','" + tbtel.Text + "','" + tbmail.Text + "','" + tbadres.Text + "','" + tbeski.Text + "','" + tbyeni.Text + "','" + tbteshis.Text + "','" + tbilac.Text + "')";
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    ds.Clear();
                    listele();
                    for (int i = 0; i < Controls.Count; i++)
                    {
                        if (Controls[i] is TextBox)
                        {
                            Controls[i].Text = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("BU TC NO İLE DAHA ÖNCE KAYIT YAPTINIZ !!!");
                }
            }
        }

        //KAYIT SİLME
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                baglanti.Open();
                komut.Connection = baglanti;
                komut.CommandText = "Delete *from hastalar where hasta_tc='" + tbsil.Text + "'";
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                ds.Clear();
                listele();
                for (int i = 0; i < Controls.Count; i++)
                {
                    if (Controls[i] is TextBox)
                    {
                        Controls[i].Text = "";
                    }
                }
            }
        }

        //Kayıtları DataGridden Textboxlara yazdırma bölümü
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            tbno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            tbadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbsoyadi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbtel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            tbmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            tbadres.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            tbeski.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            tbyeni.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            tbteshis.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            tbilac.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }
        //Kayıt Arama Bölümü
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=doktor.mdb");
            adtr = new OleDbDataAdapter("SElect *from hastalar where hasta_tc like '" + tbara.Text + "%'", baglanti);
            ds = new DataSet();
            baglanti.Open();
            adtr.Fill(ds, "hastalar");
            dataGridView1.DataSource = ds.Tables["hastalar"];
            baglanti.Close();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }
        //Kayıt Güncelleme Bölümü
        private void button3_Click(object sender, EventArgs e)
        {
            komut = new OleDbCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "update hastalar set hasta_ad='" + tbadi.Text + "', hasta_soyad='" + tbsoyadi.Text + "', hasta_tel='" + tbtel.Text + "', hasta_mail='" + tbmail.Text + "', hasta_adres='" + tbadres.Text + "', eski_kilo='" + tbeski.Text + "', yeni_kilo='" + tbyeni.Text + "', hasta_teshis='" + tbteshis.Text + "', hasta_ilac='" + tbilac.Text + "' where hasta_tc='" + tbno.Text + "'";
            komut.ExecuteNonQuery();
            baglanti.Close();
            ds.Clear();
            listele();
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i] is TextBox)
                {
                    Controls[i].Text = "";
                }
            }
        }
        //FORMDAN/PROGRAMDAN TAMAMEN ÇIKIŞ YAPMAK İÇİN 
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            tbno.Clear();
            tbadi.Clear();
            tbsoyadi.Clear();
            tbtel.Clear();
            tbmail.Clear();
            tbadres.Clear();
            tbeski.Clear();
            tbyeni.Clear();
            tbteshis.Clear();
            tbilac.Clear();
        }
        //TEXTBOX'A SADECE RAKAM GİRME ÖZELLİĞİ
        private void Tbno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Tbsil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Tbara_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Tbtel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        //TEXTBOX'A SADECE HARF GİRME ÖZELLİĞİ
        private void Tbadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Tbsoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Tbeski_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void Tbyeni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }   
    }
}
