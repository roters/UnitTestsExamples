

using System;

namespace UTExamples
{
    public class WeatherProviderProvider : IWeatherProvider
    {
        private readonly IWeekDayProvider _weekDayProvider;

        public WeatherProviderProvider(IWeekDayProvider weekDayProvider)
        {
            _weekDayProvider = weekDayProvider;
        }

        public string Forecast()
        {
            return _weekDayProvider.GetDayOfWeek() switch
            {
                DayOfWeek.Monday => "sunny",
                DayOfWeek.Tuesday => "rain",
                _ => "cloudy"
            };
        }

        public double CalculateWindForce(int pressure, DayOfWeek dayOfWeek)
        {
            return _weekDayProvider.WeekdayWindForceRatio(dayOfWeek) * pressure;
        }
    }

    public interface IWeatherProvider
    {
        string Forecast();
        double CalculateWindForce(int pressure, DayOfWeek dayOfWeek);
    }
}