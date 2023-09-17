namespace ExHash
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> numeros = new HashSet<int>();

            Console.WriteLine("Digite 10 números inteiros: ");
            for (var i = 0; i < 10; i++)
            {
                int valor = 0;
                valor = Convert.ToInt32(Console.ReadLine());
                numeros.Add(valor);

            }
            Console.WriteLine();
            foreach (var valor in numeros)
            {
                Console.WriteLine(valor);
            }
        }
    }
}