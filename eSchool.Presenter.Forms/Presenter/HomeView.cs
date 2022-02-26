using eSchool.Presenter.Forms.Utils;
using System;
using System.Windows.Forms;

namespace eSchool.Presenter.Forms.Presenter
{
	public partial class HomeView : Form
	{
		public HomeView()
		{
			InitializeComponent();
		}


		private void loginButton_Click(object sender, EventArgs e)
		{
			FormFactory.GetFormInstance<LoginView>().Show();
			this.Hide();
		}

		private void HomeView_FormClosed(object sender, FormClosedEventArgs e)
		{

		}
	}
}
