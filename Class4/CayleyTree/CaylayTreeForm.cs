using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class CaylayTreeForm : Form
    {
        private Graphics graphics;
        private Color penColor;

        public CaylayTreeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(N_TB.Text, out int n))
                throw new ArgumentException("n input error");

            if (!double.TryParse(Length_TB.Text, out double length))
                throw new ArgumentException("lenght input error");

            if (!double.TryParse(Per1_TB.Text, out double per1 ))
                throw new ArgumentException("per1 input error");

            if (!double.TryParse(Per2_TB.Text, out double per2))
                throw new ArgumentException("per2 input error");

            if (!double.TryParse(th1_TB.Text, out double th1))
                throw new ArgumentException("th1 input error");

            if (!double.TryParse(th1_TB.Text, out double th2))
                throw new ArgumentException("th2 input error");

            if (graphics == null)
                graphics = panel1.CreateGraphics();
            else
                graphics.Clear(Color.White);
            CaylayTreeController caylayTreeController = new CaylayTreeController(graphics, n, length, th1 * Math.PI / 180, th2 * Math.PI / 180, per1, per2, penColor);

        }

        public static void Main()
        {
            Application.Run(new CaylayTreeForm());
        }

        private void Color_Btn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.penColor = colorDialog1.Color;
                Color_Btn.BackColor = colorDialog1.Color;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
