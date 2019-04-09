using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string prev_num = "0";
        char prev_op = '+';
        bool status = false; //Initial is false, when used is true

        public Form1()
        {
            InitializeComponent();
            // Fade in
            int duration = 300;
            int steps = 30;
            Timer timer = new Timer();
            timer.Interval = duration / steps;

            int currentStep = 0;
            timer.Tick += (arg1, arg2) =>
            {
                Opacity = ((double)currentStep) / steps;
                currentStep++;

                if (currentStep >= steps)
                {
                    timer.Stop();
                    timer.Dispose();
                }
            };
            timer.Start();
        }

        private void number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btntext = button.Text;

            if (resultText.Text == "0") resultText.Text = btntext;
            else if (status && resultText.Text.Length > 0) resultText.Text = btntext;
            else resultText.Text += btntext; // Input more than one number
            status = false;
        }

        private int calculate(int left, char op,int right)
        {
            int result = 0;
            if (op == '+') result = left + right;
            else if (op == '-') result = left - right;
            else if (op == '*') result = left * right;
            else if (op == '/') result = left / right;
            return result;
        }

        private void opBtn_Click(object sender, EventArgs e)
        {
            string raw_op = ((Button)sender).Text;
            char operation = '+';
            if (raw_op == "＋") operation = '+';
            else if (raw_op == "－") operation = '-';
            else if (raw_op == "×") operation = '*';
            else if (raw_op == "÷") operation = '/';

            int result = calculate(int.Parse(prev_num), prev_op, int.Parse(resultText.Text));

            prev_op = operation;
            prev_num = result.ToString();
            status = true;
            resultText.Text = result.ToString();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            int result = calculate(int.Parse(prev_num), prev_op, int.Parse(resultText.Text));

            prev_num = "0";
            prev_op = '+';
            status = true;
            resultText.Text = result.ToString();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            prev_num = "0";
            prev_op = '+';
            status = false;
            resultText.Text = "0";
        }

        private void OpacityScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            Opacity = ((HScrollBar)sender).Value;
        }
    }
}
