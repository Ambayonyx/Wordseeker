using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using WordSeekerFileIO;

namespace WordSeeker
{
    internal class MauriceSolver : IWordSeekerSolver
    {
        public WordSeekerSolution Solve(Field field, IEnumerable<string> words)
        {
            // Create list of words starting on every position going into every direction
            // When on of these entries starts with a given word, we have a match.
            // Save the result in the solution

            List<Tuple<int, int>> grid = CreateGrid(field);
            List<Tuple<int, int>> validDirections = CreateValidDirections();
            var wordsFound = new List<Tuple<WordLocation, string>>(field.Height * field.Width * validDirections.Count);

            foreach (var cell in grid)
            {
                foreach (var direction in validDirections)
                {
                    var word = CreateWord(field, cell.Item2, cell.Item1, direction);
                    wordsFound.Add(Tuple.Create(new WordLocation()
                    {
                        AnchorRow = cell.Item2,
                        AnchorColumn = cell.Item1,
                        NextRowOffset = direction.Item2,
                        NextColumnOffset = direction.Item1
                    },
                    word));
                }
            }

            var solution = new WordSeekerSolution();
            foreach (var word in words)
            {
                var locations = new List<WordLocation>();
                var matches = wordsFound.FindAll(w => w.Item2.StartsWith(word));
                solution.Words.Add(word, matches.Select(match => match.Item1).ToList());
            }

            foreach (var word in solution.Words)
            {
                foreach (var finding in word.Value)
                {
                    for (var index = 0; index < word.Key.Length; index++)
                    {
                        var column = finding.AnchorColumn + index * finding.NextColumnOffset;
                        var row = finding.AnchorRow + index * finding.NextRowOffset;
                        grid.RemoveAll(cell => cell.Item1 == column && cell.Item2 == row);
                   }
                }
            }

            var sb = new StringBuilder();
            foreach (var remainingCell in grid)
            {
                sb.Append(field.GetAt(remainingCell.Item2, remainingCell.Item1));
            }
            solution.SolutionWord = sb.ToString();
            return solution;
        }

        private static List<Tuple<int, int>> CreateValidDirections()
        {
            List<Tuple<int, int>> validDirections = new List<Tuple<int, int>>();
            validDirections.Add(Tuple.Create(1, 0));
            validDirections.Add(Tuple.Create(1, 1));
            validDirections.Add(Tuple.Create(0, 1));
            validDirections.Add(Tuple.Create(-1, 1));
            validDirections.Add(Tuple.Create(-1, 0));
            validDirections.Add(Tuple.Create(-1, -1));
            validDirections.Add(Tuple.Create(0, -1));
            validDirections.Add(Tuple.Create(1, -1));
            return validDirections;
        }

        private static List<Tuple<int, int>> CreateGrid(Field field)
        {
            var grid = new List<Tuple<int, int>>(field.Height * field.Width);

            for (var row = 0; row < field.Height; row++)
            {
                for (var column = 0; column < field.Width; column++)
                {
                    grid.Add(Tuple.Create(column, row));
                }
            }

            return grid;
        }

        private bool InField(Field field, int row, int column)
        {
            return (row >= 0) &&
                   (column >= 0) &&
                   (row < field.Height) &&
                   (column < field.Width);
        }

        private string CreateWord(Field field, int row, int column, Tuple<int, int> direction)
        {
            var dColumn = direction.Item1;
            var dRow = direction.Item2;
            var sb = new StringBuilder();

            do
            {
                sb.Append(field.GetAt(row, column));
                row += dRow;
                column += dColumn;
            } while (InField(field, row, column));

            return sb.ToString();
        }
    }
}