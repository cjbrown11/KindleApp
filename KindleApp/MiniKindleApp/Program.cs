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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            LibraryModel library = new LibraryModel();
            LibraryView libraryView = new LibraryView();
            CloudLibrary cloud = new CloudLibrary();

            Controller controller = new Controller(library, libraryView, libraryView.DisplayState, cloud);
            libraryView.SetController(controller.HandleEvents);


            Application.Run(libraryView);
        }
    }

    
}
