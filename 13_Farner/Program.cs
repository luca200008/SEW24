// See https://aka.ms/new-console-template for more information
using _13_Farner;

Console.WriteLine("Hello, World!");

Farmer mcDonald = new Farmer("Ronald", "Mc", new Cat("Minka", "grau"));

mcDonald.MyDog = new Dog("Erik," "Terrier");
Console.WriteLine(mcDonald.MyDog.Name);
mcDonald.MyDog = null;
if (mcDonald != null)
{
    Console.WriteLine(mcDonald.MyDog.Name);             // MyDog is null --> NullReferenceException
}

mcDonald.MyDog = new Dog("Blacy", "Labrador-Retriever");

// Namen des Hundes vom McDonald
if(mcDonald != null)
{
    Console.WriteLine(mcDonald)
}

Console.WriteLine(mcDonald.MyCat.Name);     //MyCat nicht nullable --> daher gehen wir davon aus, dass 
                                            // immer ein Objekt vorhanden ist

// mcDonald.My Cat = null