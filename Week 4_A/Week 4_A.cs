using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
 
namespace Week_4_A
{
    public partial class frmJoesAutomotive : Form
    {
        public frmJoesAutomotive()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Only calls TotalCharges() to do the entire calculations. 
            TotalCharges();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Calls all the Void Methods to Clear the Checkboxes and Textboxes appropriately. 
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearRental();
            ClearFees();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //This closes the form entirely. 
            this.Close();
        }


        //All value-returning methods. 
        //Will calculate total charges for any oil/lubes. 
        private decimal OilLubeCharges()
        {
            //Declare and initialize variables for this private method. 
            decimal oil_charge = 26m;
            decimal lube_charge = 18m;
            //Set this variable to 0 so that if none of the conditons are met
            //method will return this value at 0. 
            decimal total_OilLube = 0m; 

            //If oil is checked, add that charge value for oil. 
            if (chkOilChange.Checked)
            {
                total_OilLube += oil_charge;
            }
            //If the lube is checked, add that to the total value. 
            if (chkLubeJob.Checked)
            {
                total_OilLube += lube_charge;
            }

            //If none of these conditions are met, then still return the Total as 0. 
            return total_OilLube;
        }


        //Will calculate total charges for any flush services. 
        private decimal FlushCharges()
        {
            //Declare and Initialize variables. 
            decimal radiator_charge = 30m;
            decimal transmission_charge = 80m;
            decimal total_Flush = 0m;

            //If checked, add this to the total variable.
            if (chkRadiator.Checked)
            {
                total_Flush += radiator_charge;
            }
            //If checked, add this to the total variable. 
            if (chkTransmission.Checked)
            {
                total_Flush += transmission_charge;
            }
            //Return the value, even when there is zero if none of the conditions are met. 
            return total_Flush;
        }


        //Will calculate total charges for any misc services. 
        private decimal MiscCharges()
        {
            //Delcare and Initialize my variables. 
            decimal inspection_charge = 15m;
            decimal muffler_charge = 100m;
            decimal tire_rotation_charge = 20m;
            decimal TOTAL_Misc = 0m;

            //If checked, add this to the total variable. 
            if (chkInspection.Checked)
            {
                TOTAL_Misc += inspection_charge;
            }
            //If chcked, add this to the total variable. 
            if (chkReplaceMuffler.Checked)
            {
                TOTAL_Misc += muffler_charge;
            }
            //If checked, add this to the total variable. 
            if (chkTireRotation.Checked)
            {
                TOTAL_Misc += tire_rotation_charge;
            }
            //Return the value, even when there is zero if none of the conditions are met. 
            return TOTAL_Misc; 
        }

        //NOTE: I cannot figure out how to get a method to return two values for OtherCharges()
        //and even with one value, having to work with that value in TotalCharges() seemed to defeat
        //the purpose of using methods. Thus, due to the time crunch for this assignment, I chose 
        //to split the method into two separate methods, which are found below OtherCharges(). 
        //I have kept OtherCharges() so that you can see my attempt. To my knowledge, the 
        //application still runs just fine.
        private decimal OtherCharges()
        {
            //Declare and initialize all variables. 
            decimal parts_charges = 0m;
            decimal labor_charges = 0m;
            decimal temp_labor = 0m;
            decimal temp_parts = 0m;
            decimal total_OtherCharges = 0m; 

            //Focus on PARTS FIRST. 
            //Check if the User leaves the textbox blank. 
            if (txtParts.Text == "")
            {
                parts_charges = 0m;
            }
            //If the User does indeed put a valid value in the textbox, use it!!!
            else if (decimal.TryParse(txtParts.Text, out temp_parts))
            {
                parts_charges = temp_parts;
            }
            else
            {
                //Under any other circumstances. 
                MessageBox.Show("Invalid Input. Please enter only decimnal values.");
                txtParts.Clear();
                txtParts.Focus();
            }
            //Now do the LABOR textbox. 
            //Check if the User leaves the textbox blank. 
            if (txtLabor.Text == "")
            {
                labor_charges = 0m; 
            }
            //If the User does indeed put a valid input in the textbox, set value 
            //equal to the appropriate variable. 
            else if (decimal.TryParse(txtLabor.Text, out temp_labor))
            {
                labor_charges = temp_labor;
            }
            else
            {
                //User error message. 
                MessageBox.Show("Invalid Input. Please enter only a decimal value.");
                txtLabor.Clear();
                txtLabor.Focus();
            }
            //Add up both charges to return one sum value. 
            total_OtherCharges = parts_charges + labor_charges;
            return total_OtherCharges;

        }

