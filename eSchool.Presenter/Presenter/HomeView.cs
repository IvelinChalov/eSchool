using eSchool.Presenter.Controllers;
using eSchool.Presenter.Utils;
using eSchool.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSchool.Presenter.Presenter
{
	public class HomeView
	{
		public void HomeMenu()
		{

			while (true)
			{
				Console.WriteLine(new string('-', 40));
				Console.WriteLine(new string(' ', 10) + "Добре дошли в eSchool" + new string(' ', 18));
				Console.WriteLine(new string('-', 40));
				Console.WriteLine("1. Вход");
				Console.WriteLine("2. Регистрация");
				Console.WriteLine("3. Изход");

				int command;
				if (int.TryParse(Console.ReadLine(), out command))
				{
					switch (command)
					{
						case 1:
							Console.Clear();
							LoginUser();
							break;
						case 2:
							RegisterUser();
							break;
						case 3:
							return;
						default:
							MessagingService.ShowWarningMessage("Моля въведете валидна команда!");
							break;
					}
				}
				else
				{
					MessagingService.ShowWarningMessage("Моля въведете число!");
				}
			}



		}

		private void RegisterUser()
		{
			string command = "Д";
			while (command.ToUpper().Equals("Д"))
			{
				try
				{
					Console.Write("Потребителско име: ");
					string username = Console.ReadLine();

					Console.Write("Парола: ");
					string password = Console.ReadLine();

					Console.Write("Повторете паролата: ");
					string repeatedPassword = Console.ReadLine();

					Dictionary<string, string> allRoles = ConstructRoles(homeController.GetAllRoles());

					Console.WriteLine("Изберете роля на потребителя: ");

					foreach (var key in allRoles)
					{
						Console.WriteLine($"{key.Key} {key.Value}");
					}

					string role = Console.ReadLine();

					if (!password.Equals(repeatedPassword))
					{
						throw new ArgumentException("Паролите не съвпадат.");
					}
					else if (allRoles.ContainsKey(role))
					{
						homeController.Register(username, password, allRoles[role]);
						Console.WriteLine("Потребителя е създаден.");
						return;
					}
					else
					{
						throw new ArgumentException("Моля изберете роля от списъка.");
					}

				}
				catch (ArgumentException e)
				{
					MessagingService.ShowWarningMessage(e.Message);

					Console.Write("Желаете ли да опитате отново?(Д/Н): ");
					command = Console.ReadLine();
				}

			}
		}

		private HomeController homeController;

		public HomeView(HomeController homeController)
		{
			if (homeController is null) new ArgumentException("homeController");

			this.homeController = homeController;
		}

		private void LoginUser()
		{
			string command = "Д";
			while (command.ToUpper().Equals("Д"))
			{
				try
				{
					Console.Write("Потребителско име: ");
					string username = Console.ReadLine();
					Console.Write("Парола: ");
					string password = Console.ReadLine();

					homeController.LogIn(username, password);
					break;
				}
				catch (ArgumentException e)
				{
					MessagingService.ShowErrorMessage(e.Message);
					Console.Write("Желаете ли да опитате отново?(Д/Н): ");
					command = Console.ReadLine();
				}

			}

		}

		private Dictionary<string, string> ConstructRoles(List<Roles> roles)
		{
			Dictionary<string, string> rolesDictionary = new Dictionary<string, string>();
			int num = 1;
			foreach (var role in roles.OrderBy(r => r.Name))
			{
				rolesDictionary.Add(num.ToString(), role.Name);
				num++;
			}

			return rolesDictionary;
		}
	}
}
