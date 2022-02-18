using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashBoard_Stive
{
    public partial class Inventaire : Form
    {
        public Inventaire()
        {
            InitializeComponent();
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = "../../images/logoStive.png";
        }

        private void button_SaveInventaire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveAndMajInventaire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
