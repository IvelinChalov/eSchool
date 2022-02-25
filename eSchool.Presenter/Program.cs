using eSchool.Presenter.Presenter;
using System;
using System.Text;

namespace eSchool.Presenter
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Console.InputEncoding = Encoding.Unicode;

			HomeView homeView = new HomeView();

			homeView.HomeMenu();
		}
	}
}
