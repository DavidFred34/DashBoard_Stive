using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class Fournisseur
    {
        public int Fou_Id { get; set; }
        public string Fou_NomDomaine { get; set; }
        public string Fou_NomResp { get; set; }
        public string Fou_TelResp { get; set; }
        public string Fou_MailResp { get; set; }
        public string Fou_Fonction { get; set; }
        public string Fou_DateCreation { get; set; }
        public string Fou_Role { get; set; }

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
