namespace Application3 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.info = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(12, 13);
            this.info.Size = new System.Drawing.Size(244, 39);
            this.info.Text = "Enter the values of triangle side in the fields.\n" +
                             "A comma is used to separate the integer and\n" +
                             "fractional parts.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 55);
            this.textBox1.Size = new System.Drawing.Size(120, 20);
            this.textBox1.MaxLength = 12;
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "a: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 55);
            this.textBox2.MaxLength = 12;
            this.textBox2.Size = new System.Drawing.Size(120, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "b: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 109);
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.Text = "Enter the values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 109);
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.Text = "\"а\" and \"b\"";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(12, 81);
            this.button.Size = new System.Drawing.Size(246, 24);
            this.button.TabIndex = 3;
            this.button.Text = "Calculate";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(270, 131);
            this.Controls.Add(this.info);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Triangle Calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label info;
    }
}

