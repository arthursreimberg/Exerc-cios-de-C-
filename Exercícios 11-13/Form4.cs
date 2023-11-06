using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercícios_11_13
{
    public partial class frmTabuada_do : Form
    {
        public frmTabuada_do()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_do_Click(object sender, EventArgs e)
        {
            double num1, result, I;
            num1 = Convert.ToDouble(txtNum1_do.Text);
            I = 1;
            do
            {
                result = num1 * I;
                txtresult_do.Text = String.Concat(txtresult_do.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + result.ToString());
                I++;

            } while (I <= 10);
        }

        private void btnLimpar_do_Click(object sender, EventArgs e)
        {
            txtNum1_do.Clear();
            txtresult_do.Clear();
            txtNum1_do.Focus();
        }

        private void códigoForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_for tabuada = new frmTabuada_for();
            tabuada.Show();
        }

        private void códigoWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_while tabuada = new frmTabuada_while();
            tabuada.Show();
        }
    }
}
