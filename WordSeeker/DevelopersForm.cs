using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordSeekerFileIO;

namespace WordSeeker
{
    public partial class DevelopersForm : Form
    {
        private Field field;
        private IEnumerable<string> words;

        public DevelopersForm()
        {
            InitializeComponent();
            this.fileBrowserWords.Dialog.Filter = "Word files|*.words|All files|*.*";
            this.fileBrowserFields.Dialog.Filter = "Field files|*.field|All files|*.*";
        }

        private void fileBrowser1_FileNameChanged(object sender, FileNameChangedEventArgs e)
        {
            var reader = new WordReader();
            this.words = reader.ReadAll(e.FileName);
            this.txtWords.Text = string.Join(Environment.NewLine, this.words);
        }

        private void fileBrowserFields_FileNameChanged(object sender, FileNameChangedEventArgs e)
        {
            var reader = new FieldReader();
            this.field = reader.Read(e.FileName);
            var sb = new StringBuilder();
            for (var row =0; row < this.field.Height; row++)
            {
                for (var column = 0; column < this.field.Width; column++)
                {
                    sb.Append($"{this.field.GetAt(row, column)} ");
                }
                sb.Append(Environment.NewLine);
            }
            this.txtWords.Text = sb.ToString();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            // Call one of Eddie's alogrithms
            // - Solution word
            // - Where were the words found (start coordinate and direction (dx, dy)
            // - Which words were NOT found
            // - Which words were found multiple times
            // - how many times were the words found

            IWordSeekerSolver solver = new MauriceSolver();

            var solution = solver.Solve(this.field, this.words);
            var sb = new StringBuilder();

            foreach (var word in solution.Words)
            {
                sb.AppendLine($"{word.Key}: {word.Value.Count}");
            }

            sb.AppendLine($"Solution word: {solution.SolutionWord}");
            this.txtWords.Text = sb.ToString();
        }
    }
}
