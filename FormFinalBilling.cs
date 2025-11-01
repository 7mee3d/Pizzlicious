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
using Pizzlicious.Properties;

namespace Mini_Project___Pizza_Resto_Shodwe
{

 

    public partial class FormFinalBilling : Form
    {
         private string _StrSizePizza = "";
        private string _StrCrustTypePizza  = "";
        private string []_StrToppingsPizza  ;
        private string _StrWhereToEatPizza  = "";
        private string _StrTotalPrice = "";
       static  int  numberOrders = 0;


        private FormMainRestochooseThePizzaProperties _frmMainMenuResto; 

        private void setFormFixedRezizeAndMove()
        {

            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth -300 , yHeight);

            this.Size = new Size(615, 930);

        }
        private void ResetAllOrder()
        {
            _StrSizePizza = "";
            _StrCrustTypePizza = "";

            for (int i = 0; i < _StrToppingsPizza.Length; i += 1)
                _StrToppingsPizza[i] = "";

            _StrWhereToEatPizza = "";
            _StrTotalPrice = "0";

     
        }
        public FormFinalBilling(string SizePizza , string CrustTypePizza , string[] ToppingsPizza , string WhereToEatPizza , string totalPricePizza , FormMainRestochooseThePizzaProperties FrmMainRetoMenu  ) 
        {
            InitializeComponent();
            
                _StrSizePizza = SizePizza;
                _StrCrustTypePizza = CrustTypePizza;
                _StrToppingsPizza = ToppingsPizza;
                _StrWhereToEatPizza = WhereToEatPizza;
                _StrTotalPrice = totalPricePizza;
                _frmMainMenuResto = FrmMainRetoMenu;

        }

        private void resetAllControlsInForm (Form frmForm)
        {
            foreach (Control con in frmForm.Controls )
            {

                if(con is GroupBox GB )
                {
                    foreach (Control innerCon in GB.Controls)
                    {
                        if (innerCon is RadioButton RB)
                            RB.Checked = false;

                        if (innerCon is CheckBox CB)
                            CB.Checked = false; 
                    }
                }
              
            }


        }
        private void FormFinalBilling_Load(object sender, EventArgs e)
        {

           // this.BackgroundImage = Resources.FinalBilling; 

            this.BackgroundImageLayout = ImageLayout.Stretch;

            labelResultSizePizza.Text = _StrSizePizza;
            labelResultCrustTypePizza.Text = _StrCrustTypePizza;


            /*  for (int x = 0; x < _StrToppingsPizza.Length; x += 1)
           {
               labelResultToppings.Text = string.Join("", _StrToppingsPizza.Where(Toppings => !string.IsNullOrEmpty(Toppings)));

           }
           */

            int count = 0; 
            foreach (string toppings in _StrToppingsPizza)
            {
                if (!string.IsNullOrEmpty(toppings))
                {
                    labelResultToppings.Text += toppings;
                    ++count;

                }

            }

            if(count ==0  )
                labelResultToppings.Text = "No Toppings";

            labelResultWhereToEat.Text = _StrWhereToEatPizza;
            labelTotalPriceBilling.Text = _StrTotalPrice;

            notifyIconCheckOutOrder.BalloonTipClicked += notifyIconCheckOutOrder_BalloonTipClicked;



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

        string path = @"../../Data Orders Pizzlicious/DataRestoShadweOrders.txt";

        private void buttonCheakOut_Click(object sender, EventArgs e)
        {

            if (!System.IO.File.Exists(path))
            {
                System.IO.File.Create(path).Close(); 

            }

            System.IO.StreamWriter SW = new System.IO.StreamWriter(path, true);

            string InfoOneOrder =

                  Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine
                + Environment.NewLine

                + "--------------------- +Order Pizza+ -----------------------"


                     + Environment.NewLine
                     + Environment.NewLine
                     + "                     - Order .NO : " + ++numberOrders + Environment.NewLine + Environment.NewLine
                     + "       - Date Time Order : " + DateTime.Now.ToString()
                     + Environment.NewLine
                     + Environment.NewLine


                + "---------------------- +Info Order+ -----------------------"
                + Environment.NewLine
                + Environment.NewLine

                     + "+ Size Pizza : " + _StrSizePizza + Environment.NewLine
                     + "+ Crust Type Pizza : " + _StrCrustTypePizza + Environment.NewLine
                     + "+ Where Eat Pizza : " + _StrWhereToEatPizza + Environment.NewLine
                     + "+ Price This Order = " + _StrTotalPrice + Environment.NewLine
                     + "+ Toggings : " + labelResultToppings.Text


                + Environment.NewLine

                + "-----------------------------++-----------------------------"
                + Environment.NewLine;

            //Write The Order in the File .TXT
            SW.WriteLine(InfoOneOrder);

            //Close File After store order in the file
            SW.Close();

            notifyIconCheckOutOrder.ShowBalloonTip(1500, "Finial Bill Order", "This Order is Save in the file Orders", ToolTipIcon.Info);

            // Aleart The Reciption the order is done 
            MessageBox.Show("The Order Is Done", "Note This Order", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetAllOrder();

            resetAllControlsInForm(_frmMainMenuResto);

            _frmMainMenuResto.Show();
            this.Close();
        }

        private async void notifyIconCheckOutOrder_BalloonTipClicked(object sender, EventArgs e)
        {
            string fullPathFileOrders = System.IO.Path.GetFullPath(path);
            await Task.Delay(1000);
            if (System.IO.File.Exists(path))
                System.Diagnostics.Process.Start("explorer.exe", fullPathFileOrders);
            else
                MessageBox.Show(
                    "The File Not Found"
                    , "Error! File Not Found"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
        }
    }
}
