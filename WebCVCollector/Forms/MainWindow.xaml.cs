using DAL.Models;
using Microsoft.Practices.ServiceLocation;
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
using WebPageParser.Interfaces;
using WebPageParser.Parsers;

namespace WebCVCollector.Forms
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

        private void CollectBtn_Click(object sender, RoutedEventArgs e)
        {
            //string url = Properties.Settings.Default.CVUrl;
            MessageBox.Show("CV collertor starts working. It can takes a few minutes! Please, wait!", "Attention!");

            var parser = ServiceLocator.Current.GetInstance<IWebPageParser>();

            var cvs = parser.GetCvs();

            using (var uow = new UnitOfWork())
            {
                uow.CVs.AddRange(cvs);
                uow.Complete();
            }
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            var searchWind = new SearchWindow();
            searchWind.ShowDialog();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {

            await Task.Run(() =>
            {
                using (var cont = new CVDbContext())
                {
                    cont.Database.Initialize(true);
                }
            });

            initLabel.Visibility = Visibility.Hidden;
        }
    }
}
