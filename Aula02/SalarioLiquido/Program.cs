namespace SalarioLiquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float salarioBruto, adicionalNot, horasExtras, desconto, salarioLiquido;

            Console.WriteLine("Insira o valor do salário bruto: ");
            salarioBruto = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor do adicional noturno: ");
            adicionalNot = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor da hora extra: ");
            horasExtras = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o valor dos descontos: ");
            desconto = Convert.ToSingle(Console.ReadLine());

            salarioLiquido = salarioBruto + adicionalNot + (horasExtras * 5) - desconto;
            Console.WriteLine("Salário líquido: "+ salarioLiquido);
        }
    }
}