using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    class ContenuInventaire : Inventaire
    {
        public int CoI_Inv_Id { get; set; }

        public int Coi_ProId { get; set; }
        public string Coi_ProLibelle { get; set; }
        public int Coi_ProQuantite { get; set; }
        public int Coi_Inventaire { get; set; }
    }
}
