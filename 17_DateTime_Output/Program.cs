// See https://aka.ms/new-console-template for more information
using System.Globalization;



class Programm
{
    static void Main()
    {
        DateTime now = new DateTime(2024, 12, 16, 15, 26, 3);

        // Ausgabe des Datums und der Zeit im gewünschten Format
        Console.WriteLine(now.ToString("dd.MM.yyyy, HH:mm", CultureInfo.InvariantCulture));
        Console.WriteLine(now.ToString("dddd, dd. MMMM yyyy, HH:mm:ss", CultureInfo.InvariantCulture));

        // Jahr, Monat, Tag, Stunde, Minute, Sekunde und Millisekunde
        Console.WriteLine($"Jahr: {now.Year}");
        Console.WriteLine($"Monat: {now.Month}");
        Console.WriteLine($"Tag: {now.Day}");
        Console.WriteLine($"Stunde: {now.Hour}");
        Console.WriteLine($"Minute: {now.Minute}");
        Console.WriteLine($"Sekunde: {now.Second}");
        Console.WriteLine($"Millisekunde: {now.Millisecond}");

        // Wochentag
        Console.WriteLine($"Wochentag: {now.DayOfWeek}");

        // Mein Geburtstag
        DateTime birthday = new DateTime(2008, 2, 19);
        Console.WriteLine($"Mein Geburtstag: {birthday.ToString("dd.MM.yyyy", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Wochentag meiner Geburt: {birthday.DayOfWeek}");

        // Alter in Tagen und Sekunden
        TimeSpan ageInDays = now - birthday;
        Console.WriteLine($"Mein Alter in Tagen: {ageInDays.Days}");

        double ageInSeconds = ageInDays.TotalSeconds;
        Console.WriteLine($"Mein Alter in Sekunden: {ageInSeconds}");

        // Tage bis Ferienbeginn
        DateTime holidayStart = new DateTime(2025, 6, 28);
        TimeSpan daysUntilHoliday = holidayStart - now;
        Console.WriteLine($"Tage bis Ferienbeginn (28.6.2025): {daysUntilHoliday.Days}");
    }
}

































