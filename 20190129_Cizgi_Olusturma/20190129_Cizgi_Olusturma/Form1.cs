using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190129_Cizgi_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen kalem = new Pen(Color.DarkRed,3);
            //x ekseni üzerinde ilk konumu, y ekseni üzerinde ilk konumu, x ekseni üzerinde ikinci konumu, y ekseni üzerinde ikinci konumu
            e.Graphics.DrawLine(kalem, 20, 0, 50, 0);

            Pen kalem2 = new Pen(Color.Salmon, 11);
            e.Graphics.DrawLine(kalem2, 10, 50, 90, 50);
            e.Graphics.DrawLine(kalem2, 90, 50, 130, 20);
            e.Graphics.DrawLine(kalem2, 130, 20, 170, 20);
            e.Graphics.DrawLine(kalem2, 170, 20, 170, 20);

            

            
        }
    }
}
