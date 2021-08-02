/*
 * Author: Laith Oudah
 * University: Luleå Tekniska Universitet
 * Course: L0002B
 * LTU: LAIOUD-1
 * Assignment: Inlämningsuppgift 1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsAppUppgift1

{
    public class Change
    {
        // Change constructor
        public Change()
        {
            CalcChange();
        }

        /*
         * Declaring the different bill values, getters and setters.
         * Using get due to its an access method/indexer that returns  
         * the value of the property or indexed element.
         */
        int FiveHundredBills { get; set; }
        int HundredBills { get; set; }
        int FiftyBills { get; set; }
        int TwentyBill { get; set; }
        int TenCoin { get; set; }
        int FiveCoin { get; set; }
        int OneCoin { get; set; }

        internal static string price;
        internal static string paid;

        public static void CalcChange()
        {

            int priceInt = int.Parse(price);
            int paidInt = int.Parse(paid);

            var result = paidInt - priceInt;

            // Output organizer
            string outputMsg = "";

            // Instance of the function change called change that calulates the value of Växel
            var change = new Change(result);

            // If statement that checks if the user have payed too little
            if (result >= 0)
            {
                /*
                 * The If satement contains several if statements that check if the change exceeds 0.
                 * If it does, write out the value, else nothing.
                 * If this method wasn't used, the output would show every bill with a 0 next to it
                 * which is not wanted for a customer.
                 */
                // Display "change back" if theres change.
                if (result > 0)
                {
                    outputMsg = "Växel tillbaka:\n";
                }

                if (change.FiveHundredBills > 0)
                {
                    outputMsg = outputMsg + ($"{change.FiveHundredBills} Femhundralappar\n");
                }

                if (change.HundredBills > 0)
                {
                    outputMsg = outputMsg + ($"{change.HundredBills} st Hundralappar\n");
                }

                if (change.FiftyBills > 0)
                {
                    outputMsg = outputMsg + ($"{change.FiftyBills} st Femtiolappar\n");
                }

                if (change.TwentyBill > 0)
                {
                    outputMsg = outputMsg + ($"{change.TwentyBill} st Tjugiolappar\n");
                }

                if (change.TenCoin > 0)
                {
                    outputMsg = outputMsg + ($"{change.TenCoin} st Tiokronor\n");
                }

                if (change.FiveCoin > 0)
                {
                    outputMsg = outputMsg + ($"{change.FiveCoin} st Femkronor\n");
                }

                if (change.OneCoin > 0)
                {
                    outputMsg = outputMsg + ($"{change.OneCoin} st Enkroner\n");
                }

                outputMsg = outputMsg + ("\nTotalt tillbaka: " +
                    result + " kr\n" + "\nTotal belopp: " + price + "kr" +
                    "\n" + "Betalt: " + paid + "kr\n\n");
            }
            else
            {
                MessageBox.Show("\nFör lite betalt. \n");
            }
            MessageBox.Show(outputMsg);

        } // CalcChange

        /*
         * This function checks the different values by taking in an argument called price
         * and checks if the arg is divideable (mod) by the diffrent assigned values,
         * then saves the value in price
         */

        private Change(int price)
        {
            FiveHundredBills = (price / 500);
            price %= 500;

            HundredBills = (price / 100);
            price %= 100;

            FiftyBills = (price / 50);
            price %= 50;

            TwentyBill = (price / 20);
            price %= 20;

            TenCoin = (price / 10);
            price %= 10;

            FiveCoin = (price / 5);
            price %= 5;

            OneCoin = (price / 1);
            price %= 1;

        } // Private Change


    } // Public class Change
}


