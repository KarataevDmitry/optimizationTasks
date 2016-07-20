using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationTasks.DataStructures;

namespace OptimisationTaskTests
{
    [TestClass]
    public class MathFunctionTests
    {
        [TestCategory("Trig")]
        [TestMethod]
        public void TanTest()
        {
            Task1D t = new Task1D("tg(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = Math.Tan(Math.PI/2);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI/4);
            double f1_excepted = Math.Tan(Math.PI/4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("Trig")]
        [TestMethod]
        public void TanTest2()
        {
            Task1D t = new Task1D("tan(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = Math.Tan(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = Math.Tan(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("Trig")]
        [TestMethod]
        public void ctgTest()
        {
            Task1D t = new Task1D("ctg(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = 1/Math.Tan(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = 1/Math.Tan(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("Trig")]
        [TestMethod]
        public void ctgTest2()
        {
            Task1D t = new Task1D("cot(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = 1 / Math.Tan(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = 1 / Math.Tan(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("HyperTrig")]
        [TestMethod]
        public void CoshTest()
        {
            Task1D t = new Task1D("ch(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = Math.Cosh(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = Math.Cosh(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("HyperTrig")]
        [TestMethod]
        public void SinhTest()
        {
            Task1D t = new Task1D("sh(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = Math.Sinh(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = Math.Sinh(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("HyperTrig")]
        [TestMethod]
        public void TanhTest()
        {
            Task1D t = new Task1D("th(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = Math.Tanh(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = Math.Tanh(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("HyperTrig")]
        [TestMethod]
        public void TanhTest2()
        {
            Task1D t = new Task1D("tanh(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = Math.Tanh(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = Math.Tanh(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("HyperTrig")]
        [TestMethod]
        public void cthTest()
        {
            Task1D t = new Task1D("cth(x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(Math.PI);
            double f0_excepted = 1 / Math.Tanh(Math.PI);
            Assert.AreEqual(f0_excepted, f0_actual);
            double f1_actual = t.GetFuncResult(Math.PI / 4);
            double f1_excepted = 1 / Math.Tanh(Math.PI / 4);
            Assert.AreEqual(f1_excepted, f1_actual);
        }
        [TestCategory("Log&Exp")]
        [TestMethod]
        public void LnTest()
        {
            Task1D t = new Task1D("ln(4*x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(6);
            double f0_excepted = Math.Log(4 * 6);
            Assert.AreEqual(f0_excepted, f0_actual);
        }
        [TestCategory("Log&Exp")]
        [TestMethod]
        public void LgTest()
        {
            Task1D t = new Task1D("lg(4*x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(6);
            double f0_excepted = Math.Log10(4 * 6);
            Assert.AreEqual(f0_excepted, f0_actual);
        }
        [TestCategory("Log&Exp")]
        [TestMethod]
        public void ExpTest()
        {
            Task1D t = new Task1D("exp(4*x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(6);
            double f0_excepted = Math.Exp(4 * 6);
            Assert.AreEqual(f0_excepted, f0_actual);
        }
        [TestCategory("Log&Exp")]
        [TestMethod]
        public void lbTest()
        {
            Task1D t = new Task1D("lb(4*x)", OptKind.Maximum, "x");
            double f0_actual = t.GetFuncResult(6);
            double f0_excepted = Math.Log(4 * 6) / Math.Log(2);
            Assert.AreEqual(f0_excepted, f0_actual);
        }
    }
   
}
