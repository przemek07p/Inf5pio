using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.repositories;

namespace database.services
{
    public class UserService : IUserService
    {
        readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string GetUserName(int id)
        {
            var item = _unitOfWork.UserRepository.GetById(id);

            if (item != null)
            {
                return item.Name;
            }

            throw new ArgumentException("Zły ID");
        }
    }
}
