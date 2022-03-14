using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using DashBoard_Stive.Class;

namespace DashBoard_Stive
{
    public partial class Connexion : Form 
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            pictureBoxLogo2.ImageLocation = "../../images/logoStive.png";
       
        }

        private void Btn_Connexion_MouseEnter(object sender, EventArgs e)
        {
            Btn_Connexion.BackColor = Color.FromArgb(44, 130, 201);
            Btn_Connexion.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void Btn_Connexion_MouseLeave(object sender, EventArgs e)
        {
            Btn_Connexion.BackColor = Color.FromArgb(137, 196, 244);
            Btn_Connexion.ForeColor = Color.FromArgb(44, 130, 201);
        }

        public  async void Btn_Connexion_Click(object sender, EventArgs e)
        {
            Connect newCon = new Connect(Txb_Login.Text, Txb_Mp.Text);
            
            //MessageBox.Show(newCon.tokenRequete());
            
            try
            {
                var httpClient = new HttpClient();
                var json = JsonConvert.SerializeObject(newCon);
               // MessageBox.Show(json.ToString());

                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await httpClient.PostAsync("https://apistive.azurewebsites.net/API/controlers/login/login.php", data);
                var content = await response.Content.ReadAsStringAsync();
                Globales.token = JsonConvert.DeserializeObject<Connect>(content);
                MessageBox.Show(content);  //controle du json
                newCon.defToken(Globales.token.tokenRequete());
                MessageBox.Show(newCon.tokenRequete());
                Dashboard Dashboard = new Dashboard();
                Dashboard.ShowDialog();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Connexion refusée");
            }
        }
        
    }
}
