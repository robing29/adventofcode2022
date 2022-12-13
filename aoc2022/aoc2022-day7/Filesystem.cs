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
        public List<string>? ContainedFilesOrFolders { get; set; }
        public Folder (string cdLine)
        {
            Name = cdLine;
            ContainedFilesOrFolders = new List<string>();
        }

    }

    internal class FileSystemFile
    {
        public string? Name { get; set; }
        public int? Size { get; set; }
    }
    public class Dir
    {
        public string? Name { get; set; }
        public List<Dir>? Subdirectories { get; set; }
        public List<FileSys>? Files { get; set; }
        public long? TotalSize { get; set; }
    }

    public class FileSys
    {
        public string? Name { get; set; }
        public long? Size { get; set; }
    }

    

}
