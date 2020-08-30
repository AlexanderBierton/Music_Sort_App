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
        string CurrentActionFile;

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
                ShowProgressPanel("Transferring playlists", "Transferring");
                backgroundWorker.RunWorkerAsync(argument:  dialog.SelectedPath + '\\');
            }
        }

        private void ShowProgressPanel(string title, string action)
        {
            lblProgTitle.Text = title;
            lblProgAction.Text = action;

            progressBar.Maximum = 100;
            progressBar.Value = 0;
            progressBar.Step = 1;

            progressPanel.Visible = true;

        }

        private void HideProgressPanel()
        {
            progressPanel.Visible = false;
            lblProgTitle.Text = String.Empty;
            lblProgAction.Text = String.Empty;
            lblActionOn.Text = String.Empty;

            progressBar.Maximum = 100;
            progressBar.Value = 0;
            progressBar.Step = 1;
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

            fileName = name + extension;

            return fileName;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Do_Work(object sender, DoWorkEventArgs e)
        {
            string exportFolder = (string) e.Argument;
            int totalFiles = 0;
            foreach (MusicTabPage page in MusicFolders)
            {
                totalFiles += page.FileCount;
            }

            int fileCount = 0;
            foreach (MusicTabPage page in MusicFolders)
            {
                foreach (MusicListViewItem item in page.musicItems)
                {
                    FileInfo file = new FileInfo(item.filePath);
                    Action action = () => lblActionOn.Text = file.Name;
                    lblActionOn.Invoke(action);
                    CurrentActionFile = file.Name;
                    string newFileName = TrimFileName(file.Name);

                    if (File.Exists(exportFolder + newFileName))
                    {
                        fileCount++;
                        backgroundWorker.ReportProgress((fileCount * 100) / totalFiles);
                        continue;
                    } 
                    else
                    {
                        fileCount++;
                        backgroundWorker.ReportProgress((fileCount * 100) / totalFiles);
                        file.CopyTo(exportFolder + newFileName);
                    }
                }
            }
        }

        private void On_Progress_Changed(object sender, ProgressChangedEventArgs e)
        {
            //lblActionOn.Text = CurrentActionFile;
            progressBar.Value = e.ProgressPercentage;
        }

        private void On_Worker_Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(this, "Files Successfully Transferred", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
            HideProgressPanel();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
