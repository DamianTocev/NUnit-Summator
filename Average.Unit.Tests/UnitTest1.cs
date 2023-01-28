using NUnit.Framework;

namespace Average.Unit.Tests
{
    public class Tests
    {

        [Test]
        public void Test_Average_ZERO_intNumber_With_Expected_IntResult()
        {
            //Arange
            var nums = new double[] { 0 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert            
            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void Test_Average_One_Positive_intNumber_With_Expected_IntResult()
        {
            //Arange
            var nums = new double[] { 2 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert            
            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Test_Average_Two_Positive_intNumbers_With_Expected_IntResult()
        {
            //Arange
            var nums = new double[] { 2, 4 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void Test_Average_Two_Negative_intNumbers_With_Expected_IntResult()
        {
            //Arange
            var nums = new double[] { -2, -4 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(-3));
        }

        [Test]
        public void Test_Average_Three_Positive_intNumbers_With_Expected_IntResult()
        {
            //Arange
            var nums = new double[] { 1, 2, 3 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void Test_Average_Three_Negative_intNumbers_With_Expected_IntResult()
        {
            //Arange
            var nums = new double[] { -1, -2, -3 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(-2));
        }

        [Test]
        public void Test_Average_Three_Positive_intNumbers_With_Expected_DoubleResult()
        {
            //Arange
            var nums = new double[] { 1, 3, 4 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(2.6666666666666665));
        }

        [Test]
        public void Test_Average_Three_Negative_intNumbers_With_Expected_DoubleResult()
        {
            //Arange
            var nums = new double[] { -1, -3, -4 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(-2.6666666666666665));
        }

        [Test]
        public void Test_Average_One_Positive_intNumber_And_One_Positive_DoubleNumber_With_Expected_DoubleResult()
        {
            //Arange
            var nums = new double[] { 2, 3.5 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(2.75));
        }

        [Test]
        public void Test_Average_One_Negative_intNumber_And_One_Positive_DoubleNumber_With_Expected_DoubleResult()
        {
            //Arange
            var nums = new double[] { -2, 3.5 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(0.75));
        }

        [Test]
        public void Test_Average_One_Positive_intNumber_And_One_Negative_DoubleNumber_With_Expected_DoubleResult()
        {
            //Arange
            var nums = new double[] { 2, -3.5 };
            //Act
            var actual = Summator.Average.AverageNums(nums);
            //Assert
            Assert.That(actual, Is.EqualTo(-0.75));
        }

        /*

        [Test]
        public void Test_Average_Zero_Numbers()
        {
            // Test with exception
            var nums = new int[] { };
            Assert.Throws<DivideByZeroException>(
                delegate { throw new DivideByZeroException(); });
        }

        */

    }
}