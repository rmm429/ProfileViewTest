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

            IEnumerable<String> filesD = GetAllFiles("D:\\Ricky\\Documents\\", "*.cs");
            IEnumerable<String> filesC = GetAllFiles("C:\\Users\\Ricky\\source\\", "*.cs");
            IEnumerable<String> files = filesC.Concat(filesD);

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
