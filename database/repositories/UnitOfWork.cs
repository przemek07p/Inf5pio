using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private AppDbContext _context;
        public IRepository<Access> AccessRepository { get; set; }
        public IRepository<Admin> AdminRepository { get; set; }
        public IRepository<Car> CarRepository { get; set; }
        public IRepository<Company> CompanyRepository { get; set; }
        public IRepository<Manager> ManagerRepository { get; set; }
        public IRepository<User> UserRepository { get; set; }

        public UnitOfWork(AppDbContext context)
        {
            AccessRepository = new AccessRepository(_context);
            AdminRepository = new AdminRepository(_context);
            CarRepository = new CarRepository(_context);
            CompanyRepository = new CompanyRepository(_context);
            ManagerRepository = new ManagerRepository(_context);
            UserRepository = new UserRepository(_context);

        }
        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
