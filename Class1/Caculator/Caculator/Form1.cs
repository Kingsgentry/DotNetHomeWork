using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private double result = 0;
        private string operatorStr = null;
        private bool isFirstNum = true;

        private void NumBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (isFirstNum)
            {
                if (btn.Text == "0" && operatorStr == "/")
                {
                    operatorStr = null;
                    MessageBox.Show("除数不能为0");
                }
                else
                {
                    label1.Text = btn.Text;
                    isFirstNum = false;
                }
            }
            else
            {
                if (btn.Text == "0" && label1.Text == "0")
                {
                    isFirstNum = true;
                    MessageBox.Show("输入无效");
                }
                else
                    label1.Text += btn.Text;
            }

        }

        private void OperatorBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            switch (operatorStr)
            {
                case "+":
                    {
                        result += double.Parse(label1.Text);
                        label1.Text = result.ToString();
                        break;
                    }
                case "-":
                    {
                        result -= double.Parse(label1.Text);
                        label1.Text = result.ToString();
                        break;
                    }
                case "/":
                    {
                        result /= double.Parse(label1.Text);
                        label1.Text = result.ToString();
                        break;
                    }
                case "*":
                    {
                        result *= double.Parse(label1.Text);
                        label1.Text = result.ToString();
                        break;
                    }
                default:
                    result = double.Parse(label1.Text);
                    break;
            }

            operatorStr = btn.Tag.ToString();

            if (operatorStr == "c")
            {
                operatorStr = null;
                label1.Text = "0";
                result = 0;
            }

            if (operatorStr != "=")
                isFirstNum = true;
            else 
                operatorStr = null;


        }

        static void Main()
        {
            Application.Run(new Form1());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
