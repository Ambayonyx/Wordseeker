using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordSeeker
{
    public partial class FileBrowser : UserControl
    {

        public event EventHandler<FileNameChangedEventArgs> FileNameChanged;


        public string Label {
            get
            {
                var label = lblCaption.Text;
                return label.Substring(0, label.Length - 1);
            }
            set
            {
                lblCaption.Text = value + ":";
            }
        }

        public FileDialog Dialog
        {
            get { return this.dlgOpenFile; }
        }

        public FileBrowser()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.dlgOpenFile.ShowDialog();
        }

        private void dlgOpenFile_FileOk(object sender, CancelEventArgs e)
        {
            this.txtPath.Text = this.dlgOpenFile.FileName;
            OnFileNameChanged(new FileNameChangedEventArgs(this.dlgOpenFile.FileName));
        }

        protected virtual void OnFileNameChanged(FileNameChangedEventArgs e)
        {
            FileNameChanged?.Invoke(this, e);
        }
    }

    public class FileNameChangedEventArgs: EventArgs
    {
        public string FileName{ get; private set; }
        public FileNameChangedEventArgs(string fileName)
        {
            this.FileName = fileName;
        }
    }
}
