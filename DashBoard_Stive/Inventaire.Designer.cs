
namespace DashBoard_Stive
{
    partial class Inventaire
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
            this.Dv_Inventaire = new System.Windows.Forms.DataGridView();
            this.label_Inventaire = new System.Windows.Forms.Label();
            this.panel_Inventaire = new System.Windows.Forms.Panel();
            this.Dv_Historique = new System.Windows.Forms.DataGridView();
            this.buttonSaveAndMajInventaire = new System.Windows.Forms.Button();
            this.button_SaveInventaire = new System.Windows.Forms.Button();
            this.label_Historique = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.contenuInventaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Pro_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Typ_Libelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fou_NomDomaine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pro_Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coIInvIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiDateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiDateMajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coi_ProId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coi_ProLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coi_ProQuantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coi_Inventaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Inventaire)).BeginInit();
            this.panel_Inventaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Historique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenuInventaireBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Dv_Inventaire
            // 
            this.Dv_Inventaire.AllowUserToDeleteRows = false;
            this.Dv_Inventaire.AutoGenerateColumns = false;
            this.Dv_Inventaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dv_Inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dv_Inventaire.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pro_Nom,
            this.Typ_Libelle,
            this.Fou_NomDomaine,
            this.Pro_Quantite,
            this.Inv,
            this.coIInvIdDataGridViewTextBoxColumn,
            this.coiDateCreationDataGridViewTextBoxColumn,
            this.coiDateMajDataGridViewTextBoxColumn,
            this.Coi_ProId,
            this.Coi_ProLibelle,
            this.Coi_ProQuantite,
            this.Coi_Inventaire});
            this.Dv_Inventaire.DataSource = this.contenuInventaireBindingSource;
            this.Dv_Inventaire.Location = new System.Drawing.Point(145, 35);
            this.Dv_Inventaire.Name = "Dv_Inventaire";
            this.Dv_Inventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Dv_Inventaire.Size = new System.Drawing.Size(516, 540);
            this.Dv_Inventaire.TabIndex = 20;
            // 
            // label_Inventaire
            // 
            this.label_Inventaire.AutoSize = true;
            this.label_Inventaire.BackColor = System.Drawing.Color.Transparent;
            this.label_Inventaire.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inventaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.label_Inventaire.Location = new System.Drawing.Point(141, 8);
            this.label_Inventaire.Name = "label_Inventaire";
            this.label_Inventaire.Size = new System.Drawing.Size(103, 24);
            this.label_Inventaire.TabIndex = 19;
            this.label_Inventaire.Text = "Inventaire";
            // 
            // panel_Inventaire
            // 
            this.panel_Inventaire.Controls.Add(this.Dv_Historique);
            this.panel_Inventaire.Controls.Add(this.buttonSaveAndMajInventaire);
            this.panel_Inventaire.Controls.Add(this.button_SaveInventaire);
            this.panel_Inventaire.Controls.Add(this.label_Historique);
            this.panel_Inventaire.Controls.Add(this.Dv_Inventaire);
            this.panel_Inventaire.Controls.Add(this.pictureBoxLogo);
            this.panel_Inventaire.Controls.Add(this.label_Inventaire);
            this.panel_Inventaire.Location = new System.Drawing.Point(2, 1);
            this.panel_Inventaire.Name = "panel_Inventaire";
            this.panel_Inventaire.Size = new System.Drawing.Size(1102, 601);
            this.panel_Inventaire.TabIndex = 21;
            // 
            // Dv_Historique
            // 
            this.Dv_Historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dv_Historique.Location = new System.Drawing.Point(744, 35);
            this.Dv_Historique.Name = "Dv_Historique";
            this.Dv_Historique.Size = new System.Drawing.Size(313, 158);
            this.Dv_Historique.TabIndex = 25;
            // 
            // buttonSaveAndMajInventaire
            // 
            this.buttonSaveAndMajInventaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.buttonSaveAndMajInventaire.FlatAppearance.BorderSize = 0;
            this.buttonSaveAndMajInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAndMajInventaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAndMajInventaire.ForeColor = System.Drawing.Color.White;
            this.buttonSaveAndMajInventaire.Location = new System.Drawing.Point(797, 360);
            this.buttonSaveAndMajInventaire.Name = "buttonSaveAndMajInventaire";
            this.buttonSaveAndMajInventaire.Size = new System.Drawing.Size(219, 53);
            this.buttonSaveAndMajInventaire.TabIndex = 24;
            this.buttonSaveAndMajInventaire.Text = "Mettre  à jour le stock";
            this.buttonSaveAndMajInventaire.UseVisualStyleBackColor = false;
            this.buttonSaveAndMajInventaire.Click += new System.EventHandler(this.buttonSaveAndMajInventaire_Click);
            // 
            // button_SaveInventaire
            // 
            this.button_SaveInventaire.FlatAppearance.BorderSize = 0;
            this.button_SaveInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveInventaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveInventaire.ForeColor = System.Drawing.Color.Green;
            this.button_SaveInventaire.Location = new System.Drawing.Point(797, 275);
            this.button_SaveInventaire.Name = "button_SaveInventaire";
            this.button_SaveInventaire.Size = new System.Drawing.Size(219, 34);
            this.button_SaveInventaire.TabIndex = 23;
            this.button_SaveInventaire.Text = "Enregistrer l\'inventaire";
            this.button_SaveInventaire.UseVisualStyleBackColor = true;
            this.button_SaveInventaire.Click += new System.EventHandler(this.button_SaveInventaire_Click);
            // 
            // label_Historique
            // 
            this.label_Historique.AutoSize = true;
            this.label_Historique.BackColor = System.Drawing.Color.Transparent;
            this.label_Historique.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Historique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.label_Historique.Location = new System.Drawing.Point(740, 8);
            this.label_Historique.Name = "label_Historique";
            this.label_Historique.Size = new System.Drawing.Size(104, 24);
            this.label_Historique.TabIndex = 21;
            this.label_Historique.Text = "Historique";
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(33, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(73, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 20;
            this.pictureBoxLogo.TabStop = false;
            // 
            // contenuInventaireBindingSource
            // 
            this.contenuInventaireBindingSource.DataSource = typeof(DashBoard_Stive.ContenuInventaire);
            // 
            // Pro_Nom
            // 
            this.Pro_Nom.DataPropertyName = "Pro_Nom";
            this.Pro_Nom.HeaderText = "Produit";
            this.Pro_Nom.Name = "Pro_Nom";
            this.Pro_Nom.ReadOnly = true;
            // 
            // Typ_Libelle
            // 
            this.Typ_Libelle.DataPropertyName = "Typ_Libelle";
            this.Typ_Libelle.HeaderText = "Type";
            this.Typ_Libelle.Name = "Typ_Libelle";
            this.Typ_Libelle.ReadOnly = true;
            // 
            // Fou_NomDomaine
            // 
            this.Fou_NomDomaine.DataPropertyName = "Fou_NomDomaine";
            this.Fou_NomDomaine.HeaderText = "Fournisseur";
            this.Fou_NomDomaine.Name = "Fou_NomDomaine";
            this.Fou_NomDomaine.ReadOnly = true;
            // 
            // Pro_Quantite
            // 
            this.Pro_Quantite.DataPropertyName = "Pro_Quantite";
            this.Pro_Quantite.HeaderText = "Stock";
            this.Pro_Quantite.Name = "Pro_Quantite";
            this.Pro_Quantite.ReadOnly = true;
            // 
            // Inv
            // 
            this.Inv.HeaderText = "Inventaire";
            this.Inv.Name = "Inv";
            // 
            // coIInvIdDataGridViewTextBoxColumn
            // 
            this.coIInvIdDataGridViewTextBoxColumn.DataPropertyName = "CoI_Inv_Id";
            this.coIInvIdDataGridViewTextBoxColumn.HeaderText = "CoI_Inv_Id";
            this.coIInvIdDataGridViewTextBoxColumn.Name = "coIInvIdDataGridViewTextBoxColumn";
            this.coIInvIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // coiDateCreationDataGridViewTextBoxColumn
            // 
            this.coiDateCreationDataGridViewTextBoxColumn.DataPropertyName = "Coi_DateCreation";
            this.coiDateCreationDataGridViewTextBoxColumn.HeaderText = "Coi_DateCreation";
            this.coiDateCreationDataGridViewTextBoxColumn.Name = "coiDateCreationDataGridViewTextBoxColumn";
            this.coiDateCreationDataGridViewTextBoxColumn.Visible = false;
            // 
            // coiDateMajDataGridViewTextBoxColumn
            // 
            this.coiDateMajDataGridViewTextBoxColumn.DataPropertyName = "Coi_DateMaj";
            this.coiDateMajDataGridViewTextBoxColumn.HeaderText = "Coi_DateMaj";
            this.coiDateMajDataGridViewTextBoxColumn.Name = "coiDateMajDataGridViewTextBoxColumn";
            this.coiDateMajDataGridViewTextBoxColumn.Visible = false;
            // 
            // Coi_ProId
            // 
            this.Coi_ProId.DataPropertyName = "Coi_ProId";
            this.Coi_ProId.HeaderText = "Coi_ProId";
            this.Coi_ProId.Name = "Coi_ProId";
            this.Coi_ProId.Visible = false;
            // 
            // Coi_ProLibelle
            // 
            this.Coi_ProLibelle.DataPropertyName = "Coi_ProLibelle";
            this.Coi_ProLibelle.HeaderText = "Coi_ProLibelle";
            this.Coi_ProLibelle.Name = "Coi_ProLibelle";
            this.Coi_ProLibelle.Visible = false;
            // 
            // Coi_ProQuantite
            // 
            this.Coi_ProQuantite.DataPropertyName = "Coi_ProQuantite";
            this.Coi_ProQuantite.HeaderText = "Coi_ProQuantite";
            this.Coi_ProQuantite.Name = "Coi_ProQuantite";
            this.Coi_ProQuantite.Visible = false;
            // 
            // Coi_Inventaire
            // 
            this.Coi_Inventaire.DataPropertyName = "Coi_Inventaire";
            this.Coi_Inventaire.HeaderText = "Coi_Inventaire";
            this.Coi_Inventaire.Name = "Coi_Inventaire";
            this.Coi_Inventaire.Visible = false;
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 601);
            this.Controls.Add(this.panel_Inventaire);
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Inventaire)).EndInit();
            this.panel_Inventaire.ResumeLayout(false);
            this.panel_Inventaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Historique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contenuInventaireBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dv_Inventaire;
        private System.Windows.Forms.Label label_Inventaire;
        private System.Windows.Forms.Panel panel_Inventaire;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label label_Historique;
        private System.Windows.Forms.DataGridView Dv_Historique;
        private System.Windows.Forms.Button buttonSaveAndMajInventaire;
        private System.Windows.Forms.Button button_SaveInventaire;
        private System.Windows.Forms.BindingSource contenuInventaireBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Typ_Libelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fou_NomDomaine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pro_Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inv;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIInvIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiDateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiDateMajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_ProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_ProLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_ProQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_Inventaire;
    }
}