using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InputOutputTask
{
    internal class Program
    {
        public static void Main()
        {
            
            string path = @"E:\UbuntuFiles";
            FileViewer fileViewer = new FileViewer();
            fileViewer.Path = path;
            fileViewer.GetMenu();
        }
    }
}