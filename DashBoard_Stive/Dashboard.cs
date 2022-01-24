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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            pictureBoxLogo.ImageLocation = "../../images/logoStive.png";
            pictureBoxUser.ImageLocation = "../../images/concombres01.png";
            pictureBoxProduit.ImageLocation = "../../images/VinRouge.jpg";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(44, 130, 201);
            button1.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(137, 196, 244);
            button1.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(44, 130, 201);
            button2.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(137, 196, 244);
            button2.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(44, 130, 201);
            button3.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(137, 196, 244);
            button3.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(44, 130, 201);
            button4.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(137, 196, 244);
            button4.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(44, 130, 201);
            button5.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(137, 196, 244);
            button5.ForeColor = Color.FromArgb(44, 130, 201);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(44, 130, 201);
            button6.ForeColor = Color.FromArgb(255, 255, 255);

            //MessageBox.Show("yes");
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(137, 196, 244);
            button6.ForeColor = Color.FromArgb(44, 130, 201);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = true;
            panel6.Visible = false;
            panel12.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = true;
            panel12.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel12.Visible = true;
        }
    }
}
