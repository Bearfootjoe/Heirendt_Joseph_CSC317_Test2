using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heirendt_Joseph_CSC317_Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal numBoxValue = numberBoxTempValue.Value;

            if(comboUnits.Text == "Fahrenheit")
            {
                lbl_ConversionValue1.Text = Convert.ToString(KelvinValue("Fahrenheit", numBoxValue)) + "k";
                lbl_ConversionValue2.Text = Convert.ToString(CelsiusValue("Fahrenheit", numBoxValue)) + "°C";
            }
            else if(comboUnits.Text == "Celsius")
            {
                lbl_ConversionValue1.Text = Convert.ToString(KelvinValue("Celsius", numBoxValue)) + "k";
                lbl_ConversionValue2.Text = Convert.ToString(FahrenheitValue("Celsius", numBoxValue)) + "°F";
            }
            else if(comboUnits.Text == "Kelvin")
            {
                if (numBoxValue >= 0)
                {
                    lbl_ConversionValue1.Text = Convert.ToString(CelsiusValue("Celsius", numBoxValue)) + "°C";
                    lbl_ConversionValue2.Text = Convert.ToString(FahrenheitValue("Kelvin", numBoxValue)) + "°F";
                }
                else
                {
                    // Open dialog box
                    comboUnits.Text = null;
                    numBoxValue = 0;
                }
            }

        }

        public double KelvinValue(string unit, decimal temperature)
        {
            double temp = Convert.ToDouble(temperature);
            double outputTemp;
            if (unit == "Fahrenheit")
            {
                // Output to Kelvin
                outputTemp = ((temp - 32) * (5 / 9)) + 273.15;
                return outputTemp;
            }
            else if (unit == "Celsius")
            {
                // Output to Kelvin
                outputTemp = temp + 273.15;
                return outputTemp;
            }
            else
                return 0;
        }
        public double CelsiusValue(string unit, decimal temperature)
        {
            double temp = Convert.ToDouble(temperature);
            double outputTemp;
            if (unit == "Fahrenheit")
            {
                // Output to Celsius
                outputTemp = ((temp - 32) * (5 / 9));
                return outputTemp;
            }
            else if (unit == "Kelvin")
            {
                // Output to Celsius
                outputTemp = temp - 273.15;
                return outputTemp;
            }
            else
                return 0;
        }
        public double FahrenheitValue(string unit, decimal temperature)
        {
            double temp = Convert.ToDouble(temperature);
            double outputTemp;
            if(unit == "Celsius")
            {
                // Output to Fahrenheit
                outputTemp = (temp * (9 / 5)) + 32;
                return outputTemp;
            }
            else if(unit == "Kelvin")
            {
                // Output to Fahrenheit
                outputTemp = ((temp - 273.15) * (9 / 5) + 32);
                return outputTemp;
            }
            else 
                return 0;
        }

        private void numberBoxTempValue_ValueChanged(object sender, EventArgs e)
        {
            comboUnits_SelectedIndexChanged(sender, e);
        }
    }
}
