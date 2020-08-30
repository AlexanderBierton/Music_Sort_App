using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Music_Sort
{
    class MusicListViewItem : ListViewItem
    {
        public enum FileStatus
        {
            Unset = 0,
            InProgress = 1,
            Complete = 2
        }

        public string filePath { get; }
        public string fileName { get;  }

        private FileStatus _fileStatus;
        public FileStatus CurrentStatus { get { return _fileStatus; } }
        

        public MusicListViewItem(string filePath)
            : base()
        {
            if (File.Exists(filePath))
                this.filePath = filePath;
            else
                throw new FileNotFoundException();

            this.fileName = filePath.Substring(filePath.LastIndexOf('\\') + 1);
            this._fileStatus = FileStatus.Unset;
            this.SetUp();
        }

        private void SetUp()
        {
            this.SubItems.Add(this.fileName);
            this.SubItems[0].Text = this.fileName;
            this.SubItems[1].Text = _fileStatus.ToString();
            
        }

    }
}
