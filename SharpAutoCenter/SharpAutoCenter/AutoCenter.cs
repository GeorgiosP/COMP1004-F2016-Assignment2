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
                BasePriceTextBox.Text = standard.ToString("c2");
           }
        }

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            prices();
        }

        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            prices();
        }
        
        /*
            This method will check the radio buttons and set the prices
         */
        public void prices() {
            Program.car.CarPriceStandard = 23000;
            Program.car.CarPricePeral = 23500;
            Program.car.CarPriceCustomized = 24500;
            if (StandardRadioButton.Checked)
            {

                BasePriceTextBox.Text = Program.car.CarPriceStandard.ToString("c2");
            }
            else if (PearlizedRadioButton.Checked)
            {
                BasePriceTextBox.Text = Program.car.CarPricePeral.ToString("c2");
            }
            else if (CustomizedDetailingRadioButton.Checked)
            {
                BasePriceTextBox.Text = Program.car.CarPriceCustomized.ToString("c2");
            }
            else StandardRadioButton.Select();
        }
    }
}
