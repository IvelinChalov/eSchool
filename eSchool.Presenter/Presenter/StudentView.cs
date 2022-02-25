using eSchool.Controller.Utils;
using eSchool.Interfaces.Views;
using eSchool.Presenter.Utils;
using System;

namespace eSchool.Presenter.Presenter
{
	public class StudentView : IStudentView
	{

		public void StudentMenu()
		{

			while (true)
			{
				Console.WriteLine(new string('-', 40));
				Console.WriteLine(new string(' ', 10) + $"Добре дошъл {Session.CurrentUser.Username}" + new string(' ', 18));
				Console.WriteLine(new string('-', 40));
				Console.WriteLine("1. Проверка на оценки");
				Console.WriteLine("2. Проверка на предмети");
				Console.WriteLine("3. Излизане от профила");

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
