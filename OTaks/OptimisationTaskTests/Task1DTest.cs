using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationTasks.DataStructures;

namespace OptimisationTaskTests
{

    [TestClass]
    public class Task1DTest
    {
        [TestCategory("All_in_One")]
        [TestMethod]
        public void SimpleExpressionTest()
        {
            Task1D t = new Task1D("x*x+4,0*x-2,0", OptimisationTasks.DataStructures.OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(0);
            double f0_excepted = -2;
            Assert.AreEqual(f0_excepted, f0_actual);
            double f4_actual = t.GetFuncResult(4);
            double f4_excepted = 4 * 4 + 4 * 4 - 2;
            Assert.AreEqual(f4_excepted, f4_actual); 
            

        }
        [TestCategory("All_in_One")]
        [TestMethod]
        public void ComplexExpressionTest()
        {
            Task1D t = new Task1D("cos(x)+sin(ln(4*x))+6*x*x+6", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(0);
            double f0_excepted = Math.Cos(0)+Math.Sin(Math.Log(4*0))+6*Math.Pow(0,2)+6;
            Assert.AreEqual(f0_excepted, f0_actual);
            double fPI4_actual = t.GetFuncResult(Math.PI/4.0);
            double fPI4_excepted = Math.Cos(Math.PI/4) + Math.Sin(Math.Log(4 * (Math.PI/4.0))) + 6 * Math.Pow(Math.PI/4, 2)+6;
            Assert.AreEqual(fPI4_excepted, fPI4_actual);
        }

    }
}
