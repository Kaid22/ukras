using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a = 20;
        Random r = new Random();
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Color boja = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Ukras u = new Ukras(e.X, e.Y, a,boja);
            ukrasi.Add(u);
            Refresh();
        }
        List<Ukras> ukrasi = new List<Ukras>();
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ukras ukras in ukrasi)
            {
                ukras.Crtaj(e.Graphics);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Ukras ukras in ukrasi)
            {
                ukras.Povecaj(2);
            }
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
