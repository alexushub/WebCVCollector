using DAL.Models;
using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
using System.Windows.Shapes;

namespace WebCVCollector.Forms
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        public bool SalaryChecked { get; set; }
        public bool minAgeChecked { get; set; }
        public bool maxAgeChecked { get; set; }

        public SearchWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SearchStringTextBox.Focus();
            SalaryTextBox.IsEnabled = false;
            ageMaxTextBox.IsEnabled = false;
            ageMinTextBox.IsEnabled = false;

            using (var uow = new UnitOfWork())
            {
                var cnt = uow.CVs.Count();//.Find(preBuilder).ToList();
                totalLabel.Content = "Total in Db: " + cnt;
            }

            
        }

        private void SalaryTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            long num;
            var sen = (TextBox)sender;
            e.Handled = !long.TryParse(sen.Text + e.Text, out num);

            //e.Handled = !IsTextAllowed(e.Text);// || (!String.IsNullOrWhiteSpace(sen.Text) && !long.TryParse(sen.Text, out a ));
        }

        private bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9]");
            return !regex.IsMatch(text);
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            long salaryMax = 0;
            long ageMin = 0;
            long ageMax = 0;
            ExpAmount exp;

            var searchStrs = SearchStringTextBox.Text.ToLower().Split(' ', ',').Where(m => !String.IsNullOrWhiteSpace(m)).ToList();

            var preBuilder = PredicateBuilder.True<CV>();

            if (searchStrs.Count != 0)
            {
                foreach (var str in searchStrs)
                {
                    preBuilder = preBuilder.And(cv => cv.Name.ToLower().Contains(str)
                    || cv.Position.ToLower().Contains(str)
                    || cv.Skills.ToLower().Contains(str)
                    || cv.City.ToLower().Contains(str)
                    || cv.Education.ToLower().Contains(str));
                }
            }

            if (SalaryTextBox.IsEnabled && !String.IsNullOrWhiteSpace(SalaryTextBox.Text))
            {
                long.TryParse(SalaryTextBox.Text, out salaryMax);

                preBuilder = preBuilder.And(cv => cv.Salary <= salaryMax);
            }

            if (ageMinTextBox.IsEnabled && !String.IsNullOrWhiteSpace(ageMinTextBox.Text))
            {
                long.TryParse(ageMinTextBox.Text, out ageMin);

                var date = DateTime.Now.Subtract(TimeSpan.FromDays(365 * ageMin));

                preBuilder = preBuilder.And(cv => cv.BirthDate.HasValue && cv.BirthDate.Value <= date);
            }

            if (ageMaxTextBox.IsEnabled && !String.IsNullOrWhiteSpace(ageMaxTextBox.Text))
            {
                long.TryParse(ageMaxTextBox.Text, out ageMax);

                var date = DateTime.Now.Subtract(TimeSpan.FromDays(365 * ageMax));

                preBuilder = preBuilder.And(cv => cv.BirthDate.HasValue && cv.BirthDate.Value >= date);
            }

            var sel = int.Parse(((ComboBoxItem)expComboBox.SelectedItem).Tag.ToString());
            if (sel > -1)
            {
                exp = (ExpAmount)sel;

                preBuilder = preBuilder.And(cv => cv.ExpAmount == exp);
            }

            var cvs = new List<CV>();
            using (var uow = new UnitOfWork())
            {
                cvs = uow.CVs.Find(preBuilder).ToList();
            }

            resultLabel.Content = "Result: " + cvs.Count;

            cvsListBox.Items.Clear();
            cvs.ForEach(a => cvsListBox.Items.Add(a));
        }

        private void salaryCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SalaryTextBox.IsEnabled = salaryCheckBox.IsChecked.Value;
            ageMaxTextBox.IsEnabled = ageMaxCheckBox.IsChecked.Value;
            ageMinTextBox.IsEnabled = ageMinCheckBox.IsChecked.Value;
        }
    }
}
