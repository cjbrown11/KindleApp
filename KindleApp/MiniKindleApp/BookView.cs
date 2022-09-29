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

        private int pages;

        private List<int> bookmarks = new List<int>();

        public BookView(LibraryView view)
        {
            InitializeComponent();
            BookModel bm = new BookModel();
            bm = (BookModel)view.bookListView.SelectedItem;
            pages = bm.Pages;
            pageNumber.Text = bm.CurrentPage.ToString();
            bookTitle.Text = bm.Title;
            if (bm.CurrentPage == 1) backButton.Enabled = false;
            if (bm.CurrentPage == bm.Pages) nextPageButton.Enabled = false;
            bookmarks = bm.Bookmarks;
            check_Bookmark();
        }

        public void SetController(HandleEventsDel c)
        {
            handleDel = c;
        }

        public void DisplayState(State state)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            handleDel(State.PAGEBACKWARDS, "");
            this.pageNumber.Text = (Int32.Parse(this.pageNumber.Text) - 1).ToString();
            check_Bookmark();
            if (this.pageNumber.Text == "1")
            {
                backButton.Enabled = false;
            }
            if (this.pageNumber.Text != pages.ToString())
            {
                nextPageButton.Enabled = true;
            }
        }

        private void removeMarkButton_Click(object sender, EventArgs e)
        {
            handleDel(State.REMOVEBOOKMARK, "");
            bookmarks.Remove(Int32.Parse(this.pageNumber.Text));
            check_Bookmark();
            //numMarks--;
        }

        private void goToPageButton_Click(object sender, EventArgs e)
        {
            handleDel(State.GOTOPAGE, "");
            if (Int32.Parse(gotoPage.Text) <= pages && Int32.Parse(gotoPage.Text) > 0)
            {
                this.pageNumber.Text = gotoPage.Text;
            }
            check_Bookmark();
        }

        private void setMarkButton_Click(object sender, EventArgs e)
        {
            if (bookmarks.Count == 5)
            {
                MessageBox.Show("Cannot have more than 5 bookmarks");
            }
            else
            {
                handleDel(State.SETBOOKMARK, "");
                bookmarks.Add(Int32.Parse(this.pageNumber.Text));
                check_Bookmark();
                //numMarks++;
            }
        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            handleDel(State.PAGEFORWARDS, "");
            this.pageNumber.Text = (Int32.Parse(this.pageNumber.Text) + 1).ToString();
            check_Bookmark();
            backButton.Enabled = true;
            if (pageNumber.Text == pages.ToString())
            {
                nextPageButton.Enabled = false;
            }
        }

        private void check_Bookmark()
        {
            if (bookmarks.Contains(Int32.Parse(this.pageNumber.Text)))
            {
                this.bookMark.Text = "Yes";
                setMarkButton.Enabled = false;
                removeMarkButton.Enabled = true;
            }
            else
            {
                this.bookMark.Text = "No";
                setMarkButton.Enabled = true;
                removeMarkButton.Enabled = false;
            }
        }
    }
}
