using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //file

namespace Geth_DosyaKaydet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string yol = "bilgi.dat";
        string path = Path.GetDirectoryName((yol) + @"bilgi.dat");
        private void Form1_Load(object sender, EventArgs e)
        {
            #region Bilgi.dat
            _lblYol.Text = path.ToString();
            try
            {
                using (TextReader dosya = File.OpenText(path + @"bilgi.dat"))
                {
                    string satir = null;
                    while ((satir = dosya.ReadLine()) != null) //dosya satırları boş değil ise
                    {
                        _txtMetin.Text += satir+(char)13+(char)10; //alt satıra geçmek için
                    }
                }
            }
            catch (Exception)
            {

                // throw;
            }
            #endregion
            #region isim ver
            _nmtUpDown1.Minimum = 1;
            _nmtUpDown1.Maximum = 12;

            _nmtUpDown2.Minimum = 1;
            _nmtUpDown2.Maximum = 12;

            _mnthAylar.ShowWeekNumbers = true;
            DateTime[] tatiller =
                {
                    new DateTime(2019,2,04),
                    new DateTime(2019,05,04)
            };
            // verilen günleri tatil olarak seçilmez olarak işaretler
            _mnthAylar.AnnuallyBoldedDates = tatiller;
            //olayları birleştiriyor
            _nmtUpDown2.ValueChanged += new EventHandler(_nmtUpDown1_ValueChanged);
            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_txtMetin.Modified) // okuma yazma ya da companette herhangi bir değişiklik yapıldı mı
            {
                DialogResult result = MessageBox.Show("Değişiklikler Kaydedilsin mi?", "Kaydet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    using (TextWriter writer = File.CreateText(Path.GetDirectoryName(yol) + @"bilgi.dat"))
                    {
                        writer.Write(_txtMetin.Text);
                    }
                }
            }
        }
        /// <summary>
        /// takvim tablosunu genişletmek amaçlı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _nmtUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (_nmtUpDown1.Value*_nmtUpDown2.Value==0)
            {
                return;
            }
            if (_nmtUpDown1.Value * _nmtUpDown2.Value > 12)
            {
                MessageBox.Show("Satır, Sütun sayısı 12 yi geçemez: ");
            }
            else
            {
                _mnthAylar.CalendarDimensions = new Size((int)_nmtUpDown1.Value, (int)_nmtUpDown2.Value);
            }
        }
    }
}
