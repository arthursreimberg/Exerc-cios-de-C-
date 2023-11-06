
namespace Exercícios_11_13
{
    partial class frmConver_for
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConver_for));
            this.btnLimp_conver_for = new System.Windows.Forms.Button();
            this.btnCalc_conver_for = new System.Windows.Forms.Button();
            this.txtConver_for = new System.Windows.Forms.TextBox();
            this.txtTmp_for = new System.Windows.Forms.TextBox();
            this.lblConver_for = new System.Windows.Forms.Label();
            this.lblTmp_for = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.variaçõesDeCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimp_conver_for
            // 
            this.btnLimp_conver_for.Location = new System.Drawing.Point(723, 408);
            this.btnLimp_conver_for.Name = "btnLimp_conver_for";
            this.btnLimp_conver_for.Size = new System.Drawing.Size(75, 28);
            this.btnLimp_conver_for.TabIndex = 17;
            this.btnLimp_conver_for.Text = "Limpar";
            this.btnLimp_conver_for.UseVisualStyleBackColor = true;
            this.btnLimp_conver_for.Click += new System.EventHandler(this.btnLimp_conver_for_Click);
            // 
            // btnCalc_conver_for
            // 
            this.btnCalc_conver_for.Location = new System.Drawing.Point(902, 408);
            this.btnCalc_conver_for.Name = "btnCalc_conver_for";
            this.btnCalc_conver_for.Size = new System.Drawing.Size(75, 28);
            this.btnCalc_conver_for.TabIndex = 16;
            this.btnCalc_conver_for.Text = "Calcular";
            this.btnCalc_conver_for.UseVisualStyleBackColor = true;
            this.btnCalc_conver_for.Click += new System.EventHandler(this.btnCalc_conver_for_Click);
            // 
            // txtConver_for
            // 
            this.txtConver_for.Enabled = false;
            this.txtConver_for.Location = new System.Drawing.Point(723, 181);
            this.txtConver_for.Multiline = true;
            this.txtConver_for.Name = "txtConver_for";
            this.txtConver_for.Size = new System.Drawing.Size(254, 211);
            this.txtConver_for.TabIndex = 15;
            // 
            // txtTmp_for
            // 
            this.txtTmp_for.Location = new System.Drawing.Point(723, 115);
            this.txtTmp_for.Name = "txtTmp_for";
            this.txtTmp_for.Size = new System.Drawing.Size(254, 22);
            this.txtTmp_for.TabIndex = 14;
            // 
            // lblConver_for
            // 
            this.lblConver_for.AutoSize = true;
            this.lblConver_for.Location = new System.Drawing.Point(468, 181);
            this.lblConver_for.Name = "lblConver_for";
            this.lblConver_for.Size = new System.Drawing.Size(230, 17);
            this.lblConver_for.TabIndex = 13;
            this.lblConver_for.Text = "Conversão da temperatura insirida:";
            // 
            // lblTmp_for
            // 
            this.lblTmp_for.AutoSize = true;
            this.lblTmp_for.Location = new System.Drawing.Point(386, 118);
            this.lblTmp_for.Name = "lblTmp_for";
            this.lblTmp_for.Size = new System.Drawing.Size(308, 17);
            this.lblTmp_for.TabIndex = 12;
            this.lblTmp_for.Text = "Insira a temperatura em Celsius para o cálculo: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variaçõesDeCódigoToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1457, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // variaçõesDeCódigoToolStripMenuItem
            // 
            this.variaçõesDeCódigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conversãoDoToolStripMenuItem,
            this.conversãoWhileToolStripMenuItem});
            this.variaçõesDeCódigoToolStripMenuItem.Name = "variaçõesDeCódigoToolStripMenuItem";
            this.variaçõesDeCódigoToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.variaçõesDeCódigoToolStripMenuItem.Text = "Variações de Código";
            // 
            // conversãoDoToolStripMenuItem
            // 
            this.conversãoDoToolStripMenuItem.Name = "conversãoDoToolStripMenuItem";
            this.conversãoDoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.conversãoDoToolStripMenuItem.Text = "Conversão : Do";
            this.conversãoDoToolStripMenuItem.Click += new System.EventHandler(this.conversãoDoToolStripMenuItem_Click);
            // 
            // conversãoWhileToolStripMenuItem
            // 
            this.conversãoWhileToolStripMenuItem.Name = "conversãoWhileToolStripMenuItem";
            this.conversãoWhileToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.conversãoWhileToolStripMenuItem.Text = "Conversão: While";
            this.conversãoWhileToolStripMenuItem.Click += new System.EventHandler(this.conversãoWhileToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.voltarToolStripMenuItem.Text = "Sair";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // frmConver_for
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SpringGreen;
            this.ClientSize = new System.Drawing.Size(1457, 531);
            this.Controls.Add(this.btnLimp_conver_for);
            this.Controls.Add(this.btnCalc_conver_for);
            this.Controls.Add(this.txtConver_for);
            this.Controls.Add(this.txtTmp_for);
            this.Controls.Add(this.lblConver_for);
            this.Controls.Add(this.lblTmp_for);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConver_for";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de C° para F° : For";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimp_conver_for;
        private System.Windows.Forms.Button btnCalc_conver_for;
        private System.Windows.Forms.TextBox txtConver_for;
        private System.Windows.Forms.TextBox txtTmp_for;
        private System.Windows.Forms.Label lblConver_for;
        private System.Windows.Forms.Label lblTmp_for;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variaçõesDeCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoWhileToolStripMenuItem;
    }
}