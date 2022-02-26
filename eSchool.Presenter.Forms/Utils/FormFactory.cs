using Autofac;
using System;

namespace eSchool.Presenter.Forms.Utils
{
	static class FormFactory
	{
		public static ILifetimeScope scope;

		public static T GetFormInstance<T>()
		{
			return scope is null ? throw new ArgumentException("scope") : scope.Resolve<T>();
		}
	}
}
