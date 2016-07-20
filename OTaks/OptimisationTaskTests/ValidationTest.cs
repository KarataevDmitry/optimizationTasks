using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OptimisationTasks.Utilites;

namespace OptimisationTaskTests
{
    [TestClass]
    public class ValidationTest
    {
        [TestCategory("ValidatorTests")]
        [TestMethod]
        public void IncorrectMultTest()
        {
            ExpressionValidator ev = new ExpressionValidator();
            string s = "25x";
            string s1 = "25*x";
            string s2 = "25x^2";
            string s3 = "25*x^2";
            string s4 = "24.8*x";
            string s5 = "24.732x";
            Assert.IsFalse(ev.Validate(s).IsValid);
            Assert.AreEqual("25x", ev.Validate(s).ErrorIn);
            Assert.IsTrue(ev.Validate(s1).IsValid);
            Assert.AreEqual(ev.VALIDATION_STATUS_OK, ev.Validate(s1).ErrorIn);
            Assert.IsFalse(ev.Validate(s2).IsValid);
            Assert.AreEqual("25x", ev.Validate(s2).ErrorIn);
            Assert.IsTrue(ev.Validate(s3).IsValid);
            Assert.IsTrue(ev.Validate(s4).IsValid);
            Assert.IsFalse(ev.Validate(s5).IsValid);
            Assert.AreEqual("24.732x", ev.Validate(s5).ErrorIn);
        }
    }
}
