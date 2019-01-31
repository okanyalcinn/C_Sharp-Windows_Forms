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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// arama metodunu çağırma (c# kaynağının tasarladığı)
        /// </summary>
        public static RichTextBox richTextBox;

        string dosya_yolu;       

        private void Form1_Load(object sender, EventArgs e)
        {            
            //fontlar
            _cmbYaziTip.DrawMode = DrawMode.OwnerDrawVariable;
            FontFamily[] fonts = FontFamily.Families;
            for (int i = 0; i < fonts.GetUpperBound(0); i++)
            {
                //item comboBox'a eklenen item değer
                _cmbYaziTip.Items.Add(fonts[i].Name);
            }
            _cmbYaziTip.Text = _richMetin.Font.Name; //başlangıçta seçili olan 

            //boyut
            for (int i = 1; i < 72; i++)
            {
                _cmbBoyut.Items.Add(i.ToString());
            }
            _cmbBoyut.Text = _richMetin.Font.Size.ToString(); //başlangıçta seçili olan 

            //Renk
            _cmbRenk.DrawMode = DrawMode.OwnerDrawFixed;
            string[] renkler = { "Kırmızı", "Azure", "Sarı", "Siyah", "Mavi", "Kahverengi" };
            _cmbRenk.Items.AddRange(renkler);
            _cmbRenk.Text = "Siyah"; //başlangıçta seçili olan siyah

            //Zoom
            _cmbZoom.Items.Add("%20");
            _cmbZoom.Items.Add("%50");
            _cmbZoom.Items.Add("%70");
            _cmbZoom.Items.Add("%100");
            _cmbZoom.Items.Add("%200");
            _cmbZoom.Items.Add("%400");
            _cmbZoom.Text = "100"; //başlangıçta seçili olan 100

            //Rich işlemleri
            // seçimi temizleme
            _richMetin.HideSelection = false;
            _richMetin.Modified = false;
            _richMetin.Text = ""; //başlangıçta seçili olan 

        }

        private void _cmbRenk_DrawItem(object sender, DrawItemEventArgs e)
        {
            Color color = Color.Black;
            string eleman = _cmbRenk.Items[e.Index].ToString(); //comboboxtan gelen
            switch (eleman)
            {
                case "Kırmızı": color = Color.Red; break;
                case "Azure": color = Color.Green; break;
                case "Sarı": color = Color.Yellow; break;
                case "Siyah": color = Color.Black; break;
                case "Mavi": color = Color.Blue; break;
                case "Kahverengi": color = Color.Brown; break;
                default:
                    break;
            }
            //rectaangele içine değerleri basma --seçim kısmını alt menü
            if (e.State == DrawItemState.Selected) //hangi renk seçili ise o rengi ver
            {//çiz
                e.Graphics.FillRectangle(new SolidBrush(Color.Turquoise), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
            }
            else
            {//Seçili değilse kendi rengiyle çiz
                e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds.Left, e.Bounds.Top, e.Bounds.Width, e.Bounds.Height);
                e.Graphics.DrawString(eleman, e.Font, new SolidBrush(Color.White), e.Bounds.Left, e.Bounds.Top);
                e.DrawFocusRectangle();
            }

        }

        private void _cmbYaziTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //seçili fontuuygula
                _richMetin.SelectionFont = new Font(_cmbYaziTip.SelectedItem.ToString(), _richMetin.SelectionFont.Size, _richMetin.SelectionFont.Style);

            }
            catch (Exception)
            {
                _richMetin.Focus();
            }
        }

        private void _cmbYaziTip_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground(); // liste elemanları ekle
            e.DrawFocusRectangle(); // liste ekranını çiz
            string ad = _cmbYaziTip.Items[e.Index].ToString();
            try
            {
                e.Graphics.DrawString(ad, new Font(ad, 12, FontStyle.Regular), new SolidBrush(Color.Black), e.Bounds.Left, e.Bounds.Top);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void _cmbBoyut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _richMetin.SelectionFont = new Font(_richMetin.SelectionFont.Name, float.Parse(_cmbBoyut.Text), _richMetin.SelectionFont.Style);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void _cmbZoom_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //yakınlaştır
                _richMetin.ZoomFactor = float.Parse(_cmbZoom.Text.Substring(1)) / 100;
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void _cmbRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color color = Color.Black;
            string eleman = _cmbRenk.SelectedItem.ToString(); //comboboxtan gelen
            switch (eleman)
            {
                case "Kırmızı": color = Color.Red; break;
                case "Azure": color = Color.Green; break;
                case "Sarı": color = Color.Yellow; break;
                case "Siyah": color = Color.Black; break;
                case "Mavi": color = Color.Blue; break;
                case "Kahverengi": color = Color.Brown; break;
                default:
                    break;
            }
            _richMetin.SelectionColor = color; // seçilen rengi richbox a ata
            _cmbRenk.BackColor = color;  // cmb durumu
            _cmbRenk.ForeColor = Color.Black; // 
            _richMetin.Focus();
        }
        /// <summary>
        /// Dosya açma işlemi yapar
        /// </summary>
        private void Ac()
        {
            _opnDosyaAc.Title = "Proje Aç"; //seçm ekranının başlığı
            _opnDosyaAc.Filter = "RTF Dosyaları|*.rtf"; // seçim yapılacak dosya türü.  | .rtf uzantılı dosyaları gösterir
            _opnDosyaAc.DefaultExt = "RTF"; // RTF seçmeye zorlama
            EkranKayit("Değişiklikler kaydedilsin mi ?");
            if (_opnDosyaAc.ShowDialog() == DialogResult.OK) //seçim yapılıp kapandıysa
            {
                dosya_yolu = _opnDosyaAc.FileName; // dosya uzantısını hafızaya alır
                _richMetin.LoadFile(dosya_yolu); // dosya yolunu yükler
                _richMetin.Modified = false;
                this.Text = "Açılan Proje" + dosya_yolu;
            }
        }

        private void Kaydet()
        {
            if (dosya_yolu == null)
            {
                FarkliKaydet("Kaydet");
            }
            else
            {
                _richMetin.SaveFile(dosya_yolu);
                _richMetin.Modified = false;
            }
        }

        private void FarkliKaydet(string baslik)
        {
            _saveDosyaKaydet.Title = baslik; //pencere başlığı
            _saveDosyaKaydet.Filter = "RTF Dosyalar|*.rtf";
            _saveDosyaKaydet.DefaultExt = "RTF";
            if (_saveDosyaKaydet.ShowDialog() == DialogResult.OK)
            {
                dosya_yolu = _saveDosyaKaydet.FileName; //kaydedilecek dosya uzantısını hafızaya alır
                _richMetin.SaveFile(dosya_yolu); // verilen uzantıya kaydeder
                this.Text = dosya_yolu;
            }
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkranKayit("Eski çalışmada ki değişiklikler kaydedilsin mi ?");
            _richMetin.Text = null;
            _richMetin.Modified = false;
            this.Text = "Yeni Dosya";

        }

        private void YaziStil(Boolean basilan, byte secim)
        {

            if (basilan)
            {
                switch (secim)
                {
                    case 1://seçili alanı bold yap
                        _richMetin.SelectionFont = new Font(_richMetin.SelectionFont, _richMetin.SelectionFont.Style | FontStyle.Bold);
                        break;
                    case 2://seçili alanı italik yap
                        _richMetin.SelectionFont = new Font(_richMetin.SelectionFont, _richMetin.SelectionFont.Style | FontStyle.Italic);
                        break;
                    case 3://seçili alanı altı çizili yap
                        _richMetin.SelectionFont = new Font(_richMetin.SelectionFont, _richMetin.SelectionFont.Style | FontStyle.Underline);
                        break;
                    default: // düzenli hal
                        _richMetin.SelectionFont = new Font(_richMetin.SelectionFont, _richMetin.SelectionFont.Style | FontStyle.Regular);
                        break;
                }

            }
        }

        private void EkranKayit(string mesaj)
        {
            if (_richMetin.Modified) //richbox düzenlendi mi
            {
                if (_richMetin.Modified) // metinbox düzenlendiyse
                {
                    DialogResult result = MessageBox.Show(mesaj, "Kaydet", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        Kaydet();
                    }
                }
            }
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ac();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void farkliKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarkliKaydet("Farklı Kaydet");
        }

        private void kalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziStil(true, 1);
        }

        private void eğikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziStil(true, 2);
        }

        private void altıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YaziStil(true, 3);
        }

        private void altSimgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.SelectionCharOffset = (int)-_richMetin.SelectionFont.Size / 2;
        }

        private void üstSimgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.SelectionCharOffset = (int)_richMetin.SelectionFont.Size / 2;
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.Copy();
        }

        private void yapistirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _richMetin.Paste();
            }
            catch (Exception)
            {
                MessageBox.Show("Bilgi alınmadı");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.SelectedText = null;
        }

        private void tümünüYenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_richMetin.CanRedo)
            {
                _richMetin.Redo();
            }
        }

        private void maddeİşaretiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.SelectionBullet = true;
        }

        private void _btnUstA_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _btnUstA.Left = e.X + _btnUstA.Left;
                _richMetin.SelectionIndent = _btnUstA.Left;
                _richMetin.SelectionHangingIndent = _btnUstA.Left - _btnUstA.Left;
            }
        }

        private void _btnAltB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _btnAltB.Left = e.X + _btnAltB.Left;
                _richMetin.SelectionHangingIndent = _btnAltB.Left - _btnUstA.Left;
            }
        }

        private void _btnAltC_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _btnAltC.Left = e.X + _btnAltC.Left;
                try
                {
                    _richMetin.SelectionHangingIndent = _richMetin.ClientSize.Width - _btnAltC.Left;
                }
                catch (Exception)
                {
                    throw;
                }                
            }
        }

        private void solaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void sağaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _richMetin.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void sağaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _richMetin.SelectionAlignment = HorizontalAlignment.Center;
        }
        AramaForm aramaForm = new AramaForm();
        private void bulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aramaForm._txtArananDeger.Text = _richMetin.SelectedText;            
            richTextBox = _richMetin;
            aramaForm.Show();
            MainForm mainf = new MainForm();
            aramaForm.MdiParent = mainf.ActiveMdiChild;

            //AramaForm aramaForm = new AramaForm();
            //// ilgili form içerisinde bulunsun diye 
            //aramaForm.Text = "Arama";
            //aramaForm.MdiParent = this;
            ////
            //aramaForm.Show();
        }
        
    }
}
