namespace eSchool.Interfaces.Utils
{
	/// <summary>
	/// Exposes functionalitites for redirecting current user
	/// </summary>
	public interface IRedirectionService
	{
		/// <summary>
		/// Navigates to diffrent menues based on user Role/>
		/// </summary>
		/// <param name="roleName">The role of the current user</param>
		void Redirect(string roleName);
	}
}
