using FluentAssertions;
using NUnit.Framework;

namespace Codecov.Example.Domain.Tests
{
    [TestFixture]
    public class WhenRequestingNumber
    {
        private double result;

        [SetUp]
        public void EstablishContext()
        {
            var sut = new Game();
            result = sut.RequestNumber();
        }

        [Test]
        public void ShouldGiveBackAPositiveNumber()
        {
            result.Should().BeGreaterThan(0);
        }
    }
}
