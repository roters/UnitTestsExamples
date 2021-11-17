namespace UTExamples
{
    public class WeekDayProvider : IWeekDayProvider
    {
        public DayOfWeek GetDayOfWeek()
        {
            return DateTime.Now.DayOfWeek;
        }

        public int WeekdayWindForceRatio(DayOfWeek dayOfWeek)
        {
            return dayOfWeek == DayOfWeek.Monday ? 0 : 999;
        }
    }

    public interface IWeekDayProvider
    {
        DayOfWeek GetDayOfWeek();
        int WeekdayWindForceRatio(DayOfWeek dayOfWeek);
    }
}
