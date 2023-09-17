namespace ExCollections02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int numeroEncontrado;
                List<int> numeros = new List<int>() { 2, 5, 1, 3, 4, 9, 7, 10, 6 };

             
                Console.Write("Digite o número que você deseja encontrar: ");
                numeroEncontrado = Convert.ToInt32(Console.ReadLine());

                if (numeros.IndexOf(numeroEncontrado) != -1)
                {
                    Console.WriteLine($"O número {numeroEncontrado} está localizado na posição: " + numeros.IndexOf(numeroEncontrado));
                }
                else
                {
                    Console.WriteLine($"O número {numeroEncontrado} não foi encontrado!");
                }
            }
        }
    }