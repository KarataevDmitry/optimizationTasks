using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationTasks.OptimisationMethods.Linear;
using OptimisationTasks.Optimisation.Linear;
using OptimisationTasks.DataStructures.LinearProgramming;

namespace OptimisationTaskTests
{
    [TestClass]

    public class SimplexTest
    {
        [TestMethod]
        [TestCategory("Linear Optimization")]
        public void SimplexMethodTest()
        {
            double[,] table = { {25, -3,  5},
                                {30, -2,  5},
                                {10,  1,  0},
                                { 6,  3, -8},
                                { 0, -6, -5} };

            double[] result = new double[2];
            double[,] table_result;
            Simplex S = new Simplex(table);
            table_result = S.Calculate(result);
            double[] result_excepted = { 10, 10 };
            Assert.AreEqual(result_excepted[0], result[0]);
            Assert.AreEqual(result_excepted[1], result[1]);
        }
        [TestMethod]
        [TestCategory("Linear Optimization")]
        public void SimplexWrapperTest()
        {
            double[,] table = { {25, -3,  5},
                                {30, -2,  5},
                                {10,  1,  0},
                                { 6,  3, -8},
                                { 0, -6, -5} };

            double[] result = new double[2];
            SimplexOptimizer S = new SimplexOptimizer();
            result = S.CalcSolution(table); 
            double[] result_excepted = { 10, 10 };
            Assert.AreEqual(result_excepted[0], result[0]);
            Assert.AreEqual(result_excepted[1], result[1]);
        }
        [TestCategory("Linear Data Structure Test")]
        [TestMethod]
        public void LinearTaskTest ( )
        {
            double [ , ] table = { {25, -3,  5},
                                {30, -2,  5},
                                {10,  1,  0},
                                { 6,  3, -8},
                                { 0, -6, -5} };

            double [ ] result = new double [ 2 ];
            LinearTask lt = new LinearTask(table);
            SimplexOptimizer S = new SimplexOptimizer();
            result = lt.Optimize(S);
            double [ ] result_excepted = { 10, 10 };
            Assert.AreEqual(result_excepted [ 0 ], result [ 0 ]);
            Assert.AreEqual(result_excepted [ 1 ], result [ 1 ]);
        }
        [TestMethod]
        [TestCategory("Linear Optimization")]
        public void MatrixTaskTest ( )
        {
            double [ , ] table = { {25, -3,  5},
                                {30, -2,  5},
                                {10,  1,  0},
                                { 6,  3, -8},
                                { 0, -6, -5} };
            Matrix m = new Matrix(table);
            double [ ] result = new double [ 2 ];
            LinearTask lt = new LinearTask(m);
            SimplexOptimizer S = new SimplexOptimizer();
            result = lt.Optimize(S);
            double [ ] result_excepted = { 10, 10 };
            Assert.AreEqual(result_excepted [ 0 ], result [ 0 ]);
            Assert.AreEqual(result_excepted [ 1 ], result [ 1 ]);
        }
        [TestMethod]
        [TestCategory("Linear Optimisation.Sergienco.Yes")]
        public void SergienkoYes ( )
        {
            double [ , ] table = { {25, 5,  2,3},
                                {20, 1,  6, 2},
                                {18,  4,0,3},
                                { -6, 0, -5, -9} };
            Matrix m = new Matrix(table);
            double [ ] result = new double [ 3 ];
            LinearTask lt = new LinearTask(m);
            SimplexOptimizer S = new SimplexOptimizer();
            result = lt.Optimize(S);
            double [ ] result_excepted = { 0, 1+1.0/3.0, 6 };
            Assert.AreEqual(result_excepted [ 0 ], result [ 0 ]);
            Assert.AreEqual(result_excepted [ 1 ], result [ 1 ]);
            Assert.AreEqual(result_excepted [ 2 ], result [ 2 ]);

        }
        [TestMethod]
        [TestCategory("Linear Optimisation.Sergienco.Yes")]
        public void SergienkoNo ( )
        {
            double [ , ] table = { {10, -3,  2,1},
                                {70, -1,  2, 2},
                                {10,  1,-3,1},
                                { 0, -4, -6, -4} };
            Matrix m = new Matrix(table);
            double [ ] result = new double [ 3 ];
            LinearTask lt = new LinearTask(m);
            SimplexOptimizer S = new SimplexOptimizer();
            result = lt.Optimize(S);
            Assert.AreEqual(Double.NaN, result[0]);

        }

    }
    }
   

   
