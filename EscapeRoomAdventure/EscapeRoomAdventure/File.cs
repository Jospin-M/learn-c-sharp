using System;
using System.Collections.Generic;
using System.Text;

namespace EscapeRoomAdventure
{
    internal class File
    {
        public string FileName { get; set; }
        public int FileSize { get; set; }

        public File(string fileName, int fileSize)
        {
            FileName = fileName;
            FileSize = fileSize;
        }
    }
}
