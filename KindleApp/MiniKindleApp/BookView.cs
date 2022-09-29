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

        public BookView(LibraryView view)
        {
            InitializeComponent();
            BookModel bm = new BookModel();
            bm = (BookModel)view.bookListView.SelectedItem;
            pages = bm.Pages;
            pageNumber.Text = bm.CurrentPage.ToString();
            if(bm.CurrentPage == 1) backButton.Enabled = false;
            if (bm.CurrentPage == bm.Pages) nextPageButton.Enabled = false;
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
            if (this.pageNumber.Text  == "1")
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
        }

        private void goToPageButton_Click(object sender, EventArgs e)
        {
            handleDel(State.GOTOPAGE, "");
            
            if (Int32.Parse(gotoPage.Text) <= pages && Int32.Parse(gotoPage.Text) > 0)
            {
                this.pageNumber.Text = gotoPage.Text;
            }
        }

        private void setMarkButton_Click(object sender, EventArgs e)
        {
            handleDel(State.SETBOOKMARK, "");

        }

        private void nextPageButton_Click(object sender, EventArgs e)
        {
            handleDel(State.PAGEFORWARDS, "");
            this.pageNumber.Text = (Int32.Parse(this.pageNumber.Text) + 1).ToString();
            backButton.Enabled = true;
            if (pageNumber.Text == pages.ToString())
            {
                nextPageButton.Enabled = false;
            }
        }

        private void bookViewBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pageNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookMark_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
