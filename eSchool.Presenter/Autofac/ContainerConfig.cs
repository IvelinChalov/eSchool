using Autofac;
using eSchool.Presenter.Controllers;
using eSchool.Presenter.Interfaces.Services;
using eSchool.Presenter.Interfaces.Utils;
using eSchool.Presenter.Interfaces.Views;
using eSchool.Presenter.Presenter;
using eSchool.Presenter.Services;
using eSchool.Presenter.Utils;

namespace eSchool.Presenter.Autofac
{
	public static class ContainerConfig
	{
		public static IContainer Configure()
		{
			var builder = new ContainerBuilder();

			//Views
			builder.RegisterType<HomeView>();
			builder.RegisterType<StudentView>().As<IStudentView>();

			//Controllers
			builder.RegisterType<HomeController>();

			//DAOs
			builder.RegisterType<RoleDAO>().As<IRoleDAO>();
			builder.RegisterType<UserDAO>().As<IUserDAO>();

			//Utils
			builder.RegisterType<RedirectionService>().As<IRedirectionService>();
			//DbContext
			//builder.RegisterInstance<eSchoolDbContext>(new EvilInfoDBContext());
			builder.RegisterType<eSchoolDbContext>();

			//Main
			builder.RegisterType<Application>();

			return builder.Build();
		}
	}
}
