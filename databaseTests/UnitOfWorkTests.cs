using database.entities;
using database.repositories;
using database.services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace databaseTests
{
    [TestClass]
    public class UnitOfWorkTests
    {
        [TestMethod]
        public void UserServiceGivenIdReturnsUserName()
        {
            //Arrange
            var userId = 1;
            var expected = "KIBOS";
            var user = new User() { Name = expected, RoleId = userId };

            var userRepositoryMock = new Mock<IRepository<User>>();
            userRepositoryMock.Setup(m => m.GetById(userId)).Returns(user).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.UserRepository).Returns(userRepositoryMock.Object);

            IUserService sut = new UserService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetUserName(userId);

            //Assert
            userRepositoryMock.Verify();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void UserServiceGivenIdReturnsException()
        {
            //Arrange
            var userId = 1;
            var expected = "KIBOS";
            var user = new User() { Name = "ADMIN", RoleId = 2 };

            var userRepositoryMock = new Mock<IRepository<User>>();
            userRepositoryMock.Setup(m => m.GetById(userId)).Returns(user).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.UserRepository).Returns(userRepositoryMock.Object);

            IUserService sut = new UserService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetUserName(userId);

            //Assert
            Assert.AreNotEqual(expected,actual);
        }

        [TestMethod]
        public void UserServiceGivenIdReturnsUserSurname()
        {
            //Arrange
            var userId = 1;
            var expected = "SKOWRON";
            var user = new User() { Name = expected, RoleId = userId };

            var userRepositoryMock = new Mock<IRepository<User>>();
            userRepositoryMock.Setup(m => m.GetById(userId)).Returns(user).Verifiable();

            var unitOfWorkMock = new Mock<IUnitOfWork>();
            unitOfWorkMock.Setup(m => m.UserRepository).Returns(userRepositoryMock.Object);

            IUserService sut = new UserService(unitOfWorkMock.Object);

            //Act
            var actual = sut.GetUserName(userId);

            //Assert
            userRepositoryMock.Verify();
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
