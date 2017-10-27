using System;
using Lightpoint.Task.DAL.Entities;
using Lightpoint.Task.DAL.Entity_Framework;
using Lightpoint.Task.DAL.Interface;

namespace Lightpoint.Task.DAL.Repository
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext db;
        private EFProductRepository productRepository;
        private EFShopRepository shopRepository;
        private Boolean disposed = false;

        public EFUnitOfWork()
        {
            String connectionStringName = "DefaultConnection";
            this.db = new ApplicationDbContext(connectionStringName);
        }

        void IUnitOfWork.Save()
        {
            db.SaveChanges();
        }
       
        IRepository<Shop> IUnitOfWork.GetShopRepository()
        {
            if (shopRepository == null)
                shopRepository = new EFShopRepository(db);
            return shopRepository;
        }

        IRepository<Product> IUnitOfWork.GetProductRepository()
        {
            if (productRepository == null)
                productRepository = new EFProductRepository(db);
            return productRepository;
        }

        public virtual void Dispose(Boolean disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
