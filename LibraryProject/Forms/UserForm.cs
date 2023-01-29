using LibraryProject.Controls;
using LibraryProject.Controls.Interfaces;
using LibraryProject.DataClasses;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace LibraryProject.Forms
{
    public partial class UserForm : Form
    {
        private User user;

        private Button selectedButton;
        private Color buttonSelectedColor = Color.FromArgb(50, 60, 70);
        private Color buttonNotSelectedColor = Color.FromArgb(30, 35, 41);
        public UserForm(User adminUser)
        {
            InitializeComponent();
            this.user = adminUser;
            userNameLabel.Text = adminUser.UserName;

            manageUsersButton.Tag = new Library(user) { Dock = DockStyle.Fill };
            manageBooksButton.Tag = new MyBooks(user) { Dock = DockStyle.Fill };

            selectedButton = manageUsersButton;
            menuButtons_Click(manageUsersButton, EventArgs.Empty);
            foreach (Control c in menuPanel.Controls)
            {
                if (c is Button b)
                    b.Click += menuButtons_Click;
            }
        }

        private void menuButtons_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (selectedButton is not null)
                selectedButton.BackColor = buttonNotSelectedColor;
            button.BackColor = buttonSelectedColor;
            selectedButton = button;

            selectedButtonPanel.Top = button.Top;
            selectedButtonPanel.Left = button.Right - selectedButtonPanel.Width;

            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(button.Tag as UserControl);

            (button.Tag as IBookList).UpdateBooksList();
        }

        private void AdministratorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserForm_SizeChanged(object sender, EventArgs e)
        {
            this.Text = this.Size.ToString();
        }
    }
}
