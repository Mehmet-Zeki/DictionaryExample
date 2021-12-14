using System;


namespace DictionaryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryList<string> bilgiler = new DictionaryList<string>();
            bilgiler.Add("Zeki");
            bilgiler.Add("Mehmet");
            bilgiler.Print();
            Console.WriteLine(bilgiler.Count);
        }
    }
}
