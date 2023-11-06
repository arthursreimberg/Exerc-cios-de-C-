
namespace Exercícios_11_13
{
    partial class frmTabuada_for
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuada_for));
            this.btnLimpar_tab_for = new System.Windows.Forms.Button();
            this.btnCalcular_tab_for = new System.Windows.Forms.Button();
            this.txtresult_for = new System.Windows.Forms.TextBox();
            this.txtNum1_for = new System.Windows.Forms.TextBox();
            this.lblResult_for = new System.Windows.Forms.Label();
            this.lblNum_for = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.variaçõesDeCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpar_tab_for
            // 
            this.btnLimpar_tab_for.Location = new System.Drawing.Point(784, 414);
            this.btnLimpar_tab_for.Name = "btnLimpar_tab_for";
            this.btnLimpar_tab_for.Size = new System.Drawing.Size(69, 24);
            this.btnLimpar_tab_for.TabIndex = 22;
            this.btnLimpar_tab_for.Text = "Limpar";
            this.btnLimpar_tab_for.UseVisualStyleBackColor = true;
            this.btnLimpar_tab_for.Click += new System.EventHandler(this.btnLimpar_for_Click);
            // 
            // btnCalcular_tab_for
            // 
            this.btnCalcular_tab_for.Location = new System.Drawing.Point(859, 414);
            this.btnCalcular_tab_for.Name = "btnCalcular_tab_for";
            this.btnCalcular_tab_for.Size = new System.Drawing.Size(73, 24);
            this.btnCalcular_tab_for.TabIndex = 21;
            this.btnCalcular_tab_for.Text = "Calcular";
            this.btnCalcular_tab_for.UseVisualStyleBackColor = true;
            this.btnCalcular_tab_for.Click += new System.EventHandler(this.btnCalcular_for_Click);
            // 
            // txtresult_for
            // 
            this.txtresult_for.Enabled = false;
            this.txtresult_for.Location = new System.Drawing.Point(784, 194);
            this.txtresult_for.Multiline = true;
            this.txtresult_for.Name = "txtresult_for";
            this.txtresult_for.Size = new System.Drawing.Size(148, 196);
            this.txtresult_for.TabIndex = 20;
            // 
            // txtNum1_for
            // 
            this.txtNum1_for.Location = new System.Drawing.Point(784, 149);
            this.txtNum1_for.Name = "txtNum1_for";
            this.txtNum1_for.Size = new System.Drawing.Size(148, 22);
            this.txtNum1_for.TabIndex = 19;
            // 
            // lblResult_for
            // 
            this.lblResult_for.AutoSize = true;
            this.lblResult_for.Location = new System.Drawing.Point(545, 194);
            this.lblResult_for.Name = "lblResult_for";
            this.lblResult_for.Size = new System.Drawing.Size(195, 17);
            this.lblResult_for.TabIndex = 18;
            this.lblResult_for.Text = "Tabuada do número inserido:";
            // 
            // lblNum_for
            // 
            this.lblNum_for.AutoSize = true;
            this.lblNum_for.Location = new System.Drawing.Point(463, 149);
            this.lblNum_for.Name = "lblNum_for";
            this.lblNum_for.Size = new System.Drawing.Size(277, 17);
            this.lblNum_for.TabIndex = 17;
            this.lblNum_for.Text = "Digite um número para calcular a tabuada:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variaçõesDeCódigoToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1447, 28);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // variaçõesDeCódigoToolStripMenuItem
            // 
            this.variaçõesDeCódigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.códigoDoToolStripMenuItem,
            this.códigoWhileToolStripMenuItem});
            this.variaçõesDeCódigoToolStripMenuItem.Name = "variaçõesDeCódigoToolStripMenuItem";
            this.variaçõesDeCódigoToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.variaçõesDeCódigoToolStripMenuItem.Text = "Variações de Código";
            this.variaçõesDeCódigoToolStripMenuItem.Click += new System.EventHandler(this.variaçõesDeCódigoToolStripMenuItem_Click);
            // 
            // códigoDoToolStripMenuItem
            // 
            this.códigoDoToolStripMenuItem.Name = "códigoDoToolStripMenuItem";
            this.códigoDoToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.códigoDoToolStripMenuItem.Text = "Código : Do";
            this.códigoDoToolStripMenuItem.Click += new System.EventHandler(this.códigoDoToolStripMenuItem_Click);
            // 
            // códigoWhileToolStripMenuItem
            // 
            this.códigoWhileToolStripMenuItem.Name = "códigoWhileToolStripMenuItem";
            this.códigoWhileToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.códigoWhileToolStripMenuItem.Text = "Código : While";
            this.códigoWhileToolStripMenuItem.Click += new System.EventHandler(this.códigoWhileToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.voltarToolStripMenuItem.Text = "Sair";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // frmTabuada_for
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1447, 531);
            this.Controls.Add(this.btnLimpar_tab_for);
            this.Controls.Add(this.btnCalcular_tab_for);
            this.Controls.Add(this.txtresult_for);
            this.Controls.Add(this.txtNum1_for);
            this.Controls.Add(this.lblResult_for);
            this.Controls.Add(this.lblNum_for);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTabuada_for";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada : For";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar_tab_for;
        private System.Windows.Forms.Button btnCalcular_tab_for;
        private System.Windows.Forms.TextBox txtresult_for;
        private System.Windows.Forms.TextBox txtNum1_for;
        private System.Windows.Forms.Label lblResult_for;
        private System.Windows.Forms.Label lblNum_for;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variaçõesDeCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoWhileToolStripMenuItem;
    }
}