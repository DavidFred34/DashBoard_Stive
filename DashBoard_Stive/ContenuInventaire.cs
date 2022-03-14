using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuInventaire : Inventaire
    {
        public int Coi_Inv_Id { get; set; }
        public int Coi_Pro_Id { get; set; }
        public string Coi_Pro_Nom { get; set; }
        public string Coi_Typ_Libelle{ get; set; }
        public string Coi_Fou_NomDomaine { get; set; }
        public int Coi_Pro_Quantite { get; set; }
        public int Coi_Inventaire { get; set; }
    }
}
