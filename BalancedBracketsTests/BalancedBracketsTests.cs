using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void OnlyBracketsReturnsTrue()
        {

            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        [TestMethod]
        public void MismatchedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod]
        public void DoubleMismatchedBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]This is dumb"));
        }
        [TestMethod]
        public void MisMatchedOppositeBracketsReturnFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }
        [TestMethod]
        public void StringContainsNoBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("string"));
        }
        [TestMethod]
        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void StringContainsEmbeddedBracketTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
        [TestMethod]
        public void StringStartsWithClosedBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }
        [TestMethod]
        public void StringContainsSingleMisalignedBracketLeftFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }
        [TestMethod]
        public void StringContainsSingleMisalignedBracketRightFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void StringContainsMisalignedBracketInSentenceRightFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("this]is ridiculous"));
        }
        [TestMethod]
        public void AnotherRedundantTest()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("redundanttest[redundanttest"));
        }
    }

}
