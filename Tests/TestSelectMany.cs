using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqExercise;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class TestSelectMany
    {
        [TestMethod]
        public void TestNear_1()
        {
            var results = Program.Near(new Point(0, 0)).OrderBy(p => p.X * 10 + p.Y);
            var expected = new[]
            {
                new Point(-1, -1),
                new Point(-1, 0),
                new Point(-1, 1),
                new Point(0, -1),
                new Point(0, 0),
                new Point(0, 1),
                new Point(1, -1),
                new Point(1, 0),
                new Point(1, 1),
            }.OrderBy(p => p.X * 10 + p.Y);
            CollectionAssert.AreEqual(expected.ToList(), results.ToList());
        }

        [TestMethod]
        public void TestNear_2()
        {
            var results = Program.Near(new Point(-4, 2)).OrderBy(p => p.X * 10 + p.Y);
            var expected = new[]
            {
                new Point(-5, 3),
                new Point(-5, 2),
                new Point(-5, 1),
                new Point(-4, 3),
                new Point(-4, 2),
                new Point(-4, 1),
                new Point(-3, 3),
                new Point(-3, 2),
                new Point(-3, 1),
            }.OrderBy(p => p.X * 10 + p.Y);
            CollectionAssert.AreEqual(expected.ToList(), results.ToList());
        }
    }
}
