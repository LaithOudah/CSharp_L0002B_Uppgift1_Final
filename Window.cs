/*
 * Author: Laith Oudah
 * University: Luleå Tekniska Universitet
 * Course: L0002B
 * LTU: LAIOUD-1
 * Assignment: Inlämningsuppgift 1
 */

using System;
using System.Linq;
using System.Windows.Forms;

namespace FormsAppUppgift1

{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Change.price = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Change.paid = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Function to check if digit when the button is pressed
            if (!textBox1.Text.All(Char.IsDigit) || !textBox2.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Only numbers allowed");
            }
            else
            {
                Change.CalcChange();
            }

        } // Button

    } // Public partial class Window
}


