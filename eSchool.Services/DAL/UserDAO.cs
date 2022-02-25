using eSchool.Services.Interfaces;
using eSchool.Services.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace eSchool.Services.DAL
{
	public class UserDAO : IUserDAO
	{
		public Users GetExtendedUserData(string username, string password)
		{
			return eSchoolDbContext.Users
								  .Include(u => u.Roles)
								  .Where(u => u.Username.Equals(username) && u.Password.Equals(password))
								  .FirstOrDefault();
		}

		public Users GetExtendedUserData(string username)
		{
			return eSchoolDbContext.Users
								  .Include(u => u.Roles)
								  .Where(u => u.Username.Equals(username))
								  .FirstOrDefault();
		}

		public void AddUser(Users user)
		{
			eSchoolDbContext.Users.Add(user);
			eSchoolDbContext.SaveChanges();
		}

		private eSchoolDbContext eSchoolDbContext;

		public UserDAO(eSchoolDbContext eSchoolDbContext)
		{
			if (eSchoolDbContext is null) throw new ArgumentException("eSchoolDbContext");

			this.eSchoolDbContext = eSchoolDbContext;
		}
	}
}
