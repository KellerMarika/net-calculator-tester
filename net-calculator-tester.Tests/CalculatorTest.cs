using System.ComponentModel;

namespace net_calculator_tester.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        public  float n1;
        private  float n2;

        [SetUp]
        public void Setup()
        {
             n1 = 6;
             n2 = 2;
        }

        [Test(Description = "ADDICTION")]
        [TestCase(5, 3, 5+3)]
        public void AddTest(float num1, float num2, float sum) => Assert.IsTrue( Calculator.Add( num1, num2) == sum);

        [Test(Description = "SUBTRACT")]
        [TestCase(5, 3, 5 - 3)]
        public void SubtractTest(float num1, float num2, float sub) => Assert.IsTrue(Calculator.Subtract(num1, num2) == sub);

        [Test(Description = "DIVIDE")]
        [TestCase(6, 3, (6 / 3))]
        [TestCase(5, 0, 0)]
        [TestCase(5, 3, (5.0f / 3))]
        public void DivideTest(float num1, float num2, float div) => Assert.IsTrue(Calculator.Divide(num1, num2) == div);       
   
        [Test(Description = "MULTIPLY")]
        [TestCase(5, 3, 5*3)]
        public void MultiplyTest(float num1, float num2, float div) => Assert.IsTrue(Calculator.Multiply(num1, num2) == div);


        [Test(Description = "POW")]
        [TestCase(5,3, (5*5*5) )]
        [TestCase(5, 0, 1)]
        [TestCase(0, 5, 0)]
        [TestCase(3, -2, (1.0/3)*(1.0/3)) ]
        public void PowTest(int num1, int num2, double pow ) => Assert.IsTrue(Calculator.pow(num1, num2) == pow);



    }
}