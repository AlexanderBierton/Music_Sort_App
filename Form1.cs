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
        List<MusicListView> MusicLists;
        public Form1()
        {
            InitializeComponent();

            MusicLists = new List<MusicListView>();
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
            TabPage newTabPage = new TabPage(Name);

            MusicListView newListView = new MusicListView(Path);
            newListView.Dock = DockStyle.Fill;
            newListView.Width = newTabPage.Width;
            newListView.Height = newTabPage.Height;
            
            ListViewItem item = new ListViewItem();

            newTabPage.Controls.Add(newListView);
            MusicLists.Add(newListView);

            directoryTabContainer.TabPages.Add(newTabPage);
            directoryTabContainer.SelectedIndex = directoryTabContainer.TabCount - 1;
        }

    }
}
