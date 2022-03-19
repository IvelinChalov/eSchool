using eSchool.Controller;
using eSchool.Presenter.Utils;
using eSchool.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSchool.Presenter.Presenter
{
	/// <summary>
	/// Allows visualization of basic menus
	/// </summary>
	/// <remarks>
	/// These are the menus for non registered users
	/// </remarks>
	public class HomeView
	{
		/// <summary>
		/// Menue for entry point of the application
		/// </summary>
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

		/// <summary>
		/// Menu for registering new users
		/// </summary>
		/// <exception cref="System.ArgumentException">Throws when user enters unvalid values</exception>
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

		/// <summary>
		/// Constructor for dependancy injection
		/// </summary>
		/// <param name="homeController">The controller associated with this view</param>
		public HomeView(HomeController homeController)
		{
			if (homeController is null) new ArgumentException("homeController");

			this.homeController = homeController;
		}

		/// <summary>
		/// Menu for logging users
		/// </summary>
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

		/// <summary>
		/// Creates dictionary of <see cref="Roles">Roles</see>
		/// </summary>
		/// <param name="roles">All the roles from the database</param>
		/// <returns>Dictionary with all the roles</returns>
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
