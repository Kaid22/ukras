using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ukras
{
    class Ukras
    {
        int a, x, y;
        int b;
        public Color boja;
        Random r = new Random();
        public Ukras(int x,int y,int a,Color boja)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.boja = boja;
        }
        public void Povecaj(int b)
        {
            a += b;
        }
        public void Crtaj(Graphics g)
        {
            
            Pen pen = new Pen(boja, 3);
            Pen pen2 = new Pen(Color.Black, 3);
            Brush brush1 = new SolidBrush(boja);
            Brush brush2 = new SolidBrush(Color.Black);
            g.DrawEllipse(pen, x - a, y - a, 2 * a, 2 * a);
            g.FillEllipse(brush1, x - a, y - a, 2 * a, 2 * a);
            g.DrawRectangle(pen2, x - a / 6, y - (7 * a) / 6, a / 3, ((7 * a) / 6) - a);
            g.FillRectangle(brush2, x - a / 6, y - (7 * a) / 6, a / 3, ((7 * a) / 6) - a);
            g.DrawEllipse(pen, x - a / 3, y - (13 * a) / 6, 2 * a / 3, (13 * a) / 6 - (7 * a) / 6);


        }
    }
}
