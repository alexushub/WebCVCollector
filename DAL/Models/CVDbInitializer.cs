using System;
using System.Data.Entity;

namespace DAL.Models
{
    public class CVDbInitializer : DropCreateDatabaseIfModelChanges<CVDbContext>
    {
        protected override void Seed(CVDbContext context)
        {
            base.Seed(context);
        }
    }
}