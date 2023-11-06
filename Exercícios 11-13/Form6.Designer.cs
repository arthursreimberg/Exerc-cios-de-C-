
namespace Exercícios_11_13
{
    partial class frmConver_do
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConver_do));
            this.btnLimp_conver_do = new System.Windows.Forms.Button();
            this.btnCalc_conver_do = new System.Windows.Forms.Button();
            this.txtConver_do = new System.Windows.Forms.TextBox();
            this.txtTmp_do = new System.Windows.Forms.TextBox();
            this.lblConver_do = new System.Windows.Forms.Label();
            this.lblTmp_do = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.variaçõesDeCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimp_conver_do
            // 
            this.btnLimp_conver_do.Location = new System.Drawing.Point(689, 440);
            this.btnLimp_conver_do.Name = "btnLimp_conver_do";
            this.btnLimp_conver_do.Size = new System.Drawing.Size(75, 28);
            this.btnLimp_conver_do.TabIndex = 11;
            this.btnLimp_conver_do.Text = "Limpar";
            this.btnLimp_conver_do.UseVisualStyleBackColor = true;
            this.btnLimp_conver_do.Click += new System.EventHandler(this.btnLimp_conver_do_Click);
            // 
            // btnCalc_conver_do
            // 
            this.btnCalc_conver_do.Location = new System.Drawing.Point(868, 440);
            this.btnCalc_conver_do.Name = "btnCalc_conver_do";
            this.btnCalc_conver_do.Size = new System.Drawing.Size(75, 28);
            this.btnCalc_conver_do.TabIndex = 10;
            this.btnCalc_conver_do.Text = "Calcular";
            this.btnCalc_conver_do.UseVisualStyleBackColor = true;
            this.btnCalc_conver_do.Click += new System.EventHandler(this.btnCalc_conver_do_Click);
            // 
            // txtConver_do
            // 
            this.txtConver_do.Enabled = false;
            this.txtConver_do.Location = new System.Drawing.Point(689, 213);
            this.txtConver_do.Multiline = true;
            this.txtConver_do.Name = "txtConver_do";
            this.txtConver_do.Size = new System.Drawing.Size(254, 211);
            this.txtConver_do.TabIndex = 9;
            // 
            // txtTmp_do
            // 
            this.txtTmp_do.Location = new System.Drawing.Point(689, 147);
            this.txtTmp_do.Name = "txtTmp_do";
            this.txtTmp_do.Size = new System.Drawing.Size(254, 22);
            this.txtTmp_do.TabIndex = 8;
            // 
            // lblConver_do
            // 
            this.lblConver_do.AutoSize = true;
            this.lblConver_do.Location = new System.Drawing.Point(434, 213);
            this.lblConver_do.Name = "lblConver_do";
            this.lblConver_do.Size = new System.Drawing.Size(230, 17);
            this.lblConver_do.TabIndex = 7;
            this.lblConver_do.Text = "Conversão da temperatura insirida:";
            // 
            // lblTmp_do
            // 
            this.lblTmp_do.AutoSize = true;
            this.lblTmp_do.Location = new System.Drawing.Point(352, 150);
            this.lblTmp_do.Name = "lblTmp_do";
            this.lblTmp_do.Size = new System.Drawing.Size(308, 17);
            this.lblTmp_do.TabIndex = 6;
            this.lblTmp_do.Text = "Insira a temperatura em Celsius para o cálculo: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variaçõesDeCódigoToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1458, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // variaçõesDeCódigoToolStripMenuItem
            // 
            this.variaçõesDeCódigoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.códigoForToolStripMenuItem,
            this.códigoWhileToolStripMenuItem});
            this.variaçõesDeCódigoToolStripMenuItem.Name = "variaçõesDeCódigoToolStripMenuItem";
            this.variaçõesDeCódigoToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.variaçõesDeCódigoToolStripMenuItem.Text = "Variações de Código";
            // 
            // códigoForToolStripMenuItem
            // 
            this.códigoForToolStripMenuItem.Name = "códigoForToolStripMenuItem";
            this.códigoForToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.códigoForToolStripMenuItem.Text = "Código : For";
            this.códigoForToolStripMenuItem.Click += new System.EventHandler(this.códigoForToolStripMenuItem_Click);
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
            // frmConver_do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1458, 546);
            this.Controls.Add(this.btnLimp_conver_do);
            this.Controls.Add(this.btnCalc_conver_do);
            this.Controls.Add(this.txtConver_do);
            this.Controls.Add(this.txtTmp_do);
            this.Controls.Add(this.lblConver_do);
            this.Controls.Add(this.lblTmp_do);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConver_do";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de C° para F° : Do";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimp_conver_do;
        private System.Windows.Forms.Button btnCalc_conver_do;
        private System.Windows.Forms.TextBox txtConver_do;
        private System.Windows.Forms.TextBox txtTmp_do;
        private System.Windows.Forms.Label lblConver_do;
        private System.Windows.Forms.Label lblTmp_do;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variaçõesDeCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoWhileToolStripMenuItem;
    }
}