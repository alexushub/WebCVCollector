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

namespace WebCVCollector
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

            var parser = ServiceLocator.Current.GetInstance<IWebPageParser>();

            var cvs = parser.GetCvs();

            using (var uow = new UnitOfWork())
            {
                uow.CVs.AddRange(cvs);
                uow.Complete();
            }
        }
    }
}
