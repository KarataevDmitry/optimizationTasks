using Microsoft.Win32;
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
using System.Xml.Linq;
using OptimisationTasks.FileOperations;
using OptimisationTasks.DataStructures;
using OptimisationTasks.OptimisationMethods;
using OptimisationTasks.Utilites;

namespace OptimisationTasksEditor
{
    /// <summary>
    /// Interaction logic for OneDimesionalTaskDefinition.xaml
    /// </summary>
    public partial class OneDimesionalTaskDefinition : PageFunction<String>
    {
        public OneDimesionalTaskDefinition()
        {
            InitializeComponent();
        }

        private void btnSaveTo_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog()
            {
                Filter = "XML Documents |*.xml"
            };
            OptKind d = OptKind.NotSet;
                if ( rbMaximize.IsChecked.Value )
                    d = OptKind.Maximum;
                if ( rbMinimize.IsChecked.Value )
                    d = OptKind.Minimum;
                if ( sd.ShowDialog() == true )
                    TaskWriter.WriteTaskToFile(new Task1D(tbxFunction.Text, d, tbxVarName.Text, new Interval(tbxOptInterval.Text)), sd.FileName);
            
            
        }

        private void btnLoadFrom_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "XML Documents |*.xml";
            if (of.ShowDialog()==true)
            {
                Task1D t = TaskReader.ReadTaskFromFile(of.FileName);
                tbxFunction.Text = t.TargetFunction;
                tbxVarName.Text = t.VariableName;
                if (t.OptimumType == OptKind.Maximum) rbMaximize.IsChecked = true;
                if (t.OptimumType == OptKind.Minimum) rbMinimize.IsChecked = true;
                tbxOptInterval.Text = t.OptimumInterval.ToString();
            }
        }

        private void btnOptimise_Click(object sender, RoutedEventArgs e)
        {
            OptKind o = OptKind.NotSet;
            if (rbMaximize.IsChecked.Value) o = OptKind.Maximum;
            if (rbMinimize.IsChecked.Value) o = OptKind.Minimum;
            Task1D t = new Task1D(tbxFunction.Text, o, tbxVarName.Text, new Interval(tbxOptInterval.Text));
            if (cbMethod.Text=="Золотое сечение")
            {
                GoldenPropOptimisator gp = new GoldenPropOptimisator();
                double? result = gp.Optimise(t);
                if (result.HasValue) MessageBox.Show($"Оптимум достигается в точке {result}");
                else MessageBox.Show("На введеном промежутке нет локального оптимума");
            }
        }
    }
}
