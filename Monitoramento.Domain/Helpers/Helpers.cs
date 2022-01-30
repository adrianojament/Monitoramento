namespace Monitoramento.Domain.Helpers
{
    public abstract class Helpers
    {
        public static DateTime GetDateTimeBrasilian()
        {
            DateTime dateTime = DateTime.UtcNow;
            TimeZoneInfo horaBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime, horaBrasilia);
        }
    }
}
