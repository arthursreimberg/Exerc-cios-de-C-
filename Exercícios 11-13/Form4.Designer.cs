
namespace Exercícios_11_13
{
    partial class frmTabuada_do
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuada_do));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.variaçõesDeCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoWhileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpar_tab_do = new System.Windows.Forms.Button();
            this.btnCalcular_tab_do = new System.Windows.Forms.Button();
            this.txtresult_do = new System.Windows.Forms.TextBox();
            this.txtNum1_do = new System.Windows.Forms.TextBox();
            this.lblResult_do = new System.Windows.Forms.Label();
            this.lblNum_do = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variaçõesDeCódigoToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1453, 28);
            this.menuStrip1.TabIndex = 10;
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
            // btnLimpar_tab_do
            // 
            this.btnLimpar_tab_do.Location = new System.Drawing.Point(748, 402);
            this.btnLimpar_tab_do.Name = "btnLimpar_tab_do";
            this.btnLimpar_tab_do.Size = new System.Drawing.Size(69, 24);
            this.btnLimpar_tab_do.TabIndex = 16;
            this.btnLimpar_tab_do.Text = "Limpar";
            this.btnLimpar_tab_do.UseVisualStyleBackColor = true;
            this.btnLimpar_tab_do.Click += new System.EventHandler(this.btnLimpar_do_Click);
            // 
            // btnCalcular_tab_do
            // 
            this.btnCalcular_tab_do.Location = new System.Drawing.Point(823, 402);
            this.btnCalcular_tab_do.Name = "btnCalcular_tab_do";
            this.btnCalcular_tab_do.Size = new System.Drawing.Size(73, 24);
            this.btnCalcular_tab_do.TabIndex = 15;
            this.btnCalcular_tab_do.Text = "Calcular";
            this.btnCalcular_tab_do.UseVisualStyleBackColor = true;
            this.btnCalcular_tab_do.Click += new System.EventHandler(this.btnCalcular_do_Click);
            // 
            // txtresult_do
            // 
            this.txtresult_do.Enabled = false;
            this.txtresult_do.Location = new System.Drawing.Point(748, 182);
            this.txtresult_do.Multiline = true;
            this.txtresult_do.Name = "txtresult_do";
            this.txtresult_do.Size = new System.Drawing.Size(148, 196);
            this.txtresult_do.TabIndex = 14;
            // 
            // txtNum1_do
            // 
            this.txtNum1_do.Location = new System.Drawing.Point(748, 137);
            this.txtNum1_do.Name = "txtNum1_do";
            this.txtNum1_do.Size = new System.Drawing.Size(148, 22);
            this.txtNum1_do.TabIndex = 13;
            // 
            // lblResult_do
            // 
            this.lblResult_do.AutoSize = true;
            this.lblResult_do.Location = new System.Drawing.Point(509, 182);
            this.lblResult_do.Name = "lblResult_do";
            this.lblResult_do.Size = new System.Drawing.Size(195, 17);
            this.lblResult_do.TabIndex = 12;
            this.lblResult_do.Text = "Tabuada do número inserido:";
            // 
            // lblNum_do
            // 
            this.lblNum_do.AutoSize = true;
            this.lblNum_do.Location = new System.Drawing.Point(427, 137);
            this.lblNum_do.Name = "lblNum_do";
            this.lblNum_do.Size = new System.Drawing.Size(277, 17);
            this.lblNum_do.TabIndex = 11;
            this.lblNum_do.Text = "Digite um número para calcular a tabuada:";
            // 
            // frmTabuada_do
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1453, 531);
            this.Controls.Add(this.btnLimpar_tab_do);
            this.Controls.Add(this.btnCalcular_tab_do);
            this.Controls.Add(this.txtresult_do);
            this.Controls.Add(this.txtNum1_do);
            this.Controls.Add(this.lblResult_do);
            this.Controls.Add(this.lblNum_do);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTabuada_do";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada : Do";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpar_tab_do;
        private System.Windows.Forms.Button btnCalcular_tab_do;
        private System.Windows.Forms.TextBox txtresult_do;
        private System.Windows.Forms.TextBox txtNum1_do;
        private System.Windows.Forms.Label lblResult_do;
        private System.Windows.Forms.Label lblNum_do;
        private System.Windows.Forms.ToolStripMenuItem variaçõesDeCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoForToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoWhileToolStripMenuItem;
    }
}