using eSchool.Presenter.Interfaces.Views;
using eSchool.Presenter.Models;
using System;

namespace eSchool.Presenter.Presenter
{
	class StudentView : IStudentView
	{

		public void StudentMenu()
		{

			while (true)
			{
				Console.WriteLine(new string('-', 40));
				Console.WriteLine(new string(' ', 10) + $"WELCOME {currentUser.Username}" + new string(' ', 18));
				Console.WriteLine(new string('-', 40));
				Console.WriteLine("1. Check marks");
				Console.WriteLine("2. Check curriculum");
				Console.WriteLine("3. Logout");

				int command;
				if (int.TryParse(Console.ReadLine(), out command))
				{
					switch (command)
					{
						case 1:
							//TODO add marks
							break;
						case 2:
							//RegisterUser();
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

		private Users currentUser = null;

		public StudentView(Users currentUser)
		{
			if (currentUser is null) throw new Exception("currentUser");

			this.currentUser = currentUser;
		}
	}
}
