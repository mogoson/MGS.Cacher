using MGS.Cacher;
using NUnit.Framework;

namespace Tests
{
    public class CacherTests
    {
        ICacher<string> cacher;

        [SetUp]
        public void SetUp()
        {
            cacher = new Cacher<string>(3);
        }

        [TearDown]
        public void TearDown()
        {
            cacher.Clear();
            cacher = null;
        }

        [Test]
        public void TestAdd()
        {
            cacher.Add("0", "0");//will discard.
            cacher.Add("1", "1");
            cacher.Add("2", "2");
            cacher.Add("3", "3");
            Assert.AreEqual(cacher.Find("0"), null);
        }

        [Test]
        public void TestFind()
        {
            TestAdd();

            var value0 = cacher.Find("0");//Already discard.
            Assert.AreEqual(value0, null);

            var value3 = cacher.Find("3");
            Assert.AreEqual(value3, "3");
        }
    }
}