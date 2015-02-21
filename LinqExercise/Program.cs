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

        public Point Add(Point vector)
        {
            return new Point(X + vector.X, Y + vector.Y);
        }
    }

    public static class Program
    {
        static void Main(string[] args)
        {
        }

        public static IEnumerable<int> AddTwoToEachElement(IEnumerable<int> enumerable)
        {
            return enumerable.Select(x => x + 2);
        }

        public static IEnumerable<int> NegatePositiveElements(IEnumerable<int> enumerable)
        {
            return enumerable.Select(x => -Math.Abs(x));
        }

        public static IEnumerable<string> OnlyPalindromes(IEnumerable<string> words)
        {
            return words.Where(IsPalindrome);
        }

        public static bool IsPalindrome(string word)
        {
            return word.ToLower() == new string(word.ToLower().Reverse().ToArray());
        }

        public static IEnumerable<Point> Near(Point point)
        {
            var xComponent = new[] {-1, 0, 1};
            var yComponent = new[] {-1, 0, 1};
            return xComponent.SelectMany(x => yComponent.Select(y => point.Add(new Point(x, y))));
        }
    }
}
