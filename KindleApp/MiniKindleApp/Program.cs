using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace MiniKindleApp
{
    public delegate void DisplayStateDel(State state);

    public delegate void HandleEventsDel(State state, String args);

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Book book1 = new Book();
            book1.Title = "Poop";
            book1.Pages = ;


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LibraryModel library = new LibraryModel(@"C:\Users\jcrig\source\repos\KindleApp1\KindleApp\KindleApp\bin\book\book1.txt");
            LibraryView libraryView = new LibraryView();

            Controller controller = new Controller(library, libraryView.DisplayState);
            libraryView.SetController(controller.HandleEvents);

            Application.Run(libraryView);
        }
    }

    /*
     Rigdon's raw thoughts @ 1 am for whoever works on this next:
        i dont think our original idea of having a book just be a txt.file is
        going to work. Becauseeee, i think book has to be it's own object, that you
        can assigns things to such as a bookmark that will be stored in the book,
        or even page numbers so that the user can type in a page and go to that page,
        . I couldnt figure out how to get a txt file to read into the library view (as you will
        see in my failed attempts that are half commented out) soooo, yeah. 
        Also dont think we necesarily have to show content in the book view
        maybe just some predefined books that we predefine in the code that are of type 'book', and when we go
        back and forth betweenn pages, it shows what page we are on, as well as if there
        is a bookmark on that page. as well as some books that will get added to the 
        
        
     */
}
