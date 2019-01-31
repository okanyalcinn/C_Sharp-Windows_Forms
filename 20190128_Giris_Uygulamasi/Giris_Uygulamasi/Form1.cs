using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giris_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnGiris_Click(object sender, EventArgs e)
        {
            if (_txtKullaniciAdi.Text == "admin" && _txtSifre.Text == "1234" )
            {
                MessageBox.Show("Giriş Yapıldı.","Onay",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form2 form2 = new Form2();
                form2.Show(); //form2 gösterir
                this.Hide(); // şu anki formu gizler
            }
            else
            {
                MessageBox.Show("Hatalı giriş yapıldı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _btnReset_Click(object sender, EventArgs e)
        {
            // PROGRAM ÇIKIŞ İŞLEMLERİ
            //Close(); 
            //Application.Exit();
            //Environment.Exit(0);
            //this.Close();

            // TEXTBOX İÇERİĞİNİ TEMİZLEME / RESETLEME
            //_txtKullaniciAdi.Text = "";
            //_txtKullaniciAdi.Text = null;
            //_txtKullaniciAdi.Text = string.Empty;
            _txtKullaniciAdi.Clear();
            _txtSifre.Clear();
        }       
    }
}
