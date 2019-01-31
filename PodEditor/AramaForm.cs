using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodEditor
{
    public partial class AramaForm : Form
    {
        public AramaForm()
        {
            InitializeComponent();
        }

        int yer;

        private void _btnBul_Click(object sender, EventArgs e)
        {
            yer = Form1.richTextBox.Find(_txtArananDeger.Text, 0, richTxtBx());
            if (yer == -1)
            {
                MessageBox.Show("Kayıt Bulumamadı");
            }
        }
        /// <summary>
        /// arama yapmak için metodumuz richtextbox olayı
        /// </summary>
        /// <returns></returns>
        public RichTextBoxFinds richTxtBx()
        {
            RichTextBoxFinds finds;
            if (_chkBuyukKucukHarf.Checked == true) // büyük küçük harf duyarlılığına göre
            {
                finds = RichTextBoxFinds.MatchCase; //duyarlılık göster
            }
            else
            {
                finds = RichTextBoxFinds.None; //duyarlılık gösterme                
            }

            if (_chkTamSozluklar.Checked == true)
            {
                finds = finds | RichTextBoxFinds.WholeWord; //duyarlılık göster
            }
            else
            {
                finds = finds | RichTextBoxFinds.None; //duyarlılık gösterme

            }
            return finds;
        }

        private void _btnSonrakiniBul_Click(object sender, EventArgs e)
        {
            yer = Form1.richTextBox.Find(_txtArananDeger.Text, Form1.richTextBox.SelectionStart + 1, richTxtBx());
            if (yer == -1)
            {
                MessageBox.Show("Kayıt Bulumamadı");
            }
        }

        private void _btnDegistir_Click(object sender, EventArgs e)
        {
            if (Form1.richTextBox.SelectedText == _txtArananDeger.Text)//değiştireceğimiz metni fare ile seçersek (yazının arka planı mavi olunca) veya bul butonuna bastıktan sonra. bul butonuna basınca da seçmiş olduğu için
            {
                Form1.richTextBox.SelectedText = _txtYeniDeger.Text; // yeni değer ile seçilen kısmı değiştir (selectedText)
            }
            else
            {
                yer = Form1.richTextBox.Find(_txtArananDeger.Text, 0, richTxtBx()); //find hazır metoduyla aranan değeri, 0 ıncı indexten başlatarak ara ve gelen index numarasını yer değişkenine aktar
                if (yer == -1)
                {
                    MessageBox.Show("Kayıt Bulumamadı");
                }
                else
                {
                    Form1.richTextBox.SelectedText = _txtYeniDeger.Text;//değişme
                }
            }
        }

        private void _btnTumunuDegistir_Click(object sender, EventArgs e)
        {
            bool _DahaVarmi = true;
            yer = Form1.richTextBox.Find(_txtArananDeger.Text, 0, richTxtBx()); 
            if (yer == -1)
            {
                MessageBox.Show("Kayıt Bulumamadı");
                _DahaVarmi = false;
            }
            
            while (_DahaVarmi == true)
            {
                yer = Form1.richTextBox.Find(_txtArananDeger.Text, +1, richTxtBx()); // find ile text içerisinde aranan kelimenin indexini verir. her zaman +1 ile bir sonrakini bulsun denilir
                if (yer != -1)
                {
                    Form1.richTextBox.SelectedText = _txtYeniDeger.Text;//seçili index numaralarının bulunduğu kısıma yazdığımız texti işlet (değiştir)
                    _DahaVarmi = true;
                    yer = yer+ 1;
                }
                else
                {
                    _DahaVarmi = false;
                    break;
                }
            }
        }
    }
}
