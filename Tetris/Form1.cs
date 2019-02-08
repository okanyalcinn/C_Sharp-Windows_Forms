using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tetris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int _satirSayisi;
        int _sutunSayisi;
        int _kutuSayisi;
        int _puan;
        int _level;
        int _xa;
        int _ya;
        Boolean _demo = false;
        int[] _kutu;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            _level = 1;
            _satirSayisi = 4;
            _sutunSayisi = 4;
            _btnOdun.Text = "";
            _btnOdun.Top = this.ClientSize.Height - 100;

            //label boyutları otomatik büyüyüp küçülsün
            _lblPuan.AutoSize = true;
            _lblLevel.AutoSize = true;
            _lblKutuSayisi.AutoSize = true;
            _lblTepki.AutoSize = true;

            _lblTepki.Font = new Font("Calibri", 14, FontStyle.Bold);
            _lblPuan.Text = "0";
            _lblPuan.Top = ClientSize.Height - _lblPuan.Height;
            _lblPuan.Left = 0;

            _lblKutuSayisi.Text = "Kutu Sayisi";
            _lblKutuSayisi.Top = ClientSize.Height - _lblKutuSayisi.Height;
            _lblKutuSayisi.Left = _lblPuan.Left + _lblKutuSayisi.Width + 10;

            _lblLevel.Text = "Level 1";
            _lblLevel.Top = ClientSize.Height - _lblLevel.Height;
            _lblLevel.Left = _lblKutuSayisi.Left + _lblKutuSayisi.Width+10;
            Oyun();

            //
            _tmr1.Interval = 50;
            _tmr1.Enabled = true;
            _tmr2.Enabled = true;

        }

        private void Oyun()
        {
            int i;
            int j;
            _satirSayisi = _satirSayisi + 1;
            _sutunSayisi = _sutunSayisi + 1;
            _kutuSayisi = _satirSayisi * _sutunSayisi;
            _kutu = new int[_kutuSayisi];
            _xa = 10;
            _ya = -10;
            //topun kutuya dokunma durumu
            this._picTop.Top = this._btnOdun.Top - 100;
            this._lblLevel.Text = "Level " + _level;
            this.Width = 60 * _sutunSayisi + 8;

            //kutu sayısı oluşturma | her üst sütun indiğinde yeni küp sayısı sırası oluştur
            Random _r = new Random((int)(DateTime.Now.Ticks % System.Int32.MaxValue));
            this.BackColor = Color.FromArgb(_r.Next(255), _r.Next(255), _r.Next(255));

            //her seviyede çubuk genişliğini azalt
            this._btnOdun.Width = this._btnOdun.Width - 10;

            //kutuları oluşturma
            for (i = 0; i <= _kutuSayisi - 1; i++)
            {
                _kutu[i] = (int)(_r.Next(6)) + 1;
            }

            //kutulara rastgele bomba yerleştirme
            for (i = 0; i <= _kutuSayisi / 5; i++)
            {
                j = _r.Next(_kutuSayisi);
                _kutu[j] = 200; //buraya bomba değer girdik
            }

            _lblTepki.Text = "Level " + _level;
            this._lblTepki.Left = (this.ClientSize.Width - this._lblTepki.Width / 2);
            this._lblTepki.Top = (this.ClientSize.Height - this._lblTepki.Height / 2);
            this._lblTepki.Visible = true;

            Application.DoEvents(); // ascecron

            Thread.Sleep(2000); // 2sn ekle
            this._lblTepki.Visible = false;
        }

        private void _btnOdun_MouseMove(object sender, MouseEventArgs e)
        {
            if ((_kutuSayisi != 1) && (_demo == false))
            {
                _btnOdun.Left = _btnOdun.Left + e.X;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //if ((_kutuSayisi != 1) && (_demo == false))
            //{
            //    _btnOdun.Left = _btnOdun.Left + e.X;
            //}
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //esc yapınca anında dur
            if (e.KeyChar == (char)24)
            {
                _demo = !_demo;
            }
        }

        int _resimNo = 0;

        private void _tmr2_Tick(object sender, EventArgs e)
        {
            _resimNo++;
            _resimNo = _resimNo % 7; //_imgLstTop içinde kaç adet fotoğraf var ise o kadar bölüyoruz | 7 resim var 
            _picTop.Image = _imgLstTop.Images[_resimNo];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int _ks = 0; //kutu sayısı
            SolidBrush _b = new SolidBrush(Color.White);
            for (int i = 0; i <= _satirSayisi * _sutunSayisi - 1; i++)
            {
                float _x = 60 * (i % _sutunSayisi);
                float _y = 20 * (int)(i / _sutunSayisi);
                if (_kutu[i] != 100)
                {
                    Random _r = new Random((int)(DateTime.Now.Ticks % System.Int32.MaxValue));
                    _b.Color = Color.FromArgb(_r.Next(255), _r.Next(255), _r.Next(255));
                    _ks++;
                    e.Graphics.FillRectangle(_b, _x, _y, 60, 20); //rastgele renkli kutu oluştur
                    e.Graphics.DrawRectangle(new Pen(this.BackColor), _x, _y, 60, 20);
                    //bomba varsa resim koyma
                    if (_kutu[i] != 200)
                    {
                        _imgLstKutu.Draw(e.Graphics, (int)_x + 22, (int)_y + 2, _kutu[i] - 1);
                    }
                }
                else
                {//kutu yoksa zemin rengine boya
                    _b.Color = this.BackColor;
                    e.Graphics.FillRectangle(_b, _x, _y, 60, 20);
                }
            }
            _kutuSayisi = _ks;
            _lblKutuSayisi.Text = _kutuSayisi.ToString();
        }

        private void _tmr1_Tick(object sender, EventArgs e)
        {
            int _i;
            int _j;
            int _k;
            int _m;
            int _n;
            int _s;
            //formun dışına çıkarsa oyunu bitir
            if (_picTop.Top >= ClientSize.Height)
            {
                _tmr1.Enabled = false;
                DialogResult _dialog = MessageBox.Show("Yeniden oynamak ister misiniz?", "Oyun", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (_dialog == DialogResult.Yes)
                {
                    Oyun();
                }
                else if (_dialog == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //top sol kenara gelince çarpıp dön
            if (_picTop.Left <= 0)
            {
                _xa = -_xa;
                _picTop.Left = 0;
            }
            //top sağ kenara gelince çarpıp dön
            if (_picTop.Right >= ClientSize.Width)
            {
                _xa = -_xa;
            }
            //top yukarı kenara gelince çarpıp dön
            if (_picTop.Top <= 0)
            {
                _ya = -_ya;
                _picTop.Top = 0;
            }
            //buton karelere çarptığında geri dönme
            if ((_picTop.Top >= _btnOdun.Top)&&(_picTop.Top <_btnOdun.Bottom) && (_picTop.Left>_btnOdun.Left)&& (_picTop.Left <_btnOdun.Right))
            {
                _ya = -_ya;
            }

            //alt kenara çarparsa oyunu bitir
            if (_picTop.Top >=ClientSize.Height)
            {
                _tmr1.Enabled = false;
                MessageBox.Show("Oyun Bitti");
            }
            _picTop.Left += _xa;
            _picTop.Top += _ya;

            //koordinata denk gelen kutuyu bul sil
            _i = (int)(_picTop.Left + _picTop.Width / 2)/60;
            _j = (int)(_picTop.Top / 20);
            _k = _j * _sutunSayisi + _i;
            if ((_j <= _satirSayisi -1) && (_i <= _sutunSayisi-1))
            {
                //koordinatta kutu varsa
                if (_kutu[_k] != 100)// bu kutu daha önce vurulmuşsa
                {
                    Graphics _g;
                    _g = this.CreateGraphics();
                    _kutuSayisi = _kutuSayisi - 1;
                    _puan = _puan + 10 *_kutu[_k];
                    _lblPuan.Text = _puan.ToString();
                    //puan yaz
                    _g.DrawString((_kutu[_k] * 10).ToString(), new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.White), 60 * (_k % _sutunSayisi) + 10, 20 * (_k / _sutunSayisi) + 5);
                    Thread.Sleep(100);//100 ms beklet
                    _ya = -_ya; // kutuya çarpınca geri dönsün
                    if (_kutu[_k] == 200) //bomba
                    {
                        for (_m=_i; _m<=_i+2; _m++)
                        {
                            for (_n=_j; _n<=_j ; _n++)
                            {
                                _s = _n * _sutunSayisi + _m - 1;
                                // kutu varsa yok et
                                if ((_s >= 0) && (_n<=_satirSayisi -1) && (_m<=_sutunSayisi-1))
                                {
                                    _kutu[_s] = 100;
                                    _g.DrawString("Boomm!", new Font("Tahoma",10, FontStyle.Regular), new SolidBrush(Color.White), 60 * (_s % _sutunSayisi), 20 * (_s / _sutunSayisi));
                                    Thread.Sleep(100);
                                }
                            }
                        }
                    }
                    _kutu[_k] = 100;
                    this.Invalidate();
                    _g.Dispose();
                }
            }
            //otomatik pilot
            if ((_kutuSayisi==1)||(_demo==true))
            {
                _btnOdun.Left = _picTop.Left - (_btnOdun.Width / 2);
                _btnOdun.Text = "Auto Pilot";
            }
            else
            {
                _btnOdun.Text = "";
            }

            //Yeni oyuna geçme
            if (_kutuSayisi == 0)
            {
                _level++;
                Oyun();
            }
        }
    }
}
