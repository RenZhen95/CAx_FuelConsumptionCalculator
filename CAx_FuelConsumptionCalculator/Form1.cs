using System;
using System.Globalization;
using MetroFramework.Forms;

namespace CAx_FuelConsumptionCalculator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LKMtoMPG_Click(object sender, EventArgs e)
        {
            double convertedValue, nominator, denominator;

            // First check the value input by the user
            (bool, double) checkResults = checkUserInput(LiterKilometerBox.Text);
            if (!checkResults.Item1) { return; }
            else
            {
                nominator   = 62.13712;     // 100km in Miles
                denominator = 0.26417205;   // 1 Liter in Gallons

                // Convert L/100km into MpG
                convertedValue = nominator / (denominator * checkResults.Item2);

                MilesGallonBox.Text = convertedValue.ToString();
            }
        }

        private void MPGtoLKM_Click(object sender, EventArgs e)
        {
            double convertedValue, nominator, denominator;

            // First check the value input by the user
            (bool, double) checkResults = checkUserInput(MilesGallonBox.Text);
            if (!checkResults.Item1) { return; }
            else
            {
                nominator   = 3.78541182;       // 1 Gallon in Liter
                denominator = 1 / (62.13712);   // Miles in 100km

                // Convert MpG into L/100km
                convertedValue = nominator / (denominator * checkResults.Item2);

                LiterKilometerBox.Text = convertedValue.ToString();
            }

        }

        /// <summary>
        /// Check if the user input a double parsable string and returns that value
        /// </summary>
        /// <param name="_userInput"></param>
        /// <returns></returns>
        private (bool, double) checkUserInput(string _userInput)
        {
            bool goodToGo;

            // First replace the , with .
            _userInput = _userInput.Replace(',', '.');
            
            if (Double.TryParse(_userInput, NumberStyles.Any, CultureInfo.InvariantCulture, out double _userInputDouble))
            {
                goodToGo = true;
                return (goodToGo, _userInputDouble);
            }
            else
            {
                goodToGo = false;
                return (goodToGo, 0.0);
            }
        }
    }
}
