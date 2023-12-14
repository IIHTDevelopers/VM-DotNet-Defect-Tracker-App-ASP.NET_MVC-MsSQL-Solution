
using DefectTrackerApp.Models;
using System.Data.Entity;

namespace DefectTrackerApp.DAL
{
    public class DefectTrackerDbContext : DbContext
    {
        public DefectTrackerDbContext()
            : base("name=DefaultConnectionString")
        {
        }
        public DbSet<Defect> Defects { get; set; }
    }
}