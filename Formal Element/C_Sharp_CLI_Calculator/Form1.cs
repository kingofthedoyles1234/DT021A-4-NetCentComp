using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SquareClient;

namespace C_Sharp_CLI_Calculator
{
    public partial class Form1 : Form
    {
        bool firstFlag;
        bool firstDec;
        bool add;
        bool sub;
        bool div;
        bool multiply;
        double runningTotal = 0;
        double newVal = 0;
        public Form1()
        {
            InitializeComponent();
            firstFlag = true;
            firstDec = true;
            add = false;
            sub = false;
            multiply = false;
            div = false;
        }

        private void T_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zero_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "0";
                firstFlag = false;
            }
            else
                T.Text += "0";
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "1";
                firstFlag = false;
            }
            else
                T.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "2";
                firstFlag = false;
            }
            else
                T.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "3";
                firstFlag = false;
            }
            else
                T.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "4";
                firstFlag = false;
            }
            else
                T.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "5";
                firstFlag = false;
            }
            else
                T.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "6";
                firstFlag = false;
            }
            else
                T.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "7";
                firstFlag = false;
            }
            else
                T.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "8";
                firstFlag = false;
            }
            else
                T.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "9";
                firstFlag = false;
            }
            else
                T.Text += "9";
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            if (firstFlag)
            {
                T.Text = "0.";
                firstFlag = false;
                firstDec = false;
            }
            else if (firstDec)
            {
                T.Text += ".";
                firstDec = false;
            }
        }

        private void Calc_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                if (T.Text != "")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal + newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
                else
                {
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
            }
            if (sub == true)
            {
                if (T.Text != "")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal - newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
                else
                {
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
            }
            if (multiply == true)
            {
                if (T.Text != "")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal * newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
                else
                {
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
            }
            if (div == true)
            {
                if (T.Text != "" && T.Text != "0")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal/newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
                else
                {
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = false;
                }
            }
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (add == false && sub == false && multiply == false && div == false)
            {
                runningTotal = Convert.ToDouble(T.Text);
                firstFlag = true;
                firstDec = true;
                add = true;
                sub = false;
                multiply = false;
                div = false;
            }
            else if (add == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal + newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = true;
                sub = false;
                multiply = false;
                div = false;
            }
            else if (sub == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal - newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = true;
                sub = false;
                multiply = false;
                div = false;
            }
            else if (multiply == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal * newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = true;
                sub = false;
                multiply = false;
                div = false;
            }
            else if (div == true)
            {
                if (T.Text != "" && T.Text != "0")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal / newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = true;
                    sub = false;
                    multiply = false;
                    div = false;
                }
            }
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (add == false && sub == false && multiply == false && div == false)
            {
                runningTotal = Convert.ToDouble(T.Text);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = true;
                multiply = false;
                div = false;
            }
            else if (add == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal + newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = true;
                multiply = false;
                div = false;
            }
            else if (sub == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal - newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = true;
                multiply = false;
                div = false;
            }
            else if (multiply == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal * newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = true;
                multiply = false;
                div = false;
            }
            else if (div == true)
            {
                if (T.Text != "" && T.Text != "0")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal / newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = true;
                    multiply = false;
                    div = false;
                }
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            if (add == false && sub == false && multiply == false && div == false)
            {
                runningTotal = Convert.ToDouble(T.Text);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = true;
                div = false;
            }
            else if (add == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal + newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = true;
                div = false;
            }
            else if (sub == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal - newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = true;
                div = false;
            }
            else if (multiply == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal * newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = true;
                div = false;
            }
            else if (div == true)
            {
                if (T.Text != "" && T.Text != "0")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal / newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = true;
                    div = false;
                }
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            if (add == false && sub == false && multiply == false && div == false)
            {
                runningTotal = Convert.ToDouble(T.Text);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = false;
                div = true;
            }
            else if (add == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal + newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = false;
                div = true;
            }
            else if (sub == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal - newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = false;
                div = true;
            }
            else if (multiply == true)
            {
                newVal = Convert.ToDouble(T.Text);
                runningTotal = runningTotal * newVal;
                newVal = 0;
                T.Text = Convert.ToString(runningTotal);
                firstFlag = true;
                firstDec = true;
                add = false;
                sub = false;
                multiply = false;
                div = true;
            }
            else if (div == true)
            {
                if(T.Text !="" && T.Text !="0")
                {
                    newVal = Convert.ToDouble(T.Text);
                    runningTotal = runningTotal / newVal;
                    newVal = 0;
                    T.Text = Convert.ToString(runningTotal);
                    firstFlag = true;
                    firstDec = true;
                    add = false;
                    sub = false;
                    multiply = false;
                    div = true;
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            T.Text = "0";
            firstFlag = true;
            firstDec = true;
            add = false;
            sub = false;
            multiply = false;
            div = false;
            runningTotal = 0;
            newVal = 0;
        }

        private void Square_Click(object sender, EventArgs e)
        {
            ColmSquareClient gRPC = new ColmSquareClient();
            newVal = Convert.ToDouble(T.Text);
            runningTotal = gRPC.getSquare(newVal);
            newVal = 0;
            T.Text = Convert.ToString(runningTotal);
            firstFlag = true;
            firstDec = true;
            add = false;
            sub = false;
            multiply = false;
            div = false;
        }
    }
}
