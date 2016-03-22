using DAL.Models;
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

            cvsListBox.Items.Add(new CV() {
                BirthDate = DateTime.Now,
                City = "CityIzhevsk",
                Education = "Educ",
                ExpAmount = ExpAmount.From1To3,
                Link = "http://aaa.ru",
                Name = "NameAlexus",
                Position = "Programmer",
                Salary = 100000,
                Skills = "Can all"
            });
        }

        private void SalaryTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            long a;
            var sen = (TextBox)sender;
            e.Handled = !IsTextAllowed(e.Text) || (!String.IsNullOrEmpty(sen.Text) && !long.TryParse(sen.Text, out a ));
        }

        private bool IsTextAllowed(string text)
        {
            Regex regex = new Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            long salaryMax = 0;
            long ageMin = 0;
            long ageMax = 0;
            ExpAmount exp;

            var searchStrs = SearchStringTextBox.Text.ToLower().Split(' ', ',').Where(m => !String.IsNullOrWhiteSpace(m)).ToList();

            Expression<Func<CV, bool>> predicate = cv =>
                searchStrs.Count == 0 || searchStrs.Any(m => cv.Name.ToLower().Contains(m)
                    || cv.Position.ToLower().Contains(m)
                    || cv.Skills.ToLower().Contains(m)
                    || cv.City.ToLower().Contains(m)
                    || cv.Education.ToLower().Contains(m));
            
            
            var compiled = predicate.Compile();
            //exp = i => compiled(i) && i % 2 == 0;

            
            if (SalaryTextBox.IsEnabled && !String.IsNullOrWhiteSpace(SalaryTextBox.Text))
            {
                long.TryParse(SalaryTextBox.Text, out salaryMax);
                predicate = cv => compiled(cv) && cv.Salary <= salaryMax;
                compiled = predicate.Compile();
            }

            if (ageMinTextBox.IsEnabled && !String.IsNullOrWhiteSpace(ageMinTextBox.Text))
            {
                long.TryParse(ageMinTextBox.Text, out ageMin);

                var date = DateTime.Now.Subtract(TimeSpan.FromDays(365 * ageMin));
                predicate = cv => compiled(cv) && cv.BirthDate.HasValue && cv.BirthDate.Value > date;
                compiled = predicate.Compile();
            }

            if (ageMaxTextBox.IsEnabled && !String.IsNullOrWhiteSpace(ageMaxTextBox.Text))
            {
                long.TryParse(ageMaxTextBox.Text, out ageMax);

                var date = DateTime.Now.Subtract(TimeSpan.FromDays(365 * ageMax));
                predicate = cv => compiled(cv) && cv.BirthDate.HasValue && cv.BirthDate.Value < date;
                compiled = predicate.Compile();
            }

            var sel = int.Parse(((ComboBoxItem)expComboBox.SelectedItem).Tag.ToString());
            if (sel > -1)
            {
                exp = (ExpAmount)sel;
                predicate = cv => compiled(cv) && cv.ExpAmount == exp;
                compiled = predicate.Compile();
            }

            var cvs = new List<CV>();
            using (var uow = new UnitOfWork())
            {
                cvs = uow.CVs.Find(compiled).ToList();
            }

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
