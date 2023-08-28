namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] vetor02 = new int[5];

            string[] vetor03 = new string[5];

          

            //for (int indice = 0; indice < 10; indice++)
            //{
            //    Console.WriteLine($"vetor01 [{indice}] = {vetor01[indice]}");

            //}
            //for (int indice = 0; indice < 5; indice++)
            //{
            //    Console.Write($"vetor02 [{indice}] = "); 
            //    vetor02[indice] = Convert.ToInt32( Console.ReadLine() );
            //}
            //Array.Sort( vetor02 );

            //for (int indice = 0; indice < 5; indice++)
            //{
            //    Console.WriteLine($"vetor02[{indice}] =  {vetor02[indice]}");

            //}
            for(int indice  = 0; indice < 5; indice++)
            {
                Console.Write($"vetor03[{indice}]= ");
                vetor03[indice] = Convert.ToString(Console.ReadLine() );
            }
            Array.Sort ( vetor03 );

            for (int indice = 0; indice < 5; indice++)
            {
                Console.WriteLine($"vetor03 [{indice}] = {vetor03[indice]}");
            }
            Console.WriteLine("A posição é igual a: " + Array.IndexOf(vetor03, "cinza")); 

        }
    }
}