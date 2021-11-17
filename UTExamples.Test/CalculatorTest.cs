using System;
using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace UTExamples.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add_WhenAddingTwoIntegers_ReturnCorrectResult()
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(1, 1);

            //Assert
            result.ShouldBe(2);
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, -1, 0)]
        [InlineData(-1, -1, -2)]
        public void Add_WhenAddingTwoDoubles_ReturnCorrectResult_Inline(double a, double b, double expected)
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(a, b);

            //Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [ClassData(typeof(CalculatorTestData))]
        public void Add_WhenAddingTwoDoubles_ReturnCorrectResult_ClassData(double a, double b, double expected)
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(a, b);

            //Assert
            result.ShouldBe(expected);
        }

        public static List<object[]> AddTestData() => new()
        {
            new object[] { 1, 1, 2 },
            new object[] { 1, -1, 0 },
            new object[] { -1, -1, -2 }
        };

        [Theory]
        [MemberData(nameof(AddTestData))]
        public void Add_WhenAddingTwoDoubles_ReturnCorrectResult_MemberData(double a, double b, double expected)
        {
            //Arrange
            var sut = new Calculator();

            //Act
            var result = sut.Add(a, b);

            //Assert
            result.ShouldBe(expected);
        }

        [Fact]
        public void Add_PassingNumberAboveLimit_ThrowException_Shouldly()
        {
            //Arrange
            var sut = new Calculator();

            //Act + Arrange
            var exception = Should.Throw<ArgumentException>(() => sut.Add(100, 1));

            exception.Message.ShouldBe("No more than 99");
        }

        [Fact]
        public void Add_PassingNumberAboveLimit_ThrowException_XUnit()
        {
            //Arrange
            var sut = new Calculator();

            //Act + Arrange
             Assert.Throws<AccessViolationException>(() => sut.Add(100, 1));

           // exception.Message.ShouldBe("No more than 99");
        }
    }
}
