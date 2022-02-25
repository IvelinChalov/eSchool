using eSchool.Presenter.Models;
using System.Collections.Generic;

namespace eSchool.Presenter.Interfaces.Services
{
	public interface IRoleDAO
	{
		Roles GetRoleByName(string roleName);
		List<Roles> GetAllRoles();
	}
}
