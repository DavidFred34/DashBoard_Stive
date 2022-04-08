using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuCommandeClient
    {
        public int Ccf_Cof_Id { get; set; }

        public DateTime Ccc_DateCreation { get; set; }
        public DateTime Ccc_DateMaj { get; set; }
        public int Ccc_Pro_Id { get; set; }
        public int Ccc_Quantite { get; set; }
        public string Pro_Nom { get; set; }
        public string Pro_Ref { get; set; }
        public string Fou_NomDomaine { get; set; }
        public int Coc_Fou_Id { get; set; }
        public string Eta_Libelle { get; set; }
        public int Eta_Id { get; set; }
        public int Uti_Id { get; set; }
    }
}
