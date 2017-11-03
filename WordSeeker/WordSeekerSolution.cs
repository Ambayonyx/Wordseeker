using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSeeker
{
    public class WordSeekerSolution
    {
        public string SolutionWord { get; set; }
        public Dictionary<string, List<WordLocation>> Words = new Dictionary<string, List<WordLocation>>();

        // Call one of Eddie's alogrithms
        // - Solution word
        // - Where were the words found (start coordinate and direction (dx, dy) ==> WordLocation
        // - Which words were NOT found ==> #locations == 0 
        // - Which words were found multiple times ==> #locations > 1 
        // - how many times were the words found ==> #locations

    }
}
