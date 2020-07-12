using System;
using System.Collections.Generic;
using System.Globalization;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Windows.Forms;

namespace CAx_FuelConsumptionCalculator
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            // Load the Data first from the database
            Program.ReadFromDatabase();
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

        private void LoadData_Btn_Click(object sender, EventArgs e)
        {
            // Link the BindingList in DataManger to the DataGrid
            DataGrid_LogEntries.DataSource = DataManager.BindingDriveLogEntriesList;

            // Making some minor adjustments to column widths
            DataGrid_LogEntries.Columns[0].Width = 25;
            
            // Changing the name of the column headerss
            foreach (DataGridViewTextBoxColumn colHeader in DataGrid_LogEntries.Columns)
            {
                switch (colHeader.HeaderText)
                {
                    case "LKM":
                        colHeader.HeaderText = "Liter/100km";
                        break;
                    case "MPG":
                        colHeader.HeaderText = "Miles/Gallon";
                        break;
                    case "LogEntryDate":
                        colHeader.HeaderText = "Entry Date";
                        break;
                    case "DistanceDriven":
                        colHeader.HeaderText = "Driven [km]";
                        break;
                    case "FuelConsumed":
                        colHeader.HeaderText = "Fuel Usage [Liter]";
                        colHeader.Width = 90;
                        break;
                    default:
                        break;
                }
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            fillLKMBox();
            fillMPGBox();

            // Input arguments for the DriveLogEntry class
            List<double> InputArguments = new List<double>();
            // First ensure that all input values are of a valid format
            MetroTextBox[] TextBoxFields = new MetroTextBox[] { Milage_Box, DistanceDriven_Box, Consumption_Box, LiterKilometerBox, MilesGallonBox };
            foreach (var textBox in TextBoxFields)
            {
                (bool, double) userInput = checkUserInput(textBox.Text);
                if (!userInput.Item1) { return; }
                else { InputArguments.Add(userInput.Item2); }
            }

            // Add the newly created log entry into the BindingLists
            DataManager.AddLogEntryFromUI(InputArguments);
        }
        private void fillLKMBox()
        {
            double LiterPer100km;

            // First check the Consumption in Liter input by user
            (bool, double) ConsumptionLiter = checkUserInput(Consumption_Box.Text);
            // Then check the Distance Travelled in km input by user
            (bool, double) DistanceDriven = checkUserInput(DistanceDriven_Box.Text);
            // If user has input valid values, continue
            if ((ConsumptionLiter.Item1) && (DistanceDriven.Item1))
            {
                LiterPer100km = ConsumptionLiter.Item2 / (DistanceDriven.Item2 / 100);
                LiterKilometerBox.Text = LiterPer100km.ToString();
            }
            else { return; }
        }
        private void fillMPGBox()
        {
            double convertedValue, nominator, denominator;

            // First check the value input by the user
            (bool, double) checkResults = checkUserInput(LiterKilometerBox.Text);
            if (!checkResults.Item1) { return; }
            else
            {
                nominator = 62.13712;     // 100km in Miles
                denominator = 0.26417205;   // 1 Liter in Gallons

                // Convert L/100km into MpG
                convertedValue = nominator / (denominator * checkResults.Item2);

                MilesGallonBox.Text = convertedValue.ToString();
            }
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            // If user has not selectd any row, simply do nothing
            if (DataGrid_LogEntries.SelectedRows.Count == 0) { return; }

            // Else, delete the selected row (log entry)
            DriveLogEntry _logEntry = (DriveLogEntry)DataGrid_LogEntries.SelectedRows[0].DataBoundItem;
            // Simply do nothing if it's null
            if (_logEntry == null) { return; }
            else { DataManager.DeleteLogEntry(_logEntry); }
        }

        private void DataGrid_LogEntries_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Accessing the log entry that has been modified. e corresponds to the cell with the value changed
            try 
            { 
                DriveLogEntry changedLogEntry = DataManager.BindingDriveLogEntriesList[e.RowIndex];

                // Updating the Database
                Program.UpdateDatabase(changedLogEntry);
            }
            catch (ArgumentOutOfRangeException e2) { return; }
        }
    }
}
