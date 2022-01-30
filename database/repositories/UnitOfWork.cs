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
        private IRepository<User> userRepository;

    }
}
