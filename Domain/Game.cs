using System.Linq;

namespace Codecov.Example.Domain
{
    public class Game
    {
        private readonly double[] knownNumberWangs;

        public Game()
        {
            knownNumberWangs = new[] { 1, 22, 7, 9, 1002, 2.3, 15, 109876567, 31 };
        }

        public double RequestNumber()
        {
            return 42;
        }

        public bool IsNumberWang(double number)
        {
            return knownNumberWangs.Contains(number);
        }
    }
}
