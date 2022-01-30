using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database.repositories
{
    public class ManagerRepository : IManagerRepository
    {
        private AppDbContext context;
        public ManagerRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Manager GetById(int id)
        {
            return context.Managers.Find(id);
        }
        public IEnumerable<Manager> GetAll()
        {
            return context.Managers.ToList();
        }
        public void Add(Manager entity)
        {
            context.Managers.Add(entity);
        }
        public void Update(Manager entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Manager manager = context.Managers.Find(id);
            context.Managers.Remove(manager);
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
