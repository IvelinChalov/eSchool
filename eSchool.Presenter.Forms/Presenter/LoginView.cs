using eSchool.Controller;
using eSchool.Presenter.Forms.Utils;
using System;
using System.Windows.Forms;

namespace eSchool.Presenter.Forms.Presenter
{
	public partial class LoginView : Form
	{
		private HomeController homeController;
		public LoginView(HomeController homeController)
		{
			if (homeController is null) new ArgumentException("homeController");
			InitializeComponent();

			this.homeController = homeController;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			try
			{
				validationMessageLabel.Hide();
				homeController.LogIn(usernameTextBox.Text, passwordTextbox.Text);
				this.Hide();
			}
			catch (ArgumentException ex)
			{
				validationMessageLabel.Text = ex.Message;
				validationMessageLabel.Show();
			}

		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			this.Close();
			FormFactory.GetFormInstance<HomeView>().Show();
		}

		private void LoginView_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormFactory.GetFormInstance<HomeView>().Close();
		}
	}
}
