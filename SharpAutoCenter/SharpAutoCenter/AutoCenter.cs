using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 *  Georgios Psarakis 
 *  200289922  
 *  10/14/2016 
 */
namespace SharpAutoCenter
{

    public partial class AutoCenter : Form
    {
        

        public AutoCenter()
        {
            InitializeComponent();
            


        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AutoCenter_Load(object sender, EventArgs e)
        {
            // when the form loads select the standard 
            StandardRadioButton.Select();
                 if (StandardRadioButton.Checked) {
                var standard = Program.car.CarPriceStandard = 23000;
                BasePriceTextBox.Text = standard.ToString("C2");
           }
            var tradeIn = 0;
            TradeInTextBox.Text = tradeIn.ToString("C2");
        }

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Prices();
        }

        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Prices();
        }
        
        /*
            This method will check the radio buttons and set the prices
         */
        public void Prices() {
           
            if (StandardRadioButton.Checked)
            {

                BasePriceTextBox.Text = Program.car.CarPriceStandard.ToString("C2");
            }
            else if (PearlizedRadioButton.Checked)
            {
                BasePriceTextBox.Text = Program.car.CarPricePeral.ToString("C2");
            }
            else if (CustomizedDetailingRadioButton.Checked)
            {
                BasePriceTextBox.Text = Program.car.CarPriceCustomized.ToString("C2");
            }
            else StandardRadioButton.Select();
        }
        


        private void StereoSystemCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            double addTheOption;
            double StereoOption;
            double StereoSystem = 250;



            if (StereoSystemCheckBox.Checked == true)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = StereoSystem.ToString("C2");


                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    addTheOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));


                    StereoOption = StereoSystem + addTheOption;

                    AdditionalOptionsTextBox.Text = StereoOption.ToString("C2");


                }
            }

            else
            {
                
                addTheOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                addTheOption = addTheOption - StereoSystem;

                AdditionalOptionsTextBox.Text = addTheOption.ToString("C2");

            }
            subTotal();
            Total();

        }

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            double addTheOption;
            double LeatherOption;
            double LeatherInterior = 1500;



            if (LeatherInteriorCheckBox.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = LeatherInterior.ToString("C2");


                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    addTheOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));


                    LeatherOption = LeatherInterior + addTheOption;

                    AdditionalOptionsTextBox.Text = LeatherOption.ToString("C2");


                }
            }

            else
            {
                
                addTheOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));

                addTheOption = addTheOption - LeatherInterior;

                AdditionalOptionsTextBox.Text = addTheOption.ToString("C2");

            }
            subTotal();
            Total();

        }

        private void ComputerNavigationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            double addTheOption;
            double ComputerOption;
            double ComputerNavigation = 750;



            if (ComputerNavigationCheckBox.Checked)
            {
                if (AdditionalOptionsTextBox.Text == "")
                {
                    AdditionalOptionsTextBox.Text = ComputerNavigation.ToString("C2");


                }
                else if (AdditionalOptionsTextBox.Text != "")
                {
                    addTheOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));


                    ComputerOption = ComputerNavigation + addTheOption;

                    AdditionalOptionsTextBox.Text = ComputerOption.ToString("C2");


                }
            }

            else
            {

                addTheOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));


                addTheOption = addTheOption - ComputerNavigation;

                AdditionalOptionsTextBox.Text = addTheOption.ToString("C2");

            }
            subTotal();
            Total();
           

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }

        
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResetAllControls(this);
            StandardRadioButton.Select();
            if (StandardRadioButton.Checked)
            {
                var standard = Program.car.CarPriceStandard = 23000;
                BasePriceTextBox.Text = standard.ToString("C2");
            }
            AmountDueTextBox.BackColor = Color.White;
            BasePriceTextBox.BackColor = Color.White;
            
        }
        private void subTotal()
        {
            double basePrice = Convert.ToDouble((BasePriceTextBox.Text as string).TrimStart('$'));
            double additionOption = Convert.ToDouble((AdditionalOptionsTextBox.Text as string).TrimStart('$'));
            double subTotal = basePrice + additionOption;

            SubTotalTextBox.Text = subTotal.ToString("C2");
        }
        private void Total()
        {
            double subTotal = Convert.ToDouble((SubTotalTextBox.Text as string).TrimStart('$'));
            double Total = subTotal * 1.13;
            double taxPerc = subTotal * .13;

            TotalTextBox.Text = Total.ToString("C2");
            SalesTaxTextBox.Text = taxPerc.ToString("C2");
        }
        private void AmountDue()
        {
            double subTotal = Convert.ToDouble((SubTotalTextBox.Text as string).TrimStart('$'));
            double TradeValue = Convert.ToDouble((TradeInTextBox.Text as string).TrimStart('$'));
            double AmountDue = subTotal - TradeValue;

            AmountDueTextBox.Text = AmountDue.ToString("C2"); 
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (SubTotalTextBox.Text != "")
            {
                AmountDue();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for picking your car features and getting your total, pick the options you want.");
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SubTotalTextBox.Text != "")
            {
                AmountDue();
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmountDueTextBox.BackColor = Color.Red;
            BasePriceTextBox.BackColor = Color.Red; 
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmountDueTextBox.BackColor = Color.Orange;
            BasePriceTextBox.BackColor = Color.Orange;
        }

        private void calibriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmountDueTextBox.Font = new Font("calibri", 12, FontStyle.Regular);
            BasePriceTextBox.Font = new Font("calibri", 12, FontStyle.Regular);
        }

        private void ArialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AmountDueTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
            BasePriceTextBox.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearButton.PerformClick();
        }
    }
}
