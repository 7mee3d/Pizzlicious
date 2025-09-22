using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mini_Project___Pizza_Resto_Shodwe;

namespace Mini_Project___Pizza_Resto_Shodwe
{

 

    public partial class FormFinalBilling : Form
    {

         private string _StrSizePizza = "";
        private string _StrCrustTypePizza  = "";
        private string []_StrToppingsPizza  ;
        private string _StrWhereToEatPizza  = "";
        private string _StrTotalPrice = "";
        private void setFormFixedRezizeAndMove()
        {

            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(615, 930);

        }
        private void ResetAllOrder()
        {
            _StrSizePizza = "";
            _StrCrustTypePizza = "";

            for (int i = 0; i < _StrToppingsPizza.Length; i += 1)
                _StrToppingsPizza[i] = "";

            _StrWhereToEatPizza = "";
            _StrTotalPrice = "";
        }
        public FormFinalBilling(string SizePizza , string CrustTypePizza , string[] ToppingsPizza , string WhereToEatPizza , string totalPricePizza ) 
        {
            InitializeComponent();

            _StrSizePizza = SizePizza;
            _StrCrustTypePizza = CrustTypePizza;
            _StrToppingsPizza  = ToppingsPizza;
            _StrWhereToEatPizza = WhereToEatPizza;
            _StrTotalPrice = totalPricePizza; 

            
        }

        private void FormFinalBilling_Load(object sender, EventArgs e)
        {

            this.BackgroundImage = Image.FromFile("Pizzlicious\\FinalBilling.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            labelResultSizePizza.Text = _StrSizePizza;
            labelResultCrustTypePizza.Text = _StrCrustTypePizza;

           
            /*  for (int x = 0; x < _StrToppingsPizza.Length; x += 1)
           {
               labelResultToppings.Text = string.Join("", _StrToppingsPizza.Where(Toppings => !string.IsNullOrEmpty(Toppings)));

           }
           */


            foreach (string toppings in _StrToppingsPizza)
            {
                if (!string.IsNullOrEmpty(toppings))
                {
                    labelResultToppings.Text += toppings;
                }
            }
            labelResultWhereToEat.Text = _StrWhereToEatPizza;
            labelTotalPriceBilling.Text = _StrTotalPrice;

        }

    
        private void buttonCheakOut_Click(object sender, EventArgs e)
        {

            System.IO.StreamWriter SW = new System.IO.StreamWriter("DataRestoShadweOrders.txt", true);

            string InfoOneOrder = Environment.NewLine
                + Environment.NewLine
                +"------------------- +Order Pizza+ ------------------"
                
                + Environment.NewLine
                + Environment.NewLine 
                +"Date Time Order : " + DateTime.Now.ToString() +Environment.NewLine 
                + "Size Pizza : " + _StrSizePizza + Environment.NewLine
                + "Crust Type Pizza : " + _StrCrustTypePizza + Environment.NewLine
                + "Where Eat Pizza : " + _StrWhereToEatPizza + Environment.NewLine
                + "Price This Order = " + _StrTotalPrice + Environment.NewLine
                + "Toggings : " + labelResultToppings.Text 
                + Environment.NewLine

                + "---------------------------------------------------" 
                + Environment.NewLine ;

            SW.WriteLine(InfoOneOrder);

            SW.Close();

            MessageBox.Show("The Order Is Done", "Note This Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetAllOrder();

            Application.OpenForms[1].Show();
            this.Close(); 
        }

        private void FormFinalBilling_Move(object sender, EventArgs e)
        {
            setFormFixedRezizeAndMove();
        }

        private void FormFinalBilling_Resize(object sender, EventArgs e)
        {
            setFormFixedRezizeAndMove();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.OpenForms[1].Show();
            
            this.Close(); 
        }
    }
}
