namespace Infrastructure.eFactory
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DomainDbContext dbContext;

        public DomainDbContext Init()
        {
            return dbContext ?? (dbContext = new DomainDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}