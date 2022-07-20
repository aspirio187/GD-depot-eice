namespace API.DepotEice.Test
{
    public class Tests
    {
        private int _num1 = 1;
        private int _num2 = 2;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Arrange

            int expectedResult = 3;

            // Act

            int actualResult = _num1 + _num2;

            // Assert

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}