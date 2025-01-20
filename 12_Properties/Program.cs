




// neue Klasse: Cow 
// Datenkomponente: name, age, weight
//für jede Datenkomponetne einen getter und setter
// mind. 2 Objekte von der Klasse Cow instanzieren
// von einer Kuh das Gewicht ändern 
// Ausagbe der neuen Werte (Gewicht, Alter) auf die Konsole



Cow babsi = new Cow("Babsi", 5, 650);
Cow haselnuss = new Cow("Hasselnuss", 7, 700);

babsi.Weight = 750;
haselnuss.Age = 6;

Console.WriteLine($"Gewicht: {babsi.Weight}");
Console.WriteLine($" Alter: {haselnuss.Age}");

babsi.Breed = "Holstein"