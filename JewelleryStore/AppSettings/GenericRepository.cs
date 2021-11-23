using JewelleryStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JewelleryStore.AppSettings
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntityModel
    {
        protected readonly AppDbContext dbContext;
        private DbSet<T> table;
        public GenericRepository(AppDbContext _appDbContext)
        {
            this.dbContext = _appDbContext;
            this.table = this.dbContext.Set<T>();
        }
        public int delete(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> getAll()
        {
            return this.table.Where(item => item.Active).ToList();
        }

        public T getById(int Id)
        {
            return this.table.SingleOrDefault(s => s.Active);
        }

        public int insert()
        {
            throw new NotImplementedException();
        }

        public int update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
