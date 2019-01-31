using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //çıkış işin eklenecek kütüphane

namespace Giris_Uygulamasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void _btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show(); //form1 göster
            this.Hide(); //şuanki formu gizle
        }

        private void _btnCik_Click(object sender, EventArgs e)
        {
            //görev yöneticisinden programı kapatma işlemi
            string islem = "Giris_Uygulamasi"; //çözümün tam adını girmen gerekir
            Process[] prs = Process.GetProcesses(); //görev yöneticisindeki uygulamaları getir
            foreach (Process item in prs) //foreach ile döndür
            {
                if (item.ProcessName == islem) // "Giris_Uygulamasi" adli uygulamayı bul
                {
                    item.Kill(); // uygulamayı sonlandır
                }
            }
        }

        private void _Evli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void _btnHesapla_Click(object sender, EventArgs e)
        {
            int Maas;
            int cocukSayisi;
            int agi = 191;
            int maasNet = 0;

            try
            {
                Maas = int.Parse(_txtMaas.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Maaş hatalı girildi");
                return;
            }
            
            if (_chkEvli.Checked == false) //ilgili checkBox'ın seçili olup olmama durumu
            { 
                //agi 191 olarak 61. satırda tanımlanmıştı
                maasNet = agi + Maas;
            }
            else if (_chkEvli.Checked == true)
            {
                try
                {
                    cocukSayisi = int.Parse(_txtCocukSayisi.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Çocuk sayısı hatalı girildi");
                    return;
                }
                if (_chkEsCalisiyor.Checked == true)
                {
                    agi = (cocukSayisi * 15) + agi;
                    maasNet = agi + Maas;
                }
                else
                {
                    agi = (cocukSayisi * 20) + agi;
                    maasNet = agi + Maas;
                }                               
            }            
            MessageBox.Show("Aginiz: " + agi.ToString("###,###") + "tl dir \nToplam Maaşınız: " + maasNet.ToString("###,###") + "tl dir" );
        }
       
    }
}
