using System.Linq;
using LinqExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestFilter
    {
        [TestMethod]
        public void TestOnlyPalindromes_NoPalindromes()
        {
            CollectionAssert.AreEqual(new string[] {},
                                      Program.OnlyPalindromes(new[]
                                      {
                                          "Do", "not", "you", "think", "that",
                                          "C#", "can", "be", "pretty", "?!"
                                      }).ToList());
        }

        [TestMethod]
        public void TestOnlyPalindromes_HasPalindromes()
        {
            CollectionAssert.AreEqual(new[] {"a", "radar", "level"},
                                      Program.OnlyPalindromes("There is a radar on the level".Split()).ToList());
        }

        [TestMethod]
        public void TestOnlyPalindromes_AllPalindromes()
        {
            CollectionAssert.AreEqual(new[] {"Anna", "kayak", "alala"},
                                      Program.OnlyPalindromes("Anna kayak alala".Split()).ToList());
        }
    }
}
