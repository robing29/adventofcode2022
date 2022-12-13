using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aoc2022_day7
{
    internal class Folder
    {
        public string? Name { get; set; }
        public List<Folder>? Subdirectories { get; set; }
        public List<File>? Files { get; set; }

        public Folder (List<string> input)
        {
            
        }

    }

    internal class File
    {
        public string? Name { get; set; }
        public int? Size { get; set; }

    }
}
