using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public interface IAccessRepository : IRepository<Access>, IDisposable
    {
        Access GetById(int id);
        IEnumerable<Access> GetAll();
        void Add(Access entity);
        void Update(Access entity);
        void Delete(int id);
        void Save();
    }
}
