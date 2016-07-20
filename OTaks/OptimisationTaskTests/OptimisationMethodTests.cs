using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationTasks.DataStructures;
using OptimisationTasks.OptimisationMethods;
using OptimisationTasks.FileOperations;

namespace OptimisationTaskTests
{
    [TestClass]
    public class OptimisationMethodTests
    {
        [TestMethod]
        [TestCategory("Optimisation1D")]
        public void GoldenPropMin()
        {
            Task1D t = new Task1D("x^2+4*x+6", OptKind.Minimum, "x", new Interval(-3, -1));
            GoldenPropOptimisator gp = new GoldenPropOptimisator();
            double? actual_n = gp.Optimise(t, 0.001);
            double actual = 0.0;
            if (actual_n.HasValue) actual = actual_n.Value; 
            double expected = -4 / 2;
            Assert.IsTrue(Math.Abs(expected - actual)<0.001);
        }
        [TestMethod]
        [TestCategory("Optimisation1D")]
        public void GoldenPropMax()
        {
            GoldenPropOptimisator gp = new GoldenPropOptimisator();
            Task1D t = new Task1D("-x^2+4*x+6", OptKind.Maximum, "x", new Interval(0,3));
           double expected = 2.0;
            double actual = gp.Optimise(t, 0.001).Value;
            Assert.IsTrue(Math.Abs(expected - actual) < 0.001);
        }

        [TestMethod]
        [TestCategory("Optimisation1D")]
        public void GoldenPropNoOpt()
        {
            GoldenPropOptimisator gp = new GoldenPropOptimisator();
            Task1D t = new Task1D("-x^2+4*x+6", OptKind.Maximum, "x", new Interval(4, 10));
            double? val = gp.Optimise(t, 0.001);
            Assert.IsNull(val);
        }

        [TestMethod]
        [TestCategory("Optimisation1D")]
        public void OptimiseFromFile()
        {
            GoldenPropOptimisator gp = new GoldenPropOptimisator();
            double? actual = gp.Optimise("../../../test.xml", 0.001);
            double excepted = -0.25;
            Assert.IsTrue(Math.Abs(excepted - actual.Value) < 0.001);
        }
        [TestCategory("Optimisation1D")]
        [TestMethod]
        public void GoldenPropChangeDir()
        {
            Task1D t = new Task1D("x^2+4*x+6", OptKind.Maximum, "x", new Interval(-3, -1));
            GoldenPropOptimisator gp = new GoldenPropOptimisator();
            double? actual_n = gp.Optimise(t, OptKind.Minimum, 0.001);
            double expected = -4 / 2;
            Assert.IsTrue(Math.Abs(expected - actual_n.Value) < 0.001);
        }
    }
}
