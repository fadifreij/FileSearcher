using System.Collections.Generic;
using System.IO;

namespace FileSearcher
{
    public class FolderToProcess : SearchManager
    {
        private  List<SearchManager> filesInsideFolder = new List<SearchManager>();
        
        private readonly List<string> result;
        private readonly string RootFolderName;

        public string SearchKeyword { get; }

        public FolderToProcess(List<string> result ,string RootFolderName ,string searchKeyword)
        {
            this.result = result;
            this.RootFolderName = RootFolderName;
            this.SearchKeyword = searchKeyword;
        }
        public override void DoSearch()
        {
            var list = GetTextFilesFromDirectory(RootFolderName);
            foreach (var fileToProcess in list)
                fileToProcess.DoSearch();
            LoadSubDirecotries(RootFolderName);
        }

        public override List<string> GetResult()
        {
            return result;
        }
        private List<SearchManager> GetTextFilesFromDirectory(string dir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            FileInfo[] Files = dirInfo.GetFiles("*.txt");
            //filesInsideFolder = null;
            foreach(var file in Files)
            {
                var fileToProcess = new FileToProcess(file.FullName, SearchKeyword, result);
                filesInsideFolder.Add(fileToProcess);
            }
            return filesInsideFolder;

        }


        private void LoadSubDirecotries(string dir)
        {
           
            string[] subdirectoriesEntries = Directory.GetDirectories(dir);
            foreach(string subdirectory in subdirectoriesEntries)
            {
                var listofFilesToProcess = GetTextFilesFromDirectory(subdirectory);
                foreach (var fileToProcess in listofFilesToProcess)
                           fileToProcess.DoSearch();
                LoadSubDirecotries(subdirectory);
            }
        }
    }
}
