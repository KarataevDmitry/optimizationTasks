using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using OptimisationTasks.DataStructures.LinearProgramming;
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
            dg.ColumnCount = colCount;
            dg.RowCount = rowCount;
            Matrix m = new Matrix(rowCount, colCount);
            m.WriteToDataGrid(dg);


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
            Matrix m = new Matrix(dg.RowCount, dg.ColumnCount);
            m.ReadFromDataGrid(dg);
            LinearTask lt = new LinearTask(m);
            SimplexOptimizer S = new SimplexOptimizer();
            StringBuilder sb = new StringBuilder();
            double [ ] res = lt.Optimize(S);
            if (double.IsNaN(res[0]))
            {
                System.Windows.MessageBox.Show("Задача не имеет решения ввиду неограниченности целевой функции.");
                return;
            }
            foreach ( var item in res )
            {
                sb.Append(item);
                sb.Append(";");
            }
            System.Windows.MessageBox.Show(sb.ToString());
 
        }
    }
}

