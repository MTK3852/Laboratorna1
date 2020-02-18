using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LaboTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
           double p = 0;
            double result = Laboratory1.Program.Func(p);
            Assert.AreEqual(10, result);
        }
    }
}
