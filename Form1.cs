using System;
using System.IO;
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

        private string FormatBytes(long bytes)
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

        private void ExportPlaylists (object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.Desktop;
            dialog.ShowNewFolderButton = true;
            dialog.Description = "Select the output folder for the exported playlist";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string exportFolder = dialog.SelectedPath + '\\';

                foreach(MusicTabPage page in MusicFolders)
                {
                    foreach(MusicListViewItem item in page.musicListView.Items)
                    {
                        FileInfo file = new FileInfo(item.filePath);
                        string newFileName = TrimFileName(file.Name);

                        if (File.Exists(exportFolder + newFileName))
                            continue;
                        else
                            file.CopyTo(exportFolder + newFileName);
                        
                    }
                }
            }
        }

        private string TrimFileName(string fileName)
        {
            string name = fileName.Substring(0, fileName.LastIndexOf('.'));
            string extension = fileName.Substring(fileName.LastIndexOf('.'));

            // Trim whitespace from name
            name = name.Trim();
            int startChar = 0;
            
            foreach (char c in name)
            {
                if (Char.IsLetter(c) || c == '(')
                    break;
                else
                    startChar++; ;
            }

            if (startChar < (name.Length - 1))
                name = name.Substring(startChar);

            int endChar = name.Length - 1;
            while (endChar != 0)
            {
                if (Char.IsLetter(name[endChar]) || name[endChar] == ')')
                    break;
                else
                    endChar--;
            }

            if (endChar > 0)
                name = name.Substring(0, endChar + 1);

            if (fileName == "_45_.mp3")
                Console.WriteLine(fileName);

            fileName = name + extension;

            return fileName;
        }
    }
}
