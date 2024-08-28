namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var a = Enumerable.Range(1, 5).Count();
            Assert.That(a, Is.EqualTo(5));
        }
    }
}