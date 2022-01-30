using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public interface ICompanyRepository : IRepository<Company>, IDisposable
    {
        Company GetById(int id);
        IEnumerable<Company> GetAll();
        void Add(Company entity);
        void Update(Company entity);
        void Delete(int id);
        void Save();
    }
}
