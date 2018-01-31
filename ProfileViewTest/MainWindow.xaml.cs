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
            string[] fileEntries = Directory.GetFiles(@"C:\Users\Ricky\Documents\");


            foreach (string fileName in fileEntries)
            {
                fileView.Items.Add(fileName);
            }
                
        }

    }
}
