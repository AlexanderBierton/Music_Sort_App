using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Music_Sort
{
    public partial class Form1 : Form
    {
        List<MusicTabPage> MusicFolders;
        public Form1()
        {
            InitializeComponent();
            MusicFolders = new List<MusicTabPage>();
        }

        private void AddFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddNewTab(dialog.SelectedPath);
            }
        }

        private void AddNewTab(string Path, string Name = "")
        {
            if (Name.Length == 0)
                Name = Path.Substring(Path.LastIndexOf('\\') + 1);
            MusicTabPage newTabPage = new MusicTabPage(Name, Path);

            directoryTabContainer.TabPages.Add(newTabPage);
            MusicFolders.Add(newTabPage);
            directoryTabContainer.SelectedIndex = directoryTabContainer.TabCount - 1;
            this.GetFolderOverview();
        }

        private void OnTabChanged(object sender, EventArgs e)
        {
            this.GetFolderOverview();
        }

        private void GetFolderOverview(int index = -1)
        {
            if (index == -1)
                index = directoryTabContainer.SelectedIndex;

            int fileCount = MusicFolders[index].FileCount;
            long folderSize = MusicFolders[index].FolderSize;

            lblFolderCount.Text = fileCount.ToString();
            Console.WriteLine(folderSize / 1024);
            lblFolderSize.Text = FormatBytes(folderSize);
        }

        private static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
