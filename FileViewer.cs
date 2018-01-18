using System;
using System.IO;

namespace InputOutputTask
{
    public class FileViewer
    {
        private string _path;

        public string Path
        {
            get => _path;
            set => _path = value;
        }

        public void GetMenu()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Path);
            for (int i = 0; i < directoryInfo.GetFiles().Length; i++)
            {
                Console.WriteLine("#{0}:{1}", i, directoryInfo.GetFiles()[i].Name);
            }
            Console.WriteLine("Enter the numb of the selected file.");
            int selectedFileNumb = 0; //int.Parse(Console.ReadLine());

            string prog = directoryInfo.GetFiles()[selectedFileNumb].ToString();
            using (System.Diagnostics.Process.Start(prog))
            {
                //Console.Clear();
                Console.WriteLine("selected file {0} is open.",directoryInfo.GetFiles()[selectedFileNumb].Name);
                int time4open = int.Parse(Console.ReadLine());
            }
            
           
        }
    }
}
