using System;

namespace DAL.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private CVDbContext _context;

        public UnitOfWork(/*CVDbContext context*/)
        {
            _context = CVDbContext.Create();// context;
            CVs = new CVRepository(_context);
        }


        public ICVRepository CVs { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
