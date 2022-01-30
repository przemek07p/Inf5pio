using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext context = new AppDbContext();
        private IRepository<Access> accessRepository;
        private IRepository<Admin> adminRepository;
        private IRepository<Car> carRepository;
        private IRepository<Company> companyRepository;
        private IRepository<Manager> managerRepository;
        private IRepository<User> userRepository;

        public IRepository<Access> AccessRepository
        {
            get
            {

                if (this.accessRepository == null)
                {
                    this.accessRepository = new AccessRepository(context);
                }

                return accessRepository;
            }
        }
        public IRepository<Admin> AdminRepository
        {
            get
            {

                if (this.adminRepository == null)
                {
                    this.adminRepository = new AdminRepository(context);
                }

                return adminRepository;
            }
        }
        public IRepository<Car> CarRepository
        {
            get
            {

                if (this.carRepository == null)
                {
                    this.carRepository = new CarRepository(context);
                }

                return carRepository;
            }
        }
        public IRepository<Company> CompanyRepository
        {
            get
            {

                if (this.companyRepository == null)
                {
                    this.companyRepository = new CompanyRepository(context);
                }

                return companyRepository;
            }
        }
        public IRepository<Manager> ManagerRepository
        {
            get
            {

                if (this.managerRepository == null)
                {
                    this.managerRepository = new ManagerRepository(context);
                }

                return managerRepository;
            }
        }
        public IRepository<User> UserRepository
        {
            get
            {

                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(context);
                }

                return userRepository;
            }
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
