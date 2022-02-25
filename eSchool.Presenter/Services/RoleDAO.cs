using eSchool.Presenter.Interfaces.Services;
using eSchool.Presenter.Models;
using System;
using System.Linq;

namespace eSchool.Presenter.Services
{
	class RoleDAO : IRoleDAO
	{
		public Roles GetRoleByName(string roleName)
		{
			return eSchoolDbContext.Roles.Where(x => x.Name.Equals(roleName)).FirstOrDefault();
		}

		private eSchoolDbContext eSchoolDbContext;

		public RoleDAO(eSchoolDbContext eSchoolDbContext)
		{
			if (eSchoolDbContext is null) throw new ArgumentException("eSchoolDbContext");

			this.eSchoolDbContext = eSchoolDbContext;
		}
	}
}
