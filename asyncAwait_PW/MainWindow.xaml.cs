using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static class Infos
        {
            public static List<string> pathToFile = new List<string>();
            public static List<int> count = new List<int>();
            public static List<string> nameOfFile = new List<string>();
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
            string[] allFiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach(var file in allFiles)
            {
                string text = File.ReadAllText(file);
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Contains(word))
                    {
                        MatchCollection collection = Regex.Matches(text, "\bword\b");
                        countTimes = collection.Count;
                    }
                }
                
            }
            
        }
    }
}