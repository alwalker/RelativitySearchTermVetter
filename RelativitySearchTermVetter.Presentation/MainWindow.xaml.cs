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
using RelativitySearchTermVetter.Business;
using System.Collections.ObjectModel;

namespace RelativitySearchTermVetter.Presentation
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

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            //var loadWindow = new NewLoadWindow();
            //loadWindow.ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var terms = new List<Term>();
            var loadWindow = new NewLoadWindow(terms);
            loadWindow.ShowDialog();

            var itemCollectionViewSource = (CollectionViewSource)(FindResource("ItemCollectionViewSource"));
            itemCollectionViewSource.Source = new ObservableCollection<Term>(terms);
        }
    }
}
