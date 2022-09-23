using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniKindleApp
{
    public class BookMark
    {

        private int _location = 0;

        


        public int BookMarkLocation
        {
            get => _location;
            set
            {
                _location = value;
            }
        }

        public BookMark(int location)
        {
            BookMarkLocation = location;
        }
    }
}
