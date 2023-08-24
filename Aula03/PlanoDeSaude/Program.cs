namespace PlanoDeSaude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();  

            Console.WriteLine($"Olá, {nome}! ");

            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine);


        }
    }
}