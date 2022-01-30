using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public interface IManagerRepository : IRepository<Manager>, IDisposable
    {
        Manager GetById(int id);
        IEnumerable<Manager> GetAll();
        void Add(Manager entity);
        void Update(Manager entity);
        void Delete(int id);
        void Save();
    }
}
