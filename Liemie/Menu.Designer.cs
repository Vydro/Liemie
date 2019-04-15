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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saisieVisiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_mesVisites = new System.Windows.Forms.Panel();
            this.btn_màjVisites = new System.Windows.Forms.Button();
            this.dgv_mesVisites = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bs_mesVisites = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_mesVisites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mesVisites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_mesVisites)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(932, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visitesToolStripMenuItem
            // 
            this.visitesToolStripMenuItem.Name = "visitesToolStripMenuItem";
            this.visitesToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.visitesToolStripMenuItem.Text = "Menu principal";
            this.visitesToolStripMenuItem.Click += new System.EventHandler(this.visitesToolStripMenuItem_Click);
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
            this.saisieVisiteToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.saisieVisiteToolStripMenuItem.Text = "Mes visites";
            this.saisieVisiteToolStripMenuItem.Click += new System.EventHandler(this.saisieVisiteToolStripMenuItem_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.label2);
            this.pnl_menu.Location = new System.Drawing.Point(12, 31);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(141, 109);
            this.pnl_menu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Menu principal";
            // 
            // pnl_mesVisites
            // 
            this.pnl_mesVisites.Controls.Add(this.btn_màjVisites);
            this.pnl_mesVisites.Controls.Add(this.dgv_mesVisites);
            this.pnl_mesVisites.Controls.Add(this.label1);
            this.pnl_mesVisites.Location = new System.Drawing.Point(12, 31);
            this.pnl_mesVisites.Name = "pnl_mesVisites";
            this.pnl_mesVisites.Size = new System.Drawing.Size(908, 462);
            this.pnl_mesVisites.TabIndex = 2;
            // 
            // btn_màjVisites
            // 
            this.btn_màjVisites.Location = new System.Drawing.Point(20, 394);
            this.btn_màjVisites.Name = "btn_màjVisites";
            this.btn_màjVisites.Size = new System.Drawing.Size(235, 54);
            this.btn_màjVisites.TabIndex = 2;
            this.btn_màjVisites.Text = "Mettre à jour les visites";
            this.btn_màjVisites.UseVisualStyleBackColor = true;
            this.btn_màjVisites.Click += new System.EventHandler(this.btn_màjVisites_Click);
            // 
            // dgv_mesVisites
            // 
            this.dgv_mesVisites.AllowUserToAddRows = false;
            this.dgv_mesVisites.AllowUserToDeleteRows = false;
            this.dgv_mesVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mesVisites.Location = new System.Drawing.Point(20, 56);
            this.dgv_mesVisites.Name = "dgv_mesVisites";
            this.dgv_mesVisites.ReadOnly = true;
            this.dgv_mesVisites.RowTemplate.Height = 24;
            this.dgv_mesVisites.Size = new System.Drawing.Size(864, 318);
            this.dgv_mesVisites.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes visites";
            // 
            // bs_mesVisites
            // 
            this.bs_mesVisites.DataSource = typeof(Liemie.visite);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 505);
            this.Controls.Add(this.pnl_mesVisites);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_menu.PerformLayout();
            this.pnl_mesVisites.ResumeLayout(false);
            this.pnl_mesVisites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mesVisites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_mesVisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saisieVisiteToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_mesVisites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_mesVisites;
        private System.Windows.Forms.BindingSource bs_mesVisites;
        private System.Windows.Forms.Button btn_màjVisites;
    }
}