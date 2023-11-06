
namespace Exercícios_11_13
{
    partial class frmConver_while
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConver_while));
            this.lblTmp_while = new System.Windows.Forms.Label();
            this.lblConver_while = new System.Windows.Forms.Label();
            this.txtTmp_while = new System.Windows.Forms.TextBox();
            this.txtConver_while = new System.Windows.Forms.TextBox();
            this.btnCalc_conver_while = new System.Windows.Forms.Button();
            this.btnLimp_conver_while = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.converçãoDoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conversãoForToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTmp_while
            // 
            this.lblTmp_while.AutoSize = true;
            this.lblTmp_while.Location = new System.Drawing.Point(334, 121);
            this.lblTmp_while.Name = "lblTmp_while";
            this.lblTmp_while.Size = new System.Drawing.Size(308, 17);
            this.lblTmp_while.TabIndex = 0;
            this.lblTmp_while.Text = "Insira a temperatura em Celsius para o cálculo: ";
            this.lblTmp_while.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblConver_while
            // 
            this.lblConver_while.AutoSize = true;
            this.lblConver_while.Location = new System.Drawing.Point(416, 184);
            this.lblConver_while.Name = "lblConver_while";
            this.lblConver_while.Size = new System.Drawing.Size(230, 17);
            this.lblConver_while.TabIndex = 1;
            this.lblConver_while.Text = "Conversão da temperatura insirida:";
            // 
            // txtTmp_while
            // 
            this.txtTmp_while.Location = new System.Drawing.Point(671, 118);
            this.txtTmp_while.Name = "txtTmp_while";
            this.txtTmp_while.Size = new System.Drawing.Size(254, 22);
            this.txtTmp_while.TabIndex = 2;
            // 
            // txtConver_while
            // 
            this.txtConver_while.Enabled = false;
            this.txtConver_while.Location = new System.Drawing.Point(671, 184);
            this.txtConver_while.Multiline = true;
            this.txtConver_while.Name = "txtConver_while";
            this.txtConver_while.Size = new System.Drawing.Size(254, 211);
            this.txtConver_while.TabIndex = 3;
            // 
            // btnCalc_conver_while
            // 
            this.btnCalc_conver_while.Location = new System.Drawing.Point(850, 411);
            this.btnCalc_conver_while.Name = "btnCalc_conver_while";
            this.btnCalc_conver_while.Size = new System.Drawing.Size(75, 28);
            this.btnCalc_conver_while.TabIndex = 4;
            this.btnCalc_conver_while.Text = "Calcular";
            this.btnCalc_conver_while.UseVisualStyleBackColor = true;
            this.btnCalc_conver_while.Click += new System.EventHandler(this.btnCalc_conver_while_Click);
            // 
            // btnLimp_conver_while
            // 
            this.btnLimp_conver_while.Location = new System.Drawing.Point(671, 411);
            this.btnLimp_conver_while.Name = "btnLimp_conver_while";
            this.btnLimp_conver_while.Size = new System.Drawing.Size(75, 28);
            this.btnLimp_conver_while.TabIndex = 5;
            this.btnLimp_conver_while.Text = "Limpar";
            this.btnLimp_conver_while.UseVisualStyleBackColor = true;
            this.btnLimp_conver_while.Click += new System.EventHandler(this.btnLimp_conver_while_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ttToolStripMenuItem,
            this.voltarToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1446, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ttToolStripMenuItem
            // 
            this.ttToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.converçãoDoToolStripMenuItem,
            this.conversãoForToolStripMenuItem});
            this.ttToolStripMenuItem.Name = "ttToolStripMenuItem";
            this.ttToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.ttToolStripMenuItem.Text = "Variações de Código";
            this.ttToolStripMenuItem.Click += new System.EventHandler(this.ttToolStripMenuItem_Click);
            // 
            // converçãoDoToolStripMenuItem
            // 
            this.converçãoDoToolStripMenuItem.Name = "converçãoDoToolStripMenuItem";
            this.converçãoDoToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.converçãoDoToolStripMenuItem.Text = " Conversão : Do";
            this.converçãoDoToolStripMenuItem.Click += new System.EventHandler(this.converçãoDoToolStripMenuItem_Click);
            // 
            // conversãoForToolStripMenuItem
            // 
            this.conversãoForToolStripMenuItem.Name = "conversãoForToolStripMenuItem";
            this.conversãoForToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.conversãoForToolStripMenuItem.Text = "Conversão : For";
            this.conversãoForToolStripMenuItem.Click += new System.EventHandler(this.conversãoForToolStripMenuItem_Click);
            // 
            // voltarToolStripMenuItem1
            // 
            this.voltarToolStripMenuItem1.Name = "voltarToolStripMenuItem1";
            this.voltarToolStripMenuItem1.Size = new System.Drawing.Size(62, 24);
            this.voltarToolStripMenuItem1.Text = "Voltar";
            this.voltarToolStripMenuItem1.Click += new System.EventHandler(this.voltarToolStripMenuItem1_Click);
            // 
            // frmConver_while
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(1446, 520);
            this.Controls.Add(this.btnLimp_conver_while);
            this.Controls.Add(this.btnCalc_conver_while);
            this.Controls.Add(this.txtConver_while);
            this.Controls.Add(this.txtTmp_while);
            this.Controls.Add(this.lblConver_while);
            this.Controls.Add(this.lblTmp_while);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConver_while";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão de C° para F° : While";
            this.Load += new System.EventHandler(this.frmConver_while_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTmp_while;
        private System.Windows.Forms.Label lblConver_while;
        private System.Windows.Forms.TextBox txtTmp_while;
        private System.Windows.Forms.TextBox txtConver_while;
        private System.Windows.Forms.Button btnCalc_conver_while;
        private System.Windows.Forms.Button btnLimp_conver_while;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem converçãoDoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conversãoForToolStripMenuItem;
    }
}