using Pizzlicious.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Mini_Project___Pizza_Resto_Shodwe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void setFormFixedRezizeAndMove()
        {

            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1544, 899);

        }
        private void rdbtnNextImage2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.AboutUs; 
            this.BackgroundImageLayout = ImageLayout.Zoom;

            rdBtnImage1.Enabled = false; 


        }

        private void rdbtnNextImage1_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnImage1.AutoSize = false;
            rdBtnImage1.Size = new Size(30, 30);
            rdBtnImage1.Height = 50; 
           // this.BackgroundImage = Image.FromFile("Pizzlicious\\WelcomePage.png");
           // this.BackgroundImageLayout = ImageLayout.Zoom;
            rdBtnImage1.Enabled = false;

        }

        private void rdbtnNextImage3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.TabelMenu;
            this.BackgroundImageLayout = ImageLayout.Zoom;

            rdbtnNextImage2.Enabled = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdBtnImage1.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            FormMainRestochooseThePizzaProperties FormMainChooseProperty = new FormMainRestochooseThePizzaProperties();

            FormMainChooseProperty.ShowDialog();
           

        }

        private void Form1_Move(object sender, EventArgs e)
        {
            setFormFixedRezizeAndMove();

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            setFormFixedRezizeAndMove();

        }

        private void pictureBoxExit_Click(object sender, EventArgs e) {

            Application.Exit();

        }

        private void linkLabelHowToUse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabelHowToUse.LinkVisited = true;

            System.Diagnostics.Process.Start(@"https://github.com/7mee3d/Pizzlicious");
        }
    }
}
