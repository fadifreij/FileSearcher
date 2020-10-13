using System;
using System.Collections.Generic;
using System.IO;

namespace FileSearcher
{
    // Leaf
    public class FileToProcess : SearchManager
    {
        private readonly string filepath;
        private readonly string searchword;
        private readonly List<string> result;
        
        public FileToProcess(string filepath ,string searchword ,List<string> result)
        {
            this.filepath = filepath;
            this.searchword = searchword;
            this.result = result;
           
        }

        

        public override void DoSearch()
        {
            var LineNumber = 0;
            foreach(var line in File.ReadAllLines(filepath))
            {
                LineNumber++;
                if(line.Contains(searchword))
                {
                    result.Add(ResultToSave(filepath, LineNumber.ToString()));
                }
            }


        }

       

        public override List<string> GetResult()
        {
           
            return result;
        }

        private string ResultToSave(string path , string linenumber)
        {
            return string.Format("Path :{0} , Line :{1}", path, linenumber);
        }
    }
}
