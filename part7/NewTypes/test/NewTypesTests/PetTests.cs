using System;
using NUnit.Framework;
using Pets;

namespace NewTypesTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DogTalkToOwnerReturnsWoof()
        {
            string expected = "Woof!";
            string actual = new Dog().TalkToOwner();

            Assert.AreEqual(expected, actual);
        }

          [Test]
        public void CatTalkToOwnerReturnsMeow()
        {
            string expected = "Meow!";
            string actual = new Cat().TalkToOwner();

            Assert.AreEqual(expected, actual);
        }
    }
}