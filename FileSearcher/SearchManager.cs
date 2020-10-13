using System;
using System.Collections.Generic;
using System.Text;

namespace FileSearcher
{
   public abstract class SearchManager
    {
       public List<string> ListofResult;
        public abstract void  DoSearch();
        public abstract  List<string> GetResult();

    }

    // Leaf
    public class FileToProcess : SearchManager
    {
        private readonly string filepath;
        private readonly string searchword;

        public FileToProcess(string filepath ,string searchword)
        {
            this.filepath = filepath;
            this.searchword = searchword;
           
        }

        

        public override void DoSearch()
        {
            throw new NotImplementedException();
        }

       

        public override List<string> GetResult()
        {
            return ListofResult;
        }
    }
}
