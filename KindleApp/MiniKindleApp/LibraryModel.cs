using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniKindleApp
{
    public class LibraryModel : LibraryView
    {
        public List<BookModel> libraryList = new List<BookModel>();
        
        public LibraryModel(string file)
        {
            RefreshBookList(file);
        }

        public void RefreshBookList(string file)
        {
            string line;
            BookModel book = new BookModel("");
            using (StreamReader sr = new StreamReader(file))
            {
                while (sr.EndOfStream != true)
                {
                    line = sr.ReadLine();
                    if (line[0] == '*')
                    {
                        if(book.BookName != "") libraryList.Add(book);
                        book = new BookModel(line.Substring(1));
                    }
                    else book.Pages.Add(line);
                }
                libraryList.Add(book);
            }
        }
    }
}
        