using System;

namespace Infrastructure.eFactory
{
    public interface IDbFactory : IDisposable
    {
        DomainDbContext Init();
    }
}