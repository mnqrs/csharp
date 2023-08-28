namespace ExVetores02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            float soma = 0;
            float media = 0;

            Console.WriteLine("Digite os números: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"vetor[{i}] = {vetor[i]}");
            }

            Console.WriteLine("Elementos nos índices ímpares: ");
            for(int i = 0; i < vetor.Length; i++)

            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(vetor[i] + " ");
                }
            }

            Console.WriteLine("Elementos pares: ");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i] + " ");
                }
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
                media = soma / 10;
            }
            Console.WriteLine($"O valor da soma dos elementos é {soma} e o valor da média é {media}.");
        }
    }
}