using eSchool.Presenter.Controllers;
using System;
using System.Collections.Generic;

namespace eSchool.Presenter.Presenter
{
	class HomeView
	{
		public void HomeMenu()
		{

			while (true)
			{
				Console.WriteLine(new string('-', 40));
				Console.WriteLine(new string(' ', 10) + "WELCOME TO eSchool" + new string(' ', 18));
				Console.WriteLine(new string('-', 40));
				Console.WriteLine("1. Login");
				Console.WriteLine("2. Register");
				Console.WriteLine("3. Exit");

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
							Console.ForegroundColor = ConsoleColor.Yellow;
							Console.WriteLine("Моля въведете валидна команда! Валидация");
							Console.ForegroundColor = ConsoleColor.White;
							break;
					}
				}
				else
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("Моля въведете число! Валидация");
					Console.ForegroundColor = ConsoleColor.White;
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

					Console.WriteLine("Изберете роля на потребителя: ");
					Console.WriteLine("1. Ученик");
					Console.WriteLine("2. Преподавател");
					Console.WriteLine("3. Администратор");
					string role = Console.ReadLine();

					Dictionary<string, string> roles = new Dictionary<string, string>()
					{
						{ "1", "Ученик" },
						{ "2", "Преподавател" },
						{ "3", "Администратор" }
					};

					if (!password.Equals(repeatedPassword))
					{
						throw new ArgumentException("Паролите не съвпадат. Валидация");
					}
					else if (roles.ContainsKey(role))
					{
						HomeController homeController = new HomeController();
						homeController.Register(username, password, roles[role]);
						Console.WriteLine("Потребителя е създаден.");
						return;
					}
					else
					{
						throw new ArgumentException("Моля изберете роля от списъка. Валидация");
					}

				}
				catch (ArgumentException e)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine(e.Message);
					Console.ForegroundColor = ConsoleColor.White;

					Console.Write("Желаете ли да опитате отново?(Д/Н): ");
					command = Console.ReadLine();
				}

			}
		}

		private void LoginUser()
		{
			string command = "Д";
			while (command.ToUpper().Equals("Д"))
			{
				try
				{
					Console.Write("Username: ");
					string username = Console.ReadLine();
					Console.Write("Password: ");
					string password = Console.ReadLine();

					HomeController homeController = new HomeController();
					homeController.LogIn(username, password);
					break;
				}
				catch (ArgumentException e)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine(e.Message);
					Console.ForegroundColor = ConsoleColor.White;

					Console.Write("Желаете ли да опитате отново?(Д/Н): ");
					command = Console.ReadLine();
				}

			}

		}

	}
}
