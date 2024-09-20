using First_Web_Api_Project.Models;

using Microsoft.EntityFrameworkCore;

namespace First_Web_Api_Project.Data
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Medicine> Medicines { get; set; }
    }
}
