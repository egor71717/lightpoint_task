using System.Collections.Generic;
using Lightpoint.Task.DAL.Entities;
using Lightpoint.Task.DAL.Entity_Framework;
using System;
using System.Data.Entity;
using Lightpoint.Task.DAL.Interface;

namespace Lightpoint.Task.DAL.Repository
{
    public class EFShopRepository : IRepository<Shop>
    {
        private ApplicationDbContext context;

        public EFShopRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        void IRepository<Shop>.Create(Shop item)
        {
            context.Shops.Add(item);
        }

        void IRepository<Shop>.Delete(Int32 id)
        {
            Shop product = context.Shops.Find(id);
            if (product != null)
                context.Shops.Remove(product);
        }

        Shop IRepository<Shop>.Get(Int32 id)
        {
            return context.Shops.Find(id);
        }

        IEnumerable<Shop> IRepository<Shop>.GetAll()
        {
            return context.Shops;
        }

        void IRepository<Shop>.Update(Shop item)
        {
            context.Entry(item).State = EntityState.Modified;
        }
    }

}
