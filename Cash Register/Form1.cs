using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class cashRegister : Form
    {
        //global variables
        double piesPrice = 8.25;
        double burgersPrice = 11.45;
        double drinksPrice = 2.55;
        double piesNumber;
        double burgersNumber;
        double drinksNumber;
        double subTotal;
        double taxRate = 0.13;
        double taxAmount;
        double totalCost;
        public cashRegister()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //Convert Text Boxes into numbers
            piesNumber = Convert.ToDouble(piesInput.Text);
            burgersNumber = Convert.ToDouble(burgersInput.Text);
            drinksNumber = Convert.ToDouble(drinksInput.Text);

            //Calculate Sub Total and display it
            subTotal = piesNumber * piesPrice + burgersNumber * burgersPrice + drinksNumber * drinksPrice;
            subTotallabel2.Text = $"${subTotal}";
            subTotallabel2.Text = subTotal.ToString("C");

            //Calculate Tax Amount and display it
            taxAmount = subTotal * taxRate;
            taxLabel2.Text +=$"${taxAmount}";
            taxLabel2.Text = taxAmount.ToString("C");

            //Calculate total cost including tax
            totalCost = subTotal + taxAmount;
            totalLabel2.Text += $"${totalCost}";
            totalLabel2.Text = totalCost.ToString("C");
        }

        private void recieptButton_Click(object sender, EventArgs e)
        {

            //Add printing sound effect
            SoundPlayer player = new SoundPlayer(Properties.Resources.countdown);
            player.Play();

            //Show resturant name, item names, number of items base price for each item, subtotal, tax, total and "Have a nice day!"
            reciptLabel.Text = "Humphrey's Diner";
            reciptLabel.Text += $"\nPies    x{piesNumber} @ ${piesPrice}";
            reciptLabel.Text += $"\nBurgers x{burgersNumber} @ ${burgersPrice}";
            reciptLabel.Text += $"\nDrinks  x{drinksNumber} @ ${drinksPrice}";
            reciptLabel.Text += $"\n\nSubtotal     {subTotal.ToString("C")}";
            reciptLabel.Text += $"\nTax          {taxAmount.ToString("C")}";
            reciptLabel.Text += $"\nTotal        {totalCost.ToString("C")}";
            reciptLabel.Text += $"\n\nHave A Nice Day!";
        }
    }
}
