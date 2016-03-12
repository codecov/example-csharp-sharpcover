namespace Codecov.Example.Domain.Tests
{
    using FluentAssertions;

    using NUnit.Framework;

    [TestFixture]
    public class WhenRequestingNumber
    {
        private double result;

        [SetUp]
        public void EstablishContext()
        {
            var sut = new Game();
            this.result = sut.RequestNumber();
        }

        [Test]
        public void ShouldGiveBackAPositiveNumber()
        {
            this.result.Should().BeGreaterThan(0);
        }
    }
}
