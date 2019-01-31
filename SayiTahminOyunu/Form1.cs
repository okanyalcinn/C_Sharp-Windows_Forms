using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahminOyunu
{
    public partial class Form1 : Form
    {
        int sayi = 0;
        int tahmin_sayi = 0;
        int puan = 0;
        int tahmin = 0;
        Random random = new Random();
        int sure = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _tmrOyunSuresi.Interval = 1000; //1 saniye kadar  1000ms
            _btnTahmin.Enabled = false;
            this.AcceptButton = _btnTahmin; // enter'a basınca gideceği alan
            _txtSayi.Enabled = false;
        }

        private void _btnBasla_Click(object sender, EventArgs e)
        {
            _tmrOyunSuresi.Start();
            _btnTahmin.Enabled = true;
            _btnBasla.Enabled = false;
            _txtSayi.Enabled = true;
            sayi = random.Next(1);
            _lblPuan.Text = "1000";
            _lblTahmisSayisi.Text = "0";
            _lblDurum.Text = "Oyuna başlandı";
            this.Text = "Tahmine başla"; //title 
        }

        private void _btnTahmin_Click(object sender, EventArgs e)
        {
            try
            {
                tahmin = int.Parse(_txtSayi.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Yanlış sayı girişi");
            }

            tahmin_sayi = int.Parse(_lblTahmisSayisi.Text);
            tahmin_sayi++;
            _lblTahmisSayisi.Text = tahmin_sayi.ToString();
            puan = int.Parse(_lblPuan.Text);
            puan = puan - tahmin_sayi * 10;
            _lblPuan.Text = puan.ToString(); //puan azaltma

            //girilen sayının kontrolü
            if (sayi < tahmin)
            {
                _lblDurum.Text = "Girilen Sayı Küçük";
            }
            else if(sayi>tahmin)
            {
                _lblDurum.Text = "Girilen Sayı Büyük";
            }
            else
            {
                Mesaj("Kazandınız");
            }
            _txtSayi.Text = "";
        }

        private void _tmrOyunSuresi_Tick(object sender, EventArgs e)
        {
            _lblSure.Text = sure.ToString();
            sure--;
            if (sure==0)
            {
                _tmrOyunSuresi.Stop();
                Mesaj("Oyun süresi Doldu");
            }
        }
        public void Mesaj(string mesaj)
        {
            _tmrOyunSuresi.Stop();
            //dialogResult mesaj ekranından geri dönen değeri dinler ve akabinde ona göre işlem yapılabilir
            DialogResult dialog = MessageBox.Show(mesaj+"\nTekrar oynamak ister misiniz ?", "Oyun Süres Doldu ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (dialog == DialogResult.OK)
            {
                _btnTahmin.Enabled = false;
                this.AcceptButton = _btnTahmin; // enter'a basınca gideceği alan
                _txtSayi.Enabled = false;
                _btnBasla.Enabled = true;
                sayi = random.Next(1);
                _lblPuan.Text = "1000";
                _lblTahmisSayisi.Text = "0";
                _lblDurum.Text = "Oyuna başlandı";
                this.Text = "Tahmine başla"; //title                 
                _lblSure.Text = "10";
                _lblTahmisSayisi.Text = "";
                sure = 10;
            }
            else if (dialog == DialogResult.Cancel)
            {
                Environment.Exit(0);
            }
        }
    }
}
