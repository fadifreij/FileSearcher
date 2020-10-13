using System.Collections.Generic;
using System.Text;

namespace FileSearcher
{
    public abstract class SearchManager
    {
       
        public abstract void  DoSearch();
        public abstract  List<string> GetResult();

    }
}
