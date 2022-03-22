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
using System.Net.Http.Headers;


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
            pictureBoxProduit.ImageLocation = "../../images/imgProduitDefault.png";
            //pictureBoxUser.ImageLocation = "../../images/concombres01.png";
            //pictureBoxProduit.ImageLocation = "../../images/VinRouge.jpg";

            /* System.Data.DataTable dataTable = new System.Data.DataTable();
             dataTable.Columns.Add(supp DataColumn("Couleur", typeof(string)));
             dataTable.Columns.Add(supp DataColumn("Taille", typeof(string)));
             deleteButton.HeaderText = "Supprimer cette ";
             dataGridView1.Columns.Add(DeleteButton);
             dataTable.Rows.Add(new string[] { " rouge ", " Large" });*/

            ReinitBouton();
            Btn_Accueil.PerformClick();
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
                {
                    (item as Button).Tag = 0;
                    (item as Button).BackColor = Color.FromArgb(137, 196, 244);
                    (item as Button).ForeColor = Color.FromArgb(44, 130, 201);
                }

            }
        }


        //gestion du survol de la souris des btn du menu
        private void Btn_Menu_MouseEnter(object sender, EventArgs e)
        {
            if ((int?)(sender as Button).Tag == 1)
            {

                return;
            }


            (sender as Button).BackColor = Color.FromArgb(44, 130, 201);
            (sender as Button).ForeColor = Color.FromArgb(255, 255, 255);

        }

        private void Btn_Menu_MouseLeave(object sender, EventArgs e)
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

            Lbl_Uti_Id.Text = Uti_Id;
            Lbl_Fou_Id.Text = Fou_Id;
            Txb_NomDomaine.Text = NomDomaine;
            Lbl_DateCreation.Text = "Créé le " + DateCreation;
            Txb_NomResp.Text = NomResp;
            //Txb_TelResp.Text = TelResp;
            if (TelResp == "")
            {
                Txb_TelResp.Text = "";
            }
            else { Txb_TelResp.Text = "0" + TelResp; }
            Txb_MailResp.Text = MailResp;
            Txb_Fonction.Text = Fonction;
            Txb_TelContact.Text = TelContact;
            if (TelContact == "")
            {
                Txb_TelContact.Text = "";
            }
            else { Txb_TelContact.Text = "0" + TelContact; }
            Txb_MailContact.Text = MailContact;
            Txb_Mdp.Text = Mdp;
            Txb_Adresse.Text = Adresse;
            Txb_CompAdresse.Text = CompAdresse;
            Txb_CodePostal.Text = CodePostal;
            Txb_Ville.Text = Ville;
            Txb_Pays.Text = Pays;

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
            Lbl_Uti_Id2.Text = Uti_Id2;
            Txb_Nom2.Text = Nom;
            Txb_Prenom.Text = Prenom;
            Lbl_Inscription.Text = "Inscrit le " + DateInscription;
            //labelDateNaiss.Text = "né le " + DateNaissance;
            if (TelContact == "") 
            {
                Txb_Tel.Text = "";
            }
            else { Txb_Tel.Text = "0" + TelContact; }
                
            Txb_Mail.Text = MailContact;
            Txb_Mdp2.Text = Mdp2;
            Txb_Adresse2.Text = Adresse2;
            Txb_CompAdresse2.Text = CompAdresse2;
            Txb_CP.Text = CP;
            Txb_City.Text = City;
            Txb_Country.Text = Country;

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
                        int Pro_IsWeb = 0,
                        string Pro_Volume = "",
                        string Pro_Description = "",
                        string Typ_Libelle = ""

                        )
        {
            Lbl_Pro_Fou_Id.Text = Pro_Fou_Id;
            Lbl_Pro_Uti_Id.Text = Pro_Uti_Id;
            Lbl_Pro_Typ_Id.Text = Pro_Typ_Id;
            Lbl_Pro_Id.Text = Pro_Id;
            Txb_NomProduit.Text = NomProduit;
            Cbx_ProposePar.Text = Domaine;
            Cbx_ProposePar.Text = Domaine;
            Txb_Ref.Text = Pro_Ref;
            Txb_Cepage.Text = Pro_Cepage;
            Txb_Millesime.Text = Pro_Annee;
            Txb_Prix.Text = Pro_Prix;
            Txb_PrixLitre.Text = Pro_PrixLitre;
            Txb_EnStock.Text = Pro_Quantite;
            Txb_SeuilAlerte.Text = Pro_SeuilAlerte;
            if (Pro_CommandeAuto == 1)
            {
                Cbx_CommandeAuto.Checked = true;
            }
            else { Cbx_CommandeAuto.Checked = false; }
            if (Pro_IsWeb == 1)
            {
                checkBox_IsWeb.Checked = true;
            }
            else { checkBox_IsWeb.Checked = false; }
            Txb_Volume.Text = Pro_Volume;
            Txb_Description.Text = Pro_Description;
            Cbx_TypeProduit.Text = Typ_Libelle;

        }
        private void StamperContenuBdc(
            
                        string Date = "",
                        string DateMaj = "",
                        string Etat = "",
                        string ProposePar = "",
                        string NomProduit = "",
                        string Domaine = ""
                        )
        {
            Lbl_ProposePar.Text = ProposePar;
            Lbl_DateCreationBdc.Text = Date;

            Lbl_DateMajBdc.Text = DateMaj;
            Cbx_EtatBdc.Text = Etat.ToString();

        }
        public static string AfficheDate(DateTime dateAConvertir)
        {
            var annee = dateAConvertir.Year;
            var jour = dateAConvertir.Day;
            var mois = dateAConvertir.Month;


            string result = dateAConvertir.ToString("dd/MM/yyyy") + " à " + dateAConvertir.ToString("HH:mm");
            string result2 = dateAConvertir.ToString("MM/dd/yyyy HH:mm");
            return result.Replace(':', 'h');
        }

        //gestion du clic des boutons du menu et remplissagge des grid
        public async void Btn_Accueil_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            Btn_Accueil.BackColor = Color.FromArgb(44, 130, 201);
            Btn_Accueil.ForeColor = Color.FromArgb(255, 255, 255);
            panelAccueil.Visible = true;
            Btn_Accueil.Tag = 1;

            //chargement liste etat
            IList<string> newEtatList = new List<string>();
                
            newEtatList.Add("En création");
            newEtatList.Add("En attente");
            newEtatList.Add("Livrée");
            newEtatList.Add("Annulée");
            newEtatList.Add("Auto");
                
            etatListe = newEtatList;
            /* // boucle de controle 
             * foreach( var eta in etatListe) { MessageBox.Show(eta.Key.ToString() +" : " + eta.Value);  }*/
            //Chargement liste produit
            try
            {
                var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
                var response = await
                    httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Produit/obtenirTous.php");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                prodListe = JsonConvert.DeserializeObject<List<Produit>>(content);

                //MessageBox.Show(content);  //controle du json
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste produits non chargée");
                prodListe = null;
            }


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

            //chargement list clients
            try
            {
                var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
                var response = await
                httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Client/obtenirTous.php");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                cliListe = JsonConvert.DeserializeObject<List<Client>>(content);


                //MessageBox.Show(content);  //controle du json
                //declaration des colonnes de la grid

                //if (textBoxNom.Text != "") { Dv_ListClient.DataSource = filtre; } else { Dv_ListClient.DataSource = cliListe; }
            }
            catch
            {
                MessageBox.Show("Liste des clients non chargée");
                cliListe = null;
            }

            //chargement liste bdc
            try
            {
                var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
               
                var response = await
                    httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/CommandeFournisseur/ObtenirTous.php");// label_Fou_Id.Text);
                response.EnsureSuccessStatusCode();

                var contentCommande = await response.Content.ReadAsStringAsync();

                bdcListe = JsonConvert.DeserializeObject<List<CommandeFournisseur>>(contentCommande);

                 //MessageBox.Show(contentCommande.ToString());  //controle du json
                //MessageBox.Show(contentCommande);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ce fournisseur n'a pas de bon de commande");
                bdcListe = null;
            }
            //Affectation des listes
            Dv_TypeProduit.DataSource = typListe;
            Dv_fournisseur.DataSource = fourListe;
            Dv_ListeProduit.DataSource = prodListe;
            Cbx_TypeProduit.DataSource = typListe;
            Cbx_ProposePar.DataSource = fourListe;
            Dv_ListClient.DataSource = cliListe;
            Cbx_EtatBdc.DataSource = etatListe;
            filtre_fourListe = fourListe;
            filtre_cliListe = cliListe;
            filtre_prodListe = prodListe;
            //MessageBox.Show(fourListe.Count.ToString());

            //Affichage stats accueil
            Lbl_nbClient.Text = "Nombre de Clients : " + cliListe.Count.ToString();
            Lbl_nbFournisseur.Text = "Nombre de Fournisseur : " + fourListe.Count.ToString();
            Lbl_nbProduit.Text = "Nombre de produits : " + prodListe.Count.ToString();
            
            int count = 0;
            bdcEnCoursListe = null;
            //var cc = from c in bdcListe where c.Cof_Eta_Id == 2 || c.Cof_Eta_Id == 5 select c.Cof_Eta_Id;
            bdcEnCoursListe = new List<CommandeFournisseur>();
            foreach (CommandeFournisseur bdc in bdcListe)
            {
                if (bdc.Cof_Eta_Id == 2 || bdc.Cof_Eta_Id == 5)
                {
                    count ++;
                    bdcEnCoursListe.Add(bdc);
                    //MessageBox.Show(bdcEnCoursListe.Count().ToString());
                    //MessageBox.Show(bdcEnCoursListe.ToString());

                }
            }
            Dv_BdcEnCours.DataSource = bdcEnCoursListe;
            filtre_bdcListe = bdcListe;
            Lbl_BdcEnCours.Text = "Commandes fournisseurs en cours : " + count.ToString();

            //affichage des prduits proches du seulAlerte
            List<Produit> prodSeuilListe = new List<Produit>();
            int count2 = 0;
            foreach (Produit prod in prodListe)
            {
                if (prod.Pro_Quantite/2 < prod.Pro_SeuilAlerte)
                {
                    count2++;
                    prodSeuilListe.Add(prod);
                    //MessageBox.Show(bdcEnCoursListe.Count().ToString());
                    //MessageBox.Show(bdcEnCoursListe.ToString());

                }
            }
            /*alerte = from alert in prodListe
                         where (alert.Pro_Quantite / 2) < alert.Pro_SeuilAlerte
                         select alert.Pro_Id;*/
            Dv_procheSeuil.DataSource = prodSeuilListe;
            Lbl_valSeuil.Text = count2.ToString();
        }
        List<TypeProduit> typListe;
        List<Produit> prodListe;
        List<Fournisseur> fourListe;
        List<Fournisseur> filtre_fourListe;
        List<Produit> filtre_prodListe;
        List<Client> cliListe;
        List<Client> filtre_cliListe;
        List<CommandeFournisseur> bdcListe;
        List<CommandeFournisseur> filtre_bdcListe;
        List<CommandeFournisseur> bdcEnCoursListe;
        IList<string> etatListe;

        private void Btn_Bdc_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            Btn_Bdc.BackColor = Color.FromArgb(44, 130, 201);
            Btn_Bdc.ForeColor = Color.FromArgb(255, 255, 255);
            panelBdc.Visible = true;
            Panel_InfoBdc.Visible = false;
            Panel_CreerBdc.Visible = true;
            Btn_Bdc.Tag = 1;
            Btn_CreerBdc.Visible = true;
            Btn_MajBdc.Visible = false;
            Btn_AjouterBdc.Visible = false;
            Tbx_CherchBdc.Text = "";
            Rbt_Tous.Checked = true;

            // StamperContenuBdc(); //remet les champs à vide
           
            Rbt_Tous.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Rbt_Avalider.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Rbt_Livre.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Rbt_Autre.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Dv_CommandeFournisseur.DataSource = bdcListe;
            //Cbx_Produit.DataSource = prodListe;
            Cbx_Four.DataSource = filtre_fourListe;
        }
        private void Btn_AjouterBdc_Click(object sender, EventArgs e)
        {
            //gestion affichage
            Btn_CreerBdc.Visible = true;
            Btn_MajBdc.Visible = false;
            Btn_AjouterBdc.Visible = false;
            Panel_CreerBdc.Visible = true;
            Panel_InfoBdc.Visible = false;
            List<ContenuCommandeFournisseur> newContenuBdcListe = new List<ContenuCommandeFournisseur>();
            Dv_DetailCommandeFournisseur.DataSource = newContenuBdcListe;
            //newContenuBdcListe = null;
            //Rbt_Tous.Checked = true;
            


            Rbt_Tous.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Rbt_Avalider.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Rbt_Livre.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Rbt_Autre.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
            Dv_CommandeFournisseur.DataSource = bdcListe;
        }
        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (Rbt_Tous.Checked)
            {
                filtre_bdcListe = bdcListe;
                Dv_CommandeFournisseur.DataSource = filtre_bdcListe;
            }
            else if (Rbt_Avalider.Checked)
            {
                filtre_bdcListe = bdcListe.Where(x => x.Cof_Eta_Id == 2 || x.Cof_Eta_Id == 5).ToList();
                Dv_CommandeFournisseur.DataSource = filtre_bdcListe;
            }
            else if (Rbt_Livre.Checked)
            {
                filtre_bdcListe = bdcListe.Where(x => x.Cof_Eta_Id == 3).ToList();
                Dv_CommandeFournisseur.DataSource = filtre_bdcListe;
            }
            else if (Rbt_Autre.Checked)
            {
                filtre_bdcListe = bdcListe.Where(x => x.Cof_Eta_Id == 1 || x.Cof_Eta_Id == 4).ToList();
                Dv_CommandeFournisseur.DataSource = filtre_bdcListe;
            }
        }

        private void Txb_CherchBdc_TextChanged(object sender, EventArgs e)
        {
            filtre_bdcListe = bdcListe.Where(x => x.Fou_NomDomaine.ToString().ToLower().Contains(Tbx_CherchBdc.Text.ToLower())).ToList();
            Dv_CommandeFournisseur.DataSource = filtre_bdcListe;
            if (Tbx_CherchBdc.Text != "")
            {
                Gbx_FiltreEtat.Enabled = false;
            }
            else
            {
                Gbx_FiltreEtat.Enabled = true;
            };

        }
        public async void Dv_CommandeFournisseur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //gestion affichage
            Btn_AjouterBdc.Visible = true;
            Btn_CreerBdc.Visible = false;
            Btn_MajBdc.Visible = true;
            Panel_InfoBdc.Visible = true;
            Panel_CreerBdc.Visible = false;
            
            //chargement liste contenuBdc_du bdc
            
            try
             {
                string token = Class.Globales.token.tokenRequete();  //recup du token
                

                var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete
                 var url = "https://apistive.azurewebsites.net/API/controlers/ContenuCommandeFournisseur/ObtenirTousByCommande.php?Ccf_Cof_Id=" + filtre_bdcListe[e.RowIndex].Cof_Id;
                // MessageBox.Show(url);
                 var response = await
                 httpClient.GetAsync(url);//
                 response.EnsureSuccessStatusCode();
                 var contentCommande = await response.Content.ReadAsStringAsync();
                 contenuBdcListe = JsonConvert.DeserializeObject<List<ContenuCommandeFournisseur>>(contentCommande);

                 // MessageBox.Show(debug.ToString());  //controle du json
               // MessageBox.Show(contentCommande);
             }
             catch (Exception ex)
             {
                //MessageBox.Show("Ce fournisseur n'a pas de bon de commande");
                contenuBdcListe = null;
             }

            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
            if (contenuBdcListe != null) {
                Dv_DetailCommandeFournisseur.DataSource = contenuBdcListe;
            };
           
            int eta = filtre_bdcListe[e.RowIndex].Cof_Eta_Id - 1;
    //        string eta2 = etatListe[eta].Value.Replace(eta.ToString(), "");//etatListe.Select(kvp => kvp.Value.Where(kvp.Key == eta ) //etatListe.Select(kvp=> kvp.Value.Where(Convert.ToInt32(kvp.Key) == eta));   //CompareTo(Convert.ToBoolean(eta))) ;
            //MessageBox.Show(eta2);


            //   MessageBox.Show(eta2);
            StamperContenuBdc(
                Date: "Créé le : " + AfficheDate(DateTime.Parse(filtre_bdcListe[e.RowIndex].Cof_DateCreation)),
                DateMaj: "Mis à jour le : " + AfficheDate(DateTime.Parse(filtre_bdcListe[e.RowIndex].Cof_DateMaj)),
                ProposePar: "Commandé chez : " + filtre_bdcListe[e.RowIndex].Fou_NomDomaine
                //Etat: filtre_bdcListe[e.RowIndex].Cof_Eta_Id.ToString()
     //           Etat: etatListe[eta].
            ) ;
            //      foreach (var et in etatListe) { MessageBox.Show(et.Key.ToString() + " : " + et.Value); }
            //var emailAdd = statesToEmailDictionary.FirstOrDefault(x => x.Value.Where(y => y.Contains(state))).Key;
            Cbx_EtatBdc.DataSource = etatListe;//.FirstOrDefault().Value;//.Select(kvp => kvp.Value.ToString());
            Cbx_EtatBdc.SelectedIndex = filtre_bdcListe[e.RowIndex].Cof_Eta_Id-1;
            //MessageBox.Show(Cbx_EtatBdc.SelectedItem.ToString());
            //Cbx_EtatBdc.DisplayMember = etatListe;
            Dv_ListeBdc.DataSource = bdcListeFournisseur;
            Dv_DetailCommandeFournisseur.DataSource = contenuBdcListe;
        }
        private async void Btn_MajBdcClick(object sender, EventArgs e)
        {
            int nbLigne = Dv_DetailCommandeFournisseur.RowCount;
            List<ContenuCommandeFournisseur> majBdcListe = new List<ContenuCommandeFournisseur>();
            //majBdcListe = null;
            for (int i = 0;i <  nbLigne; i++) 
            {
                //MessageBox.Show(Cbx_EtatBdc.SelectedIndex.ToString());
                ContenuCommandeFournisseur majBdc = new ContenuCommandeFournisseur();
                majBdc.Ccf_Cof_Id = Convert.ToInt32(Dv_DetailCommandeFournisseur.Rows[i].Cells[0].Value);
                majBdc.Ccf_Pro_Id = Convert.ToInt32(Dv_DetailCommandeFournisseur.Rows[i].Cells[3].Value);
                majBdc.Ccf_Quantite = (int)Dv_DetailCommandeFournisseur.Rows[i].Cells[4].Value;
                majBdc.Pro_Nom = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[1].Value;
                majBdc.Pro_Ref = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[2].Value;
                majBdc.Fou_NomDomaine = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[6].Value;
                majBdc.Eta_Id = Cbx_EtatBdc.SelectedIndex;  //Convert.ToInt32(Cbx_EtatBdc.SelectedValue);
                majBdc.Eta_Libelle = (string)Cbx_EtatBdc.SelectedItem;//(string)Dv_DetailCommandeFournisseur.Rows[i].Cells[8].Value;
                majBdc.Uti_Id = Convert.ToInt32(Dv_DetailCommandeFournisseur.Rows[i].Cells[5].Value);
                majBdcListe.Add(majBdc);
            }
            MessageBox.Show(majBdcListe.Count.ToString());
            string token = Class.Globales.token.tokenRequete();  //recup du token
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete
            var json = JsonConvert.SerializeObject(majBdcListe);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            MessageBox.Show(json.ToString());
            //StamperFournisseur(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            var response = await httpClient.PutAsync("https://apistive.azurewebsites.net/API/controlers/ContenuCommandeFournisseur/modifier.php", data);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Commande mise à jour");
            }
            else
                MessageBox.Show("Erreur: pas de mise à jour de la Commande" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            Btn_Accueil.PerformClick();
            Btn_Bdc.PerformClick();
            
            //StamperFournisseur();

        }
        private void Btn_ValiderProduit_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Convert.ToInt32(Cbx_Four.SelectedValue).ToString());
               
                Cbx_Four.Enabled = false;
                ContenuCommandeFournisseur newCont = new ContenuCommandeFournisseur();

                newCont.Ccf_Pro_Id = Convert.ToInt32(Cbx_Produit.SelectedValue);
                newCont.Ccf_Quantite = Convert.ToInt32(Tbx_qte.Text);
                newCont.Pro_Nom = Cbx_Produit.Text;

                var tt = (from p in prodListe3 where p.Pro_Id == Convert.ToInt32(Cbx_Produit.SelectedValue) select p.Pro_Ref.ToString());
                newCont.Pro_Ref = tt.FirstOrDefault();// == Convert.ToInt32(Cbx_Four.SelectedValue);
                newCont.Fou_NomDomaine = Cbx_Four.SelectedValue.ToString();
                newCont.Cof_Fou_Id = Convert.ToInt32(Cbx_Four.SelectedValue);
                newContenuBdcListe.Add(newCont);
                //Dv_DetailCommandeFournisseur.Rows.Clear();
               // List<ContenuCommandeFournisseur> newContenuBdcListe2 = new List<ContenuCommandeFournisseur>();
                //newContenuBdcListe2 = newContenuBdcListe;
                Dv_DetailCommandeFournisseur.DataSource = newContenuBdcListe;
            }
            catch
            {
                MessageBox.Show("pbbbbb");
            }
            //Cbx_Produit.DataSource = prodListe3;
            //Cbx_Four.Enabled = false;
            //List<ContenuCommandeFournisseur> newContenuBdcListe = new List<ContenuCommandeFournisseur>();
           // int ref = Convert.ToInt32(Cbx_Produit.SelectedItem);
            //newCont.Ccf_Cof_Id= Cbx
            /*
            newCont.Ccf_Pro_Id = Convert.ToInt32(Cbx_Produit.SelectedItem);
            newCont.Ccf_Quantite = Convert.ToInt32(Tbx_qte);
            newCont.Pro_Nom = Cbx_Produit.Text;
           // newCont.Fou_NomDomaine = bdcListe;
           // newCont.Uti_Id = Cof_;
            newContenuBdcListe.Add(newCont);*/
            
        }
          
            List<ContenuCommandeFournisseur> newContenuBdcListe = new List<ContenuCommandeFournisseur>();
            List<Produit> prodListe3 = new List<Produit>();
        private void Cbx_Four_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                //MessageBox.Show(Cbx_Four.SelectedValue.ToString());
                prodListe3 = prodListe.Where(x => x.Pro_Fou_Id == Convert.ToInt32(Cbx_Four.SelectedValue.ToString())).ToList();
                Cbx_Produit.DataSource = prodListe3;
            }
            catch
            {
                MessageBox.Show("Pb");
            }
        }
        private void Cbx_Four_SelectedValueChanged(object sender, EventArgs e)
        {/*
            List<Produit> prodListe3 = new List<Produit>();
            prodListe3 = prodListe.Where(x => x.Pro_Fou_Id == Convert.ToInt32(Cbx_Four.ValueMember)).ToList();
            Cbx_Produit.DataSource = prodListe3;*/
           // Cbx_Four.Enabled = false;
        }
        private void Cbx_Produit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Cbx_Four.Enabled = false;
        }
        private async void Btn_CreerBdc_Click(object sender, EventArgs e)
        {
            int nbLigne = Dv_DetailCommandeFournisseur.RowCount;
            //List<ContenuCommandeFournisseur> majBdcListe = new List<ContenuCommandeFournisseur>();
            //majBdcListe = null;
            /*for (int i = 0; i < nbLigne; i++)
            {
                ContenuCommandeFournisseur newBdc = new ContenuCommandeFournisseur();
                //MessageBox.Show((string)Dv_DetailCommandeFournisseur.Rows[i].Cells[1].Value);
                newBdc.Ccf_Cof_Id = newContenuBdcListe.Where(x=>x.Ccf_Cof_Id == );
                newBdc.Ccf_Pro_Id = Convert.ToInt32(Dv_DetailCommandeFournisseur.Rows[i].Cells[3].Value);
                newBdc.Ccf_Quantite = (int)Dv_DetailCommandeFournisseur.Rows[i].Cells[4].Value;
                newBdc.Pro_Nom = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[1].Value;
                newBdc.Pro_Ref = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[2].Value;
                newBdc.Fou_NomDomaine = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[6].Value;
                newBdc.Eta_Id = Convert.ToInt32(Dv_DetailCommandeFournisseur.Rows[i].Cells[7].Value);
                newBdc.Eta_Libelle = (string)Dv_DetailCommandeFournisseur.Rows[i].Cells[8].Value;
                newBdc.Uti_Id = Convert.ToInt32(Dv_DetailCommandeFournisseur.Rows[i].Cells[5].Value);
                majBdcListe.Add(newBdc);
            }*/
            MessageBox.Show(nbLigne.ToString());
            MessageBox.Show(newContenuBdcListe.Count.ToString());
            string token = Class.Globales.token.tokenRequete();  //recup du token
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete
            var json = JsonConvert.SerializeObject(newContenuBdcListe);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            MessageBox.Show(json.ToString());
            //StamperFournisseur(NomDomaine: json.ToString()); //permet de recup le json pour le copier
            var response = await httpClient.PutAsync("https://apistive.azurewebsites.net/API/controlers/ContenuCommandeFournisseur/ajouter.php", data);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Commande Créée");
            }
            else
                MessageBox.Show("Erreur: Commande non créée" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            Btn_Accueil.PerformClick();
            Btn_Bdc.PerformClick();
            Cbx_Four.Enabled = true;
        }
        List<ContenuCommandeFournisseur> contenuBdcListe;
        private void Btn_CommandesWeb_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            Btn_CommandesWeb.BackColor = Color.FromArgb(44, 130, 201);
            Btn_CommandesWeb.ForeColor = Color.FromArgb(255, 255, 255);
            panelCommandesWeb.Visible = true;
            Btn_CommandesWeb.Tag = 1;

            MessageBox.Show("Fonctionnalité non développée");
        }

        public void Btn_Fournisseurs_Click(object sender, EventArgs e)
        {

            //gestion affichage
            ReinitBouton();
            Btn_Fournisseurs.BackColor = Color.FromArgb(44, 130, 201);
            Btn_Fournisseurs.ForeColor = Color.FromArgb(255, 255, 255);
            panelFournisseurs.Visible = true;
            Btn_Fournisseurs.Tag = 1;
            Btn_CreerFournisseur.Visible = true;
            Btn_Ajouterfournisseur.Visible = false;
            Btn_MajFournisseur.Visible = false;
            Btn_SuppFournisseur.Visible = false;
            Dv_ListeBdc.Visible = false;
            Dv_ListeProduit2.Visible = false;
            Lbl_ListeBdc.Visible = false;
            Lbl_ListeProduit.Visible = false;
            Txb_CherchFournisseur.Text = "";
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
            Lbl_ListeBdc.Visible = true;
            Lbl_ListeProduit.Visible = true;
            Btn_CreerFournisseur.Visible = false;
            Btn_Ajouterfournisseur.Visible = true;
            Btn_MajFournisseur.Visible = true;
            Btn_SuppFournisseur.Visible = true;
            Lbl_Fou_Id.Visible = false;
            Lbl_Uti_Id.Visible = false;

            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
            StamperFournisseur(
                Uti_Id: filtre_fourListe[e.RowIndex].Fou_Uti_Id.ToString(),
                Fou_Id: filtre_fourListe[e.RowIndex].Fou_Id.ToString(),
                NomDomaine: filtre_fourListe[e.RowIndex].Fou_NomDomaine,

                DateCreation: AfficheDate(DateTime.Parse(filtre_fourListe[e.RowIndex].Uti_DateCreation)),
                NomResp: filtre_fourListe[e.RowIndex].Fou_NomResp,
                TelResp:filtre_fourListe[e.RowIndex].Fou_TelResp,
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

                bdcListeFournisseur = JsonConvert.DeserializeObject<List<CommandeFournisseur>>(contentCommande);

                // MessageBox.Show(debug.ToString());  //controle du json
                //MessageBox.Show(contentCommande);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ce fournisseur n'a pas de bon de commande");
                bdcListeFournisseur = null;
            }
            Dv_ListeBdc.DataSource = bdcListeFournisseur;
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
                //MessageBox.Show(contentProduit2);
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

            Dv_ListeBdc.DataSource = bdcListeFournisseur;
            Dv_ListeProduit2.DataSource = prodListe2;
            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
        }
        List<CommandeFournisseur> bdcListeFournisseur;
        List<Produit> prodListe2;

        private void Btn_Ajouterfournisseur_Click(object sender, EventArgs e)
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
            Btn_CreerFournisseur.Visible = true;
            Btn_Ajouterfournisseur.Visible = false;
            Btn_MajFournisseur.Visible = false;
            Btn_SuppFournisseur.Visible = false;
            Dv_ListeBdc.Visible = false;
            Dv_ListeProduit2.Visible = false;
            Lbl_ListeBdc.Visible = false;
            Lbl_ListeProduit.Visible = false;
        }

        private async void Btn_CreerFournisseur_Click(object sender, EventArgs e)
        {
            string bt_fournisseur = //bouchon test
                      @" {   
                        Fou_NomDomaine: """ + Txb_NomDomaine.Text + @""", 
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
            newFour.Fou_NomDomaine = Txb_NomDomaine.Text;
            newFour.Fou_NomResp = Txb_NomResp.Text;
            newFour.Fou_TelResp = Txb_TelResp.Text;
            newFour.Fou_MailResp = Txb_MailResp.Text;
            newFour.Fou_Fonction = Txb_Fonction.Text;
            newFour.Fou_Role = "3";
            newFour.Uti_Adresse = Txb_Adresse.Text;
            newFour.Uti_CompAdresse = Txb_CompAdresse.Text;
            newFour.Uti_Cp = Txb_CodePostal.Text;
            newFour.Uti_Ville = Txb_Ville.Text;
            newFour.Uti_Pays = Txb_Pays.Text;
            newFour.Uti_TelContact = Txb_TelContact.Text;
            newFour.Uti_Mdp = Txb_Mdp.Text;
            newFour.Uti_MailContact = Txb_MailContact.Text;

            Btn_CreerFournisseur.Visible = false;   //on empeche les clics en serie
            int exist = 0;
            foreach (var four in fourListe)  //on empeche la creation si le mail du fournisseur existe deja
            {
                if (four.Uti_MailContact.ToUpper() == Txb_MailContact.Text.ToUpper())
                {
                    exist += 1;

                }

            }

            if (exist == 0)
            {
                // MessageBox.Show(newCon.tokenRequete());
                var httpClient = new HttpClient();
                string token = Class.Globales.token.tokenRequete();

                MessageBox.Show(token);
                //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(token);
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
                {
                    MessageBox.Show("Erreur: fournisseur non créé" + "\r\n\n" + response);
                }
            }
            else
            {
                MessageBox.Show("il existe deja un fournisseur avec ce mail");
            }
            Btn_CreerFournisseur.Visible = true;
            //recharge la liste en simulant le click sur le bouton fournisseur
            Btn_Accueil.PerformClick();
            Btn_Fournisseurs.PerformClick();
            StamperFournisseur();
            //buttonAjouterfournisseur.PerformClick();
        }

        private async void Btn_SuppFournisseur_Click(object sender, EventArgs e)
        {
            Fournisseur suppFour = new Fournisseur();
            //string v = label_Uti_Id.Text.ToString();
            suppFour.Fou_Uti_Id = int.Parse(Lbl_Uti_Id.Text);

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
            Btn_Accueil.PerformClick();
            Btn_Fournisseurs.PerformClick();
            StamperFournisseur();
        }
    
        private async void Btn_MajFournisseur_Click(object sender, EventArgs e)
        {
            Fournisseur majFour = new Fournisseur();
            majFour.Fou_NomDomaine = Txb_NomDomaine.Text;
            majFour.Fou_NomResp = Txb_NomResp.Text;
            majFour.Fou_TelResp = Txb_TelResp.Text;
            majFour.Fou_MailResp = Txb_MailResp.Text;
            majFour.Fou_Fonction = Txb_Fonction.Text;
            majFour.Fou_Role = "3";
            majFour.Uti_Adresse = Txb_Adresse.Text;
            majFour.Uti_CompAdresse = Txb_CompAdresse.Text;
            majFour.Uti_Cp = Txb_CodePostal.Text;
            majFour.Uti_Ville = Txb_Ville.Text;
            majFour.Uti_Pays = Txb_Pays.Text;
            majFour.Uti_TelContact = Txb_TelContact.Text;
            majFour.Uti_Mdp = Txb_Mdp.Text;
            majFour.Uti_MailContact = Txb_MailContact.Text;
            majFour.Fou_Uti_Id = Convert.ToInt32(Lbl_Uti_Id.Text);


            string token = Class.Globales.token.tokenRequete();  //recup du token
            var httpClient  = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete
            var json = JsonConvert.SerializeObject(majFour);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            MessageBox.Show(json.ToString());
            //StamperFournisseur(NomDomaine: json.ToString()); //permet de recup le json pour le copier
           var response = await httpClient.PutAsync("https://apistive.azurewebsites.net/API/controlers/Fournisseur/modifier.php", data);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Fournisseur mis à jour");
            }
            else
                MessageBox.Show("Erreur: pas de mise à jour du fournisseur" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            Btn_Accueil.PerformClick();
            Btn_Fournisseurs.PerformClick();
            //StamperFournisseur();

        }

        private void Txb_CherchFournisseur_TextChanged(object sender, EventArgs e)
        {
            filtre_fourListe = fourListe.Where(x => x.Fou_NomDomaine.ToLower().Contains(Txb_CherchFournisseur.Text.ToLower())).ToList();
            Dv_fournisseur.DataSource = filtre_fourListe;
        }

        private void Btn_Clients_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            Btn_Clients.BackColor = Color.FromArgb(44, 130, 201);
            Btn_Clients.ForeColor = Color.FromArgb(255, 255, 255);
            panelClients.Visible = true;
            Btn_AjouterClient.Visible = false;
            Btn_CreerClient.Visible = true;
            Btn_MajClient.Visible = false;
            Btn_SuppClient.Visible = false;
            Lbl_ListCommande.Visible = false;
            Txb_CherchClient.Text = "";

            Btn_Clients.Tag = 1;

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


            /*   // version serveur
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
            */
            Dv_ListClient.Columns["Cli_Nom"].HeaderText = "Nom";
            Dv_ListClient.Columns["Cli_Prenom"].HeaderText = "Prenom";
            // Dv_ListClient.Columns["Cli_DateNaissance"].HeaderText = "Anniversaire";
            Dv_ListClient.Columns["Cli_DateCreation"].HeaderText = "Inscrit le";
            Dv_ListClient.Columns["Uti_Cp2"].HeaderText = "CP";
            Dv_ListClient.Columns["Uti_Ville2"].HeaderText = "Ville";

        }

        private void Dv_ListClient_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //gestion affichage
            dataGridViewListCommandeClient.Visible = true;
            Lbl_ListCommande.Visible = true;
            Btn_CreerClient.Visible = false;
            Btn_AjouterClient.Visible = true;
            Btn_MajClient.Visible = true;
            Btn_SuppClient.Visible = true;


            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
            // if (textBoxNom.Text != "") { Dv_ListClient.DataSource = filtre; } else { Dv_ListClient.DataSource = cliListe; }
            StamperClient(
                Uti_Id2: filtre_cliListe[e.RowIndex].Uti_Id.ToString(),
                Nom: filtre_cliListe[e.RowIndex].Cli_Nom,
                Prenom: filtre_cliListe[e.RowIndex].Cli_Prenom,
                DateInscription: AfficheDate(DateTime.Parse(filtre_cliListe[e.RowIndex].Uti_DateCreation)),
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

        private void Btn_AjouterClient_Click(object sender, EventArgs e)
        {
            //on propose une fiche vide
            StamperClient();
            Btn_CreerClient.Visible = true;
            Btn_AjouterClient.Visible = false;
            Btn_MajClient.Visible = false;
            Btn_SuppClient.Visible = false;
            dataGridViewListCommandeClient.Visible = false;
            Lbl_ListCommande.Visible = false;


        }

        private async void Btn_CreerClient_Click(object sender, EventArgs e)
        {
            Client newCli = new Client();
            newCli.Cli_Nom = Txb_Nom2.Text;
            newCli.Cli_Prenom = Txb_Prenom.Text;
            //newCli.Cli_DateNaissance = textBoxDateNaissance.Text;

            newCli.Cli_Role = "1";
            newCli.Uti_Adresse = Txb_Adresse2.Text;
            newCli.Uti_CompAdresse = Txb_CompAdresse2.Text;
            newCli.Uti_Cp = Txb_CP.Text;
            newCli.Uti_Ville = Txb_City.Text;
            newCli.Uti_Pays = Txb_Country.Text;
            newCli.Uti_TelContact = Txb_Tel.Text;
            newCli.Uti_Mdp = Txb_Mdp2.Text;
            newCli.Uti_MailContact = Txb_Mail.Text;
            Btn_AjouterClient.Visible = false;  //on empeche les clic en serie

            int exist = 0;  //pas de creation si le mail est en base
            foreach (var mail in cliListe)
            {
                if (mail.Uti_MailContact.ToUpper() == Txb_Mail.Text.ToUpper())
                {
                    exist += 1;

                }
            }

            if (exist == 0)
            {
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
            }
            //recharge la liste en simulant le click sur le bouton fournisseur
            Btn_AjouterClient.Visible = true;
            Btn_Accueil.PerformClick();
            Btn_Clients.PerformClick();
            StamperClient();

        }

        private async void Btn_MajClient_Click(object sender, EventArgs e)
        {
            Client majCli = new Client();
            majCli.Cli_Nom = Txb_Nom2.Text;
            majCli.Cli_Prenom = Txb_Prenom.Text;
            //majCli.Cli_DateNaissance = textBoxDateNaissance.Text;

            majCli.Cli_Role = "3";
            majCli.Uti_Adresse = Txb_Adresse2.Text;
            majCli.Uti_CompAdresse = Txb_CompAdresse2.Text;
            majCli.Uti_Cp = Txb_CP.Text;
            majCli.Uti_Ville = Txb_City.Text;
            majCli.Uti_Pays = Txb_Country.Text;
            majCli.Uti_TelContact = Txb_Tel.Text;
            majCli.Uti_Mdp = Txb_Mdp2.Text;
            majCli.Uti_MailContact = Txb_Mail.Text;
            majCli.Uti_Id = int.Parse(Lbl_Uti_Id2.Text);

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
            //recharge la liste en simulant le click sur le bouton client
            Btn_Accueil.PerformClick();
            Btn_Clients.PerformClick();
            StamperClient();

        }

        private async void Btn_SuppClient_Click(object sender, EventArgs e)
        {
            Client suppCli = new Client();
            suppCli.Uti_Id = Convert.ToInt32(Lbl_Uti_Id2.Text);


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
            Btn_Accueil.PerformClick();
            Btn_Clients.PerformClick();
            StamperClient();
        }

        public void Txb_Nom_TextChanged(object sender, EventArgs e)
        {
            filtre_cliListe = cliListe.Where(x => x.Cli_Nom.ToLower().Contains(Txb_CherchClient.Text.ToLower())).ToList();
            Dv_ListClient.DataSource = filtre_cliListe;
        }

        public void Btn_Produit_Click(object sender, EventArgs e)
        {
            //gestion affichage
            ReinitBouton();
            Btn_Produit.BackColor = Color.FromArgb(44, 130, 201);
            Btn_Produit.ForeColor = Color.FromArgb(255, 255, 255);
            panelProduit.Visible = true;
            Btn_Produit.Tag = 1;
            Btn_SuppProduit.Visible = false;
            Btn_MajProduit.Visible = false;
            Btn_CommanderProduit.Visible = false;
            Txb_NbPiece.Visible = false;
            Dv_ListeProduit2.Visible = true;
            panel_AjouterType.Visible = false;
            Txb_Libelle.Visible = false;
            Btn_Valider.Visible = false;
            StamperProduit(); //remet les champs à vide;
            Txb_ChProd.Text = "";




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
              MessageBox.Show(content2);  //controle du json*/

            //Dv_TypeProduit.DataSource = null;

        }



        public void Dv_Produit_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //gestion affichage
            Btn_CreerProduit.Visible = false;
            Btn_AjouterProduit.Visible = true;
            Btn_MajProduit.Visible = true;
            Btn_SuppProduit.Visible = true;
            Btn_CommanderProduit.Visible = true;
            Txb_NbPiece.Visible = true;

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
                Pro_IsWeb: filtre_prodListe[e.RowIndex].Pro_IsWeb,
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

        public void Btn_AjouterProduit_Click(object sender, EventArgs e)
        {
            Cbx_ProposePar.DataSource = fourListe;
            //on propose une fiche vide
            StamperProduit();
            Btn_CreerProduit.Visible = true;
            Btn_AjouterProduit.Visible = false;
            Btn_MajProduit.Visible = false;
            Btn_SuppProduit.Visible = false;
            Btn_CommanderProduit.Visible = false;
            Txb_NbPiece.Visible = false;

        }

        private async void Btn_CreerProduit_Click(object sender, EventArgs e)
        {
            Produit newPro = new Produit();

            try
            {
                newPro.Pro_Nom = Txb_NomProduit.Text;
                //cbo.SelectedItem.Value;

                newPro.Pro_Ref = Txb_Ref.Text;
                newPro.Pro_Fou_Id = Convert.ToInt32(Cbx_ProposePar.SelectedValue);
                //newPro.Pro_Fou_Id = Convert.ToInt32((Dv_TypeProduit.SelectedRow.Select.Typ_Id));
                // MessageBox.Show(comboBoxProposePar.SelectedValue.ToString());
                newPro.Pro_Cepage = Txb_Cepage.Text;
                if (Txb_Millesime.Text == "")
                {
                    newPro.Pro_Annee = null;
                }
                else
                {
                    newPro.Pro_Annee = Convert.ToInt32(Txb_Millesime.Text);
                }
                newPro.Pro_Prix = (float)Convert.ToDouble(Txb_Prix.Text.Replace(".", ","));
                if (Txb_PrixLitre.Text == "")
                {
                    newPro.Pro_PrixLitre = 0;
                }
                else { newPro.Pro_PrixLitre = (float)Convert.ToDouble(Txb_PrixLitre.Text.Replace(".", ",")); }
                newPro.Pro_Quantite = (float)Convert.ToDouble(Txb_EnStock.Text.Replace(".", ","));
                newPro.Pro_SeuilAlerte = (float)Convert.ToDouble(Txb_SeuilAlerte.Text.Replace(".", ","));

                //  newInv.Coi_ProId = Convert.ToInt32(dr.Cells["Coi_ProId"].Value);

                if (Cbx_CommandeAuto.Checked)
                {
                    newPro.Pro_CommandeAuto = 1;
                }
                else
                {
                    newPro.Pro_CommandeAuto = 0;
                }
                if (checkBox_IsWeb.Checked)
                {
                    newPro.Pro_IsWeb = 1;
                }
                else
                {
                    newPro.Pro_IsWeb = 0;
                }

                if (Txb_Volume.Text == "")
                {
                    newPro.Pro_Volume = 0;
                }
                else
                {
                    newPro.Pro_Volume = (float)Convert.ToDouble(Txb_Volume.Text.Replace(".", ","));
                }
                newPro.Pro_Description = Txb_Description.Text;
                newPro.Pro_Typ_Id = Convert.ToInt32(Cbx_TypeProduit.SelectedValue);
                newPro.Typ_Libelle = Cbx_TypeProduit.Text;
                newPro.Fou_NomDomaine = Cbx_ProposePar.Text;
                //newPro.Img_Adresse = textBoxProposePar.Text;
                //newPro.Img_Nom = textBoxProposePar.Text;
                //MessageBox.Show(comboBoxTypeProduit.SelectedValue.ToString());

                Btn_CreerProduit.Visible = false;  //on empeche les clics en serie
                int exist = 0;
                foreach (var prod in prodListe)  //on empeche la creation si le nom du produit et le fournisseur existent deja
                {
                    if ((prod.Pro_Nom.ToUpper() == Txb_NomProduit.Text.ToUpper()) && (prod.Pro_Fou_Id == Convert.ToInt32(Cbx_ProposePar.SelectedValue)))
                    {
                        exist += 1;

                    }
                }

                if (exist == 0)
                {
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
                    Btn_Accueil.PerformClick();
                    Btn_Produit.PerformClick();
                    StamperProduit();
                    Btn_CreerProduit.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ce fournisseur propose deja ce produit");
                    StamperProduit();
                    Btn_CreerProduit.Visible = true;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Les informations suivantes sont obligatoires: " + Environment.NewLine
                                + "     - Le nom du produit" + Environment.NewLine
                                + "     - Le nom du fournisseur" + Environment.NewLine
                                + "     - Le prix" + Environment.NewLine
                                + "     - La quantite" + Environment.NewLine
                                + "     - Le seuil d'alerte" + Environment.NewLine
                                + "     - Le type produit" + Environment.NewLine
                                );
                StamperProduit();
            }
        }
        public async void Btn_MajProduit_Click(object sender, EventArgs e2)
        {

            Produit majPro = new Produit();

            majPro.Pro_Id = Convert.ToInt32(Lbl_Pro_Id.Text);

            majPro.Pro_Typ_Id = Convert.ToInt32(Cbx_TypeProduit.SelectedValue);
            majPro.Uti_Id = int.Parse(Lbl_Pro_Uti_Id.Text);
            majPro.Pro_Nom = Txb_NomProduit.Text;
            majPro.Pro_Ref = Txb_Ref.Text; ;
            majPro.Pro_Fou_Id = Convert.ToInt32(Cbx_ProposePar.SelectedValue);
            majPro.Pro_Cepage = Txb_Cepage.Text;
            if (Txb_Millesime.Text == "")
            {
                majPro.Pro_Annee = 0;
            }
            else
            {
                majPro.Pro_Annee = Convert.ToInt32(Txb_Millesime.Text);
            }

            majPro.Pro_Prix = (float)Convert.ToDouble(Txb_Prix.Text.Replace(".", ","));
            if (Txb_PrixLitre.Text == "")
            {
                majPro.Pro_PrixLitre = 0;
            }
            else
            {
                majPro.Pro_PrixLitre = (float)Convert.ToDouble(Txb_PrixLitre.Text.Replace(".", ","));
            }

            majPro.Pro_Quantite = (float)Convert.ToDouble(Txb_EnStock.Text.Replace(".", ","));
            majPro.Pro_SeuilAlerte = (float)Convert.ToDouble(Txb_SeuilAlerte.Text.Replace(".", ","));
            if (Cbx_CommandeAuto.Checked)
            {
                majPro.Pro_CommandeAuto = 1;
            }
            else
            {
                majPro.Pro_CommandeAuto = 0;
            }
            if (checkBox_IsWeb.Checked)
            {
                majPro.Pro_IsWeb = 1;
            }
            else
            {
                majPro.Pro_IsWeb = 0;
            }
            if (Txb_Volume.Text == "")
            {
                majPro.Pro_Volume = 0;
            }
            else { majPro.Pro_Volume = (float)Convert.ToDouble(Txb_Volume.Text.Replace(".", ",")); }
            majPro.Pro_Description = Txb_Description.Text;
            majPro.Fou_NomDomaine = Cbx_ProposePar.Text;
            majPro.Typ_Libelle = Cbx_TypeProduit.Text;
            //majPro.Img_Adresse = textBoxProposePar.Text;
            //majPro.Img_Nom = textBoxProposePar.Text;


            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(majPro);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Produit/modifier.php", data);
            MessageBox.Show(json.ToString());
            //StamperProduit(Pro_Ref: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Produit mis à jour");
                //recharge la liste en simulant le click sur le bouton produit
                Btn_Accueil.PerformClick();
                Btn_Produit.PerformClick();

                StamperProduit();
            }
            else
            {
                MessageBox.Show("Erreur: pas de mise à jour du produit");
                //recharge la liste en simulant le click sur le bouton produit
                Btn_Accueil.PerformClick();
                Btn_Produit.PerformClick();

                StamperProduit();

            }





        }

        private async void Btn_SuppProduit_Click(object sender, EventArgs e)
        {
            Produit suppPro = new Produit();
            suppPro.Pro_Id = int.Parse(Lbl_Pro_Id.Text);

            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(suppPro);
            //var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "https://apistive.azurewebsites.net/API/controlers/Produit/supprimer.php?Pro_Id=" + suppPro.Pro_Id;
            var response = await httpClient.DeleteAsync(url);
            StamperProduit(Pro_Id: json.ToString()); //permet de recup le json pour le copier
            if (response.IsSuccessStatusCode)
            {
                //DialogResult dialogResult = MessageBox.Show("Fournisseur supprimé", MessageBoxIcon.Information) ; 
                MessageBox.Show("Produit supprimé");

            }
            else
                MessageBox.Show("Erreur: produit non supprimé" + "\r\n\n" + response);
            //recharge la liste en simulant le click sur le bouton fournisseur
            Btn_Accueil.PerformClick();
            Btn_Produit.PerformClick();
            StamperFournisseur();
        }

        private void Btn_CommanderProduit_Click(object sender, EventArgs e)
        {
            /* CommandeFournisseur newBdc = new CommandeFournisseur();

             newBdc.CoF_Pro_Id = Convert.ToInt32(label_Pro_Id.Text);

             newBdc.Cof_Fou_Id = Convert.ToInt32(comboBoxProposePar.SelectedValue);
             newBdc.Cof_Eta_Id = int.Parse(label_pro_Uti_Id.Text);*/
            MessageBox.Show("Fonctionnalité en cours de developpement");
        }

        private void Txb_ChProd_TextChanged(object sender, EventArgs e)
        {
            filtre_prodListe = prodListe.Where(x => x.Pro_Nom.ToLower().Contains(Txb_ChProd.Text.ToLower())).ToList();
            Dv_ListeProduit.DataSource = filtre_prodListe;
        }

        private void Btn_AjouterType_Click(object sender, EventArgs e)
        {
            panel_AjouterType.Visible = true;
            Txb_Libelle.Text = "";
            Txb_Libelle.Visible = true;
            Btn_Valider.Visible = true;

        }

        private async void Btn_Valider_Click(object sender, EventArgs e)
        {
            TypeProduit newTyp = new TypeProduit();
            newTyp.Typ_Libelle = Txb_Libelle.Text;
            Btn_Valider.Visible = false;
            int exist = 0;
            foreach (var libelle in typListe)
            {
                if (libelle.Typ_Libelle.ToUpper() == Txb_Libelle.Text.ToUpper())
                {
                    exist += 1;

                }
                if (Txb_Libelle.Text == "")
                {
                    exist += 1;
                    MessageBox.Show("Le libellé n'est pas rempli");
                    Btn_Valider.Visible = true;
                    return;

                }
            }

            if (exist == 0)
            {
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
                Btn_Accueil.PerformClick();
                Btn_Produit.PerformClick();
                Btn_Valider.Visible = true;
            }
            else
            {
                MessageBox.Show("ce type existe déja");
                Txb_Libelle.Text = "";
                Btn_Valider.Visible = true;
            }

        }


        public void Cbx_TypeProduit_SelectedValueChanged(object sender, EventArgs e)
        {
            //buttonAccueil.PerformClick();
            //buttonProduit.PerformClick();
            // string OptionText = this.cboSelectOption.SelectedItem.ToString();
            //Dv_TypeProduit.ValueMembert += labelPro_Typ_Id.Text;
            //buttonProduit_.PerformClick();
            Lbl_Pro_Typ_Id.Text = (Dv_TypeProduit.Columns.Count + 1).ToString();
            // MessageBox.Show(labelPro_Typ_Id.Text);
            //prodListe.Uti_Id.ToString();
        }

        private void Btn_Inventaire_Click(object sender, EventArgs e)
        {
            Form_inventaire Inventaire = new Form_inventaire();
            Inventaire.ShowDialog();
        }



        /////////////////////////////////////////gestion de la sasie numeric des textBox
        private void Txb_TelContact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txb_Prix_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txb_PrixLitre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txb_Millesime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }



        }

        private void Txb_Volume_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txb_EnStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txb_SeuilAlerte_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Txb_CodePostal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txb_TelResp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txb_CP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Txb_Tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        ////////////////////////////////////Gestion format mail etfonctionnalités non dev
        private void Txb_MailContact_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (Txb_MailContact.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Txb_MailContact.Text.Trim()))
                {
                    MessageBox.Show("Format mail incorrect", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txb_MailContact.Focus();
                }
            }
        }

        private void Txb_MailResp_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (Txb_MailResp.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Txb_MailResp.Text.Trim()))
                {
                    MessageBox.Show("Format mail incorrect", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txb_MailResp.Focus();
                }
            }
        }

        private void Txb_Mail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (Txb_Mail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Txb_Mail.Text.Trim()))
                {
                    MessageBox.Show("Format mail incorrect", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Txb_Mail.Focus();
                }
            }
        }




        private void Txb_2_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non développée");
        }

        private void Txb_3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Fonctionnalité non développée");
        }


    }
}
