using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema68.Entity
{
    class MovieList : Movie
    {
        public MovieList(string mname, int mrating, string mgenre, TimeSpan mlength, DateTime mreleasedate, DateTime mdates, string mdirector, string msynopsis) : base(mname, mrating, mgenre, mlength, mreleasedate, mdates, mdirector, msynopsis)
        {
        }
    }
}
