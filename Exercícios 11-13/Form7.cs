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
    public partial class frmConver_for : Form
    {
        public frmConver_for()
        {
            InitializeComponent();
        }

        private void btnCalc_conver_for_Click(object sender, EventArgs e)
        {
            double c, f;
            int I;

            c = Convert.ToDouble(txtTmp_for.Text);

            for (I = 0; I <= 100; I = I + 10)
            {
                f = c * 1.8 + 32;
                txtConver_for.Text = String.Concat(txtConver_for.Text + "\r\n" + c.ToString() + " C° " + " = " + f.ToString() + " F° ");
                c = c + 10;
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimp_conver_for_Click(object sender, EventArgs e)
        {
            txtTmp_for.Clear();
            txtConver_for.Clear();
            txtTmp_for.Focus();
        }

        private void conversãoDoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_do conversao = new frmConver_do();
            conversao.Show();
        }

        private void conversãoWhileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_while conversao = new frmConver_while();
            conversao.Show();
        }
    }
}
