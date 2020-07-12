using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_FuelConsumptionCalculator
{
    public static class DataManager
    {
        public static BindingList<DriveLogEntry> BindingDriveLogEntriesList = new BindingList<DriveLogEntry>();

        public static void AddLogEntryFromDataBase(DriveLogEntry _logEntry)
        {
            BindingDriveLogEntriesList.Add(_logEntry);
        }

        public static void AddLogEntryFromUI(List<double> _inputArguments)
        {
            // Create a DriveLogEntry entity and adding it to the binding list
            DriveLogEntry driveLogEntry = new DriveLogEntry(_inputArguments[0], _inputArguments[1], _inputArguments[2], _inputArguments[3], _inputArguments[4]);
            BindingDriveLogEntriesList.Add(driveLogEntry);

            // Create new entity in DB
            Program.CreateInDatabase(driveLogEntry);
        }

        public static void DeleteLogEntry(DriveLogEntry _logEntry)
        {
            // First check if the log entry is in the binding list
            if (BindingDriveLogEntriesList.Contains(_logEntry))
            {
                BindingDriveLogEntriesList.Remove(_logEntry);
            }

            // Delete the entity in DB
            Program.DeleteFromDatabase(_logEntry);
        }
    }
}
