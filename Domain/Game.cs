namespace Codecov.Example.Domain
{
    using System.Linq;

    public class Game
    {
        private readonly double[] knownNumberWangs;

        public Game()
        {
            this.knownNumberWangs = new[] { 1, 22, 7, 9, 1002, 2.3, 15, 109876567, 31 };
        }

        public double RequestNumber()
        {
            return 42;
        }

        public bool IsNumberWang(double number)
        {
            return this.knownNumberWangs.Contains(number);
        }
    }
}
