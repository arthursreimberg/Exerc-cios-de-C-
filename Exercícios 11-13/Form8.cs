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
    public partial class frmComodo : Form
    {
        public frmComodo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double larg, comp, area;
            string nome;

            larg = Convert.ToDouble(txtLarg.Text);
            comp = Convert.ToDouble(txtComp.Text);
            nome = Convert.ToString(txtName.Text);
            

            area = larg * comp;
            areaT += area;
            txtArea.Text = "A área do cômodo " + nome.ToString() + " é : " + area.ToString() + "m² ";

            var result = MessageBox.Show("Deseja continuar o cálculo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)

            {
                txtArea.Clear();
                txtLarg.Clear();
                txtComp.Clear();
                txtName.Clear();
            }
            else
            {
                lblAreaT.Visible = true;
                txtAreaT.Visible = true;
                txtAreaT.Text = "Área total:" + areaT.ToString() +"m² ";
            }
        }
        double areaT;
        private void frmComodo_Load(object sender, EventArgs e)
        {
            
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtAreaT.Clear();
            txtLarg.Clear();
            txtComp.Clear();
            txtName.Clear();
            txtLarg.Focus();

            lblAreaT.Visible = false;
            txtAreaT.Visible = false;
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
