using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database.repositories
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext context;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public User GetById(int id)
        {
            return context.Users.Find(id);
        }
        public IEnumerable<User> GetAll()
        {
            return context.Users.ToList();
        }
        public void Add(User entity)
        {
            context.Users.Add(entity);
        }
        public void Update(User entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            User user = context.Users.Find(id);
            context.Users.Remove(user);
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
