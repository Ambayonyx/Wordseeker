using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSeekerFileIO
{
    public class Field
    {
        public int Width { get; set; }
        public int Height { get {return this.fieldlines.Count(); } }
        public string GetAt(int row, int column)
        {
            if (row < 0) { throw new ArgumentOutOfRangeException("Row must be positive"); }
            if (column < 0) { throw new ArgumentOutOfRangeException("Column must be positive"); }
            if (row >= this.Height) { throw new ArgumentOutOfRangeException("Row exceeds height"); }
            if (column >= this.Width) { throw new ArgumentOutOfRangeException("Column exceeds width"); }
            return this.fieldlines.ElementAt(row).Substring(column, 1);
        }
        private List<string> fieldlines;

        public Field()
        {
            this.Width = 0;
            this.fieldlines = new List<string>();
        }

        public void Fill(IEnumerable<string> lines)
        {
            this.fieldlines = new List<string>();
            this.fieldlines.AddRange(lines);
            this.Width = this.fieldlines.Select(line => line.Length).Max();
            var constantWidth = this.fieldlines.All(line => line.Length == this.Width);
            if (!constantWidth)
            {
                throw new FileLoadException("Different line lengths");
            }
        }
    }

    public class FieldReader
    {
        public Field Read(string path)
        {
            var lines = File.ReadAllLines(path).Select(line => line.ToUpper());
            var field = new Field();
            field.Fill(lines);
            return field;
        }
    }
}
