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
    public partial class BookView : Form
    {
        private HandleEventsDel handleDel;
        public static LibraryView instance;

        public BookView(LibraryView view)
        {
            InitializeComponent();
            BookModel bm = new BookModel();
            bm = (BookModel)view.bookListView.SelectedItem;
            pageNumber.Text = bm.CurrentPage.ToString();
        }

        public void SetController(HandleEventsDel c)
        {
            handleDel = c;
        }

        public void DisplayState(State state)
        {
            switch (state)
            {
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
                default:
                    break;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            handleDel(State.PAGEBACKWARDS, "");
        }

        private void removeMarkButton_Click(object sender, EventArgs e)
        {
            handleDel(State.REMOVEBOOKMARK, "");
        }

        private void goToPageButton_Click(object sender, EventArgs e)
        {
            handleDel(State.GOTOPAGE, "");
        }

        private void setMarkButton_Click(object sender, EventArgs e)
        {
            handleDel(State.SETBOOKMARK, "");
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            handleDel(State.PAGEFORWARDS, "");
        }

        private void bookViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pageNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
