using LibraryProject.Controls.Events;
using LibraryProject.DataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryProject.Controls.Enums;

namespace LibraryProject.Controls
{
    public partial class LibraryBookItem : UserControl
    {
        public event EventHandler<LibraryBookItemEventArgs> OnBorrowClick;
        public event EventHandler<LibraryBookItemEventArgs> OnReturnClick;

        private Color mouseInColor = Color.FromArgb(50, 60, 70);
        private Color mouseOutColor = Color.FromArgb(30, 35, 41);
        private Book book;
        public LibraryBookItem(Book book,BookItemMode mode)
        {
            InitializeComponent();
            this.book = book;
            if (mode.Equals(BookItemMode.Borrow))
                borrowButton.BringToFront();
            else
                returnButton.BringToFront();

            imagePictureBox.ImageLocation = book.ImagePath;
            namelabel.Text = book.Name;
            authorLabel.Text = book.Author;
            descriptionTextBox.Text = book.Description;

        }

       

        private void LibraryBookItem_MouseEnter(object sender, EventArgs e)
        {
            BackColor = mouseInColor;
        }

        private void LibraryBookItem_MouseLeave(object sender, EventArgs e)
        {
            BackColor = mouseOutColor;
        }

        private void LibraryBookItem_SizeChanged(object sender, EventArgs e)
        {
            tableLayoutPanel1.Width = panelButton.Left - imagePictureBox.Right;
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            OnReturnClick?.Invoke(this, new LibraryBookItemEventArgs(book));
        }
        private void borrowButton_Click(object sender, EventArgs e)
        {
            OnBorrowClick?.Invoke(this, new LibraryBookItemEventArgs(book));
        }
    }
}
