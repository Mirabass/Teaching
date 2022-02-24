using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class FileProcessor
    {
        public string Path { get; set; }

        public void LoadFile()
        {
            Console.WriteLine($"Načítám soubor z cesty:\n{Path}");
        }
    }
}
