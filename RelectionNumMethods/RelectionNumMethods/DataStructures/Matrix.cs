using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace RelectionNumMethods.DataStructures
{
    public class Matrix
    {
        private double[,] array;

        public double this [ int i, int j ]
        {
            get { return array [ i, j ]; }
            set { array [ i, j ] = value; }
        }
        public int Rows { get; }
        public int Columns { get; }
        public Matrix (int rows, int columns )
        {
            Contract.Requires((rows > 0)&&(columns>0));
            array = new double [ rows, columns ];
            Rows = rows;
            Columns = columns;      
        }
        public Matrix (double[,] arr)
        {   Rows = arr.GetLength(0);
            Columns = arr.GetLength(1);
            array = new double [ Rows, Columns ];
            for (int i = 0 ; i<Rows; i++ )
            {
                for ( int j = 0 ; j < Columns ; j++ )
                {
                    array [ i, j ] = arr [ i, j ];
                }
            }
        }
        public static Matrix operator+(Matrix A, Matrix B)
        {
            Contract.Requires<ArithmeticException>(( A.Rows == B.Rows ) && ( A.Columns == B.Columns ));
            var rows = A.Rows;
            var colums = A.Columns;
            Matrix C = new Matrix(rows, colums);
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                   C[i,j] =  A [ i, j ] + B [ i, j ];
                }
                
            }
            return C;
        }
          public static Matrix operator-(Matrix A, Matrix B)
        {
            Contract.Requires<ArithmeticException>(( A.Rows == B.Rows ) && ( A.Columns == B.Columns ));
            var rows = A.Rows;
            var colums = A.Columns;
         
            Matrix C = new Matrix(rows, colums);
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                   C[i,j] = A [ i, j ] - B [ i, j ];
                }
            }
            return C;
        }

        public static Matrix operator*(double num, Matrix A)
        {
            Matrix B = new Matrix(A.Rows, A.Columns);
            for ( int i = 0 ; i < A.Rows ; i++ )
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    B [ i, j ] = num * A [ i, j ];
                }
            return B;
        }
        public static Matrix operator* ( Matrix A, double num )
        {
            Matrix B = new Matrix(A.Rows, A.Columns);
            for ( int i = 0 ; i < A.Rows ; i++ )
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    B [ i, j ] = num * A [ i, j ];
                }
            return B;
        }

        public Matrix Transpose ( )
        {
            Matrix T = new Matrix(Columns, Rows);
            for ( int i = 0 ; i < Rows ; i++ )
                
            {
                for ( int j = 0 ; j < Columns ; j++ )
                {
                    T [ i, j ] = this [ j, i ];
                }
            }
            Contract.Ensures(( Contract.Result<Matrix>().Columns == this.Rows ) && ( Contract.Result<Matrix>().Rows == this.Columns));
            return T;
        }
    }
    public class DiagonalMatrix:Matrix
    {
        public DiagonalMatrix (int rows, int columns, double diagElemVal):base(rows,columns)
        {
            for ( int i = 0 ; i < Rows ; i++ )
            {
                for ( int j = 0 ; j < Columns ; j++ )
                {
                    var val = ( i == j ? diagElemVal : 0);
                    this [ i, j ] = val;   
                    
                }
            }
        }
    }
}
