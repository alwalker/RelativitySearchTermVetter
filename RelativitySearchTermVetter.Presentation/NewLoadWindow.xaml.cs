using RelativitySearchTermVetter.Business;
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
using System.Windows.Shapes;

namespace RelativitySearchTermVetter.Presentation
{
    /// <summary>
    /// Interaction logic for NewLoadWindow.xaml
    /// </summary>
    public partial class NewLoadWindow : Window
    {
        private IList<Term> _terms;

        public NewLoadWindow(IList<Term> terms)
        {
            _terms = terms;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTerms.Text))
            {
                MessageBox.Show(
                    "You haven't entered any search terms! Please either enter some into the text box, load them from a file, or open an existin project.",
                    "No Terms!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Stop);
                return;
            }

            _terms = LoadTerms(txtTerms.Text, _terms);
            Close();
        }

        private IList<Term> LoadTerms(String source, IList<Term> terms)
        {
            foreach (var rawTerm in source.Split('\n'))
            {
                if (!String.IsNullOrEmpty(rawTerm))
                {
                    terms.Add(new Term(rawTerm));
                }
            }

            return terms;
        }

        private void btnLoadProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
