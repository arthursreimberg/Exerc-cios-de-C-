
namespace Exercícios_11_13
{
    partial class frmTabuada_while
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTabuada_while));
            this.lblNum_Tabuada = new System.Windows.Forms.Label();
            this.lblResult_Tabuada = new System.Windows.Forms.Label();
            this.txtNum1_Tabuada = new System.Windows.Forms.TextBox();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.btnCalcular_tab_while = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabuadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabuadaForToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLimpar_tab_while = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum_Tabuada
            // 
            this.lblNum_Tabuada.AutoSize = true;
            this.lblNum_Tabuada.Location = new System.Drawing.Point(385, 137);
            this.lblNum_Tabuada.Name = "lblNum_Tabuada";
            this.lblNum_Tabuada.Size = new System.Drawing.Size(277, 17);
            this.lblNum_Tabuada.TabIndex = 0;
            this.lblNum_Tabuada.Text = "Digite um número para calcular a tabuada:";
            // 
            // lblResult_Tabuada
            // 
            this.lblResult_Tabuada.AutoSize = true;
            this.lblResult_Tabuada.Location = new System.Drawing.Point(467, 182);
            this.lblResult_Tabuada.Name = "lblResult_Tabuada";
            this.lblResult_Tabuada.Size = new System.Drawing.Size(195, 17);
            this.lblResult_Tabuada.TabIndex = 1;
            this.lblResult_Tabuada.Text = "Tabuada do número inserido:";
            // 
            // txtNum1_Tabuada
            // 
            this.txtNum1_Tabuada.Location = new System.Drawing.Point(706, 137);
            this.txtNum1_Tabuada.Name = "txtNum1_Tabuada";
            this.txtNum1_Tabuada.Size = new System.Drawing.Size(148, 22);
            this.txtNum1_Tabuada.TabIndex = 2;
            // 
            // txtresult
            // 
            this.txtresult.Enabled = false;
            this.txtresult.Location = new System.Drawing.Point(706, 182);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(148, 196);
            this.txtresult.TabIndex = 3;
            // 
            // btnCalcular_tab_while
            // 
            this.btnCalcular_tab_while.Location = new System.Drawing.Point(781, 402);
            this.btnCalcular_tab_while.Name = "btnCalcular_tab_while";
            this.btnCalcular_tab_while.Size = new System.Drawing.Size(73, 24);
            this.btnCalcular_tab_while.TabIndex = 4;
            this.btnCalcular_tab_while.Text = "Calcular";
            this.btnCalcular_tab_while.UseVisualStyleBackColor = true;
            this.btnCalcular_tab_while.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1361, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabuadaToolStripMenuItem
            // 
            this.tabuadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabuadaDoToolStripMenuItem,
            this.tabuadaForToolStripMenuItem1});
            this.tabuadaToolStripMenuItem.Name = "tabuadaToolStripMenuItem";
            this.tabuadaToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.tabuadaToolStripMenuItem.Text = "Variações de Código";
            this.tabuadaToolStripMenuItem.Click += new System.EventHandler(this.tabuadaToolStripMenuItem_Click);
            // 
            // tabuadaDoToolStripMenuItem
            // 
            this.tabuadaDoToolStripMenuItem.Name = "tabuadaDoToolStripMenuItem";
            this.tabuadaDoToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.tabuadaDoToolStripMenuItem.Text = "Tabuada : Do";
            this.tabuadaDoToolStripMenuItem.Click += new System.EventHandler(this.tabuadaDoToolStripMenuItem_Click);
            // 
            // tabuadaForToolStripMenuItem1
            // 
            this.tabuadaForToolStripMenuItem1.Name = "tabuadaForToolStripMenuItem1";
            this.tabuadaForToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.tabuadaForToolStripMenuItem1.Text = "Tabuada : For";
            this.tabuadaForToolStripMenuItem1.Click += new System.EventHandler(this.tabuadaForToolStripMenuItem1_Click);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // btnLimpar_tab_while
            // 
            this.btnLimpar_tab_while.Location = new System.Drawing.Point(706, 402);
            this.btnLimpar_tab_while.Name = "btnLimpar_tab_while";
            this.btnLimpar_tab_while.Size = new System.Drawing.Size(69, 24);
            this.btnLimpar_tab_while.TabIndex = 6;
            this.btnLimpar_tab_while.Text = "Limpar";
            this.btnLimpar_tab_while.UseVisualStyleBackColor = true;
            this.btnLimpar_tab_while.Click += new System.EventHandler(this.btnLimpar_tabuada_Click);
            // 
            // frmTabuada_while
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1361, 531);
            this.Controls.Add(this.btnLimpar_tab_while);
            this.Controls.Add(this.btnCalcular_tab_while);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.txtNum1_Tabuada);
            this.Controls.Add(this.lblResult_Tabuada);
            this.Controls.Add(this.lblNum_Tabuada);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTabuada_while";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada : While";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum_Tabuada;
        private System.Windows.Forms.Label lblResult_Tabuada;
        private System.Windows.Forms.TextBox txtNum1_Tabuada;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Button btnCalcular_tab_while;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabuadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabuadaForToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button btnLimpar_tab_while;
    }
}