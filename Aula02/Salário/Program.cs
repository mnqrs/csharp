namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salario, abono;

            Console.WriteLine("Digite o valor do salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o valor do abono: ");
            abono = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Novo salário: " + (salario + abono));



        }
    }
}