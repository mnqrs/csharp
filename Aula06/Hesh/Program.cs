namespace Hash
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> setNomes = new HashSet<string>()
            {
             "Allan",
            "Robson",
            "João",
            "Ingrid",
            "Allan",
            };

            foreach (var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            setNomes.Add("Monique");
            setNomes.Remove("João");

            foreach(var nome in setNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("O nome Monique existe? " + setNomes.Contains("Monique"));

            List<string> list = setNomes.ToList();

            list.Sort();

            foreach (var nome in list)
            {
                Console.WriteLine(nome);
            }
        }

    }

            
        
}