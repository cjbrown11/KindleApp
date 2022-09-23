using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKindleApp
{
    public class BookModel
    {
        private string name;
        private int curPage;
        private int totPages;
        private List<int> bookmarks = new List<int>();

        public BookModel(string title, int page, int pages)
        {
            bookName = title;
            currentPage = page;
            totalPages = pages;
        }
        
        public string bookName { get => name; set => name = value; }

        public int currentPage { get => curPage; set => curPage = value; }

        public int totalPages { get => totPages; set => totPages = value; } 
    }
}
