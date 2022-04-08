using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class CommandeClient
    {
        public int Coc_Id { get; set; }
        public string Coc_DateCreation { get; set; }
        public string Coc_DateMaj { get; set; }
        public int Coc_Fou_Id { get; set; }
        public int Uti_Id { get; set; }
        public string Fou_NomDomaine { get; set; }
        public int Coc_Eta_Id { get; set; }
        public string Eta_Libelle { get; set; }
        public string Cli_Nom { get; set; }
        public string Cli_Prenom { get; set; }
    }
}
