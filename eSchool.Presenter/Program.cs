using eSchool.Presenter.Controllers;
using eSchool.Presenter.Presenter;
using eSchool.Presenter.Services;
using eSchool.Presenter.Utils;
using System;
using System.Text;

namespace eSchool.Presenter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

			eSchoolDbContext eSchoolDbContext = new eSchoolDbContext();
			StudentView studentView = new StudentView();

			HomeController homeController = new HomeController(new UserDAO(eSchoolDbContext),
																new RoleDAO(eSchoolDbContext),
																new RedirectionService(studentView));
			HomeView homeView = new HomeView(homeController);

			homeView.HomeMenu();
		}
	}
}
