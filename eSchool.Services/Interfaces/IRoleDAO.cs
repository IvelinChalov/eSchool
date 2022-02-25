using eSchool.Services.Models;
using System.Collections.Generic;

namespace eSchool.Services.Interfaces
{
	public interface IRoleDAO
	{
		Roles GetRoleByName(string roleName);
		List<Roles> GetAllRoles();
	}
}
