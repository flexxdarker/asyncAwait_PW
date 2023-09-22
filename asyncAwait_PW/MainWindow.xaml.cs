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

namespace asyncAwait_PW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static class Info
        {
            public static List<string> pathToFile { get; set; }
            public static List<int> count { get; set; }
            public static List<string> nameOfFile { get; set; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void SearchWordInFile(string word, string path)
        {
            int countTimes = 0;
            string[] allFiles = Directory.GetFiles(path, SearchOption.AllDirectories);
            foreach(var file in allFiles)
            {
                if(file.Contains(word))
                {
                    countTimes++;

                }
                count.Add(countTimes);
            }
        }
    }
}