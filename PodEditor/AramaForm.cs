using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodEditor
{
    public partial class AramaForm : Form
    {
        public AramaForm()
        {
            InitializeComponent();
        }

        int yer;

        private void _btnBul_Click(object sender, EventArgs e)
        {
            yer = Form1.richTextBox.Find(_txtArananDeger.Text, 0, richTxtBx());
            if (yer == -1)
            {
                MessageBox.Show("Kayıt Bulumamadı");
            }
        }
        public RichTextBoxFinds richTxtBx()
        {
            RichTextBoxFinds finds;
            if (_chkBuyukKucukHarf.Checked == true) // büyük küçük harf duyarlılığına göre
            {
                finds = RichTextBoxFinds.MatchCase;
            }
            else
            {
                finds = RichTextBoxFinds.None; //duyarlılık gösterme
            }

            if (_chkTamSozluklar.Checked == true)
            {
                finds = finds | RichTextBoxFinds.WholeWord;
            }
            else
            {
                finds = finds | RichTextBoxFinds.None; //duyarlılık gösterme
                
            }
            return finds;
        }

        private void _btnSonrakiniBul_Click(object sender, EventArgs e)
        {
            yer = Form1.richTextBox.Find(_txtArananDeger.Text, Form1.richTextBox.SelectionStart + 1, richTxtBx());
            if (yer == -1)
            {
                MessageBox.Show("Kayıt Bulumamadı");
            }
        }

        private void _btnDegistir_Click(object sender, EventArgs e)
        {
            if (Form1.richTextBox.SelectedText == _txtArananDeger.Text)
            {

                Form1.richTextBox.SelectedText = _txtYeniDeger.Text;
            }
            else
            {
                Form1.richTextBox.Find(_txtArananDeger.Text, 0, richTxtBx());
                if (yer == -1)
                {
                    MessageBox.Show("Kayıt Bulumamadı");
                }
                else
                {
                    Form1.richTextBox.SelectedText = _txtYeniDeger.Text;//değişme
                }
            }
        }
    }
}
