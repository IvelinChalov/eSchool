using eSchool.Presenter.Presenter;
using System;

namespace eSchool.Presenter
{
	public class Application
	{

		public void Run()
		{
			homeView.HomeMenu();
		}

		private HomeView homeView;
		public Application(HomeView homeView)
		{
			if (homeView is null) throw new ArgumentException("homeView");

			this.homeView = homeView;
		}
	}
}
