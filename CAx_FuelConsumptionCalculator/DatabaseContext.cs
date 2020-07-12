using System.Data.Entity;

namespace CAx_FuelConsumptionCalculator
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=FuelConsumption_Database") { }
        
        public virtual DbSet<DriveLogEntry> DriveLogs { get; set; }
    }
}
