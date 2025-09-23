using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Project___Pizza_Resto_Shodwe
{


    public partial class FormMainRestochooseThePizzaProperties : Form
    {
        int priceSizePizza = 0;
        int priceCrustPizza = 0;
        int priceToppingPizza = 0;
        int totalPrice = 0;
        string choiceSizePiizaFinal = "";
        string[] choiceToppingPizza = new string[6] ; 
        string choiceCrustPizza = ""; 
        string choiceWhereToEatPizza  = ""; 


        protected void setInitControlsFoodRestuarnt (/*Control PaerantControls*/ )
        {


         /*   radioButtonSmall.Checked = false;
            radioButtonMid.Checked = false;
            radioButtonLarge.Checked = false;
            radioButtonThinPizza.Checked = false;
            radioButtonEatIn.Checked = false;
            checkBoxMushrooms.Checked = false;
            checkBoxExtraCheese.Checked = false; 
            checkBoxOlives.Checked = false; 
            checkBoxOnion.Checked = false; 
            checkBoxTomatoes.Checked = false; 
            checkBoxGreenPeppers.Checked = false;
            radioButtonThinPizza.Checked = false;
            radioButtonThinkPizza.Checked = false;
            radioButtonEatIn.Checked = false;
            radioButtonTakeOut.Checked = false;
         */
            /*
            foreach (Control con in PaerantControls.Controls)
            {
                if(con is RadioButton RB)
                {
                    RB.Checked = false;
                }if (con is CheckBox CB)
                {
                    CB.Checked = false;

                }

                if (con.HasChildren) // Has Clidren (Panal or GroupBox ) --> Group Bix include cheak box or readio Button  (Recsuon)
                    setInitControlsFoodRestuarnt(con);
            }

            */


            // Change inside the Every Group Box 

            foreach (Control con in this.Controls )
            {

                if(con is GroupBox GB)
                {

                    foreach (Control inner in GB.Controls) // Control in the Group Box 
                    {
                        if (inner is RadioButton RB) // Avoid the Casting Control -> ((RadioButton)con).Check  = false ; Equal -> inner is RedioButton RB 
                            RB.Checked = false;

                        if (inner is CheckBox CB)
                            CB.Checked = false; 
                    }
                }
            }

            for (int i = 0; i < choiceToppingPizza.Length; i += 1)
                choiceToppingPizza[i] = "";

            choiceCrustPizza = "";
            choiceWhereToEatPizza = "";
            choiceSizePiizaFinal = "";

            priceToppingPizza = 0;
            priceCrustPizza = 0;
            priceSizePizza = 0;
            totalPrice = 0; 

        labelTotalPrice.Text = (totalPrice.ToString()) + '$';


        }
        private void setFormFixedRezizeAndMove ( )
        {

            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2; 
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1544, 899);

        }
        public FormMainRestochooseThePizzaProperties()
        {
            InitializeComponent();
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSmall.Checked)
                priceSizePizza = 5;
     
            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            choiceSizePiizaFinal = "Small" ; 
            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void radioButtonMid_CheckedChanged(object sender, EventArgs e)
        {
                if (radioButtonMid.Checked)
                priceSizePizza = 10;
      

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            choiceSizePiizaFinal = "Medium";

            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void radioButtonLarge_CheckedChanged(object sender, EventArgs e)
        {
              if (radioButtonLarge.Checked)
                priceSizePizza = 15;

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            choiceSizePiizaFinal = "Large" ;

            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void FormMainRestochooseThePizzaProperties_Move(object sender, EventArgs e)
        {
            setFormFixedRezizeAndMove();
        }

        private void FormMainRestochooseThePizzaProperties_Resize(object sender, EventArgs e)
        {
            setFormFixedRezizeAndMove();

        }

        private void FormMainRestochooseThePizzaProperties_Load(object sender, EventArgs e)
        {

            labelTotalPrice.Text = totalPrice.ToString() + "$";
            buttonOrderNow.BackColor = Color.FromArgb(255, 55, 8, 8); 
        }

        private void radioButtonThinPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThinPizza.Checked) priceCrustPizza = 5;

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            choiceCrustPizza = "Thin"; 
            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void radioButtonThinkPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThinkPizza.Checked) priceCrustPizza = 10;

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            choiceCrustPizza = "Think";

            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void checkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxExtraCheese.Checked)
            {

                priceToppingPizza += 5;
                choiceToppingPizza[0] = "Extra Cheese" + Environment.NewLine;
            }
            else
            {
                priceToppingPizza -= 5;
                choiceToppingPizza[0] = "";

            }

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            
            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void checkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnion.Checked)
            {

                priceToppingPizza += 2;
                choiceToppingPizza[1] = "Onion" + Environment.NewLine;

            }
            else
            {
                priceToppingPizza -= 2;
                choiceToppingPizza[1] = "";

            }

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;
            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMushrooms.Checked)
            {

                priceToppingPizza += 8;
                choiceToppingPizza[2] = "Mushrooms" + Environment.NewLine;

            }
            else
            {
                priceToppingPizza -= 8;
                choiceToppingPizza[2] = "";

            }

            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;

            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOlives.Checked)
            {

                priceToppingPizza += 5;
                choiceToppingPizza[3] = "Olives" + Environment.NewLine;


            }
            else
            {
                priceToppingPizza -= 5;
                choiceToppingPizza[3] = "";

            }
            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;

            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void checkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTomatoes.Checked)
            {

                priceToppingPizza += 2;
                choiceToppingPizza[4] = "Tomatoes" + Environment.NewLine;

            }
            else
            {
                priceToppingPizza -= 2;
                choiceToppingPizza[4] = "";

            }
            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;

            labelTotalPrice.Text = (totalPrice.ToString())+'$';
        }

        private void checkBoxGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGreenPeppers.Checked)
            {

                priceToppingPizza += 4;
                choiceToppingPizza[5] = "Green Pappers" + Environment.NewLine;

            }
            else
            {
                priceToppingPizza -= 4;
                choiceToppingPizza[5] ="";

            }
            totalPrice = priceSizePizza + priceCrustPizza + priceToppingPizza;

            labelTotalPrice.Text = (totalPrice.ToString()) + '$';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setInitControlsFoodRestuarnt(/*this*/);

        }

        private void pictureBoxBackPrevPage_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();

            
            this.Close();

        }

        private void buttonOrderNow_Click(object sender, EventArgs e)
        {

          
            FormFinalBilling FinalBillingForm = new FormFinalBilling(choiceSizePiizaFinal , choiceCrustPizza , choiceToppingPizza ,  choiceWhereToEatPizza , totalPrice.ToString() , this);

            FinalBillingForm.BackgroundImage = Image.FromFile("Pizzlicious\\FinalBilling.png");

            FinalBillingForm.ShowDialog();

            setInitControlsFoodRestuarnt();
        }

        private void radioButtonEatIn_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEatIn.Checked)
                choiceWhereToEatPizza = "Eat In" ;
          

        }

  

        private void radioButtonTakeOut_CheckedChanged(object sender, EventArgs e)
        {
               if (radioButtonTakeOut.Checked)
                choiceWhereToEatPizza = "Take Out";
        }

        private void labelTotalPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
