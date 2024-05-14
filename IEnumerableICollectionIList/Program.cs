// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Collections.Generic;

int[] values = { 1, 2, 3 };
//Array index    0  1  2


String[] strarray = { "one", "two", "three" };

Console.WriteLine(strarray[0]);
Console.WriteLine(strarray[1]);
Console.WriteLine(strarray[2]);

String[] strarray1 = new string[10];

strarray1[0] = "one";
strarray1[1] = "two";

ArrayList arlist = new ArrayList();
arlist.Add(1);  //Index of 0 
arlist.Add("Bill");  // Index of 1
arlist.Add(true); // Index of 2

arlist.Remove(1);

var arList1 = new ArrayList();
arList1.Add(1);
arList1.Add("Bill");


//Declare an Dictionary

IDictionary<int, string> numbernames = new Dictionary<int, string>();
numbernames.Add(1, "One");
numbernames.Add(2, "two");
numbernames.Add(3, "Three");

Console.WriteLine(numbernames[2]);

foreach(KeyValuePair<int, string> kvp in numbernames)
{
    Console.WriteLine("Key : {0}, value: {1}", kvp.Key, kvp.Value);
}


List<int> values2 = new List<int>() { 1, 2, 3 };

DisplayEnumerable(values2);
DisplayICollection(values2);
DisplayIList(values2);

static void DisplayEnumerable(IEnumerable<int> values)
{
    foreach (int value in values)
    {
        Console.WriteLine(value);
    }
}


static void DisplayICollection(ICollection<int> icollec)
{

    Console.WriteLine("Before adding");
    foreach (int value in icollec)
    {
        Console.WriteLine(value);
    }

    icollec.Add(4);

    Console.WriteLine("After adding");
    foreach (int value in icollec)
    {
        Console.WriteLine(value);
    }
}

static void DisplayIList(IList<int> iList)
{

    Console.WriteLine("Before adding elements in iList");
    foreach (int value in iList)
    {
        Console.WriteLine(value);
    }

    iList.Add(5);

    Console.WriteLine("After adding");
    foreach (int value in iList)
    {
        Console.WriteLine(value);
    }


    //Access elements using the id
    for (int i = 0; i < iList.Count; i++)
    {
        Console.WriteLine(iList[i]);
    }

}
