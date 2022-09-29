using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKindleApp
{
    public enum State
    {
        START,
        SYNC,
        OPENBOOK,
        CLOSEBOOK,
        SETBOOKMARK,
        GOTOPAGE,
        REMOVEBOOKMARK,
        PAGEFORWARDS,
        PAGEBACKWARDS,
        SELECTBOOK
    }

    public class Controller
    {
        private LibraryModel libraryModel;

        private LibraryView libraryView;

        private DisplayStateDel displayDel;

        private CloudLibrary cloudLibrary;

        private BookModel selectedBook;

        private BookView currentBook;

        public Controller(LibraryModel m, LibraryView v, DisplayStateDel d, CloudLibrary c)
        {
            libraryModel = m;
            libraryView = v;
            displayDel = d;
            cloudLibrary = c;
        }

        public void HandleEvents(State state, String args)
        {
            switch (state)
            {
                case State.START:
                    RefreshBookListView();
                    displayDel(State.START);
                    break;
                case State.SYNC:
                    displayDel(State.SYNC);
                    Synchronize();
                    RefreshBookListView();
                    break;
                case State.OPENBOOK:
                    displayDel(State.OPENBOOK);
                    Selectbook();
                    break;
                case State.CLOSEBOOK:
                    displayDel(State.CLOSEBOOK);
                    break;
                case State.SETBOOKMARK:
                    displayDel(State.SETBOOKMARK);
                    break;
                case State.GOTOPAGE:
                    displayDel(State.GOTOPAGE);
                    break;
                case State.REMOVEBOOKMARK:
                    displayDel(State.REMOVEBOOKMARK);
                    break;
                case State.PAGEFORWARDS:
                    displayDel(State.PAGEFORWARDS);
                    PageForward();
                    break;
                case State.PAGEBACKWARDS:
                    displayDel(State.PAGEBACKWARDS);
                    PageBackward();
                    break;
                case State.SELECTBOOK:
                    displayDel(State.SELECTBOOK);
                    break;
                default:
                    break;
            }
        }
        
        private void RefreshBookListView()
        {
            libraryView.bookListView.Items.Clear();
            foreach(BookModel b in libraryModel.BookList)
            {
                libraryView.bookListView.Items.Add(b);
            }
            libraryView.bookListView.Show();
        }
        


        public void Synchronize()
        {
            for(int i = 0; i < cloudLibrary.BookList.Count; i++)
            {
                libraryModel.BookList.Add(cloudLibrary.BookList[i]);
            }
        }

        public void Selectbook()
        {
            if (libraryView.bookListView.SelectedItem == null) MessageBox.Show("Select a book to view");
            else
            {
                BookView bookview = new BookView(libraryView);
                currentBook = bookview;
                selectedBook = (BookModel)libraryView.bookListView.SelectedItem;
                bookview.SetController(this.HandleEvents);
                bookview.ShowDialog();
            }
        }

        public void PageForward()
        {
            selectedBook.CurrentPage++;
        }

        public void PageBackward()
        {
            selectedBook.CurrentPage--;
        }
    }
}
