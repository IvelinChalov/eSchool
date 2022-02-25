using eSchool.Presenter.Interfaces;
using eSchool.Presenter.Interfaces.Services;
using eSchool.Presenter.Models;
using eSchool.Presenter.Utils;
using System;
using System.Security.Cryptography;
using System.Text;

namespace eSchool.Presenter.Controllers
{
	class HomeController
	{
		public void LogIn(string username, string password)
		{
			string hashedPassword = HashPassword(password);

			Users user = userDAO.GetExtendedUserData(username, hashedPassword);

			if (user is null) throw new ArgumentException("Грешно потребителско име или парола! Грешка");

			Session.CurrentUser = user;

			redirectionService.Redirect(user.Roles.Name);
		}

		public void Register(string username, string password, string roleName)
		{
			string hashedPassword = HashPassword(password);

			Users user = userDAO.GetExtendedUserData(username, hashedPassword);

			if (user != null) throw new ArgumentException("Потребителското име е заето! Грешка");

			Roles role = roleDAO.GetRoleByName(roleName);

			Users newUser = new Users() { Username = username, Password = hashedPassword, Roles = role };
			userDAO.AddUser(newUser);
		}

		private IUserDAO userDAO;
		private IRoleDAO roleDAO;
		private IRedirectionService redirectionService;

		public HomeController(IUserDAO userDAO, IRoleDAO roleDAO, IRedirectionService redirectionService)
		{
			if (userDAO is null) throw new ArgumentException("userDAO");
			if (roleDAO is null) throw new ArgumentException("roleDAO");
			if (redirectionService is null) throw new ArgumentException("redirectionService");

			this.userDAO = userDAO;
			this.roleDAO = roleDAO;
			this.redirectionService = redirectionService;
		}

		private string HashPassword(string password)
		{
			var provider = new SHA1CryptoServiceProvider();
			var encoding = new UnicodeEncoding();
			return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
		}

	}
}
