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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTabuada_while tabuada = new frmTabuada_while();
            tabuada.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void conversãoDeCEmFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConver_while conversao = new frmConver_while();
            conversao.Show();
        }

        private void cálculoDeImóvelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmComodo comodo = new frmComodo();
            comodo.Show();
        }
    }
}
