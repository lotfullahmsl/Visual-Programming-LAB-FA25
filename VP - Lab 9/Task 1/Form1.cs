using System;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            // Show color dialog and apply color to label
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                lblVisualProgramming.ForeColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Nothing needed here
        }
    }
}
