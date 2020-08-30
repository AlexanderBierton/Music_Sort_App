using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Car_Music_Sort
{
    public partial class FileInfoDialog : Form
    {
        public FileInfoDialog(FileInfo file)
        {
            InitializeComponent();

            lblFileName.Text = file.Name;
            lblFilePath.Text = file.FullName;
            lblFileSize.Text = MusicHelper.FormatBytes(file.Length);
        }
    }
}
