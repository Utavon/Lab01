using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e) { Console.WriteLine(trackBar1.Value); }
        int oldX, oldY; private void panel1_MouseDown(object sender, MouseEventArgs e) { oldX = e.X; oldY = e.Y; }

        private void panel1_MouseUp(object sender, MouseEventArgs e) { Graphics g = panel1.CreateGraphics(); Pen pen = new Pen(Color.Red); g.DrawLine(pen, oldX, oldY, e.X, e.Y); Graphics g = panel1.CreateGraphics(); Pen = new Pen(Color.Blue); g.DrawEllipse(pen, oldX, oldY, e.X, e.Y); Graphics g = panel1.CreateGraphics(); Pen pen = new Pen(Color.Green); g.DrawRectangle(pen, oldX, oldY, e.X, e.Y); }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}