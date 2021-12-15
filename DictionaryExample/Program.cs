using GenericDictionary;
using System;

MyDictionary<int, string> informations = new MyDictionary<int, string>();

informations.Add(1, "Zeki");
Console.WriteLine(informations.Length);

informations.Add(2, "Mehmet");
Console.WriteLine(informations.Length);



foreach (var item in informations.Values)
{
    Console.WriteLine(item);
}