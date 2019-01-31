using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_Cizim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Graphics graphics;
        int x = 0;
        int y = 0;

        private void Form1_MouseMove(object sender, MouseEventArgs e)//hareket edince yapılacak olaylar
        {
            if (e.Button==MouseButtons.Left) //mouse sol tıklama
            {
                graphics = this.CreateGraphics();
                graphics.DrawEllipse(new Pen(Color.Red),
                    x - Math.Abs(x - e.X) / 2,
                    y - Math.Abs(y - e.Y) / 2,
                    Math.Abs(x - e.X),
                    Math.Abs(y - e.Y));
                graphics.Dispose();
                _lblX.Text = x.ToString();
                _lblY.Text = y.ToString();

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left) //mouse sol tıklama
            {
                x = e.X;
                y = e.Y;
                _lblX.Text = x.ToString();
                _lblY.Text = y.ToString();
            }
            if (e.Button == MouseButtons.Right) //mouse sağ tıklama
            {
                graphics = this.CreateGraphics();
                graphics.Clear(Color.White);
                graphics.Dispose();
            }
        }
    }
}
