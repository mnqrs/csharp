namespace Calculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, num4;

            Console.WriteLine("Insira o primeiro número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o segundo número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o terceiro número: ");
            num3 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o quarto número: ");
            num4 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("O resultado é: " + ((num1 * num2) - (num3 * num4)));

        }
    }
}