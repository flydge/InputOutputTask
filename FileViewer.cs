﻿using System;
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
            int selectedFileNumb = -1;
            while (true)
            {
                for (int i = 0; i < directoryInfo.GetFiles().Length; i++)
                {
                    Console.WriteLine("#{0}:{1}", i, directoryInfo.GetFiles()[i].Name);
                }

                Console.WriteLine("Enter the numb of the selected file.");
                try
                {
                    selectedFileNumb = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input, or program for open this file not found. Try again.");
                    GetMenu();
                }

                try
                {
                    string prog = directoryInfo.GetFiles()[selectedFileNumb].Directory + @"\" + directoryInfo.GetFiles()[selectedFileNumb];
                    System.Diagnostics.Process.Start(prog);
                    Console.WriteLine("selected file {0} is open.", directoryInfo.GetFiles()[selectedFileNumb].Name);
                    Console.WriteLine("Enter 0 if u want to exit, or any other  to continue.");
                    int time4Open = int.Parse(Console.ReadLine());
                    if (time4Open == 0)
                    {
                        break;
                    }
                    Console.Clear();
                    
                }
                catch (FormatException)
                {
                    Console.Clear();
                    GetMenu();
                }
            }
        }
    }
}