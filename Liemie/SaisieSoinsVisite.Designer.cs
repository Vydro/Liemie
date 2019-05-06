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
            this.cb_categSoins = new System.Windows.Forms.ComboBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_categSoins = new System.Windows.Forms.Label();
            this.bs_categSoins = new System.Windows.Forms.BindingSource(this.components);
            this.tb_descCategSoins = new System.Windows.Forms.TextBox();
            this.lbl_descCategSoins = new System.Windows.Forms.Label();
            this.lbl_typeSoins = new System.Windows.Forms.Label();
            this.cb_typeSoins = new System.Windows.Forms.ComboBox();
            this.bs_typeSoins = new System.Windows.Forms.BindingSource(this.components);
            this.tb_descTypeSoins = new System.Windows.Forms.TextBox();
            this.lbl_descTypeSoins = new System.Windows.Forms.Label();
            this.cb_soins = new System.Windows.Forms.ComboBox();
            this.lbl_soins = new System.Windows.Forms.Label();
            this.bs_soins = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_coeffSoins = new System.Windows.Forms.Label();
            this.lbl_dateSoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs_categSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_typeSoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_soins)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_categSoins
            // 
            this.cb_categSoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_categSoins.FormattingEnabled = true;
            this.cb_categSoins.Location = new System.Drawing.Point(180, 73);
            this.cb_categSoins.Name = "cb_categSoins";
            this.cb_categSoins.Size = new System.Drawing.Size(183, 21);
            this.cb_categSoins.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.Location = new System.Drawing.Point(12, 9);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(315, 24);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Saisie des soins pour la visite n°";
            // 
            // lbl_categSoins
            // 
            this.lbl_categSoins.AutoSize = true;
            this.lbl_categSoins.Location = new System.Drawing.Point(12, 76);
            this.lbl_categSoins.Name = "lbl_categSoins";
            this.lbl_categSoins.Size = new System.Drawing.Size(99, 13);
            this.lbl_categSoins.TabIndex = 2;
            this.lbl_categSoins.Text = "Categorie des soins";
            // 
            // bs_categSoins
            // 
            this.bs_categSoins.CurrentChanged += new System.EventHandler(this.bs_categSoins_CurrentChanged);
            // 
            // tb_descCategSoins
            // 
            this.tb_descCategSoins.Location = new System.Drawing.Point(180, 100);
            this.tb_descCategSoins.Multiline = true;
            this.tb_descCategSoins.Name = "tb_descCategSoins";
            this.tb_descCategSoins.ReadOnly = true;
            this.tb_descCategSoins.Size = new System.Drawing.Size(523, 72);
            this.tb_descCategSoins.TabIndex = 1;
            // 
            // lbl_descCategSoins
            // 
            this.lbl_descCategSoins.AutoSize = true;
            this.lbl_descCategSoins.Location = new System.Drawing.Point(13, 123);
            this.lbl_descCategSoins.Name = "lbl_descCategSoins";
            this.lbl_descCategSoins.Size = new System.Drawing.Size(133, 13);
            this.lbl_descCategSoins.TabIndex = 4;
            this.lbl_descCategSoins.Text = "Description de la catégorie";
            // 
            // lbl_typeSoins
            // 
            this.lbl_typeSoins.AutoSize = true;
            this.lbl_typeSoins.Location = new System.Drawing.Point(12, 181);
            this.lbl_typeSoins.Name = "lbl_typeSoins";
            this.lbl_typeSoins.Size = new System.Drawing.Size(73, 13);
            this.lbl_typeSoins.TabIndex = 5;
            this.lbl_typeSoins.Text = "Type de soins";
            // 
            // cb_typeSoins
            // 
            this.cb_typeSoins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_typeSoins.FormattingEnabled = true;
            this.cb_typeSoins.Location = new System.Drawing.Point(180, 178);
            this.cb_typeSoins.Name = "cb_typeSoins";
            this.cb_typeSoins.Size = new System.Drawing.Size(183, 21);
            this.cb_typeSoins.TabIndex = 1;
            this.cb_typeSoins.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cb_typeSoins_Format);
            // 
            // bs_typeSoins
            // 
            this.bs_typeSoins.CurrentChanged += new System.EventHandler(this.bs_typeSoins_CurrentChanged);
            // 
            // tb_descTypeSoins
            // 
            this.tb_descTypeSoins.Location = new System.Drawing.Point(180, 205);
            this.tb_descTypeSoins.Multiline = true;
            this.tb_descTypeSoins.Name = "tb_descTypeSoins";
            this.tb_descTypeSoins.ReadOnly = true;
            this.tb_descTypeSoins.Size = new System.Drawing.Size(523, 72);
            this.tb_descTypeSoins.TabIndex = 7;
            // 
            // lbl_descTypeSoins
            // 
            this.lbl_descTypeSoins.AutoSize = true;
            this.lbl_descTypeSoins.Location = new System.Drawing.Point(12, 228);
            this.lbl_descTypeSoins.Name = "lbl_descTypeSoins";
            this.lbl_descTypeSoins.Size = new System.Drawing.Size(140, 13);
            this.lbl_descTypeSoins.TabIndex = 8;
            this.lbl_descTypeSoins.Text = "Description du type de soins";
            // 
            // cb_soins
            // 
            this.cb_soins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_soins.FormattingEnabled = true;
            this.cb_soins.Location = new System.Drawing.Point(180, 283);
            this.cb_soins.Name = "cb_soins";
            this.cb_soins.Size = new System.Drawing.Size(183, 21);
            this.cb_soins.TabIndex = 2;
            this.cb_soins.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cb_soins_Format);
            // 
            // lbl_soins
            // 
            this.lbl_soins.AutoSize = true;
            this.lbl_soins.Location = new System.Drawing.Point(12, 286);
            this.lbl_soins.Name = "lbl_soins";
            this.lbl_soins.Size = new System.Drawing.Size(33, 13);
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
            this.lbl_coeffSoins.Location = new System.Drawing.Point(177, 319);
            this.lbl_coeffSoins.Name = "lbl_coeffSoins";
            this.lbl_coeffSoins.Size = new System.Drawing.Size(57, 13);
            this.lbl_coeffSoins.TabIndex = 10;
            this.lbl_coeffSoins.Text = "Coefficient";
            // 
            // lbl_dateSoins
            // 
            this.lbl_dateSoins.AutoSize = true;
            this.lbl_dateSoins.Location = new System.Drawing.Point(288, 319);
            this.lbl_dateSoins.Name = "lbl_dateSoins";
            this.lbl_dateSoins.Size = new System.Drawing.Size(30, 13);
            this.lbl_dateSoins.TabIndex = 11;
            this.lbl_dateSoins.Text = "Date";
            // 
            // SaisieSoinsVisite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 424);
            this.Controls.Add(this.lbl_dateSoins);
            this.Controls.Add(this.lbl_coeffSoins);
            this.Controls.Add(this.lbl_soins);
            this.Controls.Add(this.cb_soins);
            this.Controls.Add(this.lbl_descTypeSoins);
            this.Controls.Add(this.tb_descTypeSoins);
            this.Controls.Add(this.cb_typeSoins);
            this.Controls.Add(this.lbl_typeSoins);
            this.Controls.Add(this.lbl_descCategSoins);
            this.Controls.Add(this.tb_descCategSoins);
            this.Controls.Add(this.lbl_categSoins);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.cb_categSoins);
            this.Name = "SaisieSoinsVisite";
            this.Text = "SaisieSoinsVisite";
            this.Load += new System.EventHandler(this.SaisieSoinsVisite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bs_categSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_typeSoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_soins)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_categSoins;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_categSoins;
        private System.Windows.Forms.BindingSource bs_categSoins;
        private System.Windows.Forms.TextBox tb_descCategSoins;
        private System.Windows.Forms.Label lbl_descCategSoins;
        private System.Windows.Forms.Label lbl_typeSoins;
        private System.Windows.Forms.ComboBox cb_typeSoins;
        private System.Windows.Forms.BindingSource bs_typeSoins;
        private System.Windows.Forms.TextBox tb_descTypeSoins;
        private System.Windows.Forms.Label lbl_descTypeSoins;
        private System.Windows.Forms.ComboBox cb_soins;
        private System.Windows.Forms.Label lbl_soins;
        private System.Windows.Forms.BindingSource bs_soins;
        private System.Windows.Forms.Label lbl_coeffSoins;
        private System.Windows.Forms.Label lbl_dateSoins;
    }
}