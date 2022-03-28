using System;
using System.IO;

namespace MapCfgCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilesNames = Console.ReadLine();
            string[] FileList = FilesNames.Split(';');
            string Path = Console.ReadLine();

            foreach (var File in FileList)
            {
                FileInfo fileInf = new FileInfo(@$"{Path}\{File}");
                if (!fileInf.Exists)
                {
                    fileInf.Create();
                }
            }
        }
    }
}
