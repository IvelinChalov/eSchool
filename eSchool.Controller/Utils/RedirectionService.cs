using eSchool.Interfaces.Utils;
using eSchool.Interfaces.Views;
using System;

namespace eSchool.Controller.Utils
{
	public class RedirectionService : IRedirectionService
	{
		public void Redirect(string roleName)
		{
			switch (roleName)
			{
				case "Преподавател":
					{
						//TODO Add controller
					}
					break;
				case "Ученик":
					{
						studentView.ShowStudentMenu();
					}
					break;
				case "Администратор":
					{
						//TODO Add controller
					}
					break;
				default:
					break;
			}
		}

		IStudentView studentView;

		public RedirectionService(IStudentView studentView)
		{
			if (studentView is null) throw new ArgumentException("studentView");

			this.studentView = studentView;
		}
	}
}
