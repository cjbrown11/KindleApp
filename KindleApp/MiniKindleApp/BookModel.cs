using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKindleApp
{
    public class BookModel
    {

        private string title;
        private List<int> _bookmarks = new List<int>();

        private int _pages;

        private int _currentPage = 1;

        public int CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
            }
        }

        public int Pages
        {
            get => _pages;
            set
            {
                _pages = value;
            }
        }

        public string Title
        {
            get => title;
            set
            {
                title = value;
            }
            
        }

        public List<int> Bookmarks
        {
            get => _bookmarks;
        }

        public void AddBookmark(int bm)
        {
            _bookmarks.Add(bm);
        }

        public void RemoveBookmark(int bm)
        {
            _bookmarks.Remove(bm);
        }

        //public string BookName { get => title; set => title = value; }

        public override string ToString()
        {
            // choose any format that suits you and display what you like
            return String.Format(this.Title);
        }




    }
}
