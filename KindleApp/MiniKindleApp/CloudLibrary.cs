using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKindleApp
{
    public class CloudLibrary
    {
        BookModel ChrisBrownGoesOnAFieldTrip = new BookModel();

        BookModel JacksFirstDayOfSchool = new BookModel();

        BookModel JorgeBio = new BookModel();

        public List<BookModel> BookList = new List<BookModel>();

        public void Setbooks()
        {
            string chris = "Chris Brown Goes On A Field Trip";
            string jack = "Jack's First Day of School";
            ChrisBrownGoesOnAFieldTrip.Title = chris;
            ChrisBrownGoesOnAFieldTrip.Pages = 100;
            JacksFirstDayOfSchool.Title = jack;
            JacksFirstDayOfSchool.Pages = 69;
            JorgeBio.Title = "The AutoBiography of Jorge";
            JorgeBio.Pages = 369;

            BookList.Add(ChrisBrownGoesOnAFieldTrip);
            BookList.Add(JacksFirstDayOfSchool);
            BookList.Add(JorgeBio);

        }

        public CloudLibrary()
        {
            Setbooks();
        }
    }
}
