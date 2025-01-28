namespace Estagio
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.childFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparCamposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem,
            this.menuContextoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.childFormToolStripMenuItem});
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            // 
            // childFormToolStripMenuItem
            // 
            this.childFormToolStripMenuItem.Name = "childFormToolStripMenuItem";
            this.childFormToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.childFormToolStripMenuItem.Text = "Child Form";
            this.childFormToolStripMenuItem.Click += new System.EventHandler(this.childFormToolStripMenuItem_Click);
            // 
            // menuContextoToolStripMenuItem
            // 
            this.menuContextoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparCamposToolStripMenuItem});
            this.menuContextoToolStripMenuItem.Name = "menuContextoToolStripMenuItem";
            this.menuContextoToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.menuContextoToolStripMenuItem.Text = "Menu Contexto";
            this.menuContextoToolStripMenuItem.Visible = false;
            // 
            // limparCamposToolStripMenuItem
            // 
            this.limparCamposToolStripMenuItem.Name = "limparCamposToolStripMenuItem";
            this.limparCamposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.limparCamposToolStripMenuItem.Text = "Limpar Campos ";
            this.limparCamposToolStripMenuItem.Click += new System.EventHandler(this.limparCamposToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 308);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem childFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuContextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparCamposToolStripMenuItem;
    }
}

