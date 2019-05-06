namespace Liemie
{
    partial class SaisieSoinsVisite
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
            this.cmb_categSoins = new System.Windows.Forms.ComboBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_categSoins = new System.Windows.Forms.Label();
            this.bs_categSoins = new System.Windows.Forms.BindingSource(this.components);
            this.txt_descCategSoins = new System.Windows.Forms.TextBox();
            this.lbl_descCategSoins = new System.Windows.Forms.Label();
            this.lbl_typeSoins = new System.Windows.Forms.Label();
            this.cmb_typeSoins = new System.Windows.Forms.ComboBox();
            this.bs_typeSoins = new System.Windows.Forms.BindingSource(this.components);
            this.txt_descTypeSoins = new System.Windows.Forms.TextBox();
            this.lbl_descTypeSoins = new System.Windows.Forms.Label();
            this.cmb_soins = new System.Windows.Forms.ComboBox();
            this.lbl_soins = new System.Windows.Forms.Label();
            this.bs_soins = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_coeffSoins = new System.Windows.Forms.Label();
            this.txt_descSoins = new System.Windows.Forms.TextBox();
            this.lbl_descSoins = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_prevue = new System.Windows.Forms.CheckBox();
            this.chk_realise = new System.Windows.Forms.CheckBox();
            this.btn_terminer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bs_categSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_typeSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_soins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_categSoins
            // 
            this.cmb_categSoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_categSoins.FormattingEnabled = true;
            this.cmb_categSoins.Location = new System.Drawing.Point(240, 90);
            this.cmb_categSoins.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_categSoins.Name = "cmb_categSoins";
            this.cmb_categSoins.Size = new System.Drawing.Size(243, 24);
            this.cmb_categSoins.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(16, 11);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(402, 32);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Saisie des soins pour la visite n°";
            // 
            // lbl_categSoins
            // 
            this.lbl_categSoins.AutoSize = true;
            this.lbl_categSoins.Location = new System.Drawing.Point(16, 94);
            this.lbl_categSoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_categSoins.Name = "lbl_categSoins";
            this.lbl_categSoins.Size = new System.Drawing.Size(133, 17);
            this.lbl_categSoins.TabIndex = 2;
            this.lbl_categSoins.Text = "Categorie des soins";
            // 
            // bs_categSoins
            // 
            this.bs_categSoins.CurrentChanged += new System.EventHandler(this.bs_categSoins_CurrentChanged);
            // 
            // txt_descCategSoins
            // 
            this.txt_descCategSoins.Location = new System.Drawing.Point(240, 123);
            this.txt_descCategSoins.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descCategSoins.Multiline = true;
            this.txt_descCategSoins.Name = "txt_descCategSoins";
            this.txt_descCategSoins.ReadOnly = true;
            this.txt_descCategSoins.Size = new System.Drawing.Size(696, 88);
            this.txt_descCategSoins.TabIndex = 1;
            // 
            // lbl_descCategSoins
            // 
            this.lbl_descCategSoins.AutoSize = true;
            this.lbl_descCategSoins.Location = new System.Drawing.Point(16, 151);
            this.lbl_descCategSoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descCategSoins.Name = "lbl_descCategSoins";
            this.lbl_descCategSoins.Size = new System.Drawing.Size(177, 17);
            this.lbl_descCategSoins.TabIndex = 4;
            this.lbl_descCategSoins.Text = "Description de la catégorie";
            // 
            // lbl_typeSoins
            // 
            this.lbl_typeSoins.AutoSize = true;
            this.lbl_typeSoins.Location = new System.Drawing.Point(16, 232);
            this.lbl_typeSoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_typeSoins.Name = "lbl_typeSoins";
            this.lbl_typeSoins.Size = new System.Drawing.Size(97, 17);
            this.lbl_typeSoins.TabIndex = 5;
            this.lbl_typeSoins.Text = "Type de soins";
            // 
            // cmb_typeSoins
            // 
            this.cmb_typeSoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_typeSoins.FormattingEnabled = true;
            this.cmb_typeSoins.Location = new System.Drawing.Point(240, 228);
            this.cmb_typeSoins.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_typeSoins.Name = "cmb_typeSoins";
            this.cmb_typeSoins.Size = new System.Drawing.Size(243, 24);
            this.cmb_typeSoins.TabIndex = 1;
            this.cmb_typeSoins.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmb_typeSoins_Format);
            // 
            // bs_typeSoins
            // 
            this.bs_typeSoins.CurrentChanged += new System.EventHandler(this.bs_typeSoins_CurrentChanged);
            // 
            // txt_descTypeSoins
            // 
            this.txt_descTypeSoins.Location = new System.Drawing.Point(239, 260);
            this.txt_descTypeSoins.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descTypeSoins.Multiline = true;
            this.txt_descTypeSoins.Name = "txt_descTypeSoins";
            this.txt_descTypeSoins.ReadOnly = true;
            this.txt_descTypeSoins.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_descTypeSoins.Size = new System.Drawing.Size(696, 116);
            this.txt_descTypeSoins.TabIndex = 7;
            // 
            // lbl_descTypeSoins
            // 
            this.lbl_descTypeSoins.AutoSize = true;
            this.lbl_descTypeSoins.Location = new System.Drawing.Point(16, 290);
            this.lbl_descTypeSoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descTypeSoins.Name = "lbl_descTypeSoins";
            this.lbl_descTypeSoins.Size = new System.Drawing.Size(187, 17);
            this.lbl_descTypeSoins.TabIndex = 8;
            this.lbl_descTypeSoins.Text = "Description du type de soins";
            // 
            // cmb_soins
            // 
            this.cmb_soins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_soins.FormattingEnabled = true;
            this.cmb_soins.Location = new System.Drawing.Point(240, 393);
            this.cmb_soins.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_soins.Name = "cmb_soins";
            this.cmb_soins.Size = new System.Drawing.Size(243, 24);
            this.cmb_soins.TabIndex = 2;
            this.cmb_soins.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmb_soins_Format);
            // 
            // lbl_soins
            // 
            this.lbl_soins.AutoSize = true;
            this.lbl_soins.Location = new System.Drawing.Point(16, 397);
            this.lbl_soins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_soins.Name = "lbl_soins";
            this.lbl_soins.Size = new System.Drawing.Size(43, 17);
            this.lbl_soins.TabIndex = 9;
            this.lbl_soins.Text = "Soins";
            // 
            // bs_soins
            // 
            this.bs_soins.CurrentChanged += new System.EventHandler(this.bs_soins_CurrentChanged);
            // 
            // lbl_coeffSoins
            // 
            this.lbl_coeffSoins.AutoSize = true;
            this.lbl_coeffSoins.Location = new System.Drawing.Point(491, 396);
            this.lbl_coeffSoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_coeffSoins.Name = "lbl_coeffSoins";
            this.lbl_coeffSoins.Size = new System.Drawing.Size(74, 17);
            this.lbl_coeffSoins.TabIndex = 10;
            this.lbl_coeffSoins.Text = "Coefficient";
            // 
            // txt_descSoins
            // 
            this.txt_descSoins.Location = new System.Drawing.Point(240, 425);
            this.txt_descSoins.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descSoins.Multiline = true;
            this.txt_descSoins.Name = "txt_descSoins";
            this.txt_descSoins.ReadOnly = true;
            this.txt_descSoins.Size = new System.Drawing.Size(696, 80);
            this.txt_descSoins.TabIndex = 11;
            // 
            // lbl_descSoins
            // 
            this.lbl_descSoins.AutoSize = true;
            this.lbl_descSoins.Location = new System.Drawing.Point(16, 444);
            this.lbl_descSoins.Name = "lbl_descSoins";
            this.lbl_descSoins.Size = new System.Drawing.Size(143, 17);
            this.lbl_descSoins.TabIndex = 12;
            this.lbl_descSoins.Text = "Description des soins";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(19, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 3);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox2.Location = new System.Drawing.Point(22, 383);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(916, 3);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox3.Location = new System.Drawing.Point(22, 512);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(916, 3);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Etat de la visite ";
            // 
            // chk_prevue
            // 
            this.chk_prevue.AutoSize = true;
            this.chk_prevue.Location = new System.Drawing.Point(240, 533);
            this.chk_prevue.Name = "chk_prevue";
            this.chk_prevue.Size = new System.Drawing.Size(71, 21);
            this.chk_prevue.TabIndex = 19;
            this.chk_prevue.Text = "prevue";
            this.chk_prevue.UseVisualStyleBackColor = true;
            // 
            // chk_realise
            // 
            this.chk_realise.AutoSize = true;
            this.chk_realise.Location = new System.Drawing.Point(406, 533);
            this.chk_realise.Name = "chk_realise";
            this.chk_realise.Size = new System.Drawing.Size(77, 21);
            this.chk_realise.TabIndex = 20;
            this.chk_realise.Text = "realisée";
            this.chk_realise.UseVisualStyleBackColor = true;
            // 
            // btn_terminer
            // 
            this.btn_terminer.Location = new System.Drawing.Point(775, 559);
            this.btn_terminer.Name = "btn_terminer";
            this.btn_terminer.Size = new System.Drawing.Size(160, 41);
            this.btn_terminer.TabIndex = 21;
            this.btn_terminer.Text = "Terminer";
            this.btn_terminer.UseVisualStyleBackColor = true;
            this.btn_terminer.Click += new System.EventHandler(this.btn_finaliser_Click);
            // 
            // SaisieSoinsVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 612);
            this.Controls.Add(this.btn_terminer);
            this.Controls.Add(this.chk_realise);
            this.Controls.Add(this.chk_prevue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_descSoins);
            this.Controls.Add(this.txt_descSoins);
            this.Controls.Add(this.lbl_coeffSoins);
            this.Controls.Add(this.lbl_soins);
            this.Controls.Add(this.cmb_soins);
            this.Controls.Add(this.lbl_descTypeSoins);
            this.Controls.Add(this.txt_descTypeSoins);
            this.Controls.Add(this.cmb_typeSoins);
            this.Controls.Add(this.lbl_typeSoins);
            this.Controls.Add(this.lbl_descCategSoins);
            this.Controls.Add(this.txt_descCategSoins);
            this.Controls.Add(this.lbl_categSoins);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.cmb_categSoins);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SaisieSoinsVisite";
            this.Text = "SaisieSoinsVisite";
            this.Load += new System.EventHandler(this.SaisieSoinsVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_categSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_typeSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_soins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_categSoins;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_categSoins;
        private System.Windows.Forms.BindingSource bs_categSoins;
        private System.Windows.Forms.TextBox txt_descCategSoins;
        private System.Windows.Forms.Label lbl_descCategSoins;
        private System.Windows.Forms.Label lbl_typeSoins;
        private System.Windows.Forms.ComboBox cmb_typeSoins;
        private System.Windows.Forms.BindingSource bs_typeSoins;
        private System.Windows.Forms.TextBox txt_descTypeSoins;
        private System.Windows.Forms.Label lbl_descTypeSoins;
        private System.Windows.Forms.ComboBox cmb_soins;
        private System.Windows.Forms.Label lbl_soins;
        private System.Windows.Forms.BindingSource bs_soins;
        private System.Windows.Forms.Label lbl_coeffSoins;
        private System.Windows.Forms.TextBox txt_descSoins;
        private System.Windows.Forms.Label lbl_descSoins;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_prevue;
        private System.Windows.Forms.CheckBox chk_realise;
        private System.Windows.Forms.Button btn_terminer;
    }
}