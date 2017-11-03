using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordSeekerFileIO
{
    public class WordReader
    {
        public WordReader()
        {
        }

        public IEnumerable<string> ReadAll(string path)
        {
            return File.ReadAllLines(path).Select(line => line.ToUpper());
        }
    }
}
