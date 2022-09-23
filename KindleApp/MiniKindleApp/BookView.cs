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

        public BookView()
        {
            InitializeComponent();
        }

        public void SetController(HandleEventsDel c)
        {
            handleDel = c;
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
    }
}