        //This is the first method in an attempt to split the OtherCharges(). 
        private decimal PartsCharges()
        {
            //Declare and Initialize variables. 
            decimal parts_charges = 0.00m;
            decimal temp_parts = 0.00m; 

            //Focus on PARTS FIRST. 
            //Check if the textbox from User is blank or not. 
            if (txtParts.Text == "")
            {
                //If blank, set to zero. 
                parts_charges = 0m;
            }
            //if the User does indeed put a valid value in the textbox, use it!!!
            else if (decimal.TryParse(txtParts.Text, out temp_parts))
            {
                parts_charges = temp_parts;
            }
            else
            {
                //Under any other circumstances, give user error message. 
                MessageBox.Show("Invalid Input. Please enter only a numerical value.");
                txtParts.Clear();
                txtParts.Focus();
            }

            return parts_charges;
        }

        //This is the second method in an attempt to split the OtherCharges(). 
        private decimal LaborChargees()
        {
            //Declare and Initialize variables. 
            decimal labor_charges = 0.00m;
            decimal temp_labor = 0.00m;
            decimal hr_charge = 20.00m;


            //Focus on LABOR NEXT. 
            //If the User leaves the textbox blank. 
            if (txtLabor.Text == "")
            {
                //If blank, set to zero. 
                labor_charges = 0m;
            }
            //If the User does indeed put a valid input in the textbox, use it. 
            else if (decimal.TryParse(txtLabor.Text, out temp_labor))
            {
                labor_charges = temp_labor * hr_charge;
            }
            else
            {
                //User error message under any other conditions. 
                MessageBox.Show("Invalid Input. Please enter only a numerical value.");
                txtLabor.Clear();
                txtLabor.Focus();
                
            }

            return labor_charges;
        }

        //Will calculate the TAX only on PARTS.  
        private decimal TaxCharges(decimal parts)
        {
            //Declare and Initialize variables. 
            decimal total_tax = 0m;
            const decimal TAX = 0.06m;

            //Do the calculation for the percentage owed on ONLY the parts. 
            total_tax = parts * TAX;

            return total_tax;
        }

