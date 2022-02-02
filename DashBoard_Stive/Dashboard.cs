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
                if (item is Button) { (item as Button).Tag = 0; }
            }
        }

        

        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            if ((int?)(sender as Button).Tag == 1) {

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
        private void Stamper(
                        //champs fournisseur
                        string Uti_Id = "",
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

        private async void buttonFournisseurs_Click(object sender, EventArgs e)
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
            Stamper();




            /*const string bt_Fournisseur = @"     //bouchon de test: simule le resultat du json obtenue
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
            utiListe = JsonConvert.DeserializeObject<List<Fournisseur>>(bt_Fournisseur);
            */
            ;
            var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
            var response = await 
                httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/obtenirTous.php");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            utiListe = JsonConvert.DeserializeObject<List<Fournisseur>>(content);
           
                //MessageBox.Show(content);
                //declaration des colonnes de la grid
                Dv_fournisseur.DataSource = utiListe;
            Dv_fournisseur.Columns["Fou_NomDomaine"].HeaderText = "Fournisseur";
            Dv_fournisseur.Columns["Fou_NomResp"].HeaderText = "Responsable";
            Dv_fournisseur.Columns["Fou_TelResp"].HeaderText = "Tel";
            Dv_fournisseur.Columns["Fou_MailResp"].HeaderText = "Mail";
            Dv_fournisseur.Columns["Uti_Cp"].HeaderText = "CP";
            Dv_fournisseur.Columns["Uti_Ville"].HeaderText = "Ville";
            //Dv_fournisseur.Columns["Fou_NomResp"].Visible = false;
            //Dv_fournisseur.Columns.Add("Uti_Pays", "Pays");
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
         
            Stamper(
                Uti_Id: utiListe[e.RowIndex].Uti_Id.ToString(),
                NomDomaine:utiListe[e.RowIndex].Fou_NomDomaine,
                DateCreation: utiListe[e.RowIndex].Uti_DateCreation,
                NomResp: utiListe[e.RowIndex].Fou_NomResp,
                TelResp: utiListe[e.RowIndex].Fou_TelResp,
                MailResp: utiListe[e.RowIndex].Fou_MailResp,
                Fonction: utiListe[e.RowIndex].Fou_Fonction,
                TelContact: utiListe[e.RowIndex].Uti_TelContact,
                MailContact: utiListe[e.RowIndex].Uti_Mail,
                Adresse: utiListe[e.RowIndex].Uti_Adresse,
                CompAdresse: utiListe[e.RowIndex].Uti_CompAdresse,
                CodePostal: utiListe[e.RowIndex].Uti_Cp,
                Ville: utiListe[e.RowIndex].Uti_Ville,
                Pays: utiListe[e.RowIndex].Uti_Pays
                );
            
            buttonCreerFournisseur.Visible = false;
            buttonMajFournisseur.Visible = true;
            buttonSuppFournisseur.Visible = true;
            


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

        private async void buttonCreerFournisseur_Click(object sender, EventArgs e)
        {
            string bt_fournisseur = 
                      @" {   
                        Fou_NomDomaine: """+textBoxNomDomaine.Text+ @""",
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
                        
                    }"

                    /* @"{
                     Adresse: ""cccccc"",
                     CodePostal: ""xxxxx"",
                     Ville: ""xxxxx"",
                     Pays: ""xxxxx"",
                     Telephone: ""xxxxx"",
                     Mdp: ""xxxxx"",
                     Mail: ""xx669S0000000DSDSDS99yx"",
                     NomDomaine: ""Les pins"",
                     NomResp: ""xzzzzz"",
                     TelResp: ""xzzzzz"",
                     MailResp: ""xzzzzz""
                    }"*/
                    ;
            Fournisseur newFour = new Fournisseur();
                newFour.Fou_NomDomaine  = textBoxNomDomaine.Text;
                newFour.Fou_NomResp     = textBoxNomResp.Text;
                newFour.Fou_TelResp     = textBoxTelResp.Text;
                newFour.Fou_MailResp    = textBoxMailResp.Text;
                newFour.Fou_Fonction    = textBoxFonction.Text;
                newFour.Fou_Role        = "3";
                newFour.Uti_Adresse     = textBoxAdresse.Text;
                newFour.Uti_CompAdresse = textBoxCompAdresse.Text;
                newFour.Uti_Cp          = textBoxCodePostal.Text;
                newFour.Uti_Ville       = textBoxVille.Text;
                newFour.Uti_Pays        = textBoxPays.Text;
                newFour.Uti_TelContact  = textBoxTelContact.Text;
                newFour.Uti_Mdp         = textBoxMdp.Text;
                newFour.Uti_Mail = textBoxMailContact.Text;

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newFour);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/ajouter.php", data);
            //MessageBox.Show(json.ToString());
            //Stamper(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Fournisseur créé");
            }
            else
                MessageBox.Show("Erreur: fournisseur non créé" + "\r\n\n" + response );
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonFournisseurs.PerformClick();
            Stamper();
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
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/suprimer.php", data);
            //Stamper(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                //DialogResult dialogResult = MessageBox.Show("Fournisseur supprimé", MessageBoxIcon.Information) ; 
                MessageBox.Show("Fournisseur supprimé");
             
              }
              else
                MessageBox.Show("Erreur: fournisseur non supprimé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            buttonFournisseurs.PerformClick();
            Stamper();
        }
    }
}
