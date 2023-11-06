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
    public partial class frmTabuada_while : Form
    {
        public frmTabuada_while()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, I, R;
            num1 = Convert.ToDouble(txtNum1_Tabuada.Text);

            I = 1;
            while (I <= 10)
            {
                R = num1 * I;
                txtresult.Text = String.Concat(txtresult.Text + "\r\n" + num1.ToString() + " X " + I.ToString() + " = " + R.ToString());
                I++;
            }
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabuadaForToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void tabuadaDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_do tabuada = new frmTabuada_do();
            tabuada.Show();
        }

        private void btnLimpar_tabuada_Click(object sender, EventArgs e)
        {
            txtNum1_Tabuada.Clear();
            txtresult.Clear();
            txtNum1_Tabuada.Focus();
        }

        private void tabuadaForToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_for tabuada = new frmTabuada_for();
            tabuada.Show();
        }
    }
}
