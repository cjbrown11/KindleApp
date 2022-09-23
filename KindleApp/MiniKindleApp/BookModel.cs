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
        
        public List<string> Pages = new List<string>();

        public BookModel(string title)
        {
            BookName = title;
        }
        
        public string BookName { get => title; set => title = value; }
    }
}
