namespace ExFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int opcao;
                Queue<string> fila = new Queue<string>();
                string? cliente;

                while (true)
                {
                    Console.WriteLine("\n***************************************************");
                    Console.WriteLine("   1: Adicionar Cliente na fila. ");
                    Console.WriteLine("   2: Listar todos os Clientes");
                    Console.WriteLine("   3: Remover cliente da fila");
                    Console.WriteLine("   0: Sair");
                    Console.WriteLine("***************************************************");
                    Console.WriteLine("   Entre com a opção desejada:");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 0)
                    {
                        Console.WriteLine("Programa Finalizado!");
                        System.Environment.Exit(0);
                    }

                    switch (opcao)
                    {
                        case 1:

                            Console.Write("Digite o nome do cliente: ");
                            cliente = Console.ReadLine();
                            fila.Enqueue(cliente);

                            Console.WriteLine("Cliente adicionado com sucesso!");
                            break;

                        case 2:

                            Console.WriteLine("Lista de clientes na fila: ");

                            foreach (var usuario in fila)
                            {
                                Console.WriteLine(usuario);
                            }
                            break;

                        case 3:

                            if (fila.Count == 0)
                            {
                                Console.WriteLine("A fila está vazia!");
                            }
                            else
                            {
                                fila.Dequeue();
                                Console.WriteLine("Cliente removido da fila com sucesso!");
                            }
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }

            }
        }
    }
} 