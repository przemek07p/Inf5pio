using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public interface IUnitOfWork
    {
        IRepository<Access> AccessRepository { get; set; }
        IRepository<Admin> AdminRepository { get; set; }
        IRepository<Car> CarRepository { get; set; }
        IRepository<Company> CompanyRepository { get; set; }
        IRepository<Manager> ManagerRepository { get; set; }
        IRepository<User> UserRepository { get; set; }
        void Dispose();
        void Save();
    }
}
