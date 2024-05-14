// See https://aka.ms/new-console-template for more information
using System.Collections;
using Person1;

Person bob = new Person("Bob", 29);
Person ben = new Person("Ben", 29);

Person[] names = new Person[2];
names[0] = (bob);
names[1] = (ben);

Console.WriteLine("Using basic method");
foreach (Person p in names)
{
    Console.WriteLine(p.Name + " Age: " + p.Age);
}

Console.WriteLine("Using ArrayList\n");
ArrayList listNames = new ArrayList();
listNames.Add(bob);
listNames.Add(ben);

foreach (Person p in listNames)
{
    Console.WriteLine(p.Name + " Age: " + p.Age);
}

Console.WriteLine("Using List\n");
List<Person> list = new List<Person>();
list.Add(bob);
list.Add(ben);
foreach(Person p in list)
{
    Console.WriteLine(p.Name + " Age: " + p.Age);
}

// using list short hand declairing the values
Console.WriteLine("Short hand adding to list");
List<Person> people = [ben, bob];
foreach(Person p in people)
{
    // Console.WriteLine($"Name: {p.Name} Age: {p.Age}");
    Console.WriteLine("toString");
    Console.WriteLine(p);
}


Console.WriteLine("\nAdding in new list");
List<Person> list2 = new List<Person>
{
    new Person("Bennie", 100),
    new Person("Rennie", 39),
    new Person("Bok", 99),
};
foreach(Person p in list2)
{
    Console.WriteLine(p.Name + " Age: " + p.Age);
}

// sort
var sortOrder = list2.OrderBy(p => p.Age);
Console.WriteLine("\nSorted");
foreach(Person p in sortOrder)
{
    Console.WriteLine(p.Name + " Age: " + p.Age);
}

// sort
var sortDecending = list2.OrderByDescending(p => p.Age);
foreach(Person p in sortDecending)
{
    Console.WriteLine(p.Name + " Age: " + p.Age);
}

Console.WriteLine();
Console.WriteLine("List of Strings");
var namings = new List<string>();
namings = ["MarvinA", "MarvinB"];
namings.Add("'Marvin', 'Marvino'");
namings.Add("'Marvin1', 'Marvino2'");

namings.Remove("MarvinA");

foreach (string p in namings)
{
    Console.WriteLine($"{p}");
}
