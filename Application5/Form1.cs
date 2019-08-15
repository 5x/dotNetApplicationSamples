using System;
using System.Drawing;
using System.Windows.Forms;

namespace Application5 {
    public partial class Form1 : Form {
        private int tick;
        private int numOfImages;
        private int currentImageLeftShift;
        private bool flip;

        public Form1() {
            InitializeComponent();

            currentImageLeftShift = -5;
            numOfImages = 4;
            tick = 0;
            flip = false;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            timer1.Interval = trackBar1.Value;
            pictureBox1.Image = imageList1.Images[tick];

            int currentInitialXPosition = pictureBox1.Left;
            int maxInitialXPosition = Width - pictureBox1.Width - 16;

            if ( currentInitialXPosition < 0 || currentInitialXPosition > maxInitialXPosition ) {
                currentImageLeftShift *= -1;
                flip = !flip;
                pictureBox1.Left = currentInitialXPosition >= 0 ? maxInitialXPosition : 0;
            }

            pictureBox1.Left += currentImageLeftShift;
            label3.Left = pictureBox1.Left;

            if ( flip ) {
                pictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }

            tick++;

            if ( tick >= numOfImages ) {
                tick = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            label3.Text = textBox1.Text;
        }
    }
}
