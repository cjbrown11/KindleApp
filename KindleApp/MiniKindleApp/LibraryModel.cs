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
        public List<BookModel> library = new List<BookModel>();
        
       
        //EnvironmentVariableTarget bookNames = 
        
       public void  GetFile(string file)
        {
            
            string f;
            f = Path.GetFileName(file);
            
            
            BookModel bm = new BookModel(f, 1, 1);
            library.Add(bm);
            Console.WriteLine(f);
           
        }
        
        public LibraryModel(string file)
        {
            
            GetFile(file);
            /*
            StreamReader sr = new StreamReader(file);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                BookModel bm = new BookModel(line.Replace(line.Split(' ').Last(), ""), 0, Int32.Parse(line.Split(' ').Last()));
                library.Add(bm);
            }
            */
        }
        


    }
}
        