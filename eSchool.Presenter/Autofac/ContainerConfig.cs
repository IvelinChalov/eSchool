using Autofac;
using eSchool.Controller;
using eSchool.Controller.Utils;
using eSchool.Interfaces.Utils;
using eSchool.Interfaces.Views;
using eSchool.Presenter.Presenter;
using eSchool.Services;
using eSchool.Services.DAL;
using eSchool.Services.Interfaces;

namespace eSchool.Presenter.Autofac
{
	/// <summary>
	/// Helper class for configuring Autofac dependancy injection container
	/// </summary>
	public static class ContainerConfig
	{
		/// <summary>
		/// Configures autofac
		/// </summary>
		/// <returns>The container used for the entire lifespan of the application</returns>
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
