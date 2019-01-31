using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _txtTarih.Text = DateTime.Now.ToShortDateString(); //sadece tarihi alır
            _txtSaat.Text = DateTime.Now.ToLongTimeString(); //sadece saati ve saniye alır
            //alarm timerleri kapalı
            _tmrAlarmSure.Enabled = false;
            _tmrDurum.Enabled = false;
            // durum kontrolü 1 ms
            _tmrDurum.Interval = 100;
            // alarm saniye artışı 1 sn
            _tmrAlarmSure.Interval = 1000;
            this.Text = "Alarm Kapalı";

            
        }        

        private void _tmrAlarmSure_Tick(object sender, EventArgs e)
        {
            if (_txtTarih.Text == DateTime.Now.ToShortDateString() && _txtSaat.Text == DateTime.Now.ToLongTimeString())
            {
                //timer durum aktif hale getiriyoruz
                _tmrDurum.Enabled = true;
                //mesaj yazdırılıyor
                MessageBox.Show(_txtMetin.Text);
            }
        }

        private void _tmrDurum_Tick(object sender, EventArgs e)
        {
            Color color;
            color = _txtMetin.BackColor;
            // renkler arası değişimi
            _txtMetin.BackColor = _txtMetin.ForeColor;
            _txtMetin.ForeColor = color;
        }

        private void _btnAlarmAc_Click(object sender, EventArgs e)
        {
            _tmrAlarmSure.Enabled = true;
            Text = "Alarm Açık";
        }
        private void _btnAlarmKapat_Click(object sender, EventArgs e)
        {
            _tmrAlarmSure.Enabled = false;
            _tmrDurum.Enabled = false;
            Text = "Alarm Kapalı";
        }
    }
}
