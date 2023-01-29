using LibraryProject.Controls.Enums;
using LibraryProject.Controls.Interfaces;
using LibraryProject.Database;
using LibraryProject.DataClasses;
using LibraryProject.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    public partial class Library : UserControl, IBookList
    {
        private User user;
        public Library(User user)
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
                c.OnBorrowClick -= BookItem_OnBorrowClick;
                c.Dispose();
            }
            booksFlowLayout.Controls.Clear();

            foreach (Book b in GetAbailableBooks())
            {
                var bookItem = new LibraryBookItem(b, BookItemMode.Borrow);
                bookItem.OnBorrowClick += BookItem_OnBorrowClick;
                bookItem.Width = booksFlowLayout.ClientSize.Width - 8;
                booksFlowLayout.Controls.Add(bookItem);
            }

            booksFlowLayout.ResumeLayout();
        }
        private void BookItem_OnBorrowClick(object sender, Events.LibraryBookItemEventArgs e)
        {
            using (LibDb db = new())
            {
                user = db.Users.Where(u => u.Id == user.Id)
                    .Include(u => u.Books)
                    .First();
                if (user.Books.Count >= 3)
                {
                    LibMessageBox.Show("Too many books!",
                        $"You have the following 3 books: {String.Join(',', user.Books.Select(b => b.Name))}.\r\n" +
                        $"Return at least one book to borrow this one!");
                    return;
                }
                user.Books.Add(e.Book);
                db.Users.Update(user);
                db.SaveChanges();
            }
            var itemControl = sender as LibraryBookItem;
            booksFlowLayout.Controls.Remove(itemControl);
            itemControl.Dispose();
           // UpdateBooksList();

        }
        private List<Book> GetAbailableBooks()
        {
            using (LibDb db = new())
                if (string.IsNullOrEmpty(searchTextBox.Text))
                    return db.Books
                        .Where(b => !db.Users.Any(u => u.Books.Contains(b)))
                        .ToList();
                else return db.Books
                            .Where(b => b.Name.ToLower().Contains(searchTextBox.Text.ToLower())
                             && (!db.Users.Any(u => u.Books.Contains(b))))
                            .ToList();

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
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBooksList();
        }
    }
}
