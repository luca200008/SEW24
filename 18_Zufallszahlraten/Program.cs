// See https://aka.ms/new-console-template for more information

// Erstelle ein Programm, das eine Zufallszahl (0-10) generiert.
// Der Benurtzer Soll sie raten. Gib die Anzahl der Verscuhe un die benötigte Zeit dafür aus. 
// Der Benutzer hat maximal 10 Versuche
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

Random random = new Random();
int randomNumber = random.Next(0, 11);
int guess;
int count = 0;

do
{
    Console.WriteLine("Bitte eine Zahl zw.0 und 10 raten: ");
    guess = int.Parse(Console.ReadLine());
    count++;

}   while (guess != randomNumber);
TimeSpan elapsed = watch.Elapsed();

Console.WriteLine(value: $"Du hast {count} - {elapsed.TotalSeconds:f0} Sekunden gebraucht, um die Zahl {randomNumber} zu erraten");


































