using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CS期末作业
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void butnOK_Click(object sender, EventArgs e)
        {
            int M = Convert.ToInt32(txtBoxM.Text);
            int T = Convert.ToInt32(txtBoxT.Text);
            double Pc = Convert.ToDouble(txtBoxPc.Text);
            double Pm = Convert.ToDouble(txtBoxPm.Text);
            GeneticAlgorithm test = new GeneticAlgorithm(M, T, Pc, Pm);
            double[] input =  test.Solveproblem();
            txtBoxX1.Text = Convert.ToString(input[0]);
            txtBoxX2.Text = Convert.ToString(input[1]);
            txtBoxAns.Text = Convert.ToString(input[2]);
        }

        private void butnCancle_Click(object sender, EventArgs e)
        {
           txtBoxM.Text = "";
           txtBoxT.Text = "";
           txtBoxPc.Text = "";
           txtBoxPm.Text = "";
        }

    }
}
