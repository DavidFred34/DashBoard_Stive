using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard_Stive
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = "../../images/logoStive.png";
            //pictureBoxUser.ImageLocation = "../../images/concombres01.png";
            pictureBoxProduit.ImageLocation = "../../images/VinRouge.jpg";
            ReinitBouton();
        }

        private void ReinitBouton()
        {
            panelAccueil.Visible = false;
            panelProduit.Visible = false;
            panelClients.Visible = false;
            panelBdc.Visible = false;
            panelCommandesWeb.Visible = false;
            panelFournisseurs.Visible = false;


            foreach (var item in panelMenu.Controls)
            {
                if (item is Button) { (item as Button).Tag = 0; }
            }
        }

        private void Stamper(
                        //champs fournisseur
                        string NomDomaine = "",
                        string DateCreation = "",
                        string NomResp = "",
                        string TelResp = "",
                        string MailResp = "",
                        string Fonction = "",
                        string TelContact = "",
                        string MailContact = "",
                        string Mdp = "",
                        string Adresse = "",
                        string CompAdresse = "",
                        string CodePostal = "",
                        string Ville = "",
                        string Pays = ""
                        )
        {
            textBoxNomDomaine.Text = NomDomaine;
            labelDateCreation.Text = "Créé le " + DateCreation;
            textBoxNomResp.Text = NomResp;
            textBoxTelResp.Text = TelResp;
            textBoxMailResp.Text = MailResp;
            textBoxFonction.Text = Fonction;
            textBoxTelContact.Text = TelContact;
            textBoxMailContact.Text = MailContact;
            textBoxMdp.Text = Mdp;
            textBoxAdresse.Text = Adresse;
            textBoxCompAdresse.Text = CompAdresse;
            textBoxCodePostal.Text = CodePostal;
            textBoxVille.Text = Ville;
            textBoxPays.Text = Pays;

        }
        

        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            if ((int?)(sender as Button).Tag == 1) {
                buttonProduit.BackColor = Color.FromArgb(44, 130, 201);
                buttonProduit.ForeColor = Color.FromArgb(255, 255, 255);
                return;
            }
            

            (sender as Button).BackColor = Color.FromArgb(44, 130, 201);
            (sender as Button).ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            if ((int?)(sender as Button).Tag == 1)
            {
                buttonProduit.BackColor = Color.FromArgb(44, 130, 201);
                buttonProduit.ForeColor = Color.FromArgb(255, 255, 255);
                return;
            }
                (sender as Button).BackColor = Color.FromArgb(137, 196, 244);
                (sender as Button).ForeColor = Color.FromArgb(44, 130, 201);
        }


        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            ReinitBouton();
            buttonAccueil.BackColor = Color.FromArgb(44, 130, 201);
            buttonAccueil.ForeColor = Color.FromArgb(255, 255, 255);
            panelAccueil.Visible = true;
            buttonAccueil.Tag = 1;

        }

        private void buttonProduit_Click(object sender, EventArgs e)
        {
            ReinitBouton();
            buttonProduit.BackColor = Color.FromArgb(44, 130, 201);
            buttonProduit.ForeColor = Color.FromArgb(255, 255, 255);
            panelProduit.Visible = true;
            buttonProduit.Tag = 1;
        }

        private void buttonClients_Click(object sender, EventArgs e)
        {
            ReinitBouton();
            buttonClients.BackColor = Color.FromArgb(44, 130, 201);
            buttonClients.ForeColor = Color.FromArgb(255, 255, 255);
            panelClients.Visible = true;

            buttonClients.Tag = 1;
        }

        private void buttonBdc_Click(object sender, EventArgs e)
        {
            ReinitBouton();
            buttonBdc.BackColor = Color.FromArgb(44, 130, 201);
            buttonBdc.ForeColor = Color.FromArgb(255, 255, 255);
            panelBdc.Visible = true;
            buttonBdc.Tag = 1;
        }

        private void buttonCommandesWeb_Click(object sender, EventArgs e)
        {
            ReinitBouton();
            buttonCommandesWeb.BackColor = Color.FromArgb(44, 130, 201);
            buttonCommandesWeb.ForeColor = Color.FromArgb(255, 255, 255);
            panelCommandesWeb.Visible = true;
            buttonCommandesWeb.Tag = 1;
        }

        private void buttonFournisseurs_Click(object sender, EventArgs e)
        {

            ReinitBouton();
            buttonFournisseurs.BackColor = Color.FromArgb(44, 130, 201);
            buttonFournisseurs.ForeColor = Color.FromArgb(255, 255, 255);
            panelFournisseurs.Visible = true;
            buttonFournisseurs.Tag = 1;
            buttonCreerFournisseur.Visible = true;
            buttonMajFournisseur.Visible = false;
            buttonSuppFournisseur.Visible = false;
            dataGridViewListeBdc.Visible = false;
            dataGridViewListeProduit.Visible = false;
            labelListeBdc.Visible = false;
            labelListeProduit.Visible = false;

            //const string bt_Fournisseur = @"
            //    [
            //        {
            //            Uti_Id : ""1"",
            //            Uti_Adresse :  ""3 rue de la paix"" 
            //            Uti_CompAdresse :""bat H""
            //            Uti_Cp :""34080""
            //            Uti_Ville :   ""Pas montpellier"" 
            //            Uti_Pays : ""france""
            //            Uti_TelContact :""0684529261""
            //            Uti_Mdp : ""1234""
            //            Uti_VerifMdp : ""1234""
            //            Uti_MailContact : ""moi@pasmoi.com""
            //            Uti_DateCreation : ""01/68/1987""
            //        },
            //        {
            //            Uti_Id: ""2""
            //            Uti_Adresse: ""ici"" 
            //            Uti_CompAdresse: ""pas la bas""
            //            Uti_Cp: ""30080""
            //            Uti_Ville: ""Nime""
            //            Uti_Pays: ""Belgique""
            //            Uti_TelContact: ""0521252569""
            //            Uti_Mdp: ""567""
            //            Uti_VerifMdp: ""1234""
            //            Uti_MailContact: ""lui@paslui.com""
            //            Uti_DateCreation: ""01/01/2021""
            //        }
            //        ]";


            const string bt_Fournisseur = @"
                [
                    {   Fou_Id : 1,
                        Fou_NomDomaine : ""Domaine de Tariquet"",
                        Fou_NomResp : ""Max"",
                        Fou_TelResp : ""0125254589"",
                        Fou_MailResp : ""max@Tariquet.com"",
                        Fou_Fonction : ""Gérant"",
                        Fou_DateCreation : ""24/12/1987"",
                        Fou_Role : ""admin"",
                        Uti_Id : 1,
                        Uti_Adresse :  ""3 rue de la paix"" ,
                        Uti_CompAdresse :""bat H"",
                        Uti_Cp :""34080"",
                        Uti_Ville :   ""Pas montpellier"" ,
                        Uti_Pays : ""france"",
                        Uti_TelContact :""0684529261"",
                        Uti_Mdp : ""1234"",
                        Uti_VerifMdp : ""1234"",
                        Uti_MailContact : ""moi@pasmoi.com"",
                        Uti_DateCreation : ""24/12/1987""
                    },

                    {
                        Fou_Id : 2,
                        Fou_NomDomaine : ""Domaine des pins"",
                        Fou_NomResp : ""Lolo"",
                        Fou_TelResp : ""0125254590"",
                        Fou_MailResp : ""lolo@lolo.com"",
                        Fou_Fonction : ""Gérant"",
                        Fou_DateCreation : ""24/12/1990"",
                        Fou_Role : ""fournisseur"",
                        Uti_Id: 2,
                        Uti_Adresse: ""ici"" ,
                        Uti_CompAdresse: ""pas la bas"",
                        Uti_Cp: ""30080"",
                        Uti_Ville: ""Nime"",
                        Uti_Pays: ""Belgique"",
                        Uti_TelContact: ""0521252569"",
                        Uti_Mdp: ""567"",
                        Uti_VerifMdp: ""1234"",
                        Uti_MailContact: ""lui@paslui.com"",
                        Uti_DateCreation: ""01/01/2021""
                    }   
                    ]";
            utiListe = JsonConvert.DeserializeObject<List<Fournisseur>>(bt_Fournisseur);
            //Dv_fournisseur.Columns.Add("Uti_Pays", "Pays");
            Dv_fournisseur.DataSource = utiListe;
            Dv_fournisseur.Columns["Fou_NomDomaine"].HeaderText = "Fournisseur";
            //Dv_fournisseur.Columns["Fou_NomResp"].Visible = false;
            Dv_fournisseur.Columns["Fou_NomResp"].HeaderText = "Responsable";
            Dv_fournisseur.Columns["Fou_TelResp"].HeaderText = "Tel";
            Dv_fournisseur.Columns["Fou_MailResp"].HeaderText = "Mail";
            Dv_fournisseur.Columns["Uti_Cp"].HeaderText = "CP";
            Dv_fournisseur.Columns["Uti_Ville"].HeaderText = "Ville";
        }
        List<Fournisseur> utiListe;

        private void Dv_fournisseur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewListeBdc.Visible = true;
            dataGridViewListeProduit.Visible = true;
            labelListeBdc.Visible = true;
            labelListeProduit.Visible = true;

            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;

            //string text = Dv_fournisseur.Rows[e.RowIndex].Cells["FouNomDomaineDataGridViewTextBoxColumn"].Value.ToString();  //affiche dans la message box le contenu de Uti_Adresse
            //MessageBox.Show(text);
            //  textBoxNomDomaine.Text =  Dv_fournisseur.Rows[e.RowIndex].Cells["fouNomDomaineDataGridViewTextBoxColumn"].Value.ToString(); // via datgagrid
            //textBoxAdresse.Text = utiListe[e.RowIndex].Uti_Adresse;
            Stamper(
                NomDomaine:utiListe[e.RowIndex].Fou_NomDomaine,
                DateCreation: utiListe[e.RowIndex].Uti_DateCreation,
                NomResp: utiListe[e.RowIndex].Fou_NomResp,
                TelResp: utiListe[e.RowIndex].Fou_TelResp,
                MailResp: utiListe[e.RowIndex].Fou_MailResp,
                Fonction: utiListe[e.RowIndex].Fou_Fonction,
                TelContact: utiListe[e.RowIndex].Uti_TelContact,
                MailContact: utiListe[e.RowIndex].Uti_MailContact,
                Adresse: utiListe[e.RowIndex].Uti_Adresse,
                CompAdresse: utiListe[e.RowIndex].Uti_CompAdresse,
                CodePostal: utiListe[e.RowIndex].Uti_Cp,
                Ville: utiListe[e.RowIndex].Uti_Ville,
                Pays: utiListe[e.RowIndex].Uti_Pays
                );
            buttonCreerFournisseur.Visible = false;
            buttonMajFournisseur.Visible = true;
            buttonSuppFournisseur.Visible = true;

            //MessageBox.Show(textBoxNomDomaine.Text);

            //labelNomDomaine.Text = Fournisseur.Equals(Fou_NomDomaine).ToString();
            // MessageBox.Show(labelDateCreation.Text);
            //Dv_fournisseur.Rows[e.RowIndex].Cells["Fou_DateCreation"].Value.ToString();
            // textBoxNomResp.Text = Dv_fournisseur.Rows[e.RowIndex].Cells["Fou_NomResp"].Value.ToString();

        }

        private void buttonAjouterfournisseur_Click(object sender, EventArgs e)
        {
            Stamper(
                NomDomaine: "",
                DateCreation: "",
                NomResp: "",
                TelResp: "",
                MailResp: "",
                Fonction: "",
                TelContact: "",
                MailContact: "",
                Adresse: "",
                CompAdresse: "",
                CodePostal: "",
                Ville: "",
                Pays: ""
                );
            buttonCreerFournisseur.Visible = true;
            buttonMajFournisseur.Visible = false;
            buttonSuppFournisseur.Visible = false;
            dataGridViewListeBdc.Visible = false;
            dataGridViewListeProduit.Visible = false;
            labelListeBdc.Visible = false;
            labelListeProduit.Visible = false;
        }

        private void buttonCreerFournisseur_Click(object sender, EventArgs e)
        {
            var httpClient = new HttpClient();
            var response = await
                _httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/ajouter.php");
            response.Ensur esuccessStatusCode();

            var content = await response.Content.ReadAsAStringAsync();
            utiListe = JsonConvert.DeserializeObject<List<Fournisseur>>(content);


            //requette http
            /* json
             Fou_NomDomaine,
             Fou_NomResp,
             Fou_TelResp,
             Fou_MailResp,
             Fou_Fonction,
             Uti_TelContact,
             Uti_MailContact,

             Uti_Adresse,
             Uti_CompAdresse,
             Uti_Cp,
             Uti_Ville,
             Uti_Pays
             Fou_Role

            Fou_Id : 2,
                        Fou_NomDomaine : ""Domaine des pins"",
                        Fou_NomResp : ""Lolo"",
                        Fou_TelResp : ""0125254590"",
                        Fou_MailResp : ""lolo@lolo.com"",
                        Fou_Fonction : ""Gérant"",
                        Fou_DateCreation : ""24/12/1990"",
                        Fou_Role : ""fournisseur"",
                        Uti_Id: 2,
                        Uti_Adresse: ""ici"" ,
                        Uti_CompAdresse: ""pas la bas"",
                        Uti_Cp: ""30080"",
                        Uti_Ville: ""Nime"",
                        Uti_Pays: ""Belgique"",
                        Uti_TelContact: ""0521252569"",
                        Uti_Mdp: ""567"",
                        Uti_VerifMdp: ""1234"",
                        Uti_MailContact: ""lui@paslui.com"",
                        Uti_DateCreation: ""01/01/2021""
            */
        }
    }
}
