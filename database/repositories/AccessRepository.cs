using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database.repositories
{
    public class AccessRepository : IAccessRepository
    {
        private AppDbContext context;
        public AccessRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Access GetById(int id)
        {
            return context.Accesses.Find(id);
        }
        public IEnumerable<Access> GetAll()
        {
            return context.Accesses.ToList();
        }
        public void Add(Access entity)
        {
            context.Accesses.Add(entity);
        }
        public void Update(Access entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Access access = context.Accesses.Find(id);
            context.Accesses.Remove(access);
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
