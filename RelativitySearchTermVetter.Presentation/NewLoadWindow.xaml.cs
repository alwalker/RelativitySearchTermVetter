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
                    "You haven't entered any search terms! Please either enter some into the text box, load them from a file, or open an existing project.",
                    "No Terms!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Stop);
                return;
            }

            LoadTerms(new StringTermLoader(), txtTerms.Text);
            Close();
        }

        private void LoadTerms(TermLoader loader, String source)
        {
            loader.Load(_terms, source);
        }

        private void btnLoadProject_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLoadFromFile_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new Microsoft.Win32.OpenFileDialog();
            var result = openFileDialog.ShowDialog();

            if (result == true)
            {
                LoadTerms(new FileTermLoader(), openFileDialog.FileName);

                if (_terms.Count <= 0)
                {
                    MessageBox.Show(
                    "No terms found in file! Please choose a valid file, enter some manually, or choose an existing project.",
                    "No Terms!",
                    MessageBoxButton.OK,
                    MessageBoxImage.Stop);
                }
                else
                {
                    Close();
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
