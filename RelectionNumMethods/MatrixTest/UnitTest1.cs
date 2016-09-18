using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RelectionNumMethods.DataStructures;

namespace MatrixTest
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [TestCategory("Arithmetical Operations")]
        public void AddTest ( )
        {
            Matrix A = new Matrix(new double [ 2, 2 ] { { 2, 1 }, { 1, 2 } });
            Matrix B = new Matrix(new double [ 2, 2 ] { { 1, 1 }, { 1, 1 } });
            Matrix C = A + B;
            Assert.AreEqual(3, C [ 0, 0 ]);
            Assert.AreEqual(2, C [ 0, 1 ]);
            Assert.AreEqual(2, C [ 1, 0 ]);
            Assert.AreEqual(3, C [ 1, 1 ]);
        }
    }
}
