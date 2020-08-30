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
        public List<MusicListViewItem> musicItems;
        public long FolderSize = 0;
        public int FileCount = 0;

        public string FolderPath;

        public MusicTabPage(string name, string folderPath)
            : base()
        {
            this.Name = name;
            this.Text = name;
            this.FolderPath = folderPath;
            this.musicItems = new List<MusicListViewItem>();

            musicListView = new MusicListView(folderPath);
            musicListView.Dock = DockStyle.Fill;
            musicListView.Width = this.Width;
            musicListView.Height = this.Height;

            musicListView.MouseDoubleClick += new MouseEventHandler(OnDoubleClick);

            this.Controls.Add(musicListView);

            this.PopulateListView();
        }

        public void OnDoubleClick(object sender, EventArgs args)
        {
            MusicListViewItem items = (MusicListViewItem) musicListView.SelectedItems[0];

            FileInfoDialog file = new FileInfoDialog(new FileInfo(items.filePath));
            file.ShowDialog(this);
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
                            musicItems.Add(musicItem);
                            
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
                        musicItems.Add(musicItem);

                        this.FileCount += 1;
                    }
                }
            }
            
        }
    }
}
