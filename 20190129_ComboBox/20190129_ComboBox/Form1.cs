using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190129_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //bilgisayarda yüklü olan font tiplerini combobox'a yükleme
            FontFamily[] font = FontFamily.Families;
            for (int i = 0; i < font.GetUpperBound(0); i++) // koordinat düzleminde x in uzunluklarını al
            {
                _cmbFont.Items.Add(font[i].Name);
                //_cmbFont.SelectedIndex = 0;                
            }
            for (int k = 7; k < 72; k++)
            {
                _cmbPunto.Items.Add(k);
                _cmbPunto.SelectedIndex = 0;
            }
            //olaylar birleştirildi
            _cmbPunto.SelectedIndexChanged += new EventHandler(_cmbFont_SelectedIndexChanged);
            _cmbPunto.TextChanged += new EventHandler(_cmbFont_SelectedIndexChanged);
        }

        private void _cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //seçime göre font ve punto ayarlama
                _txtMetinArea.Font = new Font(_cmbFont.Text.ToString(), float.Parse(_cmbPunto.Text), FontStyle.Regular);
            }
            catch (Exception)
            {
                throw;
            }
        }        
    }
}
