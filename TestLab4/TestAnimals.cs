using Lab4.model;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private Dog dog;
        private Puppy puppy;

        [SetUp]
        public void Setup()
        {
            dog = new Dog("Max");
            puppy = new Puppy("Oscar");
        }

        [Test]
        public void Test_DogBarking()
        {
            string actualBarking = dog.Voice();
            Assert.AreEqual(dog.Name + " says: Woof! Woof!", actualBarking);
        }

        [Test]
        public void Test_DogRunning()
        {
            string actualRunning = dog.Run();
            Assert.AreEqual(dog.Name + " is runnig", actualRunning);
        }

        [Test]
        public void Test_DogJumping()
        {
            string actualJumping = dog.Jump();
            Assert.AreEqual(dog.Name + " is jumping", actualJumping);
        }

        [Test]
        public void Test_DogBiting()
        {
            string actualBiting = dog.Bite();
            Assert.AreEqual(dog.Name + " is biting you", actualBiting);
        }

        [Test]
        public void Test_PuppyBiting()
        {
            string actualBiting = puppy.Bite();
            Assert.AreEqual(puppy.Name + " is tweaking you", actualBiting);
        }

        [Test]
        public void Test_PuppyBarking()
        {
            string actualBarking = puppy.Voice();
            Assert.AreEqual(puppy.Name + " says: Aw! Aw!", actualBarking);
        }
    }
}