using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190129_Cizim_Yapma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Bitmap bitmap; //kaydetmek için

        private void _btnCiz_Click(object sender, EventArgs e)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.FillEllipse(new SolidBrush(Color.Azure), 10, 100, 200, 10);
            g.DrawString(".Net Temel Eğitim", new Font("Thamoe", 10, FontStyle.Regular), new SolidBrush(Color.Blue), 10, 5);
            this.Invalidate(); // eş zamanlı olarak forma uygula
        }

        private void _btnKaydet_Click(object sender, EventArgs e)
        {
            bitmap.Save("demo.bmp");
        }

        private void _btnAc_Click(object sender, EventArgs e)
        {
            bitmap = (Bitmap)Image.FromFile("demo.bmp");
            this.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            rectangle = Screen.GetBounds(rectangle);
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
        }
    }
}
