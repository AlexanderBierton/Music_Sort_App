using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Music_Sort
{
    class MusicTabPage : TabPage
    {
        public MusicListView musicListView;
        public long FolderSize = 0;
        public int FileCount = 0;

        public string FolderPath;

        public MusicTabPage(string name, string folderPath)
            : base()
        {
            this.Name = name;
            this.Text = name;
            this.FolderPath = folderPath;

            musicListView = new MusicListView(folderPath);
            musicListView.Dock = DockStyle.Fill;
            musicListView.Width = this.Width;
            musicListView.Height = this.Height;

            this.Controls.Add(musicListView);

            this.PopulateListView();
        }

        private void PopulateListView()
        {
            if (musicListView.InvokeRequired)
            {
                musicListView.Invoke(new MethodInvoker(delegate
                {
                    DirectoryInfo info = new DirectoryInfo(this.FolderPath);

                    foreach (FileInfo file in info.EnumerateFiles())
                    {
                        this.FolderSize += file.Length;
                        if (file.Extension == ".mp3")
                        {
                            MusicListViewItem musicItem = new MusicListViewItem(file.FullName);

                            musicListView.Items.Add(musicItem);
                            
                            this.FileCount += 1;
                        }
                    }
                }));
            }
            else
            {
                DirectoryInfo info = new DirectoryInfo(this.FolderPath);

                foreach (FileInfo file in info.EnumerateFiles())
                {
                    this.FolderSize += file.Length;
                    if (file.Extension == ".mp3")
                    {
                        MusicListViewItem musicItem = new MusicListViewItem(file.FullName);

                        musicListView.Items.Add(musicItem);
                        
                        this.FileCount += 1;
                    }
                }
            }
            
        }
    }
}
