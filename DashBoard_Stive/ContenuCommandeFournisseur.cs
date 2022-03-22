using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuCommandeFournisseur 
    {
        public int Ccf_Cof_Id { get; set; }

        public DateTime Ccf_DateCreation { get; set; }
        public DateTime Ccf_DateMaj { get; set; }
        public int Ccf_Pro_Id { get; set; }
        public int Ccf_Quantite { get; set; }
        public string Pro_Nom { get; set; }
        public string Pro_Ref { get; set; }
        public string Fou_NomDomaine { get; set; }
        public int Cof_Fou_Id { get; set; }
        public string Eta_Libelle { get; set; }
        public int Eta_Id { get; set; }
        public int Uti_Id { get; set; }

    }
}
