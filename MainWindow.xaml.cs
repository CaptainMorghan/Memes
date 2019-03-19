using System;
using System.Collections.Generic;
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

namespace junk
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnClick_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int Song = rnd.Next(1, 2);
            

            if (Song == 1)
            {
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("CountryRoads.txt");
                    lblOutput.Content = "";
                    while (!sr.EndOfStream)
                    {
                        lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                    }
                }

            }
            else
            
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader("RickRoll.txt");
                    lblOutput.Content = "";
                    while (!sr.EndOfStream)
                    {
                        lblOutput.Content += sr.ReadLine() + Environment.NewLine;
                    }
                }
            

        }
    }
}

