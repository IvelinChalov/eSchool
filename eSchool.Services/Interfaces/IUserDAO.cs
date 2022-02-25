using eSchool.Services.Models;

namespace eSchool.Services.Interfaces
{
	public interface IUserDAO
	{
		Users GetExtendedUserData(string username, string password);
		Users GetExtendedUserData(string username);
		void AddUser(Users user);
	}
}
