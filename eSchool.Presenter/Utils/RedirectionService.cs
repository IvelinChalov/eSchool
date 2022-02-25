using eSchool.Presenter.Interfaces.Utils;
using eSchool.Presenter.Interfaces.Views;
using System;

namespace eSchool.Presenter.Utils
{
	class RedirectionService : IRedirectionService
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
						studentView.StudentMenu();
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
