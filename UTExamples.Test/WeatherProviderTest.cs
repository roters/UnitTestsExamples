using System;
using Moq;
using Shouldly;
using Xunit;

namespace UTExamples.Test
{
    //moq

    public class WeatherProviderTest
    {
        private readonly Mock<IWeekDayProvider> _weekDayProviderMock;

        public WeatherProviderTest()
        {
            _weekDayProviderMock = new Mock<IWeekDayProvider>();
        }

        //wartość zwracana

        [Fact]
        public void Forecast_WhenDayIsMonday_ReturnSunny()
        {
            _weekDayProviderMock.Setup(m => m.GetDayOfWeek()).Returns(DayOfWeek.Monday);

            var sut = new WeatherProviderProvider(_weekDayProviderMock.Object);

            var result = sut.Forecast();

            result.ShouldBe("sunny");
        }

        //ilość wykonań

        [Fact]
        public void Forecast_WhenDayIsTuesday_WeekDayProviderShouldBeCalledOnce()
        {
            _weekDayProviderMock.Setup(m => m.GetDayOfWeek()).Returns(DayOfWeek.Tuesday);

            var sut = new WeatherProviderProvider(_weekDayProviderMock.Object);

            _ = sut.Forecast();

            _weekDayProviderMock.Verify(m => m.GetDayOfWeek(), Times.Once); //change to once
        }

        //przyjmowane parametry

        [Fact]
        public void CalculateWindForce_WhenPressureIsNotZero_ReturnValue()
        {
            _weekDayProviderMock.Setup(m => m.WeekdayWindForceRatio(It.IsAny<DayOfWeek>())).Returns(1);

            var sut = new WeatherProviderProvider(_weekDayProviderMock.Object);

            var result = sut.CalculateWindForce(1, DayOfWeek.Monday);

            result.ShouldNotBe(0);
        }
    }
}