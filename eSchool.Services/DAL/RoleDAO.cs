using eSchool.Services.Interfaces;
using eSchool.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSchool.Services.DAL
{
	public class RoleDAO : IRoleDAO
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
