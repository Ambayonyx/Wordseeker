using System.Collections.Generic;
using WordSeekerFileIO;

namespace WordSeeker
{
    interface IWordSeekerSolver
    {
        WordSeekerSolution Solve(Field field, IEnumerable<string> words);
    }
}
