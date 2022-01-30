using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;

namespace database.repositories
{
    public interface ICarRepository : IRepository<Car>, IDisposable
    {
        Car GetById(int id);
        IEnumerable<Car> GetAll();
        void Add(Car entity);
        void Update(Car entity);
        void Delete(int id);
        void Save();
    }
}
