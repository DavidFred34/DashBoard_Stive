using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DashBoard_Stive
{
    public class Fournisseur
    {
        public int Fou_Id { get; set; }

        //[JsonProperty(PropertyName = "NomDomaine")]
        public string Fou_NomDomaine { get; set; }
        public string NomDomaine  { get=>Fou_NomDomaine; }

        //[JsonProperty(PropertyName = "NomResp")]
        public string Fou_NomResp { get; set; }
        public string NomResp { get => Fou_NomResp;}

        //[JsonProperty(PropertyName = "TelResp")]
        public string Fou_TelResp { get; set; }
        public string TelResp { get => Fou_TelResp;}

        //[JsonProperty(PropertyName = "MailResp")]
        public string Fou_MailResp { get; set; }
        public string MailResp { get => Fou_MailResp;}

        //[JsonProperty(PropertyName = "FonctionFou")]
        public string Fou_Fonction { get; set; }
        public string FonctionFou { get => Fou_Fonction; }

        public string Fou_DateCreation { get; set; }
        public string Fou_Role { get; set; }

        public int Uti_Id { get; set; }

        //[JsonProperty(PropertyName = "Adresse")]
        public string Uti_Adresse { get; set; }
        public string Adresse { get => Uti_Adresse; }

        //[JsonProperty(PropertyName = "CompAdresse")]
        public string Uti_CompAdresse { get; set; }
        public string CompAdresse { get => Uti_CompAdresse; }

        //[JsonProperty(PropertyName = "CodePostal")]
        public string Uti_Cp { get; set; }
        public string CodePostal { get => Uti_Cp; }

        //[JsonProperty(PropertyName = "Ville")]
        public string Uti_Ville { get; set; }
        public string Ville { get => Uti_Ville; }

        //[JsonProperty(PropertyName = "Pays")]
        public string Uti_Pays { get; set; }
        public string Pays { get => Uti_Pays; }

        //[JsonProperty(PropertyName = "Telephone")]
        public string Uti_TelContact { get; set; }
        public string Telephone { get => Uti_TelContact; }

        //[JsonProperty(PropertyName = "Mdp")]
        public string Uti_Mdp { get; set; }
        public string Mdp { get => Uti_Mdp; }

        public string Uti_VerifMdp { get; set; }

        //[JsonProperty(PropertyName = "Mail")]
        public string Uti_MailContact { get; set; }
        public string Mail { get => Uti_MailContact; }

        public string Uti_DateCreation { get; set; }

       

            
    }
}
