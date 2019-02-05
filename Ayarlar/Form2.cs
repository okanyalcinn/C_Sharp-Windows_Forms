using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayarlar
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void _btnEKiltle_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        Ayarlar ayarlar = new Ayarlar();
        private void _btnKaydet_Click(object sender, EventArgs e)
        {
            ayarlar.textDeger1 = _txt1.Text;
            ayarlar.textDeger2 = _txt2.Text;

            if (_chckSecim1.Checked == true)
            {
                ayarlar.Chekbox1 = true;
            }
            else
            {
                ayarlar.Chekbox1 = false;
            }
            if (_chckSecim2.Checked == true)
            {
                ayarlar.Chekbox2 = true;
            }
            else
            {
                ayarlar.Chekbox2 = false;
            }
            ayarlar.Save(); // yapılan ayar değişikliklerini save metodu ile hafızada tutuyor
            MessageBox.Show("Ayarlar Kaydedildi");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //ayarlarda önceden kaydedilmiş veriyi getirme işlemi
            _txt1.Text = ayarlar.textDeger1;
            _txt2.Text = ayarlar.textDeger2;
            _chckSecim1.Checked = ayarlar.Chekbox1;
            _chckSecim2.Checked = ayarlar.Chekbox2;

            //_btnKaydet.Enabled = ayarlar.Chekbox1;
            //_btnKaydet.Text = ayarlar.Chekbox1.ToString(); // true ya da false döndüreceği için toString() metodu kullanılır

            //seçimler yüklendikten sonra nasıl davranacak onu belirliyoruz
            if (_chckSecim1.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            //////////////////////////
            if (_chckSecim2.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            //////////////////////////
            if (_chckSecim1.Checked == true && _chckSecim2.Checked == true)
            {
                this.BackColor = Color.Azure;
            }
        }

        private void _chckSecim1_CheckedChanged(object sender, EventArgs e)
        {
            if (_chckSecim1.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void _chckSecim2_CheckedChanged(object sender, EventArgs e)
        {
            if (_chckSecim2.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
        

        
    }
}
