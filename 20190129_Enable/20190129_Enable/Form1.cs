using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190129_Enable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _btnBaglan_Click(object sender, EventArgs e)
        {
            _btnBaglan.Enabled = false;
            _btnBaglantiKes.Enabled = true;
            radioButton4.Enabled = false;            
        }

        private void _btnBaglantiKes_Click(object sender, EventArgs e)
        {
            _btnBaglan.Enabled = true;
            _btnBaglantiKes.Enabled = false;
            radioButton4.Enabled = true;
        }
    }
}
