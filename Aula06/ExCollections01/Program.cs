using System;
using System.Runtime.CompilerServices;

namespace ExCollections01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cor = new List<string>();
            
                
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite uma cor: ");

                cor.Add(Console.ReadLine());
            }

            Console.WriteLine(" "); 

            foreach(var nome in cor)
            {
               Console.WriteLine(nome);

            }

            cor.Sort();
            Console.WriteLine(" ");
            foreach (var nome in cor)
            {
                Console.WriteLine(nome);

            }
        }
    }
}