using LibraryProject.Controls.Enums;
using LibraryProject.Controls.Events;
using LibraryProject.Controls.Interfaces;
using LibraryProject.Database;
using LibraryProject.DataClasses;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    public partial class MyBooks : UserControl, IBookList
    {
        private User user;
        public MyBooks(User user)
        {
            InitializeComponent();
            this.user = user;
            UpdateBooksList();
        }
        public void UpdateBooksList()
        {
            booksFlowLayout.SuspendLayout();
            foreach (LibraryBookItem c in booksFlowLayout.Controls)
            {
                c.OnReturnClick -= BookItem_OnReturnClick;
                c.Dispose();
            }
            booksFlowLayout.Controls.Clear();

            foreach (Book b in GetAbailableBooks())
            {
                var bookItem = new LibraryBookItem(b, BookItemMode.Return);
                bookItem.OnReturnClick += BookItem_OnReturnClick;
                bookItem.Width = booksFlowLayout.ClientSize.Width - 8;
                booksFlowLayout.Controls.Add(bookItem);
            }

            booksFlowLayout.ResumeLayout();
        }
        private void BookItem_OnReturnClick(object sender, LibraryBookItemEventArgs e)
        {
            using (LibDb db = new())
            {
                user = db.Users.Where(u => u.Id == user.Id)
                    .Include(u=>u.Books)
                    .First();
                var bookToReturn = user.Books.Where(b => b.Id == e.Book.Id).First();
                user.Books.Remove(bookToReturn);
                db.Users.Update(user);
                db.SaveChanges();
            }
            var itemControl = sender as LibraryBookItem;
            booksFlowLayout.Controls.Remove(itemControl);
            itemControl.Dispose();
        }
        private List<Book> GetAbailableBooks()
        {
            using (LibDb db = new())
                return db.Users
                    .Where(u => u.Id == user.Id)
                    .Select(u => u.Books)
                    .First();
        }
        private void booksFlowLayout_Layout(object sender, LayoutEventArgs e)
        {
            booksFlowLayout.SuspendLayout();
            foreach (Control control in booksFlowLayout.Controls)
            {
                control.Width = booksFlowLayout.ClientSize.Width - 8;
            }
            booksFlowLayout.ResumeLayout();
        }
    }
}
