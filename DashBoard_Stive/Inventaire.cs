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


namespace DashBoard_Stive
{
    public partial class Inventaire : Form
    {
        public Inventaire()
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

        //Chargement liste produit
        var httpClient = new HttpClient();   //connexion à la bdd Stive sur azure
        var response = await
            httpClient.GetAsync("https://apistive.azurewebsites.net/API/controlers/Produit/obtenirTous.php");
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        prodListe3 = JsonConvert.DeserializeObject<List<Produit>>(content);

         MessageBox.Show(content.ToString());  //controle du json

            Dv_Inventaire.DataSource = prodListe3;
       
        }
        List<Produit> prodListe3;
        private void button_SaveInventaire_Click(object sender, EventArgs e)
        {
           ContenuInventaire newInv = new ContenuInventaire();
            foreach (var contInv in Dv_Inventaire.Rows) {
                newInv.Coi_ProId = 
                newInv.Coi_ProLibelle = prodListe3.Pro_Id;
                newInv.Coi_ProQuantite = prodListe3.Pro_Id;
                newInv.Coi_Inventaire = prodListe3.Pro_Id;
            Nom: cliListe[e.RowIndex].Cli_Nom,
                    }
            this.Close();
        }

        private void buttonSaveAndMajInventaire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
