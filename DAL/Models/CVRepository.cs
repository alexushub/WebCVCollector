using System;

namespace DAL.Models
{
    public class CVRepository : Repository<CV>, ICVRepository
    {
        public CVDbContext LobbyContext
        {
            get
            {
                return Context as CVDbContext;
            }
        }

        public CVRepository(CVDbContext context) : base(context)
        {
        }
    }
}
