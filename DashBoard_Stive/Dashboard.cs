using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DashBoard_Stive;
using System.Text.RegularExpressions;

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
            //pictureBoxProduit.ImageLocation = "../../images/VinRouge.jpg";

            /* System.Data.DataTable dataTable = new System.Data.DataTable();
             dataTable.Columns.Add(supp DataColumn("Couleur", typeof(string)));
             dataTable.Columns.Add(supp DataColumn("Taille", typeof(string)));
             deleteButton.HeaderText = "Supprimer cette ";
             dataGridView1.Columns.Add(DeleteButton);
             dataTable.Rows.Add(new string[] { " rouge ", " Large" });*/

            ReinitBouton();
            buttonAccueil.PerformClick();
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
                if (item is Button) 
                { (item as Button).Tag = 0;
                    (item as Button).BackColor = Color.FromArgb(137, 196, 244);
                    (item as Button).ForeColor = Color.FromArgb(44, 130, 201);
                }

            }
        }


        //gestion du survol de la souris des btn du menu
        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            if ((int?)(sender as Button).Tag == 1)
            {

                return;
            }


            (sender as Button).BackColor = Color.FromArgb(44, 130, 201);
            (sender as Button).ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            if ((int?)(sender as Button).Tag == 1)
            {

                return;
            }
            (sender as Button).BackColor = Color.FromArgb(137, 196, 244);
            (sender as Button).ForeColor = Color.FromArgb(44, 130, 201);
        }

        //permet de renseigner les données fournisseur ds le panel 
        private void StamperFournisseur(
                        //champs fournisseur
                        string Uti_Id = "",
                        string Fou_Id = "",
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

            label_Uti_Id.Text = Uti_Id;
            label_Fou_Id.Text = Fou_Id;
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

        //permet de renseigner les données clients ds le panel client
        public void StamperClient(
                 //champs clients

                 string Nom = "",
                 string Prenom = "",
                 string DateNaissance = "",
                 string DateInscription = "",

                 //champs utilisateurs
                 string Uti_Id2 = "",
                 string Adresse2 = "",
                 string CompAdresse2 = "",
                 string CP = "",
                 string City = "",
                 string Country = "",
                 string TelContact = "",
                 string MailContact = "",
                 string Mdp2 = ""
                 // string VerifMdp = ""
                 )
        {
            labelUti_Id2.Text = Uti_Id2;
            textBoxNom2.Text = Nom;
            textBoxPrenom.Text = Prenom;
            labelInscription.Text = "Inscrit le " + DateInscription;
            //labelDateNaiss.Text = "né le " + DateNaissance;
            textBoxTel.Text = TelContact;
            textBoxMail.Text = MailContact;
            textBoxMdp2.Text = Mdp2;
            textBoxAdresse2.Text = Adresse2;
            textBoxCompAdresse2.Text = CompAdresse2;
            textBoxCP.Text = CP;
            textBoxCity.Text = City;
            textBoxCountry.Text = Country;

        }

        //permet de renseigner les données  ds le panel produit
        private void StamperProduit(
                        //champs fournisseur
                        string Pro_Fou_Id = "",
                        string Pro_Uti_Id = "",
                        string Pro_Id = "",
                        string Pro_Typ_Id = "",
                        string NomProduit = "",
                        string Domaine = "",
                        string Pro_Ref = "",
                        string Pro_Cepage = "",
                        string Pro_Annee = "",
                        string Pro_Prix = "",
                        string Pro_PrixLitre = "",
                        string Pro_Quantite = "",
                        string Pro_SeuilAlerte = "",
                        int Pro_CommandeAuto = 0,
                        string Pro_Volume = "",
                        string Pro_Description = "",
                        string Typ_Libelle = ""

                        )
        {
            label_pro_Fou_Id.Text = Pro_Fou_Id;
            label_pro_Uti_Id.Text = Pro_Uti_Id;
            labelPro_Typ_Id.Text = Pro_Typ_Id;
            label_Pro_Id.Text = Pro_Id;
            textBoxNomProduit.Text = NomProduit;
            comboBoxProposePar.Text = Domaine;
            comboBoxProposePar.Text = Domaine;
            textBoxRef.Text = Pro_Ref;
            textBoxCepage.Text = Pro_Cepage;
            textBoxMillesime.Text = Pro_Annee;
            textBoxPrix.Text = Pro_Prix;
            textBoxPrixLitre.Text = Pro_PrixLitre;
            textBoxEnStock.Text = Pro_Quantite;
            textBoxSeuilAlerte.Text = Pro_SeuilAlerte;
            if (Pro_CommandeAuto == 1)
            {
                checkBoxCommandeAuto.Checked = true;
            }
            else { checkBoxCommandeAuto.Checked = false; }
            textBoxVolume.Text = Pro_Volume;
            textBoxDescription.Text = Pro_Description;
            comboBoxTypeProduit.Text = Typ_Libelle;

        }

        //gestion du clic des boutons du menu et remplissagge des grid
        public async void buttonAccueil_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            buttonAccueil.BackColor = Color.FromArgb(44, 130, 201);
            buttonAccueil.ForeColor = Color.FromArgb(255, 255, 255);
            panelAccueil.Visible = true;
            buttonAccueil.Tag = 1;

            //Chargement liste produit
            try
            {
                var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
                var response = await
                    httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Produit/obtenirTous.php");
                response.EnsureSuccessStatusCode();
                
                var content = await response.Content.ReadAsStringAsync();
                
                prodListe = JsonConvert.DeserializeObject<List<Produit>>(content);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste produits non chargée");
                prodListe = null;
            }

            //MessageBox.Show(content2);  //controle du json

            //Chargement liste TypeProduit
            try
            {
                var httpClient2 = new HttpClient();   //connexion à la bdd Stive sur azure
                var response2 = await
                    httpClient2.GetAsync("https://apistive.azurewebsites.net/API/controlers/TypeProduit/obtenirTous.php");
                response2.EnsureSuccessStatusCode();

                var content2 = await response2.Content.ReadAsStringAsync();
                typListe = JsonConvert.DeserializeObject<List<TypeProduit>>(content2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste des types produits non chargée");
                typListe = null;
            }
            //MessageBox.Show(content2);  //controle du json

            //chargement liste fournisseur
            try
            {
                var httpClient3 = new HttpClient();   //connexion à la bdd Stive sur azure
                var response3 = await
                    httpClient3.GetAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/obtenirTous.php");
                response3.EnsureSuccessStatusCode();

                var content3 = await response3.Content.ReadAsStringAsync();
                fourListe = JsonConvert.DeserializeObject<List<Fournisseur>>(content3);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste des fournisseurs non chargée");
                typListe = null;
            }
            //MessageBox.Show(content3);  //controle du json
            //StamperFournisseur(CompAdresse: content3.ToString());


            //Affectation des listes
            Dv_TypeProduit.DataSource = typListe;
            Dv_fournisseur.DataSource = fourListe;
            Dv_ListeProduit.DataSource = prodListe;
            comboBoxTypeProduit.DataSource = typListe;
            comboBoxProposePar.DataSource = fourListe;

            filtre_fourListe = fourListe;
            filtre_prodListe = prodListe;

        }
        List<TypeProduit> typListe;
        List<Produit> prodListe;
        List<Fournisseur> fourListe;
        List<Fournisseur> filtre_fourListe;
        List<Produit> filtre_prodListe;

        private void buttonBdc_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            buttonBdc.BackColor = Color.FromArgb(44, 130, 201);
            buttonBdc.ForeColor = Color.FromArgb(255, 255, 255);
            panelBdc.Visible = true;
            buttonBdc.Tag = 1;

            MessageBox.Show("Fonctionnalité en cours de développement");
        }

        private void buttonCommandesWeb_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            buttonCommandesWeb.BackColor = Color.FromArgb(44, 130, 201);
            buttonCommandesWeb.ForeColor = Color.FromArgb(255, 255, 255);
            panelCommandesWeb.Visible = true;
            buttonCommandesWeb.Tag = 1;

            MessageBox.Show("Fonctionnalité non développée");
        }

        public void buttonFournisseurs_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            buttonFournisseurs.BackColor = Color.FromArgb(44, 130, 201);
            buttonFournisseurs.ForeColor = Color.FromArgb(255, 255, 255);
            panelFournisseurs.Visible = true;
            buttonFournisseurs.Tag = 1;
            buttonCreerFournisseur.Visible = true;
            buttonAjouterfournisseur.Visible = false;
            buttonMajFournisseur.Visible = false;
            buttonSuppFournisseur.Visible = false;
            Dv_ListeBdc.Visible = false;
            Dv_ListeProduit2.Visible = false;
            labelListeBdc.Visible = false;
            labelListeProduit.Visible = false;
            textBoxCherchFournisseur.Text = "";
            StamperFournisseur(); //remet les champs à vide


            ////bouchon de test: simule le resultat du json obtenue
            /*const string bt_Fournisseur = @"     
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
                    ]"
           fourListe = JsonConvert.DeserializeObject<List<Fournisseur>>(bt_Fournisseur);
            */



            //MessageBox.Show(content);  //controle du json
            //declaration des colonnes de la grid

            Dv_fournisseur.Columns["Fou_NomDomaine"].HeaderText = "Fournisseur";
            Dv_fournisseur.Columns["Fou_NomResp"].HeaderText = "Responsable";
            Dv_fournisseur.Columns["Fou_TelResp"].HeaderText = "Tel";
            Dv_fournisseur.Columns["Fou_MailResp"].HeaderText = "Mail";
            Dv_fournisseur.Columns["Uti_Cp"].HeaderText = "CP";
            Dv_fournisseur.Columns["Uti_Ville"].HeaderText = "Ville";
            //Dv_fournisseur.Columns["Fou_NomResp"].Visible = false;
            //Dv_fournisseur.Columns.Add("Uti_Pays", "Pays");*/
        }



        public async void Dv_fournisseur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //gestion affichage
            Dv_ListeBdc.Visible = true;
            Dv_ListeProduit2.Visible = true;
            labelListeBdc.Visible = true;
            labelListeProduit.Visible = true;
            buttonCreerFournisseur.Visible = false;
            buttonAjouterfournisseur.Visible = true;
            buttonMajFournisseur.Visible = true;
            buttonSuppFournisseur.Visible = true;
            label_Fou_Id.Visible = true;
            label_Uti_Id.Visible = true;

            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
            StamperFournisseur(
                //Uti_Id: filtre_fourListe[e.RowIndex].Uti_Id.ToString(),
                //Fou_Id: filtre_fourListe[e.RowIndex].Fou_Id.ToString(),
                NomDomaine: filtre_fourListe[e.RowIndex].Fou_NomDomaine,
                DateCreation: filtre_fourListe[e.RowIndex].Uti_DateCreation,
                NomResp: filtre_fourListe[e.RowIndex].Fou_NomResp,
                TelResp: filtre_fourListe[e.RowIndex].Fou_TelResp,
                MailResp: filtre_fourListe[e.RowIndex].Fou_MailResp,
                Fonction: filtre_fourListe[e.RowIndex].Fou_Fonction,
                TelContact: filtre_fourListe[e.RowIndex].Uti_TelContact,
                MailContact: filtre_fourListe[e.RowIndex].Uti_MailContact,
                Mdp: ".......",
                Adresse: filtre_fourListe[e.RowIndex].Uti_Adresse,
                CompAdresse: filtre_fourListe[e.RowIndex].Uti_CompAdresse,
                CodePostal: filtre_fourListe[e.RowIndex].Uti_Cp,
                Ville: filtre_fourListe[e.RowIndex].Uti_Ville,
                Pays: filtre_fourListe[e.RowIndex].Uti_Pays
                );

            //chargement liste bdc_du fournisseur
            try
            {
                var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
                var url = "https://apistive.azurewebsites.net/API/controlers/CommandeFournisseur/ObtenirByIdFournisseur.php?Cof_Fou_Id=" + filtre_fourListe[e.RowIndex].Fou_Id;
                var response = await
                    httpClient.GetAsync(url);// label_Fou_Id.Text);
                response.EnsureSuccessStatusCode();

                var contentCommande = await response.Content.ReadAsStringAsync();

                bdcListe = JsonConvert.DeserializeObject<List<CommandeFournisseur>>(contentCommande);

                // MessageBox.Show(debug.ToString());  //controle du json
                // MessageBox.Show(contentCommande);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ce fournisseur n'a pas de bon de commande");
                bdcListe = null;
            }
            Dv_ListeBdc.DataSource = bdcListe;
            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;

            //chargement liste produit_du fournisseur  
            try
            {
                var httpClient2 = new HttpClient();   //connexion à la bdd Stive sur azure 
                var url2 = "https://apistive.azurewebsites.net/API/controlers/Produit/obtenir.php?Pro_Fou_Id=" + filtre_fourListe[e.RowIndex].Fou_Id;
                var response2 = await
                    httpClient2.GetAsync(url2);// label_Fou_Id.Text);
                response2.EnsureSuccessStatusCode();
                var contentProduit2 = await response2.Content.ReadAsStringAsync();
                
                prodListe2 = JsonConvert.DeserializeObject<List<Produit>>(contentProduit2);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ce fournisseur n'a pas de produit");
                prodListe2 = null;
            }

            // MessageBox.Show(contentProduit2.ToString());
            // StamperFournisseur(Adresse: contentProduit2.ToString()); //permet de recup le json pour le copier

            //controle du json
            // MessageBox.Show(contentProduit2);

            Dv_ListeBdc.DataSource = bdcListe;
            Dv_ListeProduit2.DataSource = prodListe2;
            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
        }
        List<CommandeFournisseur> bdcListe;
        List<Produit> prodListe2;

        private void buttonAjouterfournisseur_Click(object sender, EventArgs e)
        {
            //on propose une fiche vide
            StamperFournisseur(
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
            buttonAjouterfournisseur.Visible = false;
            buttonMajFournisseur.Visible = false;
            buttonSuppFournisseur.Visible = false;
            Dv_ListeBdc.Visible = false;
            Dv_ListeProduit2.Visible = false;
            labelListeBdc.Visible = false;
            labelListeProduit.Visible = false;
        }


        private async void buttonCreerFournisseur_Click(object sender, EventArgs e)
        {
            string bt_fournisseur = //bouchon test
                      @" {   
                        Fou_NomDomaine: """ + textBoxNomDomaine.Text + @""", 
                        Fou_NomResp: ""Max"",
                        Fou_TelResp: ""0125254589"",
                        Fou_MailResp: ""max @Tariquet.com"",
                        Fou_Fonction: ""Gérant"",
                        Fou_DateCreation: ""24 / 12 / 1987"",
                        Fou_Role: 3,
                        Fou_Uti_Id: 13,
                        Uti_Adresse: ""3 rue de la paix"" ,
                        Uti_CompAdresse: ""bat H"",
                        Uti_Cp: ""34080"",
                        Uti_Ville: ""Pas montpellier"" ,
                        Uti_Pays: ""france"",
                        Uti_TelContact: ""0684529261"",
                        Uti_Mdp: ""1234"",
                        Uti_VerifMdp: ""1234"",
                        Uti_MailContact: ""moi @pasmoi.com"",
                        Uti_DateCreation: ""28/01/2022""
                        
                    }";

            Fournisseur newFour = new Fournisseur();
            newFour.Fou_NomDomaine = textBoxNomDomaine.Text;
            newFour.Fou_NomResp = textBoxNomResp.Text;
            newFour.Fou_TelResp = textBoxTelResp.Text;
            newFour.Fou_MailResp = textBoxMailResp.Text;
            newFour.Fou_Fonction = textBoxFonction.Text;
            newFour.Fou_Role = "3";
            newFour.Uti_Adresse = textBoxAdresse.Text;
            newFour.Uti_CompAdresse = textBoxCompAdresse.Text;
            newFour.Uti_Cp = textBoxCodePostal.Text;
            newFour.Uti_Ville = textBoxVille.Text;
            newFour.Uti_Pays = textBoxPays.Text;
            newFour.Uti_TelContact = textBoxTelContact.Text;
            newFour.Uti_Mdp = textBoxMdp.Text;
            newFour.Uti_MailContact = textBoxMailContact.Text;

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newFour);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/ajouter.php", data);
            //MessageBox.Show(json.ToString());
            StamperFournisseur(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Fournisseur créé");
            }
            else
                MessageBox.Show("Erreur: fournisseur non créé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonAccueil.PerformClick();
            buttonFournisseurs.PerformClick();
            StamperFournisseur();
            //buttonAjouterfournisseur.PerformClick();
        }

        private async void buttonSuppFournisseur_Click(object sender, EventArgs e)
        {
            Fournisseur suppFour = new Fournisseur();
            //string v = label_Uti_Id.Text.ToString();
            suppFour.Uti_Id = int.Parse(label_Uti_Id.Text);

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(suppFour);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/supprimer.php", data);
            //Stamper(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                //DialogResult dialogResult = MessageBox.Show("Fournisseur supprimé", MessageBoxIcon.Information) ; 
                MessageBox.Show("Fournisseur supprimé");

            }
            else
                MessageBox.Show("Erreur: fournisseur non supprimé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonAccueil.PerformClick();
            buttonFournisseurs.PerformClick();
            StamperFournisseur();
        }

        private async void buttonMajFournisseur_Click(object sender, EventArgs e)
        {
            Fournisseur majFour = new Fournisseur();
            majFour.Fou_NomDomaine = textBoxNomDomaine.Text;
            majFour.Fou_NomResp = textBoxNomResp.Text;
            majFour.Fou_TelResp = textBoxTelResp.Text;
            majFour.Fou_MailResp = textBoxMailResp.Text;
            majFour.Fou_Fonction = textBoxFonction.Text;
            majFour.Fou_Role = "3";
            majFour.Uti_Adresse = textBoxAdresse.Text;
            majFour.Uti_CompAdresse = textBoxCompAdresse.Text;
            majFour.Uti_Cp = textBoxCodePostal.Text;
            majFour.Uti_Ville = textBoxVille.Text;
            majFour.Uti_Pays = textBoxPays.Text;
            majFour.Uti_TelContact = textBoxTelContact.Text;
            majFour.Uti_Mdp = textBoxMdp.Text;
            majFour.Uti_MailContact = textBoxMailContact.Text;
            majFour.Uti_Id = Convert.ToInt32(label_Uti_Id.Text);

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(majFour);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/modifier.php", data);
            //MessageBox.Show(json.ToString());
            //StamperFournisseur(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Fournisseur mis à jour");
            }
            else
                MessageBox.Show("Erreur: pas de mise à jour du fournisseur" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonAccueil.PerformClick();
            buttonFournisseurs.PerformClick();
            //StamperFournisseur();

        }

        /*private void buttonCherchFournisseur_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Dv_fournisseur.Rows.Count.ToString());
            for (int i = 0; i < Dv_fournisseur.Rows.Count; i++)
            {
                int result = 0;
                MessageBox.Show(i.ToString() + ' ' + result);
                foreach (DataGridViewCell cell in Dv_fournisseur.Rows[i].Cells)
                {
                    if (cell.Value != null && (cell.Value.ToString().IndexOf(textBoxCherchFournisseur.Text.ToString())) > 0)
                    //if (cell.Value != null && (cell.Value.ToString().Contains(textBoxCherchFournisseur.Text.ToString())))
                    {
                        result++;
                        //MessageBox.Show(Dv_fournisseur.Rows[i].ToString() + cell.Value.ToString());
                        //Dv_fournisseur.Rows[i].Cells.
                    }
                    else { cell.Style.BackColor = Color.White; };
                    if (result > 0) { cell.Style.BackColor = Color.LightBlue; };
                }
            }
        }*/

        private void textBoxCherchFournisseur_TextChanged(object sender, EventArgs e)
        {           
            filtre_fourListe = fourListe.Where(x => x.Fou_NomDomaine.ToLower().Contains(textBoxCherchFournisseur.Text.ToLower())).ToList();
            Dv_fournisseur.DataSource = filtre_fourListe;
        }

        private async void buttonClients_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            buttonClients.BackColor = Color.FromArgb(44, 130, 201);
            buttonClients.ForeColor = Color.FromArgb(255, 255, 255);
            panelClients.Visible = true;
            buttonAjouterClient.Visible = false;
            buttonCreerClient.Visible = true;
            buttonMajClient.Visible = false;
            buttonSuppClient.Visible = false;
            labelListCommande.Visible = false;
            textBoxCherchClient.Text = "";

            buttonClients.Tag = 1;

            dataGridViewListCommandeClient.Visible = false;
            StamperClient(); //remet les champs à vide


            //bouchon de test: simule le resultat du json obtenue
            /* const string bt_Client = @"     
                 [
                     {   Cli_Id : 1,
                         Cli_Nom : ""La menace"",
                         Cli_Prenom : ""Max"",
                         cli_DateNaissance : ""0125254589"",
                         cli_DateCreation : ""09/02/2022"",
                         Cli_Role : ""client"",
                         Uti_Id : 1,
                         Uti_Adresse :  ""rue x"" ,
                         Uti_CompAdresse :""bat rond"",
                         Uti_Cp :""34080"",
                         Uti_Ville :   ""montpellier"" ,
                         Uti_Pays : ""france"",
                         Uti_TelContact :""0121252545"",
                         Uti_Mdp : ""1234"",
                         Uti_VerifMdp : ""1234"",
                         Uti_MailContact : ""max@max.com"",
                         Uti_DateCreation : ""09/02/2022""
                     },

                     {
                         Cli_Id : 2,
                         Cli_Nom : ""Masqué"",
                         Cli_Prenom : ""le concombre"",
                         Cli_DateNaissance : ""0125254589"",
                         Cli_DateCreation : ""09/02/2022"",
                         Cli_Role : ""client"",
                         Uti_Id : 1,
                         Uti_Adresse :  ""rue du sud"" ,
                         Uti_CompAdresse :""square du truc"",
                         Uti_Cp :""30000"",
                         Uti_Ville :   ""nime"" ,
                         Uti_Pays : ""france"",
                         Uti_TelContact :""0621252545"",
                         Uti_Mdp : ""1234"",
                         Uti_VerifMdp : ""1234"",
                         Uti_MailContact : ""masque@masque.com"",
                         Uti_DateCreation : ""09/02/2022""
                     }  
                     ]";*/
            //version bouchon test
            //cliListe = JsonConvert.DeserializeObject<List<Client>>(bt_Client); 


            // version serveur
            var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
            var response = await
            httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Client/obtenirTous.php");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            cliListe = JsonConvert.DeserializeObject<List<Client>>(content);
            filtre_cliListe = cliListe;


            //MessageBox.Show(content);  //controle du json
            //declaration des colonnes de la grid

            //if (textBoxNom.Text != "") { Dv_ListClient.DataSource = filtre; } else { Dv_ListClient.DataSource = cliListe; }
            Dv_ListClient.DataSource = cliListe;
            Dv_ListClient.Columns["Cli_Nom"].HeaderText = "Nom";
            Dv_ListClient.Columns["Cli_Prenom"].HeaderText = "Prenom";
           // Dv_ListClient.Columns["Cli_DateNaissance"].HeaderText = "Anniversaire";
            Dv_ListClient.Columns["Cli_DateCreation"].HeaderText = "Inscrit le";
            Dv_ListClient.Columns["Uti_Cp2"].HeaderText = "CP";
            Dv_ListClient.Columns["Uti_Ville2"].HeaderText = "Ville";

        }
        List<Client> cliListe;
        List<Client> filtre_cliListe;
        
        private void Dv_ListClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //gestion affichage
            dataGridViewListCommandeClient.Visible = true;
            labelListCommande.Visible = true;
            buttonCreerClient.Visible = false;
            buttonAjouterClient.Visible = true;
            buttonMajClient.Visible = true;
            buttonSuppClient.Visible = true;


            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
           // if (textBoxNom.Text != "") { Dv_ListClient.DataSource = filtre; } else { Dv_ListClient.DataSource = cliListe; }
            StamperClient(
                Uti_Id2: filtre_cliListe[e.RowIndex].Uti_Id.ToString(),
                Nom: filtre_cliListe[e.RowIndex].Cli_Nom,
                Prenom: filtre_cliListe[e.RowIndex].Cli_Prenom,
                DateInscription: filtre_cliListe[e.RowIndex].Uti_DateCreation,
                DateNaissance: filtre_cliListe[e.RowIndex].Cli_DateNaissance,

                TelContact: filtre_cliListe[e.RowIndex].Uti_TelContact,
                MailContact: filtre_cliListe[e.RowIndex].Uti_MailContact,
                Mdp2: ".......",
                Adresse2: filtre_cliListe[e.RowIndex].Uti_Adresse,
                CompAdresse2: filtre_cliListe[e.RowIndex].Uti_CompAdresse,
                CP: filtre_cliListe[e.RowIndex].Uti_Cp,
                City: filtre_cliListe[e.RowIndex].Uti_Ville,
                Country: filtre_cliListe[e.RowIndex].Uti_Pays
                );




        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            //on propose une fiche vide
            StamperClient();
            buttonCreerClient.Visible = true;
            buttonAjouterClient.Visible = false;
            buttonMajClient.Visible = false;
            buttonSuppClient.Visible = false;
            dataGridViewListCommandeClient.Visible = false;
            labelListCommande.Visible = false;


        }

        private async void buttonCreerClient_Click(object sender, EventArgs e)
        {
            Client newCli = new Client();
            newCli.Cli_Nom = textBoxNom2.Text;
            newCli.Cli_Prenom = textBoxPrenom.Text;
            //newCli.Cli_DateNaissance = textBoxDateNaissance.Text;

            newCli.Cli_Role = "1";
            newCli.Uti_Adresse = textBoxAdresse2.Text;
            newCli.Uti_CompAdresse = textBoxCompAdresse2.Text;
            newCli.Uti_Cp = textBoxCP.Text;
            newCli.Uti_Ville = textBoxCity.Text;
            newCli.Uti_Pays = textBoxCountry.Text;
            newCli.Uti_TelContact = textBoxTel.Text;
            newCli.Uti_Mdp = textBoxMdp2.Text;
            newCli.Uti_MailContact = textBoxMail.Text;

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newCli);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Client/ajouter.php", data);
            //MessageBox.Show(json.ToString());
            //StamperClient(Nom: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Client créé");
            }
            else
                MessageBox.Show("Erreur: Client non créé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonClients.PerformClick();
            StamperClient();

        }

        private async void buttonMajClient_Click(object sender, EventArgs e)
        {
            Client majCli = new Client();
            majCli.Cli_Nom = textBoxNom2.Text;
            majCli.Cli_Prenom = textBoxPrenom.Text;
            //majCli.Cli_DateNaissance = textBoxDateNaissance.Text;

            majCli.Cli_Role = "3";
            majCli.Uti_Adresse = textBoxAdresse2.Text;
            majCli.Uti_CompAdresse = textBoxCompAdresse2.Text;
            majCli.Uti_Cp = textBoxCP.Text;
            majCli.Uti_Ville = textBoxCity.Text;
            majCli.Uti_Pays = textBoxCountry.Text;
            majCli.Uti_TelContact = textBoxTel.Text;
            majCli.Uti_Mdp = textBoxMdp2.Text;
            majCli.Uti_MailContact = textBoxMail.Text;
            majCli.Uti_Id = int.Parse(labelUti_Id2.Text);

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(majCli);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PutAsync("https://apistive.azurewebsites.net/API/controlers/Client/modifier.php", data);
            //MessageBox.Show(json.ToString());
            //Stamper(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Client mis à jour");
            }
            else
                MessageBox.Show("Erreur: pas de mise à jour du Client" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonClients.PerformClick();
            StamperClient();

        }

        private async void buttonSuppClient_Click(object sender, EventArgs e)
        {
            Client suppCli = new Client();
            suppCli.Uti_Id = Convert.ToInt32(labelUti_Id2.Text);


            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(suppCli);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            // MessageBox.Show(json);
            //MessageBox.Show(data.ToString());
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Client/supprimer.php", data);


            //Stamper(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                //DialogResult dialogResult = MessageBox.Show("Fournisseur supprimé", MessageBoxIcon.Information) ; 
                MessageBox.Show("Client supprimé");

            }
            else
                MessageBox.Show("Erreur: client non supprimé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonClients.PerformClick();
            StamperClient();
        }

        public void textBoxNom_TextChanged(object sender, EventArgs e)
        {
            filtre_cliListe = cliListe.Where(x => x.Cli_Nom.ToLower().Contains(textBoxCherchClient.Text.ToLower())).ToList();
            Dv_ListClient.DataSource = filtre_cliListe;
        }

        public void buttonProduit_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            buttonProduit.BackColor = Color.FromArgb(44, 130, 201);
            buttonProduit.ForeColor = Color.FromArgb(255, 255, 255);
            panelProduit.Visible = true;
            buttonProduit.Tag = 1;
            buttonSuppProduit.Visible = false;
            buttonMajProduit.Visible = false;
            buttonCommanderProduit.Visible = false;
            textBoxNbPiece.Visible = false;
            Dv_ListeProduit2.Visible = true;
            panel_AjouterType.Visible = false;
            textBox_Libelle.Visible = false;
            buttonValider.Visible = false;
            StamperProduit(); //remet les champs à vide;
            textBoxChProd.Text = "";




            /* var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
             var response = await
                 httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Produit/obtenirTous.php");
             response.EnsureSuccessStatusCode();

             var content = await response.Content.ReadAsStringAsync();
             prodListe = JsonConvert.DeserializeObject<List<Produit>>(content);*/

            //MessageBox.Show(content);  //controle du json
            //declaration des colonnes de la grid

            Dv_ListeProduit.Columns["Pro_Nom"].HeaderText = "Nom";
            Dv_ListeProduit.Columns["Pro_Quantite"].HeaderText = "Stock";
            Dv_ListeProduit.Columns["Pro_SeuilAlerte"].HeaderText = "Seuil Alerte";
            Dv_ListeProduit.Columns["Pro_CommandeAuto"].HeaderText = "Auto";
            Dv_ListeProduit.Columns["Typ_Libelle"].HeaderText = "Type";
            Dv_ListeProduit.Columns["Fou_NomDomaine2"].HeaderText = "Fournisseur";

            /*  var httpClient2 = new HttpClient();   //connexion à la bdd Stive sur azure
              var response2 = await
                  httpClient2.GetAsync("https://apistive.azurewebsites.net/API/controlers/TypeProduit/obtenirTous.php");
              response2.EnsureSuccessStatusCode();

              var content2 = await response2.Content.ReadAsStringAsync();
              typListe = JsonConvert.DeserializeObject<List<TypeProduit>>(content2);
              //MessageBox.Show(content2);  //controle du json*/

            //Dv_TypeProduit.DataSource = null;

        }



        public void Dv_Produit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //gestion affichage
            buttonCreerProduit.Visible = false;
            buttonAjouterProduit.Visible = true;
            buttonMajProduit.Visible = true;
            buttonSuppProduit.Visible = true;
            buttonCommanderProduit.Visible = true;
            textBoxNbPiece.Visible = true;

            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;

            //comboBoxTypeProduit.DataSource = typListe;
            StamperProduit(
                NomProduit: filtre_prodListe[e.RowIndex].Pro_Nom,
                Domaine: filtre_prodListe[e.RowIndex].Fou_NomDomaine,
                Pro_Ref: filtre_prodListe[e.RowIndex].Pro_Ref,
                Pro_Cepage: filtre_prodListe[e.RowIndex].Pro_Cepage,
                Pro_Annee: filtre_prodListe[e.RowIndex].Pro_Annee.ToString(),
                Pro_Prix: filtre_prodListe[e.RowIndex].Pro_Prix.ToString(),
                Pro_PrixLitre: filtre_prodListe[e.RowIndex].Pro_PrixLitre.ToString(),
                Pro_Quantite: filtre_prodListe[e.RowIndex].Pro_Quantite.ToString(),
                Pro_SeuilAlerte: filtre_prodListe[e.RowIndex].Pro_SeuilAlerte.ToString(),

                Pro_CommandeAuto: filtre_prodListe[e.RowIndex].Pro_CommandeAuto,
                Pro_Volume: filtre_prodListe[e.RowIndex].Pro_Volume.ToString(),
                Pro_Description: filtre_prodListe[e.RowIndex].Pro_Description,
                Typ_Libelle: filtre_prodListe[e.RowIndex].Typ_Libelle.ToString(),//prodListe[e.RowIndex].Pro_Typ_Id.ToString(),
                Pro_Typ_Id: filtre_prodListe[e.RowIndex].Pro_Typ_Id.ToString(),//((comboBoxTypeProduit.SelectedIndex)+1).ToString(),
                Pro_Fou_Id: filtre_prodListe[e.RowIndex].Pro_Fou_Id.ToString(),
                Pro_Uti_Id: filtre_prodListe[e.RowIndex].Uti_Id.ToString(),
                Pro_Id: filtre_prodListe[e.RowIndex].Pro_Id.ToString()
                );
            //MessageBox.Show(((comboBoxTypeProduit.SelectedIndex) + 1).ToString());
        }

        public void buttonAjouterProduit_Click(object sender, EventArgs e)
        {
            comboBoxProposePar.DataSource = fourListe;
            //on propose une fiche vide
            StamperProduit();
            buttonCreerProduit.Visible = true;
            buttonAjouterProduit.Visible = false;
            buttonMajProduit.Visible = false;
            buttonSuppProduit.Visible = false;
            buttonCommanderProduit.Visible = false;
            textBoxNbPiece.Visible = false;

        }

        private async void buttonCreerProduit_Click(object sender, EventArgs e)
        {
            Produit newPro = new Produit();

            newPro.Pro_Nom = textBoxNomProduit.Text;
                                                          //cbo.SelectedItem.Value;

            newPro.Pro_Ref = textBoxRef.Text;
            newPro.Pro_Fou_Id = Convert.ToInt32(comboBoxProposePar.SelectedValue);
            //newPro.Pro_Fou_Id = Convert.ToInt32((Dv_TypeProduit.SelectedRow.Select.Typ_Id));
           // MessageBox.Show(comboBoxProposePar.SelectedValue.ToString());
            newPro.Pro_Cepage = textBoxCepage.Text;
            if (textBoxMillesime.Text == "")
            {
                newPro.Pro_Annee = null;
            }
            else
            {
                newPro.Pro_Annee = Convert.ToInt32(textBoxMillesime.Text);
            }
            newPro.Pro_Prix = (float)Convert.ToDouble(textBoxPrix.Text.Replace(".",","));
            if (textBoxPrixLitre.Text == "")
            {
                newPro.Pro_PrixLitre = 0;
            }
            else { newPro.Pro_PrixLitre = (float)Convert.ToDouble(textBoxPrixLitre.Text.Replace(".",",")); }
            newPro.Pro_Quantite = (float)Convert.ToDouble(textBoxEnStock.Text.Replace(".",","));
            newPro.Pro_SeuilAlerte = (float)Convert.ToDouble(textBoxSeuilAlerte.Text.Replace(".",","));

          //  newInv.Coi_ProId = Convert.ToInt32(dr.Cells["Coi_ProId"].Value);

            if (checkBoxCommandeAuto.Checked)
            {
                newPro.Pro_CommandeAuto = 1;
            }
            else
            {
                newPro.Pro_CommandeAuto = 0;
            }

            if (textBoxVolume.Text == "")
            {
                newPro.Pro_Volume = 0;
            }
            else
            {
                newPro.Pro_Volume = (float)Convert.ToDouble(textBoxVolume.Text.Replace(".",","));
            }
            newPro.Pro_Description = textBoxDescription.Text;
            newPro.Pro_Typ_Id = Convert.ToInt32(comboBoxTypeProduit.SelectedValue);
            newPro.Typ_Libelle = comboBoxTypeProduit.Text;
            newPro.Fou_NomDomaine = comboBoxProposePar.Text;
            //newPro.Img_Adresse = textBoxProposePar.Text;
            //newPro.Img_Nom = textBoxProposePar.Text;
            //MessageBox.Show(comboBoxTypeProduit.SelectedValue.ToString());

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newPro);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Produit/ajouter.php", data);
            //MessageBox.Show(json.ToString());
            //StamperClient(Nom: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Produit créé");
            }
            else
                MessageBox.Show("Erreur: produit non créé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonAccueil.PerformClick();
            buttonProduit.PerformClick();
            StamperProduit();
        }

        public async void buttonMajProduit_Click(object sender, EventArgs e2)
        {

            Produit majPro = new Produit();

            majPro.Pro_Id = Convert.ToInt32(label_Pro_Id.Text);

            majPro.Pro_Typ_Id = Convert.ToInt32(comboBoxTypeProduit.SelectedValue);
            majPro.Uti_Id = int.Parse(label_pro_Uti_Id.Text);
            majPro.Pro_Nom = textBoxNomProduit.Text;
            majPro.Pro_Ref = textBoxRef.Text; ;
            majPro.Pro_Fou_Id = Convert.ToInt32(comboBoxProposePar.SelectedValue);
            majPro.Pro_Cepage = textBoxCepage.Text;
            if (textBoxMillesime.Text == "")
            {
                majPro.Pro_Annee = 0;
            }
            else
            {
                majPro.Pro_Annee = Convert.ToInt32(textBoxMillesime.Text);
            }

            majPro.Pro_Prix = (float)Convert.ToDouble(textBoxPrix.Text.Replace(".",","));
            if (textBoxPrixLitre.Text == "")
            {
                majPro.Pro_PrixLitre = 0;
            }
            else
            {
                majPro.Pro_PrixLitre = (float)Convert.ToDouble(textBoxPrixLitre.Text.Replace(".",","));
            }

            majPro.Pro_Quantite = (float)Convert.ToDouble(textBoxEnStock.Text.Replace(".",","));
            majPro.Pro_SeuilAlerte = (float)Convert.ToDouble(textBoxSeuilAlerte.Text.Replace(".",","));
            if (checkBoxCommandeAuto.Checked)
            {
                majPro.Pro_CommandeAuto = 1;
            }
            else
            {
                majPro.Pro_CommandeAuto = 0;
            }
            if (textBoxVolume.Text == "")
            {
                majPro.Pro_Volume = 0;
            }
            else { majPro.Pro_Volume = (float)Convert.ToDouble(textBoxVolume.Text.Replace(".",",")); }
            majPro.Pro_Description = textBoxDescription.Text;
            majPro.Fou_NomDomaine = comboBoxProposePar.Text;
            majPro.Typ_Libelle = comboBoxTypeProduit.Text;
            //majPro.Img_Adresse = textBoxProposePar.Text;
            //majPro.Img_Nom = textBoxProposePar.Text;

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(majPro);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Produit/modifier.php", data);
            //MessageBox.Show(json.ToString());
            //StamperProduit(Pro_Ref: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Produit mis à jour");
            }
            else
                MessageBox.Show("Erreur: pas de mise à jour du produit" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton produit
            buttonAccueil.PerformClick();
            buttonProduit.PerformClick();

            StamperProduit();
        }

        private void buttonCommanderProduit_Click(object sender, EventArgs e)
        {
            /* CommandeFournisseur newBdc = new CommandeFournisseur();

             newBdc.CoF_Pro_Id = Convert.ToInt32(label_Pro_Id.Text);

             newBdc.Cof_Fou_Id = Convert.ToInt32(comboBoxProposePar.SelectedValue);
             newBdc.Cof_Eta_Id = int.Parse(label_pro_Uti_Id.Text);*/
            MessageBox.Show("Fonctionnalité en cours de developpement");
        }

        private void textBoxChProd_TextChanged(object sender, EventArgs e)
        {
            filtre_prodListe = prodListe.Where(x => x.Pro_Nom.ToLower().Contains(textBoxChProd.Text.ToLower())).ToList();
            Dv_ListeProduit.DataSource = filtre_prodListe;
        }

        private void buttonAjouterType_Click(object sender, EventArgs e)
        {
            panel_AjouterType.Visible = true;
            textBox_Libelle.Text = "";
            textBox_Libelle.Visible = true;
            buttonValider.Visible = true;

        }

        private async void buttonValider_Click(object sender, EventArgs e)
        {
            TypeProduit newTyp = new TypeProduit();
            newTyp.Typ_Libelle = textBox_Libelle.Text;

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newTyp);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/TypeProduit/ajouter.php", data);
            //MessageBox.Show(json.ToString());
            //StamperClient(Nom: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Type créé");
            }
            else
                MessageBox.Show("Erreur: Type non créé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton produit
            buttonAccueil.PerformClick();
            buttonProduit.PerformClick();
        }


        public void comboBoxTypeProduit_SelectedValueChanged(object sender, EventArgs e)
        {
            //buttonAccueil.PerformClick();
            //buttonProduit.PerformClick();
            // string OptionText = this.cboSelectOption.SelectedItem.ToString();
            //Dv_TypeProduit.ValueMembert += labelPro_Typ_Id.Text;
            //buttonProduit_.PerformClick();
            labelPro_Typ_Id.Text = (Dv_TypeProduit.Columns.Count + 1).ToString();
            // MessageBox.Show(labelPro_Typ_Id.Text);
            //prodListe.Uti_Id.ToString();
        }

        private void buttonInventaire_Click(object sender, EventArgs e)
        {
            Form_inventaire Inventaire = new Form_inventaire();
            Inventaire.ShowDialog();
        }

        
        
/////////////////////////////////////////gestion de la sasie numeric des textBox
        private void textBoxTelContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrix_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void textBoxPrixLitre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxMillesime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true;
            }

           
      
        }

        private void textBoxVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxEnStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxSeuilAlerte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxCodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelContact_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTelResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        
 ////////////////////////////////////Gestion format mail etfonctionnalités non dev
        private void textBoxMailContact_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (textBoxMailContact.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBoxMailContact.Text.Trim()))
                {
                    MessageBox.Show("Format mail incorrect", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMailContact.Focus();
                }
            }
        }

        private void textBoxMailResp_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (textBoxMailResp.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBoxMailResp.Text.Trim()))
                {
                    MessageBox.Show("Format mail incorrect", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMailResp.Focus();
                }
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (textBoxMail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(textBoxMail.Text.Trim()))
                {
                    MessageBox.Show("Format mail incorrect", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxMail.Focus();
                }
            }
        }

        private void buttonSuppProduit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non développée");
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non développée");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non développée");
        }

 
    }
}
