using LibraryProject.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Controls.Events
{
    public class LibraryBookItemEventArgs : EventArgs
    {
        public Book Book { get; set; }

        public LibraryBookItemEventArgs(Book book)
        {
            Book = book;
        }
    }
}
