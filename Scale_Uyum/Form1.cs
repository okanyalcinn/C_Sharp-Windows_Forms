using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // sürücülere anlık erişebilmek için

namespace Scale_Uyum
{
    public partial class ScaleUyum : Form
    {
        public ScaleUyum()
        {
            InitializeComponent();
        }

        private void ScaleUyum_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true; //mouse dinleme aktif
            _tmrSaat.Interval = 100;
            _tmrSaat.Enabled = true;

            _stsbarYeni.Panels[0].ToolTipText = "Disk Kapasite";
            _stsbarYeni.Panels[1].ToolTipText = "Ekran Çözünürlüğü";
            _stsbarYeni.Panels[2].ToolTipText = "Basılı Tuş";
            _stsbarYeni.Panels[3].ToolTipText = "Saat";

            long _x = 0;
            long _y = 0;
            long _z = 0;

            string _sDurum = "";
            //logical drive 
            string[] _suruculer = System.IO.Directory.GetLogicalDrives();

            //drive sürücü kapasitesi
            for (int i = 0; i < _suruculer.GetUpperBound(0); i++) // getUpperBound → x derinliği al
            {
                GetDiskFreeSpaceExA(_suruculer[i], ref _x, ref _y, ref _z);
                //GB'a çevirme işlemi
                if (_y > 1024)
                {//GB cinsinden
                    _sDurum += _suruculer[i] + " " + (_y / 1024 / 1024 / 1024).ToString() + " GB " + "";
                }
                else
                {
                    _sDurum += _suruculer[i] + " " + (_y / 1024 / 1024).ToString() + " MB " + "";
                }
            }
            _stsbarYeni.Panels[0].Text = _sDurum;
            _stsbarYeni.Panels[0].Width = 150;

            //ekran çözünürlüğü
            Rectangle _kare = new Rectangle();
            _kare = Screen.GetBounds(_kare);
            _stsbarYeni.Panels[1].Text = _kare.Width.ToString() + " x " + _kare.Height.ToString();
            _stsbarYeni.Panels[1].Width = 100;
        }

        //api tanımlama
        [DllImport("kernel32.dll")]
        public static extern int GetDiskFreeSpaceExA(string lpRootPathName, ref long lpFreeBytesAvaibleToCaller, ref long lpTotalNumberOfBytes, ref long lpTotalNumberOfFreeOfFreeBytes);

        private void ScaleUyum_KeyDown(object sender, KeyEventArgs e)
        {
            _stsbarYeni.Panels[2].Text = e.KeyData.ToString();
        }

        private void _tmrSaat_Tick(object sender, EventArgs e)
        {
            _stsbarYeni.Panels[3].Text = DateTime.Now.ToLongTimeString();
        }

        
    }
}
