
namespace eSchool.Presenter.Forms.Presenter
{
	partial class HomeView
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.loginButton = new System.Windows.Forms.Button();
			this.registerButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.welcomeMessage = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// loginButton
			// 
			this.loginButton.Location = new System.Drawing.Point(131, 114);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(87, 23);
			this.loginButton.TabIndex = 0;
			this.loginButton.Text = "Влез";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// registerButton
			// 
			this.registerButton.Location = new System.Drawing.Point(131, 143);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(87, 23);
			this.registerButton.TabIndex = 1;
			this.registerButton.Text = "Регистрация";
			this.registerButton.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(131, 172);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(87, 23);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Изход";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// welcomeMessage
			// 
			this.welcomeMessage.AutoSize = true;
			this.welcomeMessage.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.welcomeMessage.Location = new System.Drawing.Point(32, 30);
			this.welcomeMessage.Name = "welcomeMessage";
			this.welcomeMessage.Size = new System.Drawing.Size(310, 37);
			this.welcomeMessage.TabIndex = 3;
			this.welcomeMessage.Text = "Добре дошли в eSchool";
			// 
			// HomeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 226);
			this.Controls.Add(this.welcomeMessage);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.registerButton);
			this.Controls.Add(this.loginButton);
			this.Name = "HomeView";
			this.Text = "Home";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HomeView_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label welcomeMessage;
	}
}

