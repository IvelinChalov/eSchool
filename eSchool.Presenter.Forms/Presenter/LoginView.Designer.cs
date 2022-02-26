
namespace eSchool.Presenter.Forms.Presenter
{
	partial class LoginView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.exitButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.passwordTextbox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.validationMessageLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(125, 130);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 0;
			this.exitButton.Text = "Изход";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(231, 130);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 1;
			this.loginButton.Text = "Влез";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.Location = new System.Drawing.Point(206, 82);
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.PasswordChar = '*';
			this.passwordTextbox.Size = new System.Drawing.Size(100, 23);
			this.passwordTextbox.TabIndex = 2;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Location = new System.Drawing.Point(206, 53);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(100, 23);
			this.usernameTextBox.TabIndex = 3;
			// 
			// usernameLabel
			// 
			this.usernameLabel.AutoSize = true;
			this.usernameLabel.Location = new System.Drawing.Point(80, 56);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(120, 15);
			this.usernameLabel.TabIndex = 4;
			this.usernameLabel.Text = "Потребителско име:";
			// 
			// passwordLabel
			// 
			this.passwordLabel.AutoSize = true;
			this.passwordLabel.Location = new System.Drawing.Point(148, 90);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(52, 15);
			this.passwordLabel.TabIndex = 5;
			this.passwordLabel.Text = "Парола:";
			// 
			// validationMessageLabel
			// 
			this.validationMessageLabel.AutoSize = true;
			this.validationMessageLabel.ForeColor = System.Drawing.Color.Red;
			this.validationMessageLabel.Location = new System.Drawing.Point(80, 22);
			this.validationMessageLabel.Name = "validationMessageLabel";
			this.validationMessageLabel.Size = new System.Drawing.Size(0, 15);
			this.validationMessageLabel.TabIndex = 6;
			// 
			// LoginView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(360, 205);
			this.Controls.Add(this.validationMessageLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.passwordTextbox);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.exitButton);
			this.Name = "LoginView";
			this.Text = "Влизане в системата";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginView_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.TextBox passwordTextbox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Label validationMessageLabel;
	}
}