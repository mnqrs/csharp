namespace ExMatriz02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,]matriz = new double[10, 4];
            double[] vetores = new double[10];

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(2); j++)
                    Console.Write($"matriz");
                matriz[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }
    }
}