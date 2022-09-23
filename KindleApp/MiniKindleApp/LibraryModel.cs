using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniKindleApp
{
    public class LibraryModel
    {
        public List<BookModel> library = new List<BookModel>();

        public LibraryModel(string file)
        {
            StreamReader sr = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                BookModel bm = new BookModel(line.Replace(line.Split(' ').Last(), ""), 0, Int32.Parse(line.Split(' ').Last()));
                library.Add(bm);
            }
        }
    }
}
