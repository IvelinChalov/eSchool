using eSchool.Presenter.Models;
using eSchool.Presenter.Presenter;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace eSchool.Presenter.Controllers
{
	class HomeController
	{

		private eSchoolDbContext eSchoolDbContext = new eSchoolDbContext();

		public void LogIn(string username, string password)
		{
			string hashedPassword = HashPassword(password);

			Users user = eSchoolDbContext.Users
						  .Include(u => u.Roles)
						  .Where(u => u.Username.Equals(username) && u.Password.Equals(hashedPassword))
						 .FirstOrDefault();

			if (user is null) throw new ArgumentException("Грешно потребителско име или парола! Грешка");
			Redirect(user);
		}

		public void Register(string username, string password, string roleName)
		{
			string hashedPassword = HashPassword(password);

			Users user = eSchoolDbContext.Users
						 .Where(u => u.Username.Equals(username) && u.Password.Equals(hashedPassword))
						 .FirstOrDefault();

			if (user != null) throw new ArgumentException("Потребителското име е заето! Грешка");

			Roles role = eSchoolDbContext.Roles.Where(x => x.Name.Equals(roleName)).FirstOrDefault();

			eSchoolDbContext.Users.Add(new Users() { Username = username, Password = hashedPassword, Roles = role });
			eSchoolDbContext.SaveChanges();
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
