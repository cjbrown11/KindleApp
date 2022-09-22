using System;
using System.Collections.Generic;
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
        LibraryModel libraryModel;

        private DisplayStateDel displayDel;

        public Controller(LibraryModel m, DisplayStateDel d)
        {
            libraryModel = m;
            displayDel = d;
        }

        public void HandleEvents(State state, String args)
        {
            switch (state)
            {
                case State.START:
                    break;
                case State.SYNC:
                    break;
                case State.OPENBOOK:
                    break;
                case State.CLOSEBOOK:
                    break;
                case State.SETBOOKMARK:
                    break;
                case State.GOTOPAGE:
                    break;
                case State.REMOVEBOOKMARK:
                    break;
                case State.PAGEFORWARDS:
                    break;
                case State.PAGEBACKWARDS:
                    break;
                case State.SELECTBOOK:
                    break;
                default:
                    break;
            }
        }
    }
}
