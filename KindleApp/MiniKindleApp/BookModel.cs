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

        private int _pages = 1;

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
            set
            {
                _bookmarks = value;
            }
        }
        
        //public string BookName { get => title; set => title = value; }

        
        
        

        
    }
}
