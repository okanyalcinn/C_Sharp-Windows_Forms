using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190129_ComboBox_ornek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Iller i = new Iller();
            Iller[] il =
            {
                new Iller("Ankara",06),
                new Iller("İstanbul",34),
                new Iller("Rize",53),
                new Iller("Adana",01),
            };
            _cmbiller.Items.AddRange(il); //iller classını combobox'a ekliyoruz
            
        }

        private void _cmbiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lblAdi.Text = ((Iller)_cmbiller.SelectedItem).ad;
            _lblKodu.Text = ((Iller)_cmbiller.SelectedItem).plaka.ToString();
        }
    }

    public class Iller
    {
        public string ad { get; set; }
        public int plaka { get; set; }
        public Iller()
        {
            ad = String.Empty;
            plaka = 0;
        }
        public Iller(string ad, int plaka)
        {
            this.ad = ad;
            this.plaka = plaka;
        }
        public override string ToString()
        {
            return plaka + " " + ad;
        }
    }
}
