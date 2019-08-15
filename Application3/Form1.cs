using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Application3 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            string numericPattern = @"(\d+,\d+)|(\d+)";

            string a = Regex.Match(textBox1.Text, numericPattern).Value;
            string b = Regex.Match(textBox2.Text, numericPattern).Value;

            if ( a.Length > 0 && b.Length > 0 ) {
                double A = double.Parse(a);
                double B = double.Parse(b);
                double C = 0;

                if ( A < B ) {
                    C = B;
                    B = A;
                    A = C;
                }

                C = Math.Sqrt(A * A - B * B);

                if ( C > 0 && A > 0 && B > 0 ) {
                    label1.Text = "c: " + C;
                    label2.Text = "S: " + ( B + C ) * 0.5D;
                } else {
                    label1.Text = "Can't Build!";
                    label2.Text = null;
                }
            } else {
                label1.Text = "Incorrect input values.";
                label2.Text = null;
            }
        }
    }
}
