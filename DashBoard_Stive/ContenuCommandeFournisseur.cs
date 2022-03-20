using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuCommandeFournisseur : CommandeFournisseur
    {
        public int Ccf_Cof_Id { get; set; }

        public DateTime Ccf_DateCreation { get; set; }
        public DateTime Ccf_DateMaj { get; set; }
        public int Ccf_Pro_Id { get; set; }
        public int Ccf_Quantite { get; set; }
        public string Pro_Nom { get; set; }
        public string Fou_NomDomaine { get; set; }
        public string Etat_Libelle { get; set; }
        //public string Pro_Nom { get; set; }
    }
}
