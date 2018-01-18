using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InputOutputTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string path = "/home/flydge/snap/chromium/107/Downloads/js";
            FileViewer fileViewer = new FileViewer();
            fileViewer.Path = path;
            fileViewer.GetMenu();
           
        }
    }
}