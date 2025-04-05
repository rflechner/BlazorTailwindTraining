namespace BlazorTailwindTraining.App2.Client.Components;

public class DefaultLexical
{
    public static readonly Dictionary<DayOfWeek, string> DaysOfWeek = new()
    {
        { DayOfWeek.Monday, "Lundi" },
        { DayOfWeek.Tuesday, "Mardi" },
        { DayOfWeek.Wednesday, "Mercredi" },
        { DayOfWeek.Thursday, "Jeudi" },
        { DayOfWeek.Friday, "Vendredi" },
        { DayOfWeek.Saturday, "Samedi" },
        { DayOfWeek.Sunday, "Dimance" },
    };
}