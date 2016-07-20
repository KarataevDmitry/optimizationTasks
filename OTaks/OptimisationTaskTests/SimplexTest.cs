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
    }
    }
   

   