        //Will Calculate Rental Charges. 
        private decimal RentalCharges()
        {
            decimal DAYS = 0.00m; 
            decimal TOTAL_Rental = 0.00m;
            decimal daily_charge = 0.00m;
            //The set amount of charge already in the form. 
            //Had difficulty with default variable for some reason, 
            //so due to time crunch, I decided to do this. 
            const decimal fifty_charge = 50.00m;  
            decimal temp_DAYS = 0.00m;

            //If the checkbox is indeed checked. 
            if (chkRentalCars.Checked)
            {
                //Check if the box is empty then it will equal 1. 
                if (txtNumDays.Text == "")
                {
                    //test to ensure that the fifty_charge was NOT changed by user. 
                    if (decimal.TryParse(txtDailyPrice.Text, out daily_charge))
                    {
                        //If the daily charge was NOT changed, then set DAYS equal to 1. 
                        if (daily_charge == fifty_charge)
                        {
                            DAYS = 1;
                            TOTAL_Rental = DAYS * fifty_charge;
                        }
                        else
                        {
                            //If the daily charge was changed, send User Error Message. 
                            MessageBox.Show("The User cannot change the daily rental charge. It must remain $50.");
                            txtDailyPrice.Text = "50";
                            txtNumDays.Clear();
                            txtNumDays.Focus();
                        }
                    }
                    else
                    {
                        //If the user puts a non-numerical value for daily charge, send a User Error Message. 
                        MessageBox.Show("The user cannot change the value of the daily rental charge. And it has to be a numerical value./");
                        txtDailyPrice.Text = "50";
                        txtNumDays.Clear();
                        txtNumDays.Focus();
                    }
                   
                }
                //If the User does put in a number for days, check if it's a number. 
                else if (decimal.TryParse(txtNumDays.Text, out temp_DAYS))
                {
                    //Check if the days are within the right range. 
                    if (temp_DAYS >= 1 && temp_DAYS <= 7)
                    {                       
                        //Check if the daily price has again not changed by user.  
                        if (decimal.TryParse(txtDailyPrice.Text, out daily_charge))
                        {
                            //If not changed, all is good and perform calculation. 
                            if (daily_charge == fifty_charge)
                            {
                                DAYS = temp_DAYS;
                                TOTAL_Rental = DAYS * fifty_charge;
                            }
                            else
                            //User error message if the $50 has been changed by user to a different number. 
                            {                          
                                MessageBox.Show("The User cannot change the daily rental charge. It must remain $50.");
                                txtDailyPrice.Text = "50";
                                txtNumDays.Clear();
                                txtNumDays.Focus();
                            }
                        }
                        //User error message if the value has been changed to a non-numerical value. 
                        else
                        {
                            MessageBox.Show("The user cannot change the value of the daily rental charge. And it has to be a numerical value.");
                            txtDailyPrice.Text = "50";
                            txtNumDays.Clear();
                            txtNumDays.Focus();
                        }                       
                    }
                    //User Error Message if the number of days is outside of the required range. 
                    else
                    {
                        MessageBox.Show("Invalid input for days. Only put a value within the range of 1-7.");
                        //Clear the textbox. 
                        txtNumDays.Clear();
                        //Put the focus back onto that textbox for a second user attempt. 
                        txtNumDays.Focus();
                    }
                }
                //User Error Message if the user put in a non-numerical value for days. 
                else
                { 
                    MessageBox.Show("Invalid input. Please only enter only numerical values for days."); 
                    txtNumDays.Clear();
                    txtNumDays.Focus();
                }

            }
            //If the checkbox is not checked at all, keep these textboxes disabled. 
            else
            {
                txtNumDays.Enabled = false;
                txtDailyPrice.Enabled = false;
            }

            return TOTAL_Rental;

        }


