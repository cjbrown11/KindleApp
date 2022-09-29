using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MiniKindleApp
{
    public class LibraryModel : LibraryView
    {
        
        
        public LibraryModel()
        {

            Setbooks();
        }

        

        public void RefreshBookList(string file)
        {

            /*
            string line;
            BookModel book = new BookModel("");
            using (StreamReader sr = new StreamReader(file))
            {
                while (sr.EndOfStream != true)
                {
                    line = sr.ReadLine();
                    if (line[0] == '*')
                    {
                        if(book.BookName != "") libraryList.Add(book);
                        book = new BookModel(line.Substring(1));
                    }
                    else book.Pages.Add(line);
                }
                libraryList.Add(book);
            }
            */


        }

        BookModel HungerGames = new BookModel();

        BookModel LordOfTheRings = new BookModel();

        BookModel BattleStarGalactica = new BookModel();

        public List<BookModel> BookList = new List<BookModel>();

        public void Setbooks()
        {
            string lord = "Lord Of The Rings";
            string hunger = "Hunger Games";
            LordOfTheRings.Title = lord;
            LordOfTheRings.Pages = 100;
            HungerGames.Title = hunger;
            HungerGames.Pages = 69;
            BattleStarGalactica.Title = "Battle Star Galactica";
            BattleStarGalactica.Pages = 369;

            BookList.Add(HungerGames);
            BookList.Add(LordOfTheRings);
            BookList.Add(BattleStarGalactica);

        }

        
    }
}
        