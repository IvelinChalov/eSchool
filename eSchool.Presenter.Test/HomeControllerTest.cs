using eSchool.Presenter.Controllers;
using eSchool.Presenter.Interfaces.Utils;
using eSchool.Services.Interfaces;
using eSchool.Services.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Security.Cryptography;
using System.Text;

namespace eSchool.Presenter.Test
{
	public class HomeControllerTest
	{

		[Test]
		public void LogIn_UserEntersWrongeCredentials()
		{
			//Arrange
			Mock<IUserDAO> userDAOMock = new Mock<IUserDAO>();
			userDAOMock.Setup(x => x.GetExtendedUserData(It.IsAny<string>(), It.IsAny<string>())).Returns(() => null);

			Mock<IRedirectionService> redirectionServiceMock = new Mock<IRedirectionService>();
			redirectionServiceMock.Setup(x => x.Redirect(It.IsAny<string>()));

			Mock<IRoleDAO> roleDAOMock = new Mock<IRoleDAO>();
			string username = "test";
			string password = "test";

			HomeController homeController = new HomeController(
											userDAOMock.Object,
											roleDAOMock.Object,
											redirectionServiceMock.Object);
			//Act/Assert
			var exception = Assert.Throws<ArgumentException>(() => homeController.LogIn(username, password));

			Assert.AreEqual("Грешно потребителско име или парола!", exception.Message);
		}

		[Test]
		public void LogIn_PasswordHashing_Correct()
		{
			//Arrange
			Mock<IRedirectionService> redirectionServiceMock = new Mock<IRedirectionService>();
			redirectionServiceMock.Setup(x => x.Redirect(It.IsAny<string>()));

			Mock<IRoleDAO> roleDAOMock = new Mock<IRoleDAO>();
			string username = "test";
			string password = "test";

			var provider = new SHA1CryptoServiceProvider();
			var encoding = new UnicodeEncoding();
			string hashPassword = Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));

			Mock<IUserDAO> userDAOMock = new Mock<IUserDAO>();
			userDAOMock.Setup(x => x.GetExtendedUserData(It.IsAny<string>(), It.IsAny<string>()))
					   .Returns(new Users() { Roles = new Roles() });

			HomeController homeController = new HomeController(
											userDAOMock.Object,
											roleDAOMock.Object,
											redirectionServiceMock.Object);
			//Act/Assert
			homeController.LogIn(username, password);

			//Assert
			userDAOMock.Verify(x => x.GetExtendedUserData(It.IsAny<string>(), It.Is<string>(x => x.Equals(hashPassword))));
		}
	}
}