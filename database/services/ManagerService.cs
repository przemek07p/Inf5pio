using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.repositories;

namespace database.services
{
    public class ManagerService : IManageService
    {
        readonly IUnitOfWork _unitOfWork;

        public ManagerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public string GetRoleld(int id)
        {
            var item = _unitOfWork.CarRepository.GetById(id);

            if (item != null)
            {
                return item.RegistrationNumber;
            }

            throw new ArgumentException("Błędne ID");
        }
    }
}

