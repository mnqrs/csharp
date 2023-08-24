namespace Switch02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, resultado = 0;
            int opcao;

            Console.WriteLine("############# CALCULADORA #############");

            Console.WriteLine("Digite o primeiro número: ");
            num1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Selecione um dos operadores abaixo para obter o resultado: ");
            Console.WriteLine(" ----- 1. Soma -----");
            Console.WriteLine(" ----- 2. Subtração -----");
            Console.WriteLine(" ----- 3. Multiplicação ------");
            Console.WriteLine(" ----- 4. Divisão ----- ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: 
                    resultado = num1 + num2;
                    break;

                case 2:
                    resultado = num1 -num2;
                    break;

                case 3:
                    resultado = num1 *num2;
                    break;

                case 4:
                    resultado = num1 /num2;
                    break;

                default:
                    Console.WriteLine("Operação Inválida :(");
                    break;
            }

            Console.WriteLine($"O resultado é: {resultado}");   

        }
    }
}