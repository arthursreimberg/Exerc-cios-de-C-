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
    public partial class frmConver_do : Form
    {
        public frmConver_do()
        {
            InitializeComponent();
        }

        private void btnCalc_conver_do_Click(object sender, EventArgs e)
        {
            double c, f, I;
            c = Convert.ToDouble(txtTmp_do.Text);
            I = 0;
            do
            {
                f = c * 1.8 + 32;
                txtConver_do.Text = String.Concat(txtConver_do.Text + "\r\n" + c.ToString() + " C° " + " = " + f.ToString() + " F° ");
                c = c + 10;
                I = I + 10;
            } while (I <= 100);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimp_conver_do_Click(object sender, EventArgs e)
        {
            txtConver_do.Clear();
            txtTmp_do.Clear();
            txtTmp_do.Focus();
        }

        private void códigoForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_for conversao = new frmConver_for();
            conversao.Show();
        }

        private void códigoWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_while conversao = new frmConver_while();
            conversao.Show();
        }
    }
}
