using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Paint_plus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics _grp;
        Color _renk = Color.Black;
        Bitmap _bitmap;
        bool _tiklandi;
        public int _baslangicX; // mouse point konum almak için
        public int _baslangicY; // mouse point konum almak için

        private void Form1_Load(object sender, EventArgs e)
        {
            _bitmap = new Bitmap(_picCizimAlani.Width, _picCizimAlani.Height);
            _grp = Graphics.FromImage(_bitmap);
            _grp.SmoothingMode = SmoothingMode.HighQuality; // yazma modu aktif çizme modu aktif
            _grp.Clear(Color.White); //temizle beyaza boya

            _picCizimAlani.Image = _bitmap;
        }

        // mouse'a tıklandığında
        private void _picCizimAlani_MouseDown(object sender, MouseEventArgs e)
        {
            _tiklandi = true;
        }

        // mouse'tan tıklamayı çekince (parmağımızı çekince)
        private void _picCizimAlani_MouseUp(object sender, MouseEventArgs e)
        {
            _tiklandi = false;
        }

        // mouse _picCizimAlani üzerinde gezdirilince
        private void _picCizimAlani_MouseMove(object sender, MouseEventArgs e)
        {
            int _cizgiKalinlik = _trackbrKalinlik.Value; //kalınlığı
            Pen _kalem = new Pen(_renk, _cizgiKalinlik); //renk ve punto ayarlandı
            Point _baslangicN = new Point(_baslangicX, _baslangicY);
            Point _bitisN = new Point(e.X, e.Y); // mouse yeni konumu

            //mouse tıklanma olayı kontrolü
            if (e.Button == MouseButtons.Left && _tiklandi)
            {
                _grp.DrawLine(_kalem, _baslangicN, _bitisN);
                _grp.FillEllipse(new SolidBrush(_renk), e.X - _cizgiKalinlik / 2, e.Y - _cizgiKalinlik / 2,_cizgiKalinlik,_cizgiKalinlik);
                _picCizimAlani.Refresh(); //ekran yenilenmez ise. üzerinde yapılan çizim gözükmez
            }
            //her harekette yeni mouse değerini alıyoruz
            _baslangicX = e.X;
            _baslangicY = e.Y;
        }

        private void _picDairePalet_MouseDown(object sender, MouseEventArgs e)
        {
            _tiklandi = true;
            Bitmap _bt = new Bitmap(_picDairePalet.Image);
            //_bt.GetPixel() bulunduğu konumdaki rengin HEX kodunu alır
            _renk = Color.FromArgb(255, _bt.GetPixel(e.X, e.Y));
            _pnlSecilenRenk.BackColor = _renk;
        }

        private void _picDairePalet_MouseUp(object sender, MouseEventArgs e)
        {
            _tiklandi = false;
        }

        private void _picDairePalet_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {//panel içi renk alanı dşına çıkmasın
                if (e.X>= _picDairePalet.Width-4 || e.Y>= _picDairePalet.Height-4 || e.X < 0 || e.Y<0)
                {
                    return;
                }
                Bitmap _b = new Bitmap(_picDairePalet.Image);
                _renk = Color.FromArgb(255, _b.GetPixel(e.X, e.Y));
                _pnlSecilenRenk.BackColor = _renk;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void _pnlSil_Click(object sender, EventArgs e)
        {
            _renk = Color.White;
            _pnlSecilenRenk.BackColor = _renk;
            _grp.Clear(_renk);
            _picCizimAlani.Refresh();
        }

        private void _pnlSecilenRenk_Click(object sender, EventArgs e)
        {
            _grp.Clear(_renk);
            _picCizimAlani.Refresh();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _dialogCalismaKaydet.Filter = @"Bmp Dosyaları|*.bmp|Jpeg Dosyaları|*.jpeg ";
            if (_dialogCalismaKaydet.ShowDialog() == DialogResult.OK)
            {
                string _yol = _dialogCalismaKaydet.FileName;
                string _uzanti = _yol.Substring(_yol.LastIndexOf('.'));
                ImageFormat _imgFormat = null;
                switch (_uzanti)
                {
                    case ".bmp":_imgFormat = ImageFormat.Bmp;break;
                    case ".jpeg":_imgFormat = ImageFormat.Jpeg;break;
                }
                _bitmap.Save(_yol, _imgFormat);
            }
        }

        private void yükleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            OpenFileDialog _yukle = new OpenFileDialog();
            _yukle.Title = "Yüklenecek dosyayı seç";
            _yukle.Filter = @"Bmp Dosyaları|*.bmp|Jpeg Dosyaları|*.jpeg ";
            if (_yukle.ShowDialog()==DialogResult.OK)
            {
                _grp.DrawImage(Image.FromFile(_yukle.FileName), Point.Empty);

                _picCizimAlani.Refresh();
            }
        }

        private void _picDikey_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap _btmp = new Bitmap(_picDikey.Image);
            _renk = Color.FromArgb(255, _btmp.GetPixel(e.X, e.Y));
            _pnlSecilenRenk.BackColor = _renk;
        }
    }
}
