using NUnit.Framework;

namespace Summator.Unit.Test
{
    public class SummatorTests
    {

        [Test]
        public void Test_Summator_SumTwoPositiveNumbers()
        {
            //Arange
            var nums = new int[] { 1, 2 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void Test_Summator_SumTwoNegativeNumbers()
        {
            //Arange
            var nums = new int[] { -1, -99 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.AreEqual(-100, actual);
        }

        [Test]
        public void Test_Summator_SumOneNumber()
        {
            //Arange
            var nums = new int[] { 6};
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.AreEqual(6, actual);
        }

        [Test]
        public void Test_Summator_SumZeroNumbers()
        {
            //Arange
            var nums = new int[] { };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void Test_Summator_SumBigNumbers()
        {
            //Arange
            var nums = new int[] { 2000000000, 2000000000, 2000000000, 2000000000 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.AreEqual(8000000000, actual);
        }


        // My tests wiht Assert.That

        [Test]
        public void Test_Summator_SumPositiveAndNegativeNumbers()
        {
            //Arange
            var nums = new int[] { -21, 22 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.That(1, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumNumbersWithNotEqualAnsuer()
        {
            //Arange
            var nums = new int[] { 1, 2 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.That(4, Is.Not.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_Sum100Numbers()
        {
            //Arange
            var nums = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.That(100, Is.EqualTo(actual));
        }

        [Test]
        public void Test_Summator_SumRangeOfNumbers()
        {
            //Arange
            var nums = new int[] { 50, 40 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.That(90, Is.InRange(80, 100));
        }

        [Test]
        public void Test_Summator_SumGreaterThanNumbers()
        {
            //Arange
            var nums = new int[] { 18, 3 };
            //Act
            var actual = Summator.Sum(nums);
            //Assert
            Assert.That(21, Is.GreaterThan(20));
        }




    }
}