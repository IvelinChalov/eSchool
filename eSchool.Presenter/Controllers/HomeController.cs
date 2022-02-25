using eSchool.Presenter.Interfaces.Services;
using eSchool.Presenter.Models;
using eSchool.Presenter.Presenter;
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
			Redirect(user);
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

		public HomeController(IUserDAO userDAO, IRoleDAO roleDAO)
		{
			if (userDAO is null) throw new ArgumentException("userDAO");
			if (roleDAO is null) throw new ArgumentException("roleDAO");

			this.userDAO = userDAO;
			this.roleDAO = roleDAO;
		}

		private string HashPassword(string password)
		{
			var provider = new SHA1CryptoServiceProvider();
			var encoding = new UnicodeEncoding();
			return Convert.ToBase64String(provider.ComputeHash(encoding.GetBytes(password)));
		}

		private void Redirect(Users user)
		{
			switch (user.Roles.Name)
			{
				case "Преподавател":
					{
						//TODO Add controller
					}
					break;
				case "Ученик":
					{
						StudentView studentView = new StudentView(user);
						studentView.StudentMenu();
					}
					break;
				case "Администратор":
					{
						//TODO Add controller
					}
					break;
				default:
					break;
			}
		}
	}
}
