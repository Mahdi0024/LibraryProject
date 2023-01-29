using LibraryProject.Database;
using LibraryProject.DataClasses;
using LibraryProject.Forms;
using LibraryProject.Properties;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LibraryProject.Controls
{
    public partial class BookManager : UserControl
    {
        private const string bookImagesFolder = "BookImages\\";

        private Book selectedBook;
        private string selectedImagePath;
        public BookManager()
        {
            InitializeComponent();
            if (!Directory.Exists(bookImagesFolder))
                Directory.CreateDirectory(bookImagesFolder);
            UpdateBooksList();

        }
        #region Events
        private void booksGridView_SelectionChanged(object sender, EventArgs e)
        {
            #region ErrorChecking
            var selectedRows = booksGridView.SelectedRows;
            if (selectedRows.Count == 0)
                return;
            #endregion
            #region UpdateUI
            var book = selectedRows[0].DataBoundItem as Book;

            selectedBook = book;
            selectedImagePath = book.ImagePath;
            nameTextBox.Text = book.Name;
            authorTextBox.Text = book.Author;
            descriptionTextBox.Text = book.Description;
            imagePictureBox.ImageLocation = book.ImagePath;

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
            if (ImageIsNotSet())
            {
                LibMessageBox.Show("Error", "Image is not set!");
                return;
            }
            #endregion
            #region AddingBook
            var book = new Book
            {
                Name = nameTextBox.Text,
                Author = authorTextBox.Text,
                Description = descriptionTextBox.Text,
                ImagePath = CopySelectedImageAndGetNewPath()
            };
            AddBook(book);
            #endregion
            #region UIStuff
            ClearInputs();
            UpdateBooksList();
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
            if (ImageIsNotSet())
            {
                LibMessageBox.Show("Error", "Image is not set!");
                return;
            }
            #endregion
            #region UpdateData
            selectedBook.Name = nameTextBox.Text;
            selectedBook.Author = authorTextBox.Text;
            selectedBook.Description = descriptionTextBox.Text;
            if (selectedBook.ImagePath != selectedImagePath)
            {
                File.Delete(selectedBook.ImagePath);
                selectedBook.ImagePath = CopySelectedImageAndGetNewPath();
            }
            UpdateBook(selectedBook);
            #endregion
            #region UpdateUi
            DeselectBookAndResetUi();
            UpdateBooksList();
            #endregion

        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            File.Delete(selectedBook.ImagePath);
            RemoveBook(selectedBook);
            DeselectBookAndResetUi();
            UpdateBooksList();
        }
        private void deselectButton_Click(object sender, EventArgs e)
        {
            DeselectBookAndResetUi();
        }
        private void setImageButton_Click(object sender, EventArgs e)
        {
            if (imageOpenDialog.ShowDialog().Equals(DialogResult.OK))
            {
                selectedImagePath = imageOpenDialog.FileName;
                imagePictureBox.ImageLocation = selectedImagePath;
            }
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBooksList();
            emptySearchButton.Enabled = !String.IsNullOrEmpty(searchTextBox.Text);
        }
        private void emptySearchButton_Click(object sender, EventArgs e)
        {
            searchTextBox.Clear();
        }
        #endregion
        #region Ui
        private void ClearInputs()
        {
            ClearSelectedImage();
            nameTextBox.Clear();
            authorTextBox.Clear();
            descriptionTextBox.Clear();
        }
        private void ClearSelectedImage()
        {
            selectedImagePath = "";
            imagePictureBox.ImageLocation = "";
            imagePictureBox.Image?.Dispose();
            imagePictureBox.Image = Resources.LibIcon;
        }
        private void DeselectBookAndResetUi()
        {
            selectedBook = null;
            editButton.Enabled = false;
            deleteButton.Enabled = false;
            deselectButton.Visible = false;
            ClearInputs();
            ClearSelectedImage();
        }
        #endregion
        #region DatabaseCalls
        private void AddBook(Book book)
        {
            using (LibDb db = new())
            {
                db.Books.Add(book);
                db.SaveChanges();
            }
        }
        private void RemoveBook(Book book)
        {
            using (LibDb db = new())
            {
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }
        private void UpdateBook(Book book)
        {
            using (LibDb db = new())
            {
                db.Books.Update(book);
                db.SaveChanges();
            }
        }
        private void UpdateBooksList()
        {
            using (LibDb db = new())
            {
                booksGridView.DataSource = String.IsNullOrEmpty(searchTextBox.Text)
                    ? db.Books.ToList()
                    : db.Books
                        .Where(b => b.Name.ToLower().Contains(searchTextBox.Text.ToLower()))
                        .ToList();
            }
        }
        #endregion
        #region HelperMethods
        private string CopySelectedImageAndGetNewPath()
        {
            var newFileName = String.Concat(bookImagesFolder, Guid.NewGuid().ToString(), Path.GetExtension(selectedImagePath));
            File.Copy(selectedImagePath, newFileName);
            return newFileName;
        }
        private bool ImageIsNotSet() => String.IsNullOrEmpty(selectedImagePath);
        private bool TextBoxesAreEmpty() =>
            (String.IsNullOrEmpty(nameTextBox.Text) ||
              String.IsNullOrEmpty(authorTextBox.Text) ||
            String.IsNullOrEmpty(descriptionTextBox.Text));
        #endregion
    }
}
