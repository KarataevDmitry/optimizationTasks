using System;
using System.Collections;
using System.ComponentModel;
#if GUIApp
using System.Windows.Forms;
#endif

namespace OptimisationTasks.DataStructures.LinearProgramming
{
    public sealed class Matrix: IEnumerable
    {
        private double[,] data;

        public event PropertyChangedEventHandler MatrixChanged;
        public void RaiseMatrixChanged(string propName)
        {
            if ( this.MatrixChanged != null )
                MatrixChanged(this, new PropertyChangedEventArgs(propName));
        }
        public double this [ int row, int col ]
        {
            get { return data [ row, col ]; }

            set
            {
                data [ row, col ] = value;
                RaiseMatrixChanged("matrixData");         
            }
        }

        public int Count => RowCount*ColCount;

        public bool IsFixedSize => data.IsFixedSize;

        public bool IsReadOnly => data.IsReadOnly;
        public int RowCount => data.GetLength(0);
        public int ColCount => data.GetLength(1);
        public Matrix ( double [ , ] arr )
        {
            data = new double [ arr.GetLength(0), arr.GetLength(1) ];
            for ( int i = 0 ; i < RowCount ; i++ )
            {
                for ( int j = 0 ; j < ColCount ; j++ )
                {
                    data [ i, j ] = arr [ i, j ];
                }
            }
        }
        public Matrix (int rows, int cols )
        {
            data = new double [ rows, cols ];
            for ( int i = 0 ; i < RowCount ; i++ )
            {
                for ( int j = 0 ; j < ColCount ; j++ )
                {
                    data [ i, j ] = 0;
                }
            }
        }


        IEnumerator IEnumerable.GetEnumerator ( ) => data.GetEnumerator();
#if GUIApp
        public void WriteToDataGrid ( DataGridView dg )
        {
            dg.RowCount = RowCount;
            dg.ColumnCount = ColCount;
            for ( int i = 0 ; i < RowCount ; i++ )
                for ( int j = 0 ; j < ColCount ; j++ )
                {
                    dg.Rows [ i ].Cells [ j ].Value = data [ i, j ];
                }
        }
        public void ReadFromDataGrid ( DataGridView dg )
        {
            data = new double [ dg.RowCount, dg.ColumnCount ];
            for ( int i = 0 ; i < RowCount ; i++ )
                for ( int j = 0 ; j < ColCount ; j++ )
                {
                    data [ i, j ] = Convert.ToDouble(dg.Rows [ i ].Cells [ j ].Value);
                }
        }
#endif
        public double[,] ToArray()
        {
            double [ , ] arr = new double [ data.GetLength(0), data.GetLength(1) ];
            for ( int i = 0 ; i < data.GetLength(0) ; i++ )
            {
                for ( int j = 0 ; j < data.GetLength(1) ; j++ )
                {
                    arr [ i, j ] = data [ i, j ];
                }
            };
            return arr;
        } 
    }
   
};
