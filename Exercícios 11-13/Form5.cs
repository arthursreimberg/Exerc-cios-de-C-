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
    public partial class frmConver_while : Form
    {
        public frmConver_while()
        {
            InitializeComponent();
        }

        private void frmConver_while_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_conver_while_Click(object sender, EventArgs e)
        {
            double c, f, I;
            c = Convert.ToDouble(txtTmp_while.Text);
            I = 0;
            while (I <= 100)
            {
                f = (c * 1.8 + 32);
                txtConver_while.Text = String.Concat(txtConver_while.Text + "\r\n" + c.ToString() + " C° " + " = " + f.ToString() + " F° ");
                c = c + 10;
                I = I + 10;
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void voltarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void converçãoDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_do conversao = new frmConver_do();
            conversao.Show();
        }

        private void conversãoForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_for conversao = new frmConver_for();
            conversao.Show();
        }

        private void btnLimp_conver_while_Click(object sender, EventArgs e)
        {
            txtTmp_while.Clear();
            txtConver_while.Clear();
            txtTmp_while.Focus();
        }

        private void ttToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
