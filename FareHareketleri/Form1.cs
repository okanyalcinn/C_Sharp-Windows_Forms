using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FareHareketleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _txtAd2.MouseEnter += new EventHandler(_txtAd1_MouseEnter);
            _txtAd3.MouseEnter += new EventHandler(_txtAd1_MouseEnter);

            _txtAd2.MouseLeave += new EventHandler(_txtAd1_MouseEnter);
            _txtAd3.MouseLeave += new EventHandler(_txtAd1_MouseEnter);
        }

        private void _txtAd1_MouseEnter(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.Red; // mouse üzerine gelince kırmızı renk
            (sender as Control).ForeColor = Color.Yellow;
            this.BackColor = Color.Bisque; // arka plan rengi
        }

        private void _txtAd1_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.White; // mouse üzerinden ayrılınca beyaz renk
            (sender as Control).ForeColor = Color.Black;
            this.BackColor = Color.Blue; // arka plan rengi
        }

        private void _btnGonder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba");
        }

        private void _btnGonder2_Click(object sender, EventArgs e)
        {
            _btnGonder_Click(sender, e); //btnGonder'in özelliğini taşır. ona tıklanmış gibi
        }
    }
}
