using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKindleApp
{
    public class Book
    {
        private List<BookMark> _bookMarks = new List<BookMark>();

        public List<BookMark> BookMarks { get => _bookMarks; set { _bookMarks = value; } }

        private string _title = "shit";
        public string Title
        { get => _title;
            set 
            {
                _title = value;
            }
        }
    

        public List<Page> Pages { get; set; } = new List<Page>();

        public int CurrentPage { get; set; } = 0;

        public List<BookMark> BookMark { get; set; } = new List<BookMark>();

        

        

        
    }
}
