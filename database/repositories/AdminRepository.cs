using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database.repositories
{
    public class AdminRepository : IAdminRepository
    {
        private AppDbContext context;
        public AdminRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Admin GetById(int id)
        {
            return context.Admins.Find(id);
        }
        public IEnumerable<Admin> GetAll()
        {
            return context.Admins.ToList();
        }
        public void Add(Admin entity)
        {
            context.Admins.Add(entity);
        }
        public void Update(Admin entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Admin admin = context.Admins.Find(id);
            context.Admins.Remove(admin);
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
