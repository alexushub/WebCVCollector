using System;

namespace DAL.Models
{
    interface IUnitOfWork : IDisposable
    {
        ICVRepository CVs { get; }

        int Complete();
    }
}
