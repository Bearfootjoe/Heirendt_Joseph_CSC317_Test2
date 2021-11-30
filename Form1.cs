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
            this.imageTempGauge.Image = Properties.Resources.temperaturegauge_none;
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
                    lbl_ConversionValue1.Text = Convert.ToString(CelsiusValue("Kelvin", numBoxValue)) + "°C";
                    lbl_ConversionValue2.Text = Convert.ToString(FahrenheitValue("Kelvin", numBoxValue)) + "°F";
                }
                else
                {
                    validateUserEntry(numBoxValue);
                    this.numberBoxTempValue.Value = 0;
                }
            }

        }
        public void validateUserEntry(decimal value)
        {
            // Checks the value of the text.
            if (value < 0)
            {
                // Initializes the variables to pass to the MessageBox.Show method.
                string message = "Kelvin cannot be a negative value";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
            }
        }
        public double KelvinValue(string unit, decimal temperature)
        {
            double temp = Convert.ToDouble(temperature);
            double outputTemp;
            if (unit == "Fahrenheit")
            {
                // convert from F to K
                updateTempGraphic(temp);
                outputTemp = (temp - 32);
                outputTemp = outputTemp * 0.56;
                outputTemp = outputTemp + 273.15;
                return outputTemp;
            }
            if (unit == "Celsius")
            {
                // convert from celsius to kelvin
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
                updateTempGraphic(temp);
                outputTemp = (temp - 32);
                outputTemp = outputTemp * 0.56;
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
            if (unit == "Celsius")
            {
                // Output to Fahrenheit from celsius
                outputTemp = (temp * (9 / 5)) + 32;
                updateTempGraphic(outputTemp);
                return outputTemp;
            }
            else if (unit == "Kelvin")
            {
                // Output to Fahrenheit from Kelvin
                outputTemp = (temp - 273.15);
                outputTemp = outputTemp * 1.8;
                outputTemp = outputTemp + 32;
                updateTempGraphic(outputTemp);
                return outputTemp;
            }
            else
            {
                updateTempGraphic(temp);
                return temp;
            }
        }

        private void numberBoxTempValue_ValueChanged(object sender, EventArgs e)
        {
            comboUnits_SelectedIndexChanged(sender, e);
        }

        public void updateTempGraphic(double temperature)
        {
            if (temperature >= 95)
                this.imageTempGauge.Image = Properties.Resources.temperaturegauge_hot;
            else if (temperature < 95 && temperature > 75)
                this.imageTempGauge.Image = Properties.Resources.temperaturegauge_warm;
            else if (temperature <= 75 && temperature > 55)
                this.imageTempGauge.Image = Properties.Resources.temperaturegauge_mild;
            else if (temperature <= 55 && temperature >= 33)
                this.imageTempGauge.Image = Properties.Resources.temperaturegauge_cold;
            else if(temperature < 33)
                this.imageTempGauge.Image = Properties.Resources.temperaturegauge_freezing;
            else
                this.imageTempGauge.Image = Properties.Resources.temperaturegauge_none;


        }
    }
}
