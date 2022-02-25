using eSchool.Presenter.Models;

namespace eSchool.Presenter.Interfaces.Services
{
	interface IUserDAO
	{
		Users GetExtendedUserData(string username, string password);
		Users GetExtendedUserData(string username);
		void AddUser(Users user);
	}
}
