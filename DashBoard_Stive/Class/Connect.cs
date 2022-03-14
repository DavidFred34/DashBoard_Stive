using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashBoard_Stive.Class
{
    public class Connect
    {
        public string Uti_MailContact { get; private set; }
        public string Uti_Mdp { get; private set; }
        private string Token { get;  set; }

        //constructeur
        public Connect(string login,string mp,string token ="")
        {
            Uti_MailContact = login;
            Uti_Mdp = mp;
            Token = token;
        }

        //renseignement du token
        public  void defToken(string token)
        {
            this.Token = token;
        }

        public  string tokenRequete()
        {
            return this.Token;
        }

    }
}
