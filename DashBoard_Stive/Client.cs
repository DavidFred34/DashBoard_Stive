using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    public class Client
    {
        public int Cli_Id { get; set; }
        public string Cli_Nom { get; set; }
        public string Cli_Prenom { get; set; }
        public string Cli_DateNaissance { get; set; }
        public string Cli_DateCreation { get; set; }
        public string Cli_Role { get; set; }

        public int Uti_Id { get; set; }
        public string Uti_Adresse { get; set; }
        public string Uti_CompAdresse { get; set; }
        public string Uti_Cp { get; set; }
        public string Uti_Ville { get; set; }
        public string Uti_Pays { get; set; }
        public string Uti_TelContact { get; set; }
        public string Uti_Mdp { get; set; }
        public string Uti_VerifMdp { get; set; }
        public string Uti_MailContact { get; set; }
        public string Uti_DateCreation { get; set; }
    }
}
