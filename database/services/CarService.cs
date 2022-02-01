using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using database.repositories;

namespace database.services
{
    public class CarService : ICarService
    {
        readonly IUnitOfWork _unitOfWork;

        public CarService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public string GetVehicleId(int id)
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