        private decimal TotalCharges()
        {
            //Declare all variables. 
            decimal GRAND_TOTAL = 0.00m;
            decimal SUB_TOTAL1 = 0.00m;
            decimal SUB_TOTAL2 = 0.00m;
            decimal oil_lub = 0.00m;
            decimal flush = 0.00m;
            decimal misc = 0.00m;
            decimal rental = 0.00m;
            decimal parts = 0.00m;
            decimal labor = 0.00m;
            decimal tax = 0.00m;
            decimal test = 0.00m;
            decimal sub = 0.00m; 

            //Call the value-returning methods with only checkboxs. 
            oil_lub = OilLubeCharges();
            flush = FlushCharges();
            misc = MiscCharges();
            rental = RentalCharges();
            parts = PartsCharges();
            labor = LaborChargees();
            //Recall that we need the value from parts to calculate the tax. 
            //And the TaxCharges Method only takes a value of dec type, so we are good here. 
            tax = TaxCharges(parts);

            //ADD this together to determine if this is a minimum of $25 
            //in order for the user to have the rental service. 
            //Exclude parts because parts is NOT a service. 
            SUB_TOTAL1 = oil_lub + flush + misc + labor;

            //If the subtotal1 is over $25, proceed with the calculations with the rental option
            //calling the RentalCharges() method. 
            if (SUB_TOTAL1 >= 25.00m || parts >= 25.00m)
            {              
                SUB_TOTAL2 = SUB_TOTAL1 + rental;
                GRAND_TOTAL = SUB_TOTAL2 + parts + tax;
                lblActualServiceLabor.Text = SUB_TOTAL2.ToString("c");
            }
            else
            {
                //If the subtotal1 is below $25 and the user has NOT checked the rental option, 
                //proceed with the calculation appropriately, NOT adding the rental charge. 
                if (chkRentalCars.Checked == false)
                {
                    GRAND_TOTAL = SUB_TOTAL1;
                    lblActualServiceLabor.Text = SUB_TOTAL1.ToString("C");
                }
                //If the subtotal1 is below $25, but the user does check the rental checkbox. 
                else
                {
                    //Prevent the rental charges from being added and send User an Error message. 
                    GRAND_TOTAL = SUB_TOTAL1;
                    MessageBox.Show("You must have a minimum of $25 to have the rental option.");
                    txtNumDays.Clear();
                    chkRentalCars.Checked = false;
                    lblActualServiceLabor.Text = SUB_TOTAL1.ToString("C");
                }

            }            

            //Display in the Summary Groupbox for the User. 
            //Parts display. 
            lblActualParts.Text = parts.ToString("C");
            //Tax display on the parts value. 
            lblActualPartsTax.Text = tax.ToString("C");
            //Display the grand total in the appropriate label. 
            lblActualTotalFees.Text = GRAND_TOTAL.ToString("C");
            
            return GRAND_TOTAL;
        }


        //Now the VOID Methods that return NOTHING. 
        private void ClearOilLube()
        {
            //Clears check boxes for oil change and lube job. 
            //Returns nothing. 
            chkOilChange.Checked = false;
            chkLubeJob.Checked = false;
        }

        private void ClearFlushes()
        {
            //Clears check boxes for radiator flush and transmission flush. 
            chkRadiator.Checked = false;
            chkTransmission.Checked = false;
        }

        private void ClearMisc()
        {
            //Clears the check boxes for inspection, muffler replacement, and tire rotation. 
            chkInspection.Checked = false;
            chkReplaceMuffler.Checked = false;
            chkTireRotation.Checked = false;
        }

        private void ClearOther()
        {
            //Clears the text boxes for parts and labor. 
            txtParts.Clear();
            txtLabor.Clear();
            txtParts.Focus();
        }

        private void ClearRental()
        {
            //Clears the Rental Checkbox. 
            chkRentalCars.Checked = false;
            //Clears number of days. 
            txtNumDays.Clear();
            //Reset the daily rental price back to $50
            txtDailyPrice.Text = "50";
            
            //Ensure that the rest of the form is disabled until the checkbox is checked. 
            //if the checkbox is NOT checked, then disable the rest of the groupbox. 
            if (chkRentalCars.Checked == false)
            {
                //if the checkbox is NOT checked, then disable these two text boxes. 
                txtNumDays.Enabled = false;
                txtDailyPrice.Enabled = false;
            }
            else
            {
                //If the checkbox IS checked, enable these two text boxes. 
                txtNumDays.Enabled = true;
                txtDailyPrice.Enabled = true;
            }

        }
        private void ClearFees()
        {
            //Clears everything in the Summary Group 
            lblActualServiceLabor.Text = "";
            lblActualParts.Text = "";
            lblActualPartsTax.Text = "";
            lblActualTotalFees.Text = "";

        }

        private void chkRentalCars_CheckedChanged(object sender, EventArgs e)
        {
            //When the rental checkbox is checked, enable both textboxes
            //that are in the rental car groupbox. 
            txtNumDays.Enabled = chkRentalCars.Checked;
            txtDailyPrice.Enabled = chkRentalCars.Checked;
        }
        
    }
}
//ALL DONE!!!