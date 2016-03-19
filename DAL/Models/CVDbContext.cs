using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CVDbContext : DbContext
    {
        public DbSet<CV> CVs { get; set; }

        public CVDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer<CVDbContext>(new CVDbInitializer());
        }

        public static CVDbContext Create()
        {
            return new CVDbContext();
        }
    }
}
