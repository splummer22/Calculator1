using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        double first, second, answer;
        string function;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblEquation.Text = "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 4;
        }
        
        private void btn5_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 0;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + ".";
        }  
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(double.TryParse(txtCurrent.Text, out first))
            {
                function = "+";
                lblEquation.Text = txtCurrent.Text + function;
                txtCurrent.Clear();
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCurrent.Text, out first))
            {
                function = "-";
                lblEquation.Text = txtCurrent.Text + function;
                txtCurrent.Clear();
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCurrent.Text, out first))
            {
                function = "*";
                lblEquation.Text = txtCurrent.Text + function;
                txtCurrent.Clear();
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }
        
        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCurrent.Text, out first))
            {
                function = "/";
                lblEquation.Text = txtCurrent.Text + function;
                txtCurrent.Clear();
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }    
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrent.Clear();
            first = second = answer = 0;
            lblEquation.Text = "";
            function = "";
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtCurrent.Text, out second)) 
            {
                if (function == "+")
                {
                    answer = first + second;
                }
                else if(function == "-")
                {
                    answer = first - second;
                }
                else if (function == "/")
                {
                    answer = first / second;
                }
                else if (function == "*")
                {
                    answer = first * second;
                }

                txtCurrent.Text = "" + answer;
                lblEquation.Text = lblEquation.Text + second + "=";
            }
            else
            {
                txtCurrent.Text = "ERROR";
                lblEquation.Text = "";
            }
        }
    }
}
