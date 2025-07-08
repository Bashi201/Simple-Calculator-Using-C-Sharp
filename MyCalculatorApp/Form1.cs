using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    public partial class Form1 : Form
    {
        String operation = "";
        double result_Value = 0;
        bool is_Operation_Performed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (tb_Result.Text == "0" || is_Operation_Performed)
            {
                tb_Result.Clear();
            }

            Button btn = (Button)sender;

            if (btn.Text == ".")
            {
                if (!tb_Result.Text.Contains("."))
                {
                    tb_Result.Text = tb_Result.Text + btn.Text;
                }
            }
            else
            {
                tb_Result.Text = tb_Result.Text + btn.Text;
            }
            is_Operation_Performed = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operation_Performed(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            result_Value = double.Parse(tb_Result.Text);
            lb_Result.Text = result_Value + operation; // Show first operand and operation
            tb_Result.Text = "0"; // Reset text box for the second operand
            is_Operation_Performed = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
            lb_Result.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tb_Result.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double secondOperand = double.Parse(tb_Result.Text);
            lb_Result.Text = lb_Result.Text + secondOperand; // Append second operand to label

            switch (operation)
            {
                case "+":
                    tb_Result.Text = (result_Value + secondOperand).ToString();
                    break;
                case "-":
                    tb_Result.Text = (result_Value - secondOperand).ToString();
                    break;
                case "*":
                    tb_Result.Text = (result_Value * secondOperand).ToString();
                    break;
                case "/":
                    tb_Result.Text = (result_Value / secondOperand).ToString();
                    break;
            }
            operation = ""; // Reset operation after calculation
            is_Operation_Performed = true;
        }
    }
}