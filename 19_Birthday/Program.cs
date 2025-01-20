// See https://aka.ms/new-console-template for more information


// Erstelle ein Programm mit der Klasse Person. Die Person soll einen FistName, LastName und Bithday haben.
// Erstelle entsprechende Properties für die Members.
// Zusäzlich soll das readonly Property Age erstellt werden. Es soll das Alter der Person in Jahren (int) zurückgeben
// Weitere readonly Properties:
// int Days : Rückgabe: Anzahl der bereits gelebten Tage bis heute
// int DaysTillNextBirthday: Anazhl der Tage bis zum nächsten Geburtstag
using System;

    Person me = new Person("Luca", "Schodl", new DateTime(2008, 2, 19));
    Person someone = new Person("Max", "Mustermann", new DateTime(1981, 12, 31));
    Console.WriteLine(me.Age);
    Console.WriteLine(someone.Age);






































