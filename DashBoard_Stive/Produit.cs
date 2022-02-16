using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive
{
    public class Produit
    {
        public int Pro_Id { get; set; }
        public int Pro_Typ_Id { get; set; }
        public string Pro_Nom { get; set; }
        public string Pro_Ref { get; set; }
        public int Pro_Fou_Id { get; set; }
        public string Pro_Cepage { get; set; }
        public int? Pro_Annee { get; set; }
        public float Pro_Prix { get; set; }
        public float Pro_PrixLitre { get; set; }
        public float Pro_Quantite { get; set; }
        public float Pro_SeuilAlerte { get; set; }
        public int Pro_CommandeAuto { get; set; }
        public float Pro_Volume { get; set; }
        public string Pro_Description { get; set; }
        public string Typ_Libelle { get; set; }
        public string Fou_NomDomaine { get; set; }
        public string Img_Id { get; set; }
        public string Img_Adresse { get; set; }
        public string Img_Nom { get; set; }


    }
}
