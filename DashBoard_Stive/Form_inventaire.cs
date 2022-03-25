using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DashBoard_Stive
{
    public partial class Form_inventaire : Form
    {
        public Form_inventaire()
        {
            InitializeComponent();
        }

        /*public int Pro_Nom { get; set; }
        public int Pro_Id { get; set; }
        public int Pro_Id { get; set; }
        public int Pro_Id { get; set; }
        public int Pro_Id { get; set; }*/
        public async void Inventaire_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = "../../images/logoStive.png";

            List<Produit> prod_List;
            List<Inventaire> inv_List;
            List<ContenuInventaire> contInv_List;
         

            //Chargement liste produit
            try
            {
                
                string token = Class.Globales.token.tokenRequete();  //recup du token
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete

                var response = await
                    httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Produit/obtenirTous.php");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                prod_List = JsonConvert.DeserializeObject<List<Produit>>(content);

                //MessageBox.Show(content.ToString());  //controle du json
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ce fournisseur n'a pas de bon de commande");
                prod_List = null;
            }

            //alimentation de la liste inv_List
            contInv_List = null;
            List<ContenuInventaire> contInvList = new List<ContenuInventaire>();
           foreach(Produit prod in prod_List)
            {
                //List<ContenuInventaire> contInv_List = new List<ContenuInventaire>();
                ContenuInventaire newContInv = new ContenuInventaire();

                newContInv.Coi_Pro_Id = prod.Pro_Id;
                newContInv.Coi_Pro_Nom = prod.Pro_Nom;
                newContInv.Coi_Pro_Quantite = (int)prod.Pro_Quantite;
                newContInv.Coi_Typ_Libelle = prod.Typ_Libelle;
                newContInv.Coi_Fou_NomDomaine = prod.Fou_NomDomaine;
                newContInv.Inv_StockRegul = 0;
                contInvList.Add(newContInv);
                
           

            }
            contInv_List = contInvList;
            Dv_Inventaire.DataSource = contInv_List;
       
        }
        public async void Btn_SaveInventaire_Click(object sender, EventArgs e)
        {
          /*  foreach (DataGridViewRow dr in Dv_Inventaire.Rows) {
           ContenuInventaire newInv = new ContenuInventaire();
                newInv.Coi_ProId = Convert.ToInt32(dr.Cells["Coi_ProId"].Value);
                newInv.Coi_ProLibelle = dr.Cells["Pro_Nom"].Value.ToString();
                newInv.Coi_ProQuantite = Convert.ToInt32(dr.Cells["Pro_Quantite"].Value);
                newInv.Coi_Inventaire = Convert.ToInt32(dr.Cells["CoI_Inventaire"].Value);

            //envoi pour la creation de l'inventaire
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(newInv);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Inventaire/ajouter.php", data);
            MessageBox.Show(json.ToString());
           
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Inventaire créé");
            }
            else
                MessageBox.Show("Erreur: inventaire non créé" + "\r\n\n" + response);
                }
            //recharge la liste en simulant le click sur le bouton fournisseur*/


            MessageBox.Show("L'enregistrement n'a pas pu se faire, contactez l'assistance");
          


            this.Close();
        }

        private void Btn_SaveAndMajInventaire_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La mise à jour du stock n'a pas pu se faire, contactez l'assistance");
            this.Close();
        }
    }
}
