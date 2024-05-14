// See https://aka.ms/new-console-template for more information
using System.Collections.ObjectModel;
using Testing;

// Array is Already IEnumerable

string[] fradulentOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
IList<string> list = new List<string>();

foreach (string fradulentOrderID in fradulentOrderIDs)
{
    if (fradulentOrderID.StartsWith("B"))
    {
        Console.WriteLine(fradulentOrderID);
        list.Add(fradulentOrderID);
    }
}

Console.WriteLine("Enumerator");
IEnumerator<string> enumerator = list.GetEnumerator();
while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
    enumerator.Dispose();
}

Console.WriteLine("ICollection");
ICollection<string> fradulentOrderIDs2 = new List<string>{"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
string[] list2= new string[fradulentOrderIDs2.Count];
fradulentOrderIDs.CopyTo(list2, 0);

foreach (string listing in list2)
{
    Console.WriteLine(listing);
}

Console.WriteLine("IList");
IList<string> colors = new List<string> { "Red", "Green", "Blue", "Yellow" };
int index = colors.IndexOf("Yellow");
if (index != -1)
    Console.WriteLine($"Index of Yellow: {index}");

else
    Console.WriteLine("Yellow not found in the list.");

//Test Class with static and without
TestProgram.Message("Hello");

TestingProgram testingProgram = new TestingProgram(3);
Console.WriteLine(testingProgram.I);