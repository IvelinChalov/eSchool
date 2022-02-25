using eSchool.Presenter.Models;

namespace eSchool.Presenter.Interfaces.Services
{
	interface IRoleDAO
	{
		Roles GetRoleByName(string roleName);
	}
}
