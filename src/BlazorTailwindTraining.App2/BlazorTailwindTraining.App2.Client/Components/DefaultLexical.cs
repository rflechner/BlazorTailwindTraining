using System.Globalization;

namespace BlazorTailwindTraining.App2.Client.Components;

public class DefaultLexical
{
    public static IDictionary<DayOfWeek, string> GetDaysOfWeek(CultureInfo? culture = null)
    {
        culture ??= CultureInfo.CurrentUICulture;
        var formatInfo = culture.DateTimeFormat;

        return Enum.GetValues<DayOfWeek>().ToDictionary(d => d, formatInfo.GetDayName);
    }

    public static IDictionary<int, string> GetMonths(CultureInfo? culture = null)
    {
        culture ??= CultureInfo.CurrentUICulture;
        var formatInfo = culture.DateTimeFormat;
        
        return Enumerable.Range(1, 12).ToDictionary(m => m, m => formatInfo.GetMonthName(m));
    }
    
    
}