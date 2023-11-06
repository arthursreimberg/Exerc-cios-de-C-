
namespace Exercícios_11_13
{
    partial class frmComodo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComodo));
            this.lblLargura = new System.Windows.Forms.Label();
            this.txtLarg = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCompri = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblAreaT = new System.Windows.Forms.Label();
            this.txtAreaT = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(443, 145);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(267, 17);
            this.lblLargura.TabIndex = 0;
            this.lblLargura.Text = "Digite a largura do seu cômodo (metros):";
            // 
            // txtLarg
            // 
            this.txtLarg.Location = new System.Drawing.Point(731, 140);
            this.txtLarg.Name = "txtLarg";
            this.txtLarg.Size = new System.Drawing.Size(100, 22);
            this.txtLarg.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(752, 414);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(79, 31);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCompri
            // 
            this.lblCompri.AutoSize = true;
            this.lblCompri.Location = new System.Drawing.Point(407, 186);
            this.lblCompri.Name = "lblCompri";
            this.lblCompri.Size = new System.Drawing.Size(303, 17);
            this.lblCompri.TabIndex = 4;
            this.lblCompri.Text = "Digite o comprimento do seu cômodo (metros):";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(537, 239);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(173, 17);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Digite o nome do cômodo:";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Location = new System.Drawing.Point(594, 293);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(116, 17);
            this.LblArea.TabIndex = 6;
            this.LblArea.Text = "Área do cômodo:";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(731, 186);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(100, 22);
            this.txtComp.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(731, 236);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(731, 290);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(310, 22);
            this.txtArea.TabIndex = 9;
            this.txtArea.TextChanged += new System.EventHandler(this.txtArea_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(605, 414);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(79, 31);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblAreaT
            // 
            this.lblAreaT.AutoSize = true;
            this.lblAreaT.Location = new System.Drawing.Point(632, 345);
            this.lblAreaT.Name = "lblAreaT";
            this.lblAreaT.Size = new System.Drawing.Size(73, 17);
            this.lblAreaT.TabIndex = 12;
            this.lblAreaT.Text = "Área total:";
            this.lblAreaT.Visible = false;
            // 
            // txtAreaT
            // 
            this.txtAreaT.Enabled = false;
            this.txtAreaT.Location = new System.Drawing.Point(731, 342);
            this.txtAreaT.Name = "txtAreaT";
            this.txtAreaT.Size = new System.Drawing.Size(168, 22);
            this.txtAreaT.TabIndex = 13;
            this.txtAreaT.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1452, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmComodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1452, 529);
            this.Controls.Add(this.txtAreaT);
            this.Controls.Add(this.lblAreaT);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.LblArea);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCompri);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtLarg);
            this.Controls.Add(this.lblLargura);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmComodo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular área";
            this.Load += new System.EventHandler(this.frmComodo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.TextBox txtLarg;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblCompri;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label LblArea;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblAreaT;
        private System.Windows.Forms.TextBox txtAreaT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}