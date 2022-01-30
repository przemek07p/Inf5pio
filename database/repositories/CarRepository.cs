using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database.repositories
{
    public class CarRepository : ICarRepository
    {
        private AppDbContext context;
        public CarRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Car GetById(int id)
        {
            return context.Cars.Find(id);
        }
        public IEnumerable<Car> GetAll()
        {
            return context.Cars.ToList();
        }
        public void Add(Car entity)
        {
            context.Cars.Add(entity);
        }
        public void Update(Car entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Car car = context.Cars.Find(id);
            context.Cars.Remove(car);
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
