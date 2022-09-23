using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Controller(LibraryModel m, LibraryView v, DisplayStateDel d)
        {
            libraryModel = m;
            libraryView = v;
            displayDel = d;
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
                    break;
                case State.OPENBOOK:
                    displayDel(State.OPENBOOK);
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
                    break;
                case State.PAGEBACKWARDS:
                    displayDel(State.PAGEBACKWARDS);
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

            libraryView.bookListView.Clear();
            foreach (BookModel b in libraryModel.libraryList)
            {
                libraryView.bookListView.Items.Add(b.BookName);
            }
            libraryView.bookListView.Show();
        }
    }
}
