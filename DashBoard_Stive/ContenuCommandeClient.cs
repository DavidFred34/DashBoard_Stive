using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuCommandeClient
    {
        public int Ccc_Coc_Id { get; set; }
        public DateTime Ccc_DateCreation { get; set; }
        public DateTime Ccc_DateMaj { get; set; }
        public int Ccc_Pro_Id { get; set; }
        public int Ccc_Quantite { get; set; }
        public string Pro_Nom { get; set; }
        public string Pro_Ref { get; set; }
        public string Fou_NomDomaine { get; set; }
        public int Fou_Id { get; set; }
        public string Eta_Libelle { get; set; }
        public int Eta_Id { get; set; }
        public int Uti_Id { get; set; }

        public string Uti_Adresse { get; set; }
        public string Uti_CompAdresse { get; set; }
        public string Uti_Cp { get; set; }
        public string Uti_Ville { get; set; }
        public string Uti_Pays { get; set; }
        public string Uti_TelContact { get; set; }
        public string Uti_Mdp { get; set; }
        public string Uti_MailContact { get; set; }
        public string Cli_Nom { get; set; }
        public string Cli_Prenom { get; set; }
        public int Coc_Id { get; set; }
        public int Coc_Cli_Id { get; set; }
        public int Coc_Eta_Id { get; set; }
        public int Pro_Id { get; set; }
        public int Pro_Quantite { get; set; }

    }
}
