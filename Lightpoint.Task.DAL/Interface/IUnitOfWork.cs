using Lightpoint.Task.DAL.Entities;
using System;

namespace Lightpoint.Task.DAL.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Shop> GetShopRepository();
        IRepository<Product> GetProductRepository();
        void Save();
    }
}
