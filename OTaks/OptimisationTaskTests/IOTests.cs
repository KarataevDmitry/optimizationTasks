using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationTasks.FileOperations;
using OptimisationTasks.DataStructures;
using System.IO;
namespace OptimisationTaskTests
{
    [TestClass]
    public class IOTest 
    {
        [TestMethod]
        [TestCategory("IOTest")]
        public void TestReadTask()
        {
            Task1D t = TaskReader.ReadTaskFromFile("../../../test.xml");
            Task1D t_excepted = new Task1D("4*x^2+2*x+4", OptKind.Minimum, "x", new Interval("[-1; 1]"));
            Assert.AreEqual(t_excepted.OptimumType, t.OptimumType);
            Assert.AreEqual(t_excepted.TargetFunction, t.TargetFunction);
            Assert.AreEqual(t_excepted.VariableName, t.VariableName);
            Assert.AreEqual(t_excepted.GetFuncResult(0), t.GetFuncResult(0));
            Assert.AreEqual(t_excepted.OptimumInterval.ToString(), t.OptimumInterval.ToString());
        }
        [TestMethod]
        [TestCategory("IOTest")]
        public void TestWriteTask()
        {
           Task1D t = new Task1D("4*x^2+2*x+4", OptKind.Minimum, "x", new Interval("[-1; 1]"));
           TaskWriter.WriteTaskToFile(t, "../../../test.xml");
           Assert.IsTrue(File.Exists("../../../test.xml"));
        }
        [TestMethod]
        [TestCategory("IntervalTest")]
        public void InterStructTest()
        {
            Interval i1 = new Interval("-3;3");
            Interval i2 = new Interval(-2, 4);
            Interval i3 = new Interval("[-3;3]");
            Assert.AreEqual(-3, i1.Left);
            Assert.AreEqual(3, i1.Right);
            Assert.AreEqual("[-2;4]", i2.ToString());
            Assert.AreEqual(-3, i3.Left);
            Assert.AreEqual(3, i3.Right);
        }
    }
}
