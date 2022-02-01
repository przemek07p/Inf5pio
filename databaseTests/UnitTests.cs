using database.entities;
using database.repositories;
using database.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace databaseTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void CarServiceGivenIdReturnsRegistrationNumber()
        {
            //Arrange
            var VehicleId = 1;
            var expected = "WW54855";
            var car = new Car() { RegistrationNumber = expected, VehicleId = VehicleId };

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(VehicleId)).Returns(car).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.CarRepository).Returns(carRepositoryMock.Object);

            ICarService sut = new CarService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetVehicleId(VehicleId);

            //Assert
            carRepositoryMock.Verify();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CarServiceGivenIdReturnsException()
        {
            //Arrange
            var VehicleId = 1;
            var expected = "WW54855";
            var car = new Car() { RegistrationNumber = "PO72512", VehicleId = 7 };

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(VehicleId)).Returns(car).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.CarRepository).Returns(carRepositoryMock.Object);

            ICarService sut = new CarService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetVehicleId(VehicleId);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void CarServiceGivenIdReturnsColor()
        {
            //Arrange
            var VehicleId = 1;
            var expected = "Yellow";
            var car = new Car() { RegistrationNumber = expected, VehicleId = VehicleId };

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(VehicleId)).Returns(car).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.CarRepository).Returns(carRepositoryMock.Object);

            ICarService sut = new CarService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetVehicleId(VehicleId);

            //Assert
            carRepositoryMock.Verify();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CarServiceGivenIdReturnsModel()
        {
            //Arrange
            var VehicleId = 1;
            var expected = "Octavia";
            var car = new Car() { RegistrationNumber = expected, VehicleId = VehicleId };

            var carRepositoryMock = new Mock<IRepository<Car>>();
            carRepositoryMock.Setup(m => m.GetById(VehicleId)).Returns(car).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.CarRepository).Returns(carRepositoryMock.Object);

            ICarService sut = new CarService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetVehicleId(VehicleId);

            //Assert
            carRepositoryMock.Verify();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
