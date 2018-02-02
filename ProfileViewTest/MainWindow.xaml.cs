using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ProfileViewTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += PageLoaded;
        }

        public void PageLoaded(object sender, RoutedEventArgs e)
        {
            IEnumerable<String> filesD = GetAllFiles("D:\\Ricky\\Documents\\", "*.txt");
            IEnumerable<String> filesC = GetAllFiles("C:\\Users\\Ricky\\source\\", ".txt");
            IEnumerable<String> filesPath = filesC.Concat(filesD);
            IEnumerable<String> files = Enumerable.Empty<String>();

            foreach (string fileName in filesPath)
            {
                files = files.Concat(new[] {System.IO.Path.GetFileNameWithoutExtension(fileName) } );
            }

            foreach (string fileName in files)
            {
                fileView.Items.Add(fileName);
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



    }
}
