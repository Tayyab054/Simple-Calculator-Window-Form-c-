using System;
using System.Runtime.CompilerServices;

//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml.Linq;

namespace calculator
{
    public partial class Calculator_Form: Form
    {
       double num1 = 0;
        double num2 = 0;
        double result = 0;
        string option = "";

        public Calculator_Form()
        {
            InitializeComponent();
        }
       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Calculator_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn_9.Text;
        }

        private void but_8_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn_8.Text;

        }

        private void but_7_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn_7.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn_6.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn5.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn4.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn2.Text;
           

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn1.Text;
         

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt_Display.Text = txt_Display.Text + btn0.Text;
          

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txt_Display.Text);
            txt_Display.Clear();

            //txt_Display.Text = txt_Display.Text + btnPlus.Text;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txt_Display.Text);
            txt_Display.Clear();

            // txt_Display.Text = txt_Display.Text + btnMinus.Text;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txt_Display.Text);
            txt_Display.Clear();

            // txt_Display.Text = txt_Display.Text + btnMultiply.Text;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txt_Display.Text);
            txt_Display.Clear();
            // txt_Display.Text = txt_Display.Text + btnDivide.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txt_Display.Text);
            if (option == "+")
            {
                result = num1 + num2;
            }
            else if(option=="-")
            {
                result=num1- num2;
            }
            else if (option == "*")
            {
                result = num1 * num2;
            }
            else if (option == "/")
            {
                result = num1 / num2;
            }
            txt_Display.Text = result + "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txt_Display.Text = "";
        }
    }
}
