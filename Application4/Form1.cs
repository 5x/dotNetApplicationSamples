using System;
using System.Drawing;
using System.Windows.Forms;

namespace Application4 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e) {
            int a = ( this.Width - 16 ) / 2;
            int b = ( this.Height - 38 ) / 2;

            int w = this.Width % 2 == 0 ? a : a + 1;
            int h = this.Height % 2 == 0 ? b - 1 : b;

            new Rect(w, h, a, b).Draw(this.CreateGraphics());
        }
    }

    class Rect {
        private int a;
        private int b;
        private int x;
        private int y;
        private Pen p;

        public Rect(int x, int y, int a, int b) {
            this.x = x;
            this.y = y;
            this.a = a;
            this.b = b;

            p = new Pen(Color.CadetBlue, 3) {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Inset
            };
        }

        public void Draw(Graphics g) {
            g.DrawRectangle(p, new Rectangle(x, y, a, b));
        }
    }
}
