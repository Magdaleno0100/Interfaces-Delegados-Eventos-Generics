using System;
using System.Collections.Generic;

namespace AnonimoAndLamda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entry> entriesBase = new List<Entry>
            {
                new Entry{ Name = "Nombre1", LastName = "LastName1"},
                new Entry{ Name = "Nombre2", LastName = "LastName2"},
                new Entry{ Name = "Nombre3", LastName = "LastName3"},
                new Entry{ Name = "Nombre4", LastName = "LastName4"},
            };

            List<Entry> entries1 = new List<Entry>();
            List<Entry> entries2 = new List<Entry>();
            List<Entry> entries3 = new List<Entry>();

            entries1 = entriesBase;
            entries2 = entriesBase;
            entries3 = entriesBase;

            //Utilizando una función
            entries1.Sort(CompareEntries);

            //Utilización de métodos anónimos
            entries2.Sort(delegate(Entry en1, Entry en2)
            {
                return $"{en1.Name} {en1.LastName}".CompareTo($"{en2.Name} {en2.LastName}");
            });

            //Lamda expresion
            entries3.Sort((en1, en2) => $"{en1.Name} {en1.LastName}".CompareTo($"{en2.Name} {en2.LastName}"));

            Console.WriteLine("Entries 1");
            foreach (var entrie in entries1)
            {
                Console.WriteLine(entrie.Name + entrie.LastName);
            }

            Console.WriteLine("Entries 2");
            foreach (var entrie in entries2)
            {
                Console.WriteLine(entrie.Name + entrie.LastName);
            }

            Console.WriteLine("Entries 3");
            foreach (var entrie in entries3)
            {
                Console.WriteLine(entrie.Name + entrie.LastName);
            }

            Console.ReadLine();
        }

        private static int CompareEntries(Entry en1, Entry en2)
        {
            return $"{en1.Name} {en1.LastName}".CompareTo($"{en2.Name} {en2.LastName}");
        }
    }
}
