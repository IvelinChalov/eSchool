using eSchool.Controller.Utils;
using eSchool.Interfaces.Views;
using eSchool.Presenter.Forms.Utils;
using System;
using System.Windows.Forms;

namespace eSchool.Presenter.Forms.Presenter
{
	public partial class StudentView : Form, IStudentView
	{
		public StudentView()
		{
			InitializeComponent();
		}

		public void ShowStudentMenu()
		{
			this.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.button1.Text = "test";
		}

		private void StudentView_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormFactory.GetFormInstance<HomeView>().Close();
		}

		private void StudentView_Load(object sender, EventArgs e)
		{
			helloLabel.Text = $"Добре дошли {Session.CurrentUser.Username}";
		}
	}
}
