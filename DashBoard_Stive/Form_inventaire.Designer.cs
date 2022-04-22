
namespace DashBoard_Stive
{
    partial class Form_inventaire
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
            this.Btn_MajStock = new System.Windows.Forms.Button();
            this.Btn_SaveInventaire = new System.Windows.Forms.Button();
            this.label_Historique = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.Btn_AjouterInventaire = new System.Windows.Forms.Button();
            this.invIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invDateCreationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invDateMajDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invStockRegulDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coiProNomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiTypLibelleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiFouNomDomaineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiProQuantiteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiInventaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invStockRegulDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coiProIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenuInventaireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Inventaire)).BeginInit();
            this.panel_Inventaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Historique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireBindingSource)).BeginInit();
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
            this.coiProNomDataGridViewTextBoxColumn,
            this.coiTypLibelleDataGridViewTextBoxColumn,
            this.coiFouNomDomaineDataGridViewTextBoxColumn,
            this.coiProQuantiteDataGridViewTextBoxColumn,
            this.coiInventaireDataGridViewTextBoxColumn,
            this.invStockRegulDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.coiProIdDataGridViewTextBoxColumn});
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
            this.panel_Inventaire.Controls.Add(this.Btn_MajStock);
            this.panel_Inventaire.Controls.Add(this.Btn_SaveInventaire);
            this.panel_Inventaire.Controls.Add(this.label_Historique);
            this.panel_Inventaire.Controls.Add(this.Dv_Inventaire);
            this.panel_Inventaire.Controls.Add(this.pictureBoxLogo);
            this.panel_Inventaire.Controls.Add(this.label_Inventaire);
            this.panel_Inventaire.Controls.Add(this.Btn_AjouterInventaire);
            this.panel_Inventaire.Location = new System.Drawing.Point(2, 1);
            this.panel_Inventaire.Name = "panel_Inventaire";
            this.panel_Inventaire.Size = new System.Drawing.Size(1102, 601);
            this.panel_Inventaire.TabIndex = 21;
            // 
            // Dv_Historique
            // 
            this.Dv_Historique.AllowUserToAddRows = false;
            this.Dv_Historique.AllowUserToResizeColumns = false;
            this.Dv_Historique.AutoGenerateColumns = false;
            this.Dv_Historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dv_Historique.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invIdDataGridViewTextBoxColumn,
            this.invDateCreationDataGridViewTextBoxColumn,
            this.invDateMajDataGridViewTextBoxColumn,
            this.invStockRegulDataGridViewTextBoxColumn1});
            this.Dv_Historique.DataSource = this.inventaireBindingSource;
            this.Dv_Historique.Location = new System.Drawing.Point(744, 35);
            this.Dv_Historique.Name = "Dv_Historique";
            this.Dv_Historique.ReadOnly = true;
            this.Dv_Historique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dv_Historique.Size = new System.Drawing.Size(313, 158);
            this.Dv_Historique.TabIndex = 25;
            this.Dv_Historique.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Dv_Historique_CellMouseClick);
            // 
            // Btn_MajStock
            // 
            this.Btn_MajStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(130)))), ((int)(((byte)(201)))));
            this.Btn_MajStock.FlatAppearance.BorderSize = 0;
            this.Btn_MajStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MajStock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MajStock.ForeColor = System.Drawing.Color.White;
            this.Btn_MajStock.Location = new System.Drawing.Point(797, 360);
            this.Btn_MajStock.Name = "Btn_MajStock";
            this.Btn_MajStock.Size = new System.Drawing.Size(219, 53);
            this.Btn_MajStock.TabIndex = 24;
            this.Btn_MajStock.Text = "Mettre  à jour le stock";
            this.Btn_MajStock.UseVisualStyleBackColor = false;
            this.Btn_MajStock.Visible = false;
            // 
            // Btn_SaveInventaire
            // 
            this.Btn_SaveInventaire.FlatAppearance.BorderSize = 0;
            this.Btn_SaveInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SaveInventaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SaveInventaire.ForeColor = System.Drawing.Color.Green;
            this.Btn_SaveInventaire.Location = new System.Drawing.Point(797, 275);
            this.Btn_SaveInventaire.Name = "Btn_SaveInventaire";
            this.Btn_SaveInventaire.Size = new System.Drawing.Size(219, 34);
            this.Btn_SaveInventaire.TabIndex = 23;
            this.Btn_SaveInventaire.Text = "Enregistrer l\'inventaire";
            this.Btn_SaveInventaire.UseVisualStyleBackColor = true;
            this.Btn_SaveInventaire.Click += new System.EventHandler(this.Btn_SaveInventaire_Click);
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
            // Btn_AjouterInventaire
            // 
            this.Btn_AjouterInventaire.FlatAppearance.BorderSize = 0;
            this.Btn_AjouterInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AjouterInventaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AjouterInventaire.ForeColor = System.Drawing.Color.Green;
            this.Btn_AjouterInventaire.Location = new System.Drawing.Point(471, 8);
            this.Btn_AjouterInventaire.Name = "Btn_AjouterInventaire";
            this.Btn_AjouterInventaire.Size = new System.Drawing.Size(237, 31);
            this.Btn_AjouterInventaire.TabIndex = 37;
            this.Btn_AjouterInventaire.Text = "Nouvel inventaire";
            this.Btn_AjouterInventaire.UseVisualStyleBackColor = true;
            this.Btn_AjouterInventaire.Click += new System.EventHandler(this.Btn_AjouterInventaire_Click);
            // 
            // invIdDataGridViewTextBoxColumn
            // 
            this.invIdDataGridViewTextBoxColumn.DataPropertyName = "Inv_Id";
            this.invIdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.invIdDataGridViewTextBoxColumn.Name = "invIdDataGridViewTextBoxColumn";
            this.invIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invDateCreationDataGridViewTextBoxColumn
            // 
            this.invDateCreationDataGridViewTextBoxColumn.DataPropertyName = "Inv_DateCreation";
            this.invDateCreationDataGridViewTextBoxColumn.HeaderText = "Date";
            this.invDateCreationDataGridViewTextBoxColumn.Name = "invDateCreationDataGridViewTextBoxColumn";
            this.invDateCreationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invDateMajDataGridViewTextBoxColumn
            // 
            this.invDateMajDataGridViewTextBoxColumn.DataPropertyName = "Inv_DateMaj";
            this.invDateMajDataGridViewTextBoxColumn.HeaderText = "Inv_DateMaj";
            this.invDateMajDataGridViewTextBoxColumn.Name = "invDateMajDataGridViewTextBoxColumn";
            this.invDateMajDataGridViewTextBoxColumn.ReadOnly = true;
            this.invDateMajDataGridViewTextBoxColumn.Visible = false;
            // 
            // invStockRegulDataGridViewTextBoxColumn1
            // 
            this.invStockRegulDataGridViewTextBoxColumn1.DataPropertyName = "Inv_StockRegul";
            this.invStockRegulDataGridViewTextBoxColumn1.HeaderText = "Maj Stock";
            this.invStockRegulDataGridViewTextBoxColumn1.Name = "invStockRegulDataGridViewTextBoxColumn1";
            this.invStockRegulDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // inventaireBindingSource
            // 
            this.inventaireBindingSource.DataSource = typeof(DashBoard_Stive.Inventaire);
            // 
            // coiProNomDataGridViewTextBoxColumn
            // 
            this.coiProNomDataGridViewTextBoxColumn.DataPropertyName = "Coi_Pro_Nom";
            this.coiProNomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.coiProNomDataGridViewTextBoxColumn.Name = "coiProNomDataGridViewTextBoxColumn";
            this.coiProNomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coiTypLibelleDataGridViewTextBoxColumn
            // 
            this.coiTypLibelleDataGridViewTextBoxColumn.DataPropertyName = "Coi_Typ_Libelle";
            this.coiTypLibelleDataGridViewTextBoxColumn.HeaderText = "Type";
            this.coiTypLibelleDataGridViewTextBoxColumn.Name = "coiTypLibelleDataGridViewTextBoxColumn";
            this.coiTypLibelleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coiFouNomDomaineDataGridViewTextBoxColumn
            // 
            this.coiFouNomDomaineDataGridViewTextBoxColumn.DataPropertyName = "Coi_Fou_NomDomaine";
            this.coiFouNomDomaineDataGridViewTextBoxColumn.HeaderText = "Fournisseur";
            this.coiFouNomDomaineDataGridViewTextBoxColumn.Name = "coiFouNomDomaineDataGridViewTextBoxColumn";
            this.coiFouNomDomaineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coiProQuantiteDataGridViewTextBoxColumn
            // 
            this.coiProQuantiteDataGridViewTextBoxColumn.DataPropertyName = "Coi_Pro_Quantite";
            this.coiProQuantiteDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.coiProQuantiteDataGridViewTextBoxColumn.Name = "coiProQuantiteDataGridViewTextBoxColumn";
            this.coiProQuantiteDataGridViewTextBoxColumn.ReadOnly = true;
            this.coiProQuantiteDataGridViewTextBoxColumn.Width = 50;
            // 
            // coiInventaireDataGridViewTextBoxColumn
            // 
            this.coiInventaireDataGridViewTextBoxColumn.DataPropertyName = "Coi_Inventaire";
            this.coiInventaireDataGridViewTextBoxColumn.HeaderText = "Inventaire";
            this.coiInventaireDataGridViewTextBoxColumn.Name = "coiInventaireDataGridViewTextBoxColumn";
            this.coiInventaireDataGridViewTextBoxColumn.Width = 70;
            // 
            // invStockRegulDataGridViewTextBoxColumn
            // 
            this.invStockRegulDataGridViewTextBoxColumn.DataPropertyName = "Inv_StockRegul";
            this.invStockRegulDataGridViewTextBoxColumn.HeaderText = "MAJ";
            this.invStockRegulDataGridViewTextBoxColumn.Name = "invStockRegulDataGridViewTextBoxColumn";
            this.invStockRegulDataGridViewTextBoxColumn.ReadOnly = true;
            this.invStockRegulDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Coi_DateCreation";
            this.dataGridViewTextBoxColumn2.HeaderText = "Coi_DateCreation";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Coi_Inv_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Coi_Inv_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Coi_DateMaj";
            this.dataGridViewTextBoxColumn3.HeaderText = "Coi_DateMaj";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // coiProIdDataGridViewTextBoxColumn
            // 
            this.coiProIdDataGridViewTextBoxColumn.DataPropertyName = "Coi_Pro_Id";
            this.coiProIdDataGridViewTextBoxColumn.HeaderText = "Coi_Pro_Id";
            this.coiProIdDataGridViewTextBoxColumn.Name = "coiProIdDataGridViewTextBoxColumn";
            this.coiProIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // contenuInventaireBindingSource
            // 
            this.contenuInventaireBindingSource.DataSource = typeof(DashBoard_Stive.ContenuInventaire);
            // 
            // Form_inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 601);
            this.Controls.Add(this.panel_Inventaire);
            this.Name = "Form_inventaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Inventaire)).EndInit();
            this.panel_Inventaire.ResumeLayout(false);
            this.panel_Inventaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Historique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventaireBindingSource)).EndInit();
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
        private System.Windows.Forms.Button Btn_MajStock;
        private System.Windows.Forms.Button Btn_SaveInventaire;
        private System.Windows.Forms.BindingSource contenuInventaireBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIInvIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiDateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiDateMajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_ProId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_ProLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coi_ProQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiProNomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiTypLibelleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiFouNomDomaineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiProQuantiteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiInventaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invStockRegulDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn coiProIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invDateCreationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invDateMajDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invStockRegulDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource inventaireBindingSource;
        private System.Windows.Forms.Button Btn_AjouterInventaire;
    }
}