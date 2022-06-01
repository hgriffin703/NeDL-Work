using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCSample;

namespace TipTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NegativePercentNotAllowed()
        {
            double Amount = 11.65;
            double TipPercent = -20;
            
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => TipModel.CalculateTip(TipPercent)

        }
    }
}
