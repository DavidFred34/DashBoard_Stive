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
            pictureBoxUser.ImageLocation = "../../images/concombres01.png";
            pictureBoxProduit.ImageLocation = "../../images/VinRouge.jpg";
        }

        private void reinitBouton()
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(44, 130, 201);
            button1.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(137, 196, 244);
            button1.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(44, 130, 201);
            button2.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(137, 196, 244);
            button2.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(44, 130, 201);
            button3.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(137, 196, 244);
            button3.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(44, 130, 201);
            button4.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(137, 196, 244);
            button4.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(44, 130, 201);
            button5.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(137, 196, 244);
            button5.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(44, 130, 201);
            button6.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(137, 196, 244);
            button6.ForeColor = Color.FromArgb(44, 130, 201);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            reinitBouton();
            button1.BackColor = Color.FromArgb(139,0,0);
            button1.ForeColor = Color.FromArgb(255, 255, 255);
            panel2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reinitBouton();
            button2.BackColor = Color.FromArgb(44, 130, 201);
            button2.ForeColor = Color.FromArgb(255, 255, 255);
            panel3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel12.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel12.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            reinitBouton();

            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = true;

            //const string bt_utilisateur = @"
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


            const string bt_utilisateur = @"
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
            var  utiListe = JsonConvert.DeserializeObject<List<Utilisateur>>(bt_utilisateur);
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

        private void Dv_fournisseur_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex == -1) //pour ne pas avoir d'erreur en cliquant sur l'entete
                return;
            
            string text = Dv_fournisseur.Rows[e.RowIndex].Cells["utiAdresseDataGridViewTextBoxColumn"].Value.ToString();  //affiche dans la message box le contenu de Uti_Adresse
                MessageBox.Show(text);
            
        }
    }
}
