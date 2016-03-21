using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Models
{
    public class CVRepository : Repository<CV>, ICVRepository
    {
        public CVDbContext CVContext
        {
            get
            {
                return Context as CVDbContext;
            }
        }

        public CVRepository(CVDbContext context) : base(context)
        {
        }

        public void Add(CV entity)
        {
            var ent = CVContext.CVs.FirstOrDefault(m => m.ExternalId == entity.ExternalId);

            if (ent != null)
            {
                CVContext.CVs.Remove(ent);
            }

            CVContext.CVs.Add(entity);
        }

        public void AddRange(IEnumerable<CV> entities)
        {
            foreach (var entity in entities)
            {
                Add(entity);
            }
        }
    }
}
