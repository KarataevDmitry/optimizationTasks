using System;
using System.Collections.Generic;
using System.Data;
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
using OptimisationTasks.DataStructures.LinearProgramming;
using OptimisationTasks.OptimisationMethods.Linear;
using System.Windows.Forms;
using OptimisationTasks.Optimisation.Linear;

namespace OptimisationTasksEditor
{
    /// <summary>
    /// Логика взаимодействия для LinearOptimizationTaskDefinition.xaml
    /// </summary>
    public partial class LinearOptimizationTaskDefinition : Page
    {
        public LinearOptimizationTaskDefinition ( )
        {
            InitializeComponent();
        }

        private void btnCreateMatrix_Click ( object sender, RoutedEventArgs e )
        {
            DataGridView dg = new System.Windows.Forms.DataGridView();
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            int rowCount = Convert.ToInt32(tbxRowCount.Text);
            int colCount = Convert.ToInt32(tbxColCount.Text);
            OptimisationTasks.DataStructures.LinearProgramming.Matrix m = new OptimisationTasks.DataStructures.LinearProgramming.Matrix(rowCount, colCount);
#if GUIApp
            m.WriteToDataGrid(dg);
#endif

            dg.Columns [ 0 ].HeaderText = "B";
            for ( int i = 1 ; i < dg.ColumnCount ; i++ )
            {
                dg.Columns [ i ].HeaderText = $"x{i}";
            }
            dg.Rows [ dg.RowCount - 1 ].HeaderCell.Value = "f(X)";
            for ( int i = 0 ; i < dg.ColumnCount ; i++ )
            {
                dg.Columns [ i ].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dg.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dg.ColumnHeadersVisible = true;
            dg.RowHeadersVisible = true;
            dg.AutoResizeColumns();
            dg.AutoResizeRows();
            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dg.ColumnHeadersDefaultCellStyle = cs;
            dg.DefaultCellStyle = cs;
            winforms.Child = dg;
             
        }

        private void btnSolve_Click ( object sender, RoutedEventArgs e )
        {
            DataGridView dg = ( (DataGridView) winforms.Child );
            OptimisationTasks.DataStructures.LinearProgramming.Matrix m = new OptimisationTasks.DataStructures.LinearProgramming.Matrix(dg.RowCount, dg.ColumnCount);
#if GUIApp
            m.ReadFromDataGrid(dg);
#endif
            LinearTask lt = new LinearTask(m);
            SimplexOptimizer S = new SimplexOptimizer();
            StringBuilder sb = new StringBuilder();
            double [ ] res = lt.Optimize(S);
            foreach ( var item in res )
            {
                sb.Append(item);
                sb.Append(";");
            }
            System.Windows.MessageBox.Show(sb.ToString());
 
        }
    }
}
