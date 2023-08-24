namespace ParPositivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite o número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0 && numero > 0)
            {
                Console.WriteLine("O número é par e positivo");
            }
            if (numero % 2 == 0 && numero < 0)
            {
                Console.WriteLine("O número é par e negativo");
            }
            if (numero % 2> 0 && numero > 0)
            {
                Console.WriteLine("O número é ímpar e positivo");
            }
            if(numero % 2 < 0 && numero < 0)
            {
                Console.WriteLine("O número é ímpar e negativo");
            }



        }
    }
}