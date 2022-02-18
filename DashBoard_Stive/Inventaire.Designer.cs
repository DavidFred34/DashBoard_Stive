
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
            this.Dv_Inventaire = new System.Windows.Forms.DataGridView();
            this.label_Inventaire = new System.Windows.Forms.Label();
            this.panel_Inventaire = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label_Historique = new System.Windows.Forms.Label();
            this.button_SaveInventaire = new System.Windows.Forms.Button();
            this.buttonSaveAndMajInventaire = new System.Windows.Forms.Button();
            this.Dv_Historique = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Inventaire)).BeginInit();
            this.panel_Inventaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Historique)).BeginInit();
            this.SuspendLayout();
            // 
            // Dv_Inventaire
            // 
            this.Dv_Inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dv_Inventaire.Location = new System.Drawing.Point(145, 35);
            this.Dv_Inventaire.Name = "Dv_Inventaire";
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
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(33, 11);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(73, 90);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 20;
            this.pictureBoxLogo.TabStop = false;
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
            // button_SaveInventaire
            // 
            this.button_SaveInventaire.FlatAppearance.BorderSize = 0;
            this.button_SaveInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SaveInventaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveInventaire.ForeColor = System.Drawing.Color.Green;
            this.button_SaveInventaire.Location = new System.Drawing.Point(838, 286);
            this.button_SaveInventaire.Name = "button_SaveInventaire";
            this.button_SaveInventaire.Size = new System.Drawing.Size(125, 34);
            this.button_SaveInventaire.TabIndex = 23;
            this.button_SaveInventaire.Text = "Enregistrer";
            this.button_SaveInventaire.UseVisualStyleBackColor = true;
            this.button_SaveInventaire.Click += new System.EventHandler(this.button_SaveInventaire_Click);
            // 
            // buttonSaveAndMajInventaire
            // 
            this.buttonSaveAndMajInventaire.FlatAppearance.BorderSize = 0;
            this.buttonSaveAndMajInventaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveAndMajInventaire.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveAndMajInventaire.ForeColor = System.Drawing.Color.Green;
            this.buttonSaveAndMajInventaire.Location = new System.Drawing.Point(838, 360);
            this.buttonSaveAndMajInventaire.Name = "buttonSaveAndMajInventaire";
            this.buttonSaveAndMajInventaire.Size = new System.Drawing.Size(125, 114);
            this.buttonSaveAndMajInventaire.TabIndex = 24;
            this.buttonSaveAndMajInventaire.Text = "Enregistrer et mettre à jour le stock";
            this.buttonSaveAndMajInventaire.UseVisualStyleBackColor = true;
            this.buttonSaveAndMajInventaire.Click += new System.EventHandler(this.buttonSaveAndMajInventaire_Click);
            // 
            // Dv_Historique
            // 
            this.Dv_Historique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dv_Historique.Location = new System.Drawing.Point(744, 35);
            this.Dv_Historique.Name = "Dv_Historique";
            this.Dv_Historique.Size = new System.Drawing.Size(313, 158);
            this.Dv_Historique.TabIndex = 25;
            // 
            // Inventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 601);
            this.Controls.Add(this.panel_Inventaire);
            this.Location = new System.Drawing.Point(2000, 600);
            this.Name = "Inventaire";
            this.Text = "Inventaire";
            this.Load += new System.EventHandler(this.Inventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Inventaire)).EndInit();
            this.panel_Inventaire.ResumeLayout(false);
            this.panel_Inventaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_Historique)).EndInit();
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
    }
}