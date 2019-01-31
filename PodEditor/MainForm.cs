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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
                // ilgili form içerisinde bulunsun diye 
                form.Text = "PodEditor";
                form.MdiParent = this;
                //
            form.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized; // form ilk açıldığında tam ekran açılsın
        }
    }
}
