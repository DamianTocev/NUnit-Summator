using NUnit.Framework;

namespace Summator.Unit.Tests.Average
{
    public class SummatorAverageTests
    {

//        public static double Average(int[] arr)
//       {
//            double sum = 0;
//            {
//                for (int i = 0; i < arr.Length; i++)
//                {
//                  sum += arr[i];
//                }
//          return sum / arr.Length;
//            }
//        }
//                   Test : Summator.Average(new int[] {4, 5, 7})


        [Test]
        public void Test_Summator_SumPositiveNumbers()
        {
            //Arange
            var NUM = new int[] { 4, 5, 7 };
            //Act
            var actual = Summator.Average(new int[] {});
            //Assert
            Assert.AreAverage(5, actual);

        }

        [Test]
        public void TestAverageOfThreePositiveNumbers()
        {
            var nums = new double[] { 5.2, 10.8, 14 };
            var actual = Summator.Average(nums);
            var expected = 10;
            Assert.That(actual, Is.EqualTo(expected));
            Assert.AreEqual(expected, actual);












        }
}