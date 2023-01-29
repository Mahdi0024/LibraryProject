using LibraryProject.Database;
using LibraryProject.DataClasses;
using LibraryProject.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Controls
{
    public partial class UserManager : UserControl
    {
        private User selectedUser;
        public UserManager()
        {
            InitializeComponent();
            UpdateUsersList();
        }
        #region Events
        private void usersGridView_SelectionChanged(object sender, EventArgs e)
        {
            #region ErrorChecking
            var selectedRows = usersGridView.SelectedRows;
            if (selectedRows.Count == 0)
                return;
            #endregion
            #region UpdateUI
            var user = selectedRows[0].DataBoundItem as User;

            selectedUser = user;
            userNameTextBox.Text = user.UserName;
            passwordTextBox.Text = user.Password;

            var yesNoButton = user.IsAdmin ? adminYesButton : adminNoButton;
            yesNoButton.PerformClick();

            editButton.Enabled = true;
            deleteButton.Enabled = true;
            deselectButton.Visible = true;
            #endregion
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            #region ErrorChecking
            if (TextBoxesAreEmpty())
            {
                LibMessageBox.Show("Error", "Textboxes are empty!");
                return;
            }
            #endregion
            #region AddingUser
            var user = new User
            {
                UserName = userNameTextBox.Text,
                Password = passwordTextBox.Text,
                IsAdmin = ((Button)selectedButtonPanel.Tag) == adminYesButton ? true : false 
            };
            AddUser(user);
            #endregion
            #region UIStuff
            ClearInputs();
            UpdateUsersList();
            #endregion

        }
        private void editButton_Click(object sender, EventArgs e)
        {
            #region ErrorChecking
            if (TextBoxesAreEmpty())
            {
                LibMessageBox.Show("Error", "Textboxes are empty!");
                return;
            }
            #endregion
            #region UpdateData
            selectedUser.UserName = userNameTextBox.Text;
            selectedUser.Password = passwordTextBox.Text;
            selectedUser.IsAdmin = ((Button)selectedButtonPanel.Tag) == adminYesButton ? true : false;
            UpdateUser(selectedUser);
            #endregion
            #region UpdateUi
            UpdateUsersList();
            #endregion
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            RemoveUser(selectedUser);
            DeselectUserAndResetUi();
            UpdateUsersList();
        }
        private void deselectButton_Click(object sender, EventArgs e)
        {
            DeselectUserAndResetUi();
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateUsersList();
            emptySearchButton.Enabled = !String.IsNullOrEmpty(searchTextBox.Text);
        }
        private void adminYesNoButtons_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            //set *selected button mark* on the selected button.
            selectedButtonPanel.Left = button.Right - selectedButtonPanel.Width;
            selectedButtonPanel.Tag = button;

        }
        private void emptySearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }
        #endregion
        #region Ui
        private void ClearInputs()
        {
            userNameTextBox.Clear();
            passwordTextBox.Clear();
            adminYesNoButtons_Click(adminNoButton, EventArgs.Empty);
        }
        private void DeselectUserAndResetUi()
        {
            ClearInputs();
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            deselectButton.Visible = false;
            selectedUser = null;
        }
        #endregion
        #region DatabaseCalls
        private void AddUser(User user)
        {
            using (LibDb db = new())
            {
                db.Users.Add(user);
                db.SaveChanges();
            }
        }
        private void RemoveUser(User user)
        {
            using(LibDb db = new())
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
        private void UpdateUser(User user)
        {
            using(LibDb db = new())
            {
                db.Users.Update(user);
                db.SaveChanges();
            }
        }
        private void UpdateUsersList()
        {
            using (LibDb db = new())
            {
                usersGridView.DataSource = String.IsNullOrEmpty(searchTextBox.Text)
                    ? db.Users
                        .Include(u=>u.Books)
                        .ToList()
                    : db.Users
                        .Where(u => u.UserName.ToLower().Contains(searchTextBox.Text.ToLower()))
                        .Include(u=> u.Books)
                        .ToList();
            }
        }
        #endregion
        #region HelperMethods
        private bool TextBoxesAreEmpty() => (string.IsNullOrEmpty(userNameTextBox.Text) ||
               string.IsNullOrEmpty(passwordTextBox.Text));
        #endregion
    }
}
