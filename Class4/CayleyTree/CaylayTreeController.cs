using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public class CaylayTreeController
    {
        private Graphics graphics;
        private int n = 0;
        private double length = 0;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;
        private double per1 = 0.6;
        private double per2 = 0.7;
        private Color penColor = Color.Blue;

        public CaylayTreeController(Graphics graphics, int n, double length ,double th1, double th2, double per1, double per2, Color penColor)
        {
            this.graphics = graphics;
            this.n = n;
            this.length = length;
            this.th1 = th1;
            this.th2 = th2;
            this.per1 = per1;
            this.per2 = per2;
            this.penColor = penColor;

            this.DrawCayleyTree(n, 200, 310, length, -Math.PI / 2);
        }

        private void DrawLine(double x0, double y0, double x1, double y1)
        {
            Pen pen = new Pen(this.penColor);
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        public void DrawCayleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }
    }
}
