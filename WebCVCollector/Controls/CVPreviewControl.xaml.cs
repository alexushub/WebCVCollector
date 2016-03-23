using DAL.Models;
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

namespace WebCVCollector.Controls
{
    /// <summary>
    /// Interaction logic for CVPreviewControl.xaml
    /// </summary>
    public partial class CVPreviewControl : UserControl
    {
        public CVPreviewControl()
        {
            InitializeComponent();
            
        }

        private void UserControl_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var send = (CVPreviewControl)sender;
            var cv = (CV)send.DataContext;

            System.Diagnostics.Process.Start(cv.Link);
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var cv = (CV)this.DataContext;
            expLabel.Content = DALConstants.expAmountDisplay[(int)cv.ExpAmount];
        }
    }
}
