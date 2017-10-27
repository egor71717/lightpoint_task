using System.Collections.Generic;
using Lightpoint.Task.DAL.Entities;
using Lightpoint.Task.DAL.Entity_Framework;
using System.Data.Entity;
using System;
using Lightpoint.Task.DAL.Interface;
using System.Linq;

namespace Lightpoint.Task.DAL.Repository
{

    public class EFProductRepository : IRepository<Product>
    {
        private ApplicationDbContext context;

        public EFProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        void IRepository<Product>.Create(Product item)
        {
            context.Products.Add(item);
        }

        void IRepository<Product>.Delete(Int32 id)
        {
            Product product = context.Products.Find(id);
            if (product != null)
                context.Products.Remove(product);
        }

        Product IRepository<Product>.Get(Int32 id)
        {
            return context.Products.Find(id);
        }

        IEnumerable<Product> IRepository<Product>.GetAll()
        {
            return context.Products;
        }

        void IRepository<Product>.Update(Product item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
