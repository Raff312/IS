using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab5 {
    public partial class MainForm : Form {
        private Graphics graphics;
        private readonly Pen pen1;
        private readonly Pen pen2;

        public MainForm() {
            InitializeComponent();

            graphics = pictureBox.CreateGraphics();
            pen1 = new Pen(Color.Black);
            pen2 = new Pen(Color.DarkRed);
        }

        private void BtnKoh_Click(object sender, EventArgs e) {
            graphics.Clear(Color.White);

            var point1 = new PointF(200, 200);
            var point2 = new PointF(1000, 200);
            var point3 = new PointF(600, 500);

            graphics.DrawLine(pen1, point1, point2);
            graphics.DrawLine(pen1, point2, point3);
            graphics.DrawLine(pen1, point3, point1);

            KohFractal(point1, point2, point3, 5);
            KohFractal(point2, point3, point1, 5);
            KohFractal(point3, point1, point2, 5);
        }

        private int KohFractal(PointF p1, PointF p2, PointF p3, int iter) {
            if (iter <= 0) {
                return iter;
            }

            var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
            var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);

            var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
            var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);

            graphics.DrawLine(pen1, p4, pn);
            graphics.DrawLine(pen1, p5, pn);
            graphics.DrawLine(pen2, p4, p5);

            KohFractal(p4, pn, p5, iter - 1);
            KohFractal(pn, p5, p4, iter - 1);
            KohFractal(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), iter - 1);
            KohFractal(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), iter - 1);

            return iter;
        }

        private void BtnSerpinski_Click(object sender, EventArgs e) {
            graphics.Clear(Color.White);

            var carpet = new RectangleF(0, 0, pictureBox.Width, pictureBox.Height);
            DrawCarpet(5, carpet);
        }

        private void DrawCarpet(int level, RectangleF carpet) {
            if (level == 0) {
                graphics.FillRectangle(Brushes.Black, carpet);
            } else {
                var width = carpet.Width / 3f;
                var height = carpet.Height / 3f;

                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                DrawCarpet(level - 1, new RectangleF(x1, y1, width, height));
                DrawCarpet(level - 1, new RectangleF(x2, y1, width, height));
                DrawCarpet(level - 1, new RectangleF(x3, y1, width, height));
                DrawCarpet(level - 1, new RectangleF(x1, y2, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x3, y2, width, height));
                DrawCarpet(level - 1, new RectangleF(x1, y3, width, height)); 
                DrawCarpet(level - 1, new RectangleF(x2, y3, width, height));
                DrawCarpet(level - 1, new RectangleF(x3, y3, width, height));
            }
        }
    }
}
