using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combo_List_Resim_Ekleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] _yonler = { "Yukarı", "Aşağı", "Sağa", "Sola" };
            _cmb_icon.DrawMode = DrawMode.OwnerDrawVariable;
            _cmb_icon.Items.AddRange(_yonler); //ülkeler combobox'a eklendi

            _listbx_icon.DrawMode = DrawMode.OwnerDrawVariable;
            _listbx_icon.ItemHeight = 32; //her eleman için
            _listbx_icon.Items.AddRange(_yonler);
        }

        private void _cmb_icon_DrawItem(object sender, DrawItemEventArgs e)
        {
            string s = _cmb_icon.Items[e.Index].ToString();
            //üye sayısı kadar zemin oluştur - aiağıya doğru açılınca
            e.DrawBackground(); //arkaplan
            e.DrawFocusRectangle(); //odaklanma

            _imgList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Index); //konum

            //Listeye yazı yazma
            e.Graphics.DrawString(s, new Font("Calibri", 10, FontStyle.Bold), new SolidBrush(Color.Black), e.Bounds.Left + 30, e.Bounds.Top + 1);

            
        }

        private void _cmb_icon_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 30;
        }

        private void _listbx_icon_DrawItem(object sender, DrawItemEventArgs e)
        {
            string s = _listbx_icon.Items[e.Index].ToString();
            //kare oluşturuldu
            e.DrawBackground();
            e.DrawFocusRectangle();

            _imgList.Draw(e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Index); //konum
            e.Graphics.DrawString(s, new Font("Calibri", 12, FontStyle.Bold), new SolidBrush(Color.Black), e.Bounds.Left + 30, e.Bounds.Top + 1);
        }

        private void _tmrSure_Tick(object sender, EventArgs e)
        {
            _prgbrIslem.Increment(1); //progressbar'ın yeişl dolum rengini 1000 milisaniye de 1 çubuk dolsun (renk versin) 
            _tmrSure.Interval = 1000; //1000 ms zaman geçiyor
            _lblYuzde.Text = "% " + _prgbrIslem.Value.ToString();
            if (_prgbrIslem.Value == 100)
            {
                _tmrSure.Stop();
                MessageBox.Show("Yükleme Tamam!");
            }
        }

        private void _btnYukle_Click(object sender, EventArgs e)
        {
            _tmrSure.Start();
        }

        private void _btnVazgec_Click(object sender, EventArgs e)
        {
            _tmrSure.Stop();
        }
    }
}
