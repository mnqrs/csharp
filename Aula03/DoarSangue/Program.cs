namespace DoarSangue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            bool sim = true;
            bool nao = false;

            Console.WriteLine("Digite o nome da pessoa doadora: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa doadora: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Primeira doação de sangue? ");
            sim = Convert.ToBoolean(Console.ReadLine());
           

            if (idade >= 60 && sim == true)
            {
                Console.WriteLine($"{nome} não está apte a doar sangue!");
            } 
            
            if (idade >= 18 && idade <= 69 && nao == false)
            {
                Console.WriteLine($"{nome} está apte a doar sangue!");
            }

            if (idade <= 17)
            {
                Console.WriteLine($"{nome} não está apte a doar sangue!");
            }
        }
    }
}