using System;

namespace DAL.Models
{
    public class CV
    {
        public int Id { get; set; }

        public long ExternalId { get; set; }

        public string Name { get; set; }

        public string Link { get; set; }

        public string Position { get; set; }

        public DateTime? BirthDate { get; set; }

        public string Education { get; set; }

        public string Skills { get; set; }

        public string City { get; set; }

        public ExpAmount ExpAmount { get; set; }

        public long Salary { get; set; }

    }
}
