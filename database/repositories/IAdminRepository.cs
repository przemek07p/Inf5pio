using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public interface IAdminRepository : IRepository<Admin>, IDisposable
    {
        Admin GetById(int id);
        IEnumerable<Admin> GetAll();
        void Add(Admin entity);
        void Update(Admin entity);
        void Delete(int id);
        void Save();
    }
}
