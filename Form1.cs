using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf353
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color clr = Color.Black;
        Font fnt = new Font("Times New Roman", 14);
        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fntDia = new FontDialog();
            fntDia.ShowDialog(); fnt = fntDia.Font;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colDia = new ColorDialog();
            colDia.ShowDialog(); clr = colDia.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Graphics g = CreateGraphics();
            g.Clear(SystemColors.Control);
            Brush br = new SolidBrush(clr);
            g.DrawString(s, fnt, br, 20, 100);
        }
    }
}
