using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PC_Calculator_CSharp
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();

        }
        //variables to hold operands
        private double valHolder1;
        private double valHolder2;
        //Varible to hold temporary values
        private double tmpValue;
        //True if "." is use else false
        private bool hasDecimal = false;
        private bool inputStatus = true;
        
        private string calcFunc;

        #region "Number Buttons "
        private void cmd9_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd9.Text;
            }
            else
            {
                txtInput.Text = cmd9.Text;
                inputStatus = true;
            }
        }

        private void cmd8_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd8.Text;
            }
            else
            {
                txtInput.Text = cmd8.Text;
                inputStatus = true;
            }
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd7.Text;
            }
            else
            {
                txtInput.Text = cmd7.Text;
                inputStatus = true;
            }
        }

        private void cmd6_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd6.Text;
            }
            else
            {
                txtInput.Text = cmd6.Text;
                inputStatus = true;
            }
        }

        private void cmd5_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd5.Text;
            }
            else
            {
                txtInput.Text = cmd5.Text;
                inputStatus = true;
            }
        }

        private void cmd4_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd4.Text;
            }
            else
            {
                txtInput.Text = cmd4.Text;
                inputStatus = true;
            }
        }

        private void cmd3_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd3.Text;
            }
            else
            {
                txtInput.Text = cmd3.Text;
                inputStatus = true;
            }
        }

        private void cmd2_Click(object sender, System.EventArgs e)
        {
            if (inputStatus)
            {
                txtInput.Text += cmd2.Text;
            }
            else
            {
                txtInput.Text = cmd2.Text;
                inputStatus = true;
            }
        }

        private void cmd1_Click(object sender, System.EventArgs e)
        {
            //Check the inputStatus
            if (inputStatus)
            {
                
                txtInput.Text += cmd1.Text;
            }
            else
            {
                //Value is False
                //Set the value to the value of the button
                txtInput.Text = cmd1.Text;
                //Toggle inputStatus to True
                inputStatus = true;
            }
        }

        private void cmd0_Click(object sender, System.EventArgs e)
        {
            //Check the input status
            if (inputStatus)
            {
                
                if (txtInput.Text.Length >= 1)
                {
                    //Add our zero
                    txtInput.Text += cmd0.Text;
                }
            }
        }
        #endregion


        #region " Calculation Buttons "
        private void cmdAdd_Click(object sender, System.EventArgs e)
        {
            //Make sure out input box has a value
            if (txtInput.Text.Length != 0)
            {
                //Check the value of our function flag
                if (calcFunc == string.Empty)
                {
                    
                    valHolder1 = System.Double.Parse(txtInput.Text);
                    //Empty the input box
                    txtInput.Text = string.Empty;
                }
                else
                {
                    
                    CalculateTotals();
                }
                //Assign a value to our calc function flag
                calcFunc = "Add";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdSubtract_Click(object sender, System.EventArgs e)
        {
            //Make sure the input box has a value
            if (txtInput.Text.Length != 0)
            {
                //Check the valueof our calculate function flag
                if (calcFunc == string.Empty)
                {
                    
                    valHolder1 = System.Double.Parse(txtInput.Text);
                    //Empty the input box
                    txtInput.Text = string.Empty;
                }
                else
                {
                    //Flag isnt empty
                    //Call our calculate totals method
                    CalculateTotals();
                }
                
                calcFunc = "Subtract";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdDivide_Click(object sender, System.EventArgs e)
        {
            //Make sure our input box has a value
            if (txtInput.Text.Length != 0)
            {
                //Check to see if the calc func flag is empty
                if (calcFunc == string.Empty)
                {
                    
                    valHolder1 = System.Double.Parse(txtInput.Text);
                    //Empty the input box
                    txtInput.Text = string.Empty;
                }
                else
                {
                    
                    CalculateTotals();
                }
                //Assign our calc function flag
                calcFunc = "Divide";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdMultiply_Click(object sender, System.EventArgs e)
        {
            //Make sure the input box has a value
            if (txtInput.Text.Length != 0)
            {
                //Make sure out calc function flag is empty
                if (calcFunc == string.Empty)
                {
                    
                    valHolder1 = System.Double.Parse(txtInput.Text);
                    //Empty the input box
                    txtInput.Text = string.Empty;
                }
                else
                {
                    
                    CalculateTotals();
                }
                //Assign our calc function flag
                calcFunc = "Multiply";
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdPowerOf_Click(object sender, System.EventArgs e)
        {
            //Make sure the input box has a value
            if (txtInput.Text.Length != 0)
            {
                //Check if the calcFunc flag is empty
                if (calcFunc == string.Empty)
                {
                    //Assign the value of the input box to our variable
                    valHolder1 = System.Double.Parse(txtInput.Text);
                  
                    txtInput.Text = string.Empty;
                }
                else
                {
                    //Call the calculate totals method
                    CalculateTotals();
                }
                //Assign our flag the value of "PowerOf"
                calcFunc = "PowerOf";
                //Reset the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdSqrRoot_Click(object sender, System.EventArgs e)
        {
            //Make sure the input box has a value
            if (txtInput.Text.Length != 0)
            {
                //Assign our variable the value in the input box
                tmpValue = System.Double.Parse(txtInput.Text);
                //Perform the square root
                tmpValue = System.Math.Sqrt(tmpValue);
                //Display the results in the input box
                txtInput.Text = tmpValue.ToString();
                //Clear the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdEqual_Click(object sender, System.EventArgs e)
        {
          
            if (txtInput.Text.Length != 0 && valHolder1 != 0)
            {
                //Call the calculate totals method
                CalculateTotals();
                //Clear the calcFunction value
                calcFunc = string.Empty;
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdInverse_Click(object sender, System.EventArgs e)
        {
            //Make sure the input box has a value
            if (txtInput.Text.Length != 0)
            {
                
                tmpValue = System.Double.Parse(txtInput.Text);
                //Perform a (1 divided by value calculations)
                tmpValue = 1 / tmpValue;
                //Display the results in the input box
                txtInput.Text = tmpValue.ToString();
                //Toggle the decimal flag
                hasDecimal = false;
            }
        }

        private void cmdSign_Click(object sender, System.EventArgs e)
        {
            //Check the input status
            if (inputStatus)
            {
                //Check to make sure theres a value in the input box
                if (txtInput.Text.Length > 0)
                {
                    
                    valHolder1 = -1 * System.Double.Parse(txtInput.Text);
                    //Display the value to the user
                    txtInput.Text = valHolder1.ToString();
                }
            }
        }
        #endregion

        #region " Other Buttons "
        private void cmdClearEntry_Click(object sender, System.EventArgs e)
        {
            //Empty the input box
            txtInput.Text = string.Empty;
            //Toggle the decimal flag
            hasDecimal = false;
        }

        private void cmdClearAll_Click(object sender, System.EventArgs e)
        {
            //Empty the text in the input box
            txtInput.Text = string.Empty;
            //Clear out both temp values
            valHolder1 = 0;
            valHolder2 = 0;
            //Set the calc switch to empty
            calcFunc = string.Empty;
            //Toggle the hasDecimal flag
            hasDecimal = false;
        }

        private void cmdBackspace_Click(object sender, System.EventArgs e)
        {
            //Declare locals needed
            string str;
            int loc;
            //Make sure the text length is > 1
            if (txtInput.Text.Length > 0)
            {
                //Get the next to last character
                str = txtInput.Text.Substring(txtInput.Text.Length - 1);
                //Check if its a decimal
                if (str == ".")
                {
                    //If it is toggle the hasDecimal flag
                    hasDecimal = false;
                }
                //Get the length of the string
                loc = txtInput.Text.Length;
                //Remove the last character, incrementing by 1
                txtInput.Text = txtInput.Text.Remove(loc - 1, 1);
            }
        }

        private void cmdDecimal_Click(object sender, System.EventArgs e)
        {
            //Check for input status (we want true)
            if (inputStatus)
            {
                //Check if it already has a decimal (if it does then do nothing)
                if (!hasDecimal)
                {
                    
                    if (txtInput.Text.Length != 0)
                    {
                        //Make sure 0 isnt the first number
                        if (txtInput.Text != "0")
                        {
                            //It met all our requirements so add the zero
                            txtInput.Text += cmdDecimal.Text;
                            //Toggle the flag to true (only 1 decimal per calculation)
                            hasDecimal = true;
                        }
                    }
                    else
                    {
                        
                        txtInput.Text = "0.";
                    }
                }
            }
        }

        #endregion

        #region " Helpers "
        private void CalculateTotals()
        {
            valHolder2 = System.Double.Parse(txtInput.Text);
           
            switch (calcFunc)
            {
                //addition
                case "Add":
                    valHolder1 = valHolder1 + valHolder2;
                    break;
                //subtraction
                case "Subtract":
                    valHolder1 = valHolder1 - valHolder2;
                    break;
                //division
                case "Divide":
                    valHolder1 = valHolder1 / valHolder2;
                    break;
                //multiplication
                case "Multiply":
                    valHolder1 = valHolder1 * valHolder2;
                    break;
                //exponents (power of)
                case "PowerOf":
                    valHolder1 = System.Math.Pow(valHolder1, valHolder2);
                    break;
            }
            //set our input area to the value of the calculation
            txtInput.Text = valHolder1.ToString();
            inputStatus = false;
        }
        #endregion



    }
}