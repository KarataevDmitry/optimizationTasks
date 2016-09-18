using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelectionNumMethods.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelectionNumMethods.DataStructures.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod()]
        public void AddTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix B = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix C = A + B;
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    Assert.AreEqual(C [ i, j ], 2);
                }
            }
        }

        [TestMethod()]
        public void SubTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix B = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix C = A - B;
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    Assert.AreEqual(0, C [ i, j ]);
                }
            }
        }
        [TestMethod]
        public void ChainAddTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix C = A + A;
            C = C + A;
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    Assert.AreEqual(3, C [ i, j ]);
                }
            }
        }
            [TestMethod]
        public void ChainSubstrTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix C = A - A;
            C = C - A;
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    Assert.AreEqual(-1, C [ i, j ]);
                }
            }
        }
        [TestMethod]
        public void MultNumLeftTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix B = 2 * A;
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    Assert.AreEqual(2, B [ i, j ]);
                }
            }
        }
        [TestMethod]
        public void MultNumRightTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix B = A*2;
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    Assert.AreEqual(2, B [ i, j ]);
                }
            }
        }
        [TestMethod]
        public void TransposeTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 1,2},
                                                        {2,3 } });
            Matrix C = A.Transpose();
            Assert.AreEqual(1, C [ 0, 0 ]);
            Assert.AreEqual(2, C [ 0, 1 ]);
            Assert.AreEqual(2, C [ 1, 0 ]);
            Assert.AreEqual(3, C [ 1, 1 ]);
        }
        [TestMethod]
        public void DiagCreationTest ( )
        {
            Matrix A = new DiagonalMatrix(2, 2, 2);
            for ( int i = 0 ; i < A.Rows ; i++ )
            {
                for ( int j = 0 ; j < A.Columns ; j++ )
                {
                    if ( i == j )
                        Assert.AreEqual(2, A [ i, j ]);
                    else
                        Assert.AreEqual(0, A [ i, j ]);
                }
            }
        }
    }
   
        
    }