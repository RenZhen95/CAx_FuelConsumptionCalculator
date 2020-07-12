using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CAx_FuelConsumptionCalculator
{
    public class DriveLogEntry
    {
        // Public fields
        public int ID { get; set; }
        [Display(Name = "Entry Date")]
        public string LogEntryDate { get; set; }
        public double Milage { get; set; }
        [Display(Name = "Distance Driven")]
        public double DistanceDriven { get; set; }
        [Display(Name = "Fuel Consumed")]
        public double FuelConsumed { get; set; }
        [Display(Name = "Liter per 100km")]
        public double LKM { get; set; }
        [Display(Name = "Miles per Gallon")]
        public double MPG { get; set; }

        public DriveLogEntry() { }

        public DriveLogEntry(double _milage, double _distanceDriven, double _fuelConsumed, double _LKM, double _MPG)
        {
            Milage          = Math.Round(_milage, 2);
            DistanceDriven  = Math.Round(_distanceDriven, 2);
            FuelConsumed    = Math.Round(_fuelConsumed, 2);
            LKM             = Math.Round(_LKM, 2);
            MPG             = Math.Round(_MPG, 2);

            // Adding the date entry in DDMMYYYY format
            LogEntryDate = DateTime.Now.ToShortDateString();
        }
    }
}
