// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime christmas = new DateTime(2024, 12, 24, 20, 0, 0);
Console.WriteLine(christmas.ToShortDateString());
Console.WriteLine(christmas.ToLongDateString());
Console.WriteLine(christmas.ToString());

DateOnly birthday  = new DateOnly(2008, 2, 19);
Console.WriteLine(birthday.ToLongDateString());

TimeOnly sleepingTIme = new TimeOnly(22, 0);
Console.WriteLine(sleepingTIme.ToShortTimeString());

DateTime now = DateTime.Now;
Console.WriteLine($"Jetzt: {now.ToString()}");
DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);

TimeOnly timeNow = TimeOnly.FromDateTime(DateTime.Now);

TimeSpan tillChrismas = christmas - DateTime.Now;
Console.WriteLine($"Bis Weinachten: {tillChrismas.Days} Tage");
TimeSpan tillSleeping = sleepingTIme - timeNow;
Console.WriteLine($"Bis zum Schlafen: {tillSleeping.TotalMinutes} Minuten");

DateOnly today = DateOnly.FromDateTime(DateTime.Now);
DateOnly payDate = today.AddDays(30);
Console.WriteLine($"Rechnung zu bezahlen: {payDate.ToShortDateString()}");


Console.WriteLine("------------------------------------------------------");



DateTime now2 = DateTime.Now;
Console.WriteLine($"Jetzt: {now2.ToString()}");
DateOnly dateNow1 = DateOnly.FromDateTime(DateTime.Now);

Console.WriteLine("Bitte eine Taste drücken");
Console.ReadLine();
DateTime start = DateTime.Now;

Console.WriteLine("Bitte eine Taste drücken.");
Console.ReadLine();
DateTime stop  = DateTime.Now; 
TimeSpan span = stop - start;
Console.WriteLine($"Vergangerne Zeit: {span.TotalSeconds} Sekunden");