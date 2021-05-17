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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            timer1.Start();
        }
        Random r = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            Ukras u = new Ukras(r.Next(ClientRectangle.Width), r.Next(ClientRectangle.Height), r.Next(20, 50), Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            Graphics g = CreateGraphics();
            u.Crtaj(g);
        }
    }
}
