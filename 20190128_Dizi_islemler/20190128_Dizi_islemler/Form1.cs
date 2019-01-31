using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190128_Dizi_islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] ad = new string[10];
        int siraNo = 0;

        private void _btnDiziEkle_Click(object sender, EventArgs e)
        {
            ad[siraNo] = _txtAdSoyad.Text;
            siraNo += 1;
            _lstAdlar.Items.Add(_txtAdSoyad.Text);
        }

        private void _btnSirala_Click(object sender, EventArgs e)
        {
            Array.Sort(ad); //sıralama
        }

        private void _btnAra_Click(object sender, EventArgs e)
        {
            string aranan = _txtAra.Text;
            int yer = Array.IndexOf(ad,aranan);
            while (yer>=0)
            {
                MessageBox.Show(aranan + " kişi listede " + yer.ToString() + ".sırada");
                yer = Array.IndexOf(ad, aranan, yer + 1); // bir sonrakine geçiş için 
            }
        }

        private void _btnTersCevir_Click(object sender, EventArgs e)
        {
            Array.Reverse(ad);
            //bunu tekrardan gözden geçir bi yanklışlık var
            //_lstAdlar.Items.Clear(); //listede önceden ekli olanları temizler
            //foreach (var item in ad)
            //{
            //    _lstAdlar.Items.Add(item.ToString());
            //}
        }

        private void _btnDiziGoster_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            g.Clear(this.BackColor);            
            for (int i = 0; i < ad.Length; i++)
            {//dizi elemanlarını form ekranına basıyoruz
                //                       font(tipi, boyutu, sitili), solidBrush(renk), bi alt satıra geçsin diye
                g.DrawString(ad[i], new Font("Calibri", 10, FontStyle.Regular), new SolidBrush(Color.Red), 10, 30 + i * 10);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
