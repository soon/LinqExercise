using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    public struct Point
    {
        public Point(int x, int y) : this() 
        {
            X = x;
            Y = y;
        }

        public int X
        {
            get;
            private set;
        }

        public int Y
        {
            get;
            private set;
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
        }

        public static IEnumerable<int> AddTwoToEachElement(IEnumerable<int> enumerable)
        {
            return Enumerable.Empty<int>();
        }

        public static IEnumerable<int> NegatePositiveElements(IEnumerable<int> enumerable)
        {
            return Enumerable.Empty<int>();
        }

        public static IEnumerable<string> OnlyPalindromes(IEnumerable<string> words)
        {
            return Enumerable.Empty<string>();
        }

        public static IEnumerable<Point> Near(Point point)
        {
            return Enumerable.Empty<Point>();
        }
    }
}
