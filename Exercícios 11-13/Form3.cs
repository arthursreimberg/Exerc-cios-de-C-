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
    public partial class frmTabuada_for : Form
    {
        public frmTabuada_for()
        {
            InitializeComponent();
        }

        private void btnCalcular_for_Click(object sender, EventArgs e)
        {
            double num1, result, I;
            num1 = Convert.ToDouble(txtNum1_for.Text);
            I = 1;

            for (I = 1; I <= 10; I++)
            {
                result = num1 * I;
                txtresult_for.Text = String.Concat(txtresult_for.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + result.ToString());
            }
        }

        private void btnLimpar_for_Click(object sender, EventArgs e)
        {
            txtNum1_for.Clear();
            txtresult_for.Clear();
            txtNum1_for.Focus();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void variaçõesDeCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void códigoWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_while tabuada = new frmTabuada_while();
            tabuada.Show();
        }

        private void códigoDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_do tabuada = new frmTabuada_do();
            tabuada.Show();
        }
    }
}
