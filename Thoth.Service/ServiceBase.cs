using System;
using Thoth.Data;
using Thoth.Repository;

namespace Thoth.Service
{
    public class ServiceBase : IDisposable
    {
        private ThothMVCDbContext context = new ThothMVCDbContext();
        private GenericRepository<Eps> epsRepository;

        public GenericRepository<Eps> EpsRepository
        {
            get
            {
                if (this.epsRepository == null)
                {
                    this.epsRepository = new GenericRepository<Eps>(context);
                }

                return epsRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}