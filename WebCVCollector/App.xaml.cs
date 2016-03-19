using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WebPageParser.Parsers;
using WebPageParser.Interfaces;
using Microsoft.Practices.ServiceLocation;
using DAL.Models;

namespace WebCVCollector
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            string url = ConfigurationManager.AppSettings["CVUrl"];// Properties.Settings.Default.CVUrl;

            IUnityContainer container = new UnityContainer();
            container.RegisterType<IWebPageParser, E1Parser>(new InjectionConstructor(url));

            ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));
            //MainWindow mainWindow = container.Resolve<MainWindow>();
            //mainWindow.Show();

            using (var cont = new CVDbContext())
            {
                cont.Database.Initialize(true);
            }
        }
    }
}
