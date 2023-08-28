namespace ExVetores01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = { 2, 5, 1, 3, 4, 9, 7, 8, 10, 6 };
            int posicao;

            for(int i = 0; i < vetor.Length; i++)
            {
                //Console.WriteLine($"vetor [{i}] = {vetor[i]}");
                
            }
            Console.WriteLine("Digite a posição que deseja encontrar: ");
            posicao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A posição é:" + Array.IndexOf(vetor,posicao));

        }
    }
}