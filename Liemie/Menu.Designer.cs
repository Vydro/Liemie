namespace Liemie
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flp_mesVisites = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitesToolStripMenuItem,
            this.visitesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(880, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.visitesToolStripMenuItem.Text = "Options";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.menuPrincipalToolStripMenuItem.Text = "Menu principal";
            // 
            // visitesToolStripMenuItem1
            // 
            this.visitesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisieVisiteToolStripMenuItem});
            this.visitesToolStripMenuItem1.Name = "visitesToolStripMenuItem1";
            this.visitesToolStripMenuItem1.Size = new System.Drawing.Size(63, 24);
            this.visitesToolStripMenuItem1.Text = "Visites";
            // 
            // saisieVisiteToolStripMenuItem
            // 
            this.saisieVisiteToolStripMenuItem.Name = "saisieVisiteToolStripMenuItem";
            this.saisieVisiteToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.saisieVisiteToolStripMenuItem.Text = "Saisie visite";
            // 
            // flp_mesVisites
            // 
            this.flp_mesVisites.Location = new System.Drawing.Point(12, 31);
            this.flp_mesVisites.Name = "flp_mesVisites";
            this.flp_mesVisites.Size = new System.Drawing.Size(663, 328);
            this.flp_mesVisites.TabIndex = 1;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 456);
            this.Controls.Add(this.flp_mesVisites);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saisieVisiteToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flp_mesVisites;
    }
}