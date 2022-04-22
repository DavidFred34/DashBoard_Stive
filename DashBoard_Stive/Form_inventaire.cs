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
            List<Produit> prod_List;
            List<Inventaire> inv_List;
            List<ContenuInventaire> contInv_List;
        public async void Inventaire_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = "../../images/logoStive.png";
            Btn_AjouterInventaire.Visible = false;


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
            foreach (Produit prod in prod_List)
            {
                //List<ContenuInventaire> contInv_List = new List<ContenuInventaire>();
                ContenuInventaire newContInv = new ContenuInventaire();

                newContInv.Coi_Pro_Id = prod.Pro_Id;
                newContInv.Coi_Pro_Nom = prod.Pro_Nom;
                newContInv.Coi_Pro_Quantite = (int)prod.Pro_Quantite;
                newContInv.Coi_Typ_Libelle = prod.Typ_Libelle;
                newContInv.Coi_Fou_NomDomaine = prod.Fou_NomDomaine;
                //newContInv.Inv_StockRegul = 0;
                contInvList.Add(newContInv);

            }
            contInv_List = contInvList;
            Dv_Inventaire.DataSource = contInv_List;

            // chargement grille historique
            try
            {

                string token = Class.Globales.token.tokenRequete();  //recup du token
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete

                var response = await
                    httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Inventaire/obtenirTous.php");
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                
                inv_List = JsonConvert.DeserializeObject<List<Inventaire>>(content);
                inv_List = inv_List.OrderByDescending(x => x.Inv_Id).ToList();
            

            }
            catch (Exception ex)
            {
               // MessageBox.Show("Il n'y a pas d'historique");
                inv_List = null;
            }
            
        Dv_Historique.DataSource = inv_List;
        }

        public static void reloadform()
        {
            Form Form_inventaire= new Form_inventaire();
            Form_inventaire.Show();
            Form_inventaire.BringToFront();
            
        }
        private async void Dv_Historique_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Btn_AjouterInventaire.Visible = true;
            try
            {
                string token = Class.Globales.token.tokenRequete();  //recup du token
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete

                var url = "https://apistive.azurewebsites.net/API/controlers/Inventaire/obtenir.php?Inv_Id=" + inv_List[e.RowIndex].Inv_Id;
                var response = await
                    httpClient.GetAsync(url);// label_Fou_Id.Text);
                response.EnsureSuccessStatusCode();

                var contentCommande = await response.Content.ReadAsStringAsync();
               
                List<ContenuInventaire> contInvById = new List<ContenuInventaire>();
                contInvById = JsonConvert.DeserializeObject<List<ContenuInventaire>>(contentCommande);

                //MessageBox.Show(debug.ToString());  //controle du json
               // MessageBox.Show(contentCommande);
                
                Dv_Inventaire.DataSource = contInvById;

                // on affiche le bouton MajStock que si on clic sur le dernier inventaire
                if (inv_List[e.RowIndex].Inv_Id == inv_List.Select(x => x.Inv_Id).Max())
                {
                    Btn_MajStock.Visible = true;
                    Btn_SaveInventaire.Visible = true;
                    
                }
                else 
                {
                    Btn_MajStock.Visible = false;
                    Btn_SaveInventaire.Visible = false;
                    MessageBox.Show( "La mise à jour de l'inventaire et du stock n'est possible que sur le dernier inventaire");
                }
                    


                label_Inventaire.Text = "Inventaire du " + Dashboard.AfficheDate(Convert.ToDateTime(inv_List[e.RowIndex].Inv_DateCreation)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pb de chargement de l'nventaire");
            }
        }
        public async void Btn_SaveInventaire_Click(object sender, EventArgs e)
        {
            Btn_SaveInventaire.Enabled = false;
            List<ContenuInventaire> saveContInv_List = new List<ContenuInventaire>();
            foreach (DataGridViewRow dr in Dv_Inventaire.Rows)
            {
                ContenuInventaire newInv = new ContenuInventaire();
                if (dr.Cells[7].Value != null)
                {
                    newInv.Coi_Inv_Id = Convert.ToInt32(dr.Cells[7].Value);
                }
                else
                {
                    newInv.Coi_Inv_Id = null;
                }
                newInv.Coi_Pro_Id = Convert.ToInt32(dr.Cells[9].Value);
                newInv.Coi_Pro_Nom = dr.Cells[0].Value.ToString();
                newInv.Coi_Pro_Quantite = Convert.ToInt32(dr.Cells[3].Value);
     
                // si inventaire non rempli on envoi null sinon la valeur y compris zero
                if (dr.Cells[4].Value != null)
                {
                    newInv.Coi_Inventaire = Convert.ToInt32(dr.Cells[4].Value);
                    //MessageBox.Show(newInv.Coi_Inventaire.ToString() + "_try");
                }
                else
                {//MessageBox.Show(newInv.Coi_Inventaire.ToString() + "_catch");
                    newInv.Coi_Inventaire = null;
                }
                newInv.Coi_Fou_NomDomaine = dr.Cells[2].Value.ToString();
                newInv.Coi_Typ_Libelle = dr.Cells[1].Value.ToString();

                saveContInv_List.Add(newInv);
            }


            //envoi pour la creation de l'inventaire
            string token = Class.Globales.token.tokenRequete();  //recup du token
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token); //rajout du token dans le header de la requete

            var json = JsonConvert.SerializeObject(saveContInv_List);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/Inventaire/ajouter.php", data);
            //MessageBox.Show(json.ToString());

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Inventaire enregistré");
            }
            else
                MessageBox.Show("Erreur: inventaire non enregistré" + "\r\n\n" + response);
            
            Btn_SaveInventaire.Enabled = true;
            /*Form Form_inventaire = new Form_inventaire();
            Form_inventaire.Show();
            Form_inventaire.BringToFront();

            // Form_inventaire.TopMost = true;
            this.Close();*/
            reloadform();
            this.Close();

        }
          
        private async void Btn_MajStock_Click(object sender, EventArgs e)
        {
            Btn_MajStock.Enabled = false;

            // on  fait la mise à jour du stock uniquement sur le dernier inventaire et si stock!regul = 0
            if(Convert.ToInt32(Dv_Inventaire.Rows[0].Cells[7].Value) == inv_List.Select(x => x.Inv_Id).Max() && Convert.ToInt32(Dv_Inventaire.Rows[0].Cells[5].Value) == 0)  //rajouter controle regul
            {
                List<ContenuInventaire> majContInv_List = new List<ContenuInventaire>();
                foreach (DataGridViewRow dr in Dv_Inventaire.Rows)
                {
                    ContenuInventaire majInv = new ContenuInventaire();
                    majInv.Coi_Inv_Id = Convert.ToInt32(dr.Cells[7].Value);
                    majInv.Coi_Pro_Id = Convert.ToInt32(dr.Cells[9].Value);
                    majInv.Coi_Pro_Nom = dr.Cells[0].Value.ToString();
                    majInv.Coi_Pro_Quantite = Convert.ToInt32(dr.Cells[3].Value);

                    // si inventaire non rempli on envoi null sinon la valeur y compris zero
                    if (dr.Cells[4].Value != null)
                    {
                        majInv.Coi_Inventaire = Convert.ToInt32(dr.Cells[4].Value);
                        //MessageBox.Show(newInv.Coi_Inventaire.ToString() + "_try");
                    }
                    else
                    {//MessageBox.Show(newInv.Coi_Inventaire.ToString() + "_catch");
                        majInv.Coi_Inventaire = null;
                    }

                    majContInv_List.Add(majInv);
                }


                //envoi pour la creation de l'inventaire
                var httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(majContInv_List);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PutAsync("https://apistive.azurewebsites.net/API/controlers/Inventaire/update.php", data);
               // MessageBox.Show(json.ToString());

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Stock mis à jour");
                }
                else
                    MessageBox.Show("Erreur: Le stock n'a pas été mis à jour" + "\r\n\n" + response);

                Btn_SaveInventaire.Enabled = true;
                /*Form Form_inventaire = new Form_inventaire();
                Form_inventaire.Show();
                Form_inventaire.BringToFront();

                // Form_inventaire.TopMost = true;
                this.Close();*/
                Btn_MajStock.Enabled = true;
                reloadform();
                this.Close();

            }
            else
            {
                MessageBox.Show("La mise à jour du stock a déja été faite");
            }

        }

        private void Btn_AjouterInventaire_Click(object sender, EventArgs e)
        {
            reloadform();
            this.Close();
        }

        private void Btn_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
