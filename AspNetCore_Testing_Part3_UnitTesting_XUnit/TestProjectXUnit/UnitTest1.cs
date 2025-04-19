using AspNetCore_Testing_Part3_UnitTesting_XUnit;
using FluentAssertions;

namespace TestProjectXUnit
{
    public class UnitTest1
    {
        private readonly AddNumberAndReturnIt _calculator;

        public UnitTest1()
        {
            _calculator = new AddNumberAndReturnIt();
        }


        [Fact]

        public void AddTwoNumbers_PositiveNumbers_ReturnCorrectSum()
        {
            // Arrange 
            int a = 5;
            int b = 10;

            int expected = 15; //   When we add the a and be we get the expected 


            // Act 

            int result = _calculator.AddTwoNumbers(a, b);


            // Assert 
            result.Should().Be(expected);
            result.Should().BePositive();

        }

        [Fact]
        public void AddTwoNumbers_NegativeNumbers_ReturnCorrectSum()
        {
            // Arrange 
            int a = -5;
            int b = -10;
            int expected = -15;

            // Act 
            int result = _calculator.AddTwoNumbers(a, b);

            // Assert 
            result.Should().Be(expected);
            result.Should().BeNegative();
            result.Should().BeLessThan(0);

        }


        [Fact]

        public void AddTwoNumbers_ZerosValues_ReturnCorrectSum()
        {
            // Arrange 
            int a = 0;
            int b = 0;
            int expected = 0;

            // Act 
            int result = _calculator.AddTwoNumbers(a, b);

            // Assert 
            result.Should().Be(expected);
            result.Should().Be(0);
            result.Should().Be(0);
        }

        [Fact]
        public void DividedTwoNumbers_PositiveNumbers_ReturnCorrectQuotient()
        {
            // Arrange 
            int a = 10;
            int b = 2;


            // Act 
            int result = _calculator.DividedTwoNumbers(a, b);

            // Assert
            result.Should().Be(5);
            result.Should().BePositive();
            result.Should().NotBe(0);



        }

        [Fact]
        public void DividedTwoNumbers_NegativeNumbers_ReturnCorrectQuotient()
        {
            // Arrange 
            int a = -10;
            int b = 2;
            int expected = -5;

            // Act 

            int result = _calculator.DividedTwoNumbers(a, b);


            // Act 
            result.Should().Be(expected);
            result.Should().BeNegative();

        }

        [Fact]
        public void TakeStringAndReturn_NormalString_ReturnSameString()
        {
            // Arrange 
            string intput = "Hello World!";
            string expected = "Hello World!";

            // Act 

            string result = _calculator.TakeStringAndReturn(intput);

            // Assert 
            result.Should().Be(expected);
            result.Should().NotBeEmpty();
            result.Should().BeOfType(typeof(string));


        }

    }
}
