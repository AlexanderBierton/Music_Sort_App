using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Music_Sort
{
    class MusicListView : ListView
    {
        private string folderPath;
        private List<MusicListViewItem> musicListViewItems;

        public long FolderSize = 0;

        public MusicListView(string folderPath)
            : base()
        {
            if (Directory.Exists(folderPath))
                this.folderPath = folderPath;
            else
                throw new DirectoryNotFoundException();

            musicListViewItems = new List<MusicListViewItem>();

            this.View = View.Details;
            this.AllowColumnReorder = false;
            
            ColumnHeader headerFirst = new ColumnHeader();
            ColumnHeader headerSecond = new ColumnHeader(); 

            // Set the text, alignment and width for each column header.
            headerFirst.Text = "Name";
            headerFirst.TextAlign = HorizontalAlignment.Left;

            headerSecond.TextAlign = HorizontalAlignment.Left;
            headerSecond.Text = "Status";
            
            this.Columns.Add(headerFirst);
            this.Columns.Add(headerSecond);

            //this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //this.GetFolderMusic();

           // this.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        public void GetFolderMusic()
        {
            if (folderPath.Length == 0)
                throw new Exception("No folder has been given to this list");
            
            if(this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    DirectoryInfo info = new DirectoryInfo(this.folderPath);

                    foreach (FileInfo file in info.EnumerateFiles())
                    {
                        MusicListViewItem musicItem = new MusicListViewItem(file.FullName);

                        this.Items.Add(musicItem);
                        this.FolderSize += file.Length;
                    }
                }));
            }
            else
            {
                DirectoryInfo info = new DirectoryInfo(this.folderPath);

                foreach (FileInfo file in info.EnumerateFiles())
                {
                    MusicListViewItem musicItem = new MusicListViewItem(file.FullName);

                    this.Items.Add(musicItem);
                    this.FolderSize += file.Length;
                }
            }
        }
    }
}