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

namespace OptimisationTasksEditor
{
    /// <summary>
    /// Interaction logic for HelloPage.xaml
    /// </summary>
    public partial class HelloPage : Page
    {
        public HelloPage()
        {
            InitializeComponent();
        }



        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this).Navigate(new Uri("OneDimesionalTaskDefinition.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnLinear_Click ( object sender, RoutedEventArgs e )
        {
            NavigationService.GetNavigationService(this).Navigate(new Uri("LinearOptimizationTaskDefinition.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
