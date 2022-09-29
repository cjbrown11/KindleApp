using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniKindleApp
{
    public partial class LibraryView : Form
    {
        private HandleEventsDel handleDel;

        public LibraryView()
        {
            InitializeComponent();
        }

        public void DisplayState(State state)
        {
            switch(state)
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

        public void SetController(HandleEventsDel c)
        {
            handleDel = c;
            handleDel(State.START, "");
        }

        private void synchronizeButton_Click(object sender, EventArgs e)
        {
            handleDel(State.SYNC, "");
            synchronizeButton.Enabled = false;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            handleDel(State.OPENBOOK, "");
            
        }

        public void bookListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            handleDel(State.SELECTBOOK, "");
            
        }

        private void bookListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bookListView_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
