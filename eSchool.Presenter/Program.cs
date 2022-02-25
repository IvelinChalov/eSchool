using Autofac;
using eSchool.Presenter.Autofac;
using System;
using System.Text;

namespace eSchool.Presenter
{
	//Бележка Трябва да се добави допълнителен NUget при разделянето на проектите
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

			//eSchoolDbContext eSchoolDbContext = new eSchoolDbContext();
			//StudentView studentView = new StudentView();

			//HomeController homeController = new HomeController(new UserDAO(eSchoolDbContext),
			//													new RoleDAO(eSchoolDbContext),
			//													new RedirectionService(studentView));
			//HomeView homeView = new HomeView(homeController);

			//homeView.HomeMenu();
			var container = ContainerConfig.Configure();

			using (var scope = container.BeginLifetimeScope())
			{
				Application application = scope.Resolve<Application>();

				application.Run();
			}


		}
	}
}
