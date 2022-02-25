using eSchool.Presenter.Models;

namespace eSchool.Presenter.Interfaces.Services
{
	public interface IUserDAO
	{
		Users GetExtendedUserData(string username, string password);
		Users GetExtendedUserData(string username);
		void AddUser(Users user);
	}
}
