﻿namespace Liemie
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.lbl_identifiant = new System.Windows.Forms.Label();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.tb_motDePasse = new System.Windows.Forms.TextBox();
            this.tb_identifiant = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_seConnecter = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.lbl_alert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_identifiant
            // 
            this.lbl_identifiant.AutoSize = true;
            this.lbl_identifiant.Location = new System.Drawing.Point(184, 226);
            this.lbl_identifiant.Name = "lbl_identifiant";
            this.lbl_identifiant.Size = new System.Drawing.Size(59, 13);
            this.lbl_identifiant.TabIndex = 0;
            this.lbl_identifiant.Text = "Identifiant :";
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Location = new System.Drawing.Point(184, 258);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(77, 13);
            this.lbl_mdp.TabIndex = 1;
            this.lbl_mdp.Text = "Mot de passe :";
            // 
            // tb_motDePasse
            // 
            this.tb_motDePasse.Location = new System.Drawing.Point(277, 255);
            this.tb_motDePasse.Name = "tb_motDePasse";
            this.tb_motDePasse.PasswordChar = '•';
            this.tb_motDePasse.Size = new System.Drawing.Size(110, 20);
            this.tb_motDePasse.TabIndex = 2;
            // 
            // tb_identifiant
            // 
            this.tb_identifiant.Location = new System.Drawing.Point(277, 223);
            this.tb_identifiant.Name = "tb_identifiant";
            this.tb_identifiant.Size = new System.Drawing.Size(110, 20);
            this.tb_identifiant.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(187, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btn_seConnecter
            // 
            this.btn_seConnecter.Location = new System.Drawing.Point(187, 300);
            this.btn_seConnecter.Name = "btn_seConnecter";
            this.btn_seConnecter.Size = new System.Drawing.Size(97, 23);
            this.btn_seConnecter.TabIndex = 3;
            this.btn_seConnecter.Text = "Se connecter";
            this.btn_seConnecter.UseVisualStyleBackColor = true;
            this.btn_seConnecter.Click += new System.EventHandler(this.btn_seConnecter_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(290, 300);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(97, 23);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.ForeColor = System.Drawing.Color.Red;
            this.lbl_alert.Location = new System.Drawing.Point(405, 226);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(43, 13);
            this.lbl_alert.TabIndex = 7;
            this.lbl_alert.Text = "lbl_alert";
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 357);
            this.Controls.Add(this.lbl_alert);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_seConnecter);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_identifiant);
            this.Controls.Add(this.tb_motDePasse);
            this.Controls.Add(this.lbl_mdp);
            this.Controls.Add(this.lbl_identifiant);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Connexion_FormClosed);
            this.Load += new System.EventHandler(this.Connexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_identifiant;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.TextBox tb_motDePasse;
        private System.Windows.Forms.TextBox tb_identifiant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_seConnecter;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Label lbl_alert;
    }
}

