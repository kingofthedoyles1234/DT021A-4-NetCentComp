namespace C_Sharp_CLI_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.T = new System.Windows.Forms.TextBox();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.calc = new System.Windows.Forms.Button();
            this.square = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // T
            // 
            this.T.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T.Location = new System.Drawing.Point(14, 15);
            this.T.Multiline = true;
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(462, 47);
            this.T.TabIndex = 0;
            this.T.Text = "0";
            this.T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.T.TextChanged += new System.EventHandler(this.T_TextChanged);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(14, 97);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(74, 82);
            this.seven.TabIndex = 2;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(111, 97);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(74, 82);
            this.eight.TabIndex = 3;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(210, 97);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(74, 82);
            this.nine.TabIndex = 4;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(306, 97);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(170, 82);
            this.clear.TabIndex = 6;
            this.clear.Text = "AC";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(402, 202);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(74, 82);
            this.divide.TabIndex = 11;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // mult
            // 
            this.mult.Location = new System.Drawing.Point(306, 202);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(74, 82);
            this.mult.TabIndex = 10;
            this.mult.Text = "X";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.Mult_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.six.Location = new System.Drawing.Point(210, 202);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(74, 82);
            this.six.TabIndex = 9;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.Six_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.five.Location = new System.Drawing.Point(111, 202);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(74, 82);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.Five_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.four.Location = new System.Drawing.Point(14, 202);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(74, 82);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.Four_Click);
            // 
            // calc
            // 
            this.calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.calc.Location = new System.Drawing.Point(306, 409);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(170, 82);
            this.calc.TabIndex = 21;
            this.calc.Text = "=";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.Calc_Click);
            // 
            // square
            // 
            this.square.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.square.Location = new System.Drawing.Point(210, 409);
            this.square.Name = "square";
            this.square.Size = new System.Drawing.Size(74, 82);
            this.square.TabIndex = 19;
            this.square.Text = "X^2";
            this.square.UseVisualStyleBackColor = true;
            this.square.Click += new System.EventHandler(this.Square_Click);
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.dec.Location = new System.Drawing.Point(111, 409);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(74, 82);
            this.dec.TabIndex = 18;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.zero.Location = new System.Drawing.Point(14, 409);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(74, 82);
            this.zero.TabIndex = 17;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(402, 305);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(74, 82);
            this.minus.TabIndex = 16;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.plus.Location = new System.Drawing.Point(306, 305);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(74, 82);
            this.plus.TabIndex = 15;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.three.Location = new System.Drawing.Point(210, 305);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(74, 82);
            this.three.TabIndex = 14;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.Three_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.two.Location = new System.Drawing.Point(111, 305);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(74, 82);
            this.two.TabIndex = 13;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.Two_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.one.Location = new System.Drawing.Point(14, 305);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(74, 82);
            this.one.TabIndex = 12;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.One_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 82);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Seven_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(109, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 82);
            this.button2.TabIndex = 3;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Eight_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(208, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 82);
            this.button3.TabIndex = 4;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Nine_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(304, 97);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 82);
            this.button4.TabIndex = 6;
            this.button4.Text = "AC";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(304, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(74, 82);
            this.button5.TabIndex = 10;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Mult_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(400, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(74, 82);
            this.button6.TabIndex = 11;
            this.button6.Text = "/";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Divide_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.button7.Location = new System.Drawing.Point(400, 305);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(74, 82);
            this.button7.TabIndex = 16;
            this.button7.Text = "-";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 514);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.square);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.T);
            this.Name = "Form1";
            this.Text = "C_Sharp_Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox T;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Button square;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}

