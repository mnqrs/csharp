using System.ComponentModel.Design;

namespace Switch01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, quantidade;
            float pedido = 0;

            Console.WriteLine("Digite a sua opção: ");
            Console.WriteLine("\n--------------- Menu -----------------");
            Console.WriteLine("\n 1 - Cachorro Quente ----------- 10,00");
            Console.WriteLine("\n 2 - X-Salada ------------------ 15,00");
            Console.WriteLine("\n 3 - X-Bacon ------------------- 18,00");
            Console.WriteLine("\n 4 - Bauru --------------------- 12,00");
            Console.WriteLine("\n 5 - Refrigerante --------------  8,00");
            Console.WriteLine("\n 6 - Suco de Laranja ----------- 13,00");
            Console.WriteLine("\n\r");

            opcao = Convert.ToInt32(Console.ReadLine());
            
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Cachorro Quente");
                    break;

                case 2:
                    Console.WriteLine("X-Salada");
                    break;

                case 3:
                    Console.WriteLine("X-Bacon");
                    break;

                case 4:
                    Console.WriteLine("Bauru");
                    break;

                case 5:
                    Console.WriteLine("Refrigerante");
                    break;

                case 6:
                    Console.WriteLine("Suco de Laranja");
                    break;
            }

            Console.WriteLine("\n\r");
            Console.WriteLine("Digite a quantidade: ");
            quantidade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n\r");

            switch (opcao)
            {
                case 1:
                    pedido = (quantidade * 10);
                    break;

                case 2:
                    pedido = (quantidade * 15);
                    break;

                case 3:
                    pedido = (quantidade * 18);
                    break;

                case 4:
                    pedido = (quantidade * 12);
                    break;

                case 5:
                    pedido = (quantidade * 8);
                    break;

                case 6:
                    pedido = (quantidade * 13);
                    break;
            }
            Console.WriteLine("\n\r");
            Console.WriteLine($"Seu pedido ficou no total de {pedido}");
        }
    }
}