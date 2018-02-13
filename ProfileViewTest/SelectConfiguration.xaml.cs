using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProfileViewTest
{
    /// <summary>
    /// Interaction logic for SelectConfiguration.xaml
    /// </summary>
    public partial class SelectConfiguration : Window
    {
        public SelectConfiguration()
        {
            InitializeComponent();

            Loaded += PageLoaded;
        }

        public void PageLoaded(object sender, RoutedEventArgs e)
        {
            listConfigs();

        }







        public void listConfigs()
        {
            IEnumerable<String> filesAll = Enumerable.Empty<String>();
            IEnumerable<String> filesAllPath = Enumerable.Empty<String>();

            fileView.Items.Clear();

            /*
            DriveInfo[] drives = DriveInfo.GetDrives();
            
            foreach (var drive in drives)
            {

                DriveType driveType = drive.DriveType;

                if (driveType == DriveType.Fixed)
                {
                    string driveName = drive.Name;

                    string startPath;
                    

                    if (driveName == "C:\\")
                    {
                        string userName = Environment.UserName;
                        startPath = driveName + "Users\\" + userName + "\\";
                        
                    }
                    else
                    {
                        startPath = driveName;
                    }

                    IEnumerable<String> filesCurrentPath = GetAllFiles(startPath, "*.pbix");

                    if (isNotNullOrEmpty(filesCurrentPath))
                    {
                        filesAllPath = filesAllPath.Concat(filesCurrentPath);
                    }

                }
                
            }
            */

            string configFolder = "D:\\Documents\\PVAppTest\\";
            filesAllPath = GetAllFiles(configFolder, "*.txt");

            if (isNotNullOrEmpty(filesAllPath))
            {
                foreach (string fileName in filesAllPath)
                {

                    filesAll = filesAll.Concat(new[] { System.IO.Path.GetFileNameWithoutExtension(fileName) });
                }


                foreach (string fileName in filesAll)
                {
                    fileView.Items.Add(fileName);
                }
            }
            else
            {
                fileView.Items.Add("*NO CONFIGURATIONS FOUND*");
                buttonSelect.IsEnabled = false;
                fileView.IsEnabled = false;

            }
        }

        IEnumerable<String> GetAllFiles(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern).Union(
                System.IO.Directory.EnumerateDirectories(path).SelectMany(d =>
                {
                    try
                    {
                        return GetAllFiles(d, searchPattern);
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        return Enumerable.Empty<String>();
                    }
                }));
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - (e.Delta/3));
            e.Handled = true;
        }

        public bool isNotNullOrEmpty (IEnumerable<string> enumerator)
        {
            if (enumerator != null && enumerator.Any() && enumerator.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void menuItemExit_Click(object sender, RoutedEventArgs e)
        {
            string quit = System.Windows.Forms.MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();

            if (quit == "Yes")
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            listConfigs();
        }
    }
}
