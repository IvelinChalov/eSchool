using Autofac;
using eSchool.Presenter.Forms.Autofac;
using eSchool.Presenter.Forms.Presenter;
using eSchool.Presenter.Forms.Utils;
using System;
using System.Windows.Forms;

namespace eSchool.Presenter.Forms
{
	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var container = ContainerConfig.Configure();
			using (var scope = container.BeginLifetimeScope())
			{
				Application.SetHighDpiMode(HighDpiMode.SystemAware);
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);

				var homeView = scope.Resolve<HomeView>();
				FormFactory.scope = scope;
				Application.Run(homeView);
			}
		}
	}
}
