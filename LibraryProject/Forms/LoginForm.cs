using LibraryProject.Database;
using LibraryProject.DataClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryProject.Forms
{
    public partial class LoginForm : Form
    {
        bool exitProgram = true;
        bool modeIsLogin = true;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)//not complete
        {
            var userName = userNameTextBox.Text;
            var password = passwordTextBox.Text;

            bool textBoxesAreNotEmpty =
                !(string.IsNullOrEmpty(userName) ||
                string.IsNullOrEmpty(password));

            if (textBoxesAreNotEmpty)
            {
                if (modeIsLogin)
                {
                    Login(userName, password);
                }
                else
                {
                    Register(userName, password);
                }
            }
            else
            {
                LibMessageBox.Show("Error", "Textboxes are empty!");
            }
        }

        private void switchModeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SwitchMode();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (exitProgram)
                Application.Exit();
            else
            {
                foreach (Control control in Controls)
                {
                    if (control is PictureBox p)
                        p.Image.Dispose();
                    control.Dispose();
                }
                this.Dispose();
            }
        }

        private void Login(string userName, string password)
        {
            using (LibDb db = new())
            {
                var user = db.Users
                    .Where(u => u.UserName.ToLower() == userName.ToLower() && u.Password == password)
                    .Include(u => u.Books)
                    .FirstOrDefault();

                if (user is not null)
                {
                    //login successfull
                    exitProgram = false;
                    Form formToShow = user.IsAdmin ? new AdministratorForm(user) : new UserForm(user);
                    formToShow.Show();
                    this.Close();
                }
                else
                {
                    LibMessageBox.Show("Couldn't sign you in!",
                        "Your username or password is incorrect!");
                }
            }
        }
        private void Register(string userName, string password)
        {
            using (LibDb db = new())
            {
                var queryUser = db.Users.Where(u => u.UserName.ToLower() == userName.ToLower())
                    .FirstOrDefault();
                if (queryUser is not null)
                {
                    LibMessageBox.Show("Username is not available!",
                        $"The username {userName} is being used by another user." +
                        Environment.NewLine +
                        $"try another one.");
                }
                else
                {
                    var newUser = new User
                    {
                        UserName = userName,
                        Password = password
                    };
                    db.Users.Add(newUser);
                    db.SaveChanges();

                    LibMessageBox.Show("Registered!",
                        $"Registered successfully.");
                    Login(userName, password);
                }
            }
        }
        private void SwitchMode()
        {
            SwitchControlTextWithTag(titleLabel);
            SwitchControlTextWithTag(logRegButton);
            SwitchControlTextWithTag(switchQuestionLabel);
            SwitchControlTextWithTag(switchModeLabel);
            SwitchControlTextWithTag(this);

            switchModeLabel.Left = switchQuestionLabel.Right - 3;

            modeIsLogin = !modeIsLogin;
        }
        private void SwitchControlTextWithTag(Control control)
        {
            string currentText = control.Text;
            control.Text = (string)control.Tag;
            control.Tag = currentText;
        }
    }
}
