using eSchool.Presenter.Interfaces.Views;
using eSchool.Presenter.Utils;
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
				Console.WriteLine(new string(' ', 10) + $"WELCOME {Session.CurrentUser.Username}" + new string(' ', 18));
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

	}
}
