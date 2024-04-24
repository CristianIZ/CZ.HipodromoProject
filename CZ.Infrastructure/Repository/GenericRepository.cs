using CZ.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CZ.Infrastructure.Repository
{
    public abstract class GenericRepository<TEntity> where TEntity : class
    {
        public DbContext Context { get; }
        public EFCZContext DbContext => Context as EFCZContext;

        public GenericRepository(DbContext context)
        {
            this.Context = context;
        }

        public TEntity Add(TEntity entity)
        {
            // var result = Context.Set<TEntity>().Add(entity).Entity;
            var result = DbContext.Add(entity).Entity;
            return result;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
