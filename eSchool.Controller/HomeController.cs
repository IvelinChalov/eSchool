using eSchool.Controller.Utils;
using eSchool.Interfaces.Utils;
using eSchool.Services.Interfaces;
using eSchool.Services.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace eSchool.Controller
{
	public class HomeController
	{
		public void LogIn(string username, string password)
		{
			string hashedPassword = HashPassword(password);

			Users user = userDAO.GetExtendedUserData(username, hashedPassword);

			if (user is null) throw new ArgumentException("Грешно потребителско име или парола!");

			Session.CurrentUser = user;

			redirectionService.Redirect(user.Roles.Name);
		}

		public void Register(string username, string password, string roleName)
		{
			string hashedPassword = HashPassword(password);

			Users user = userDAO.GetExtendedUserData(username, hashedPassword);

			if (user != null) throw new ArgumentException("Потребителското име е заето! ");

			Roles role = roleDAO.GetRoleByName(roleName);

			Users newUser = new Users() { Username = username, Password = hashedPassword, Roles = role };
			userDAO.AddUser(newUser);
		}

		public List<Roles> GetAllRoles()
		{
			List<Roles> roles = roleDAO.GetAllRoles();
			if (roles is null || roles.Count == 0) throw new Exception("No roles found.");

			return roles;
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
