using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.entities;
using Microsoft.EntityFrameworkCore;

namespace database.repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private AppDbContext context;
        public CompanyRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Company GetById(int id)
        {
            return context.Companies.Find(id);
        }
        public IEnumerable<Company> GetAll()
        {
            return context.Companies.ToList();
        }
        public void Add(Company entity)
        {
            context.Companies.Add(entity);
        }
        public void Update(Company entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Company company = context.Companies.Find(id);
            context.Companies.Remove(company);
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
