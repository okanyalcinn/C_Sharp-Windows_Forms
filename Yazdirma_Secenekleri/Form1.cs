using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Yazdirma_Secenekleri
{
    public partial class Form1 : Form
    {
        public int sayi = 1;
        SolidBrush ciz = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnYazdir_Click(object sender, EventArgs e)
        {
            _printSayfa.Print();
        }

        private void _printSayfa_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //daire
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 50);
            //yazı
            e.Graphics.DrawString("demo yazı", new Font("Thoma", 14, FontStyle.Regular), new SolidBrush(Color.Red), 75, 100);
            int sayfa_Yuksekligi;
            PageSettings p;
            p = _printSayfa.DefaultPageSettings;
            sayfa_Yuksekligi = p.PaperSize.Height - p.Margins.Top - p.Margins.Bottom;
            Font font = new Font("Thoma", 12, FontStyle.Regular);
            int satir_yuksekligi;
            satir_yuksekligi = (int)e.Graphics.MeasureString("1", font).Height;
            int max_satir;
            max_satir = sayfa_Yuksekligi / satir_yuksekligi;
            int satir_no = 0;
            int i = 0;
            for (i = sayi; i < sayi+max_satir-1; i++)
            {
                if (i>50)
                {// 1000 kelimeyi geçmeyince yeni sayfaya geçme
                    e.HasMorePages = false;
                    sayi = 1;
                    return;
                }
                e.Graphics.DrawString(i.ToString() + ".satır", font, ciz, _printSayfa.DefaultPageSettings.Margins.Left, _printSayfa.DefaultPageSettings.Margins.Top + satir_no * satir_yuksekligi);
                satir_no += 1;                
            }
            sayi = i;
            if (i < 50)
            {// 1000 kelimeyi geçince yeni sayfaya geç
                e.HasMorePages = true;
            }
        }

        private void Yazilacaklar(System.Drawing.Printing.PrintPageEventArgs e)
        {
            //daire
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 50);
            //yazı
            e.Graphics.DrawString("demo yazı", new Font("Thoma", 14, FontStyle.Regular), new SolidBrush(Color.Red), 75, 100);
        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //daire
            e.Graphics.FillEllipse(new SolidBrush(Color.Red), 10, 10, 400, 50);
            //yazı
            e.Graphics.DrawString("demo yazı", new Font("Thoma", 14, FontStyle.Regular), new SolidBrush(Color.Red), 75, 100);
        }

        private void _btnBaskiOniz_Click(object sender, EventArgs e)
        {
            //printSayfa nesnesinin taşıdığı değeri kendi içinde açıyor
            _printDialog.Document = _printSayfa;
            _printDialog.ShowDialog();
        }

        private void _btnSayfaAyarlari_Click(object sender, EventArgs e)
        {
            _pageSayfaAyar.PageSettings = _printSayfa.DefaultPageSettings;
            if (_pageSayfaAyar.ShowDialog() == DialogResult.OK)
            {
                //ayarlar penceresinden seçilen yeni ayarları print dökümanın varsayılan ayarları haline getiriyoruz
                _printSayfa.DefaultPageSettings = _pageSayfaAyar.PageSettings;
            }
        }
    }
}
