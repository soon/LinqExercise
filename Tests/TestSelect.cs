using System.Linq;
using LinqExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestSelect
    {
        [TestMethod]
        public void TestAddTwoToEachElement_EmptySequence()
        {
            CollectionAssert.AreEqual(new int[] {}, Program.AddTwoToEachElement(new int[] {}).ToList());
        }

        [TestMethod]
        public void TestAddTwoToEachElement_OneElementInSequence()
        {
            CollectionAssert.AreEqual(new[] {1}, Program.AddTwoToEachElement(new [] {-1}).ToList());
        }

        [TestMethod]
        public void TestAddTwoToEachElement_FiveElementsInSequence()
        {
            CollectionAssert.AreEqual(new[] {-2, 342, 23, 12, 3},
                                      Program.AddTwoToEachElement(new[] {-4, 340, 21, 10, 1}).ToList());
        }

        [TestMethod]
        public void TestNegatePositiveElements_EmptySequence()
        {
            CollectionAssert.AreEqual(new int[] {}, Program.NegatePositiveElements(new int[] {}).ToList());
        }

        [TestMethod]
        public void TestNegatePositiveElements_OneElementInSequence()
        {
            CollectionAssert.AreEqual(new [] {-42}, Program.NegatePositiveElements(new [] {-42}).ToList());
        }

        [TestMethod]
        public void TestNegatePositiveElements_FiveElementsInSequence()
        {
            CollectionAssert.AreEqual(new[] {-2, -1, 0, -1, -2},
                                      Program.NegatePositiveElements(new[] {2, 1, 0, -1, -2}).ToList());
        }
    }
}
