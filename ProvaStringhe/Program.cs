using EserciziStringhe;
using System;

namespace ProvaStringhe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci la stringa:  ");
            string s1 = Console.ReadLine();
            Console.Write("Inserisci la stringa:  ");
            string s2 = Console.ReadLine();
            bool risposta = MetodiStringhe.AreEquals(s1, s2);
            Console.WriteLine($"la risposta è {risposta}");
            Console.Write("Inserisci la stringa:  ");
            string s3 = Console.ReadLine();
            bool risposta1 = MetodiStringhe.ContainsDoubleChar(s3);
            Console.WriteLine($"la risposta è {risposta1}");
            Console.Write("Inserisci la stringa:  ");
            string s4 = Console.ReadLine();
            string risposta2 = MetodiStringhe.Convert(s4);
            Console.WriteLine(risposta2);
            Console.ReadLine();
        }
    }
}
