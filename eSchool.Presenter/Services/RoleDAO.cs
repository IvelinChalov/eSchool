using eSchool.Presenter.Interfaces.Services;
using eSchool.Presenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSchool.Presenter.Services
{
	class RoleDAO : IRoleDAO
	{
		public Roles GetRoleByName(string roleName)
		{
			return eSchoolDbContext.Roles.Where(x => x.Name.Equals(roleName)).FirstOrDefault();
		}

		public List<Roles> GetAllRoles()
		{
			return eSchoolDbContext.Roles.ToList();
		}

		private eSchoolDbContext eSchoolDbContext;

		public RoleDAO(eSchoolDbContext eSchoolDbContext)
		{
			if (eSchoolDbContext is null) throw new ArgumentException("eSchoolDbContext");

			this.eSchoolDbContext = eSchoolDbContext;
		}
	}
}
