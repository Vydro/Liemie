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
            this.tsm_menuPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_planningVisites = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_deconnexion = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_mesVisites = new System.Windows.Forms.Panel();
            this.btn_saisirSoinDeLaVisite = new System.Windows.Forms.Button();
            this.btn_màjVisites = new System.Windows.Forms.Button();
            this.dgv_mesVisites = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bs_mesVisites = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_mesVisites.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mesVisites)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_mesVisites)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_menuPrincipal,
            this.tsm_planningVisites,
            this.tsm_deconnexion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(699, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsm_menuPrincipal
            // 
            this.tsm_menuPrincipal.Name = "tsm_menuPrincipal";
            this.tsm_menuPrincipal.Size = new System.Drawing.Size(99, 20);
            this.tsm_menuPrincipal.Text = "Menu principal";
            this.tsm_menuPrincipal.Click += new System.EventHandler(this.tsm_menuPrincipal_Click);
            // 
            // tsm_planningVisites
            // 
            this.tsm_planningVisites.Name = "tsm_planningVisites";
            this.tsm_planningVisites.Size = new System.Drawing.Size(122, 20);
            this.tsm_planningVisites.Text = "Planning des visites";
            this.tsm_planningVisites.Click += new System.EventHandler(this.tsm_planningVisites_Click);
            // 
            // tsm_deconnexion
            // 
            this.tsm_deconnexion.Name = "tsm_deconnexion";
            this.tsm_deconnexion.Size = new System.Drawing.Size(88, 20);
            this.tsm_deconnexion.Text = "Déconnexion";
            this.tsm_deconnexion.Click += new System.EventHandler(this.tsm_deconnexion_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.Controls.Add(this.pictureBox1);
            this.pnl_menu.Controls.Add(this.label2);
            this.pnl_menu.Location = new System.Drawing.Point(11, 26);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(86, 78);
            this.pnl_menu.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Menu principal";
            // 
            // pnl_mesVisites
            // 
            this.pnl_mesVisites.Controls.Add(this.btn_saisirSoinDeLaVisite);
            this.pnl_mesVisites.Controls.Add(this.btn_màjVisites);
            this.pnl_mesVisites.Controls.Add(this.dgv_mesVisites);
            this.pnl_mesVisites.Controls.Add(this.label1);
            this.pnl_mesVisites.Location = new System.Drawing.Point(11, 26);
            this.pnl_mesVisites.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_mesVisites.Name = "pnl_mesVisites";
            this.pnl_mesVisites.Size = new System.Drawing.Size(677, 373);
            this.pnl_mesVisites.TabIndex = 2;
            this.pnl_mesVisites.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_mesVisites_Paint);
            // 
            // btn_saisirSoinDeLaVisite
            // 
            this.btn_saisirSoinDeLaVisite.Location = new System.Drawing.Point(222, 323);
            this.btn_saisirSoinDeLaVisite.Name = "btn_saisirSoinDeLaVisite";
            this.btn_saisirSoinDeLaVisite.Size = new System.Drawing.Size(204, 32);
            this.btn_saisirSoinDeLaVisite.TabIndex = 3;
            this.btn_saisirSoinDeLaVisite.Text = "Saisir les soins de la visite sélectionnée";
            this.btn_saisirSoinDeLaVisite.UseVisualStyleBackColor = true;
            this.btn_saisirSoinDeLaVisite.Click += new System.EventHandler(this.btn_saisirSoinDeLaVisite_Click);
            // 
            // btn_màjVisites
            // 
            this.btn_màjVisites.Location = new System.Drawing.Point(18, 323);
            this.btn_màjVisites.Margin = new System.Windows.Forms.Padding(2);
            this.btn_màjVisites.Name = "btn_màjVisites";
            this.btn_màjVisites.Size = new System.Drawing.Size(146, 32);
            this.btn_màjVisites.TabIndex = 2;
            this.btn_màjVisites.Text = "Mettre à jour les visites";
            this.btn_màjVisites.UseVisualStyleBackColor = true;
            this.btn_màjVisites.Click += new System.EventHandler(this.btn_màjVisites_Click);
            // 
            // dgv_mesVisites
            // 
            this.dgv_mesVisites.AllowUserToAddRows = false;
            this.dgv_mesVisites.AllowUserToDeleteRows = false;
            this.dgv_mesVisites.AllowUserToResizeColumns = false;
            this.dgv_mesVisites.AllowUserToResizeRows = false;
            this.dgv_mesVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mesVisites.Location = new System.Drawing.Point(10, 42);
            this.dgv_mesVisites.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_mesVisites.Name = "dgv_mesVisites";
            this.dgv_mesVisites.ReadOnly = true;
            this.dgv_mesVisites.RowTemplate.Height = 24;
            this.dgv_mesVisites.Size = new System.Drawing.Size(658, 258);
            this.dgv_mesVisites.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.label1.Location = new System.Drawing.Point(250, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mes visites";
            // 
            // bs_mesVisites
            // 
            this.bs_mesVisites.DataSource = typeof(Liemie.visite);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 410);
            this.Controls.Add(this.pnl_mesVisites);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_mesVisites.ResumeLayout(false);
            this.pnl_mesVisites.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mesVisites)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_mesVisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsm_menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsm_planningVisites;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_mesVisites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_mesVisites;
        private System.Windows.Forms.BindingSource bs_mesVisites;
        private System.Windows.Forms.Button btn_màjVisites;
        private System.Windows.Forms.ToolStripMenuItem tsm_deconnexion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_saisirSoinDeLaVisite;
    }
}