using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuInventaire
    {
        public int CoI_Inv_Id { get; set; }
        public DateTime Coi_DateCreation { get; set; }
        public DateTime Coi_DateMaj { get; set; }
        public int Coi_ProId { get; set; }
        public string Coi_ProLibelle { get; set; }
        public int Coi_ProQuantite { get; set; }
        public int Coi_Inventaire { get; set; }
    }
}
