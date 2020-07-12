using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAx_FuelConsumptionCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void CreateInDatabase(DriveLogEntry _logEntry)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                _context.DriveLogs.Add(_logEntry);
                _context.SaveChanges();
            }
        }

        public static void ReadFromDatabase()
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                List<DriveLogEntry> _driveLogEntries = _context.DriveLogs.ToList();
                foreach (DriveLogEntry _logEntry in _driveLogEntries)
                {
                    DataManager.AddLogEntryFromDataBase(_logEntry);
                }
            }
        }

        public static void UpdateDatabase(DriveLogEntry _logEntry)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                DriveLogEntry _entityLogEntry = findEntityInDatabase(_logEntry.ID);
                if (_entityLogEntry != null)
                {
                    _entityLogEntry.Milage = _logEntry.Milage;
                    _entityLogEntry.DistanceDriven = _logEntry.DistanceDriven;
                    _entityLogEntry.FuelConsumed = _logEntry.FuelConsumed;
                    _entityLogEntry.LKM = _logEntry.LKM;
                    _entityLogEntry.MPG = _logEntry.MPG;

                    // Mark as "modified"
                    _context.Entry(_entityLogEntry).State = System.Data.Entity.EntityState.Modified;
                    _context.SaveChanges();
                }
            }
        }

        public static void DeleteFromDatabase(DriveLogEntry _logEntry)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                DriveLogEntry _entityLogEntry = findEntityInDatabase(_logEntry.ID);
                if (_entityLogEntry != null)
                {
                    _context.Entry(_entityLogEntry).State = System.Data.Entity.EntityState.Deleted;
                    _context.DriveLogs.Remove(_entityLogEntry);
                }
                else
                { MessageBox.Show($"Cannot delete the log entry with the ID '{_logEntry.ID}'!"); }

                _context.SaveChanges();
            }
        }

        private static DriveLogEntry findEntityInDatabase(int _id)
        {
            using (DatabaseContext _context = new DatabaseContext())
            {
                DriveLogEntry _entity = _context.DriveLogs.Find(_id);
                if (_entity == null)
                    MessageBox.Show($"Cannot find log entry with the ID '{_id}'!");

                return _entity;
            }
        }
    }
}
