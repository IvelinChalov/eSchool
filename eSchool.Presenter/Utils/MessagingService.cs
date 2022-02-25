using System;

namespace eSchool.Presenter.Utils
{
	static class MessagingService
	{
		public static void ShowWarningMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine($"{message} Валидация");
			Console.ForegroundColor = ConsoleColor.White;
		}

		public static void ShowErrorMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"{message} Грешка");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
