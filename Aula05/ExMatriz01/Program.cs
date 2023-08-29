namespace ExMatriz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int somaPrincipal = 0, somaSecundaria = 0;
            string diagonalPrinc = "", diagonalSec = "";


            for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
            {
                for (int ic = 0; ic < Math.Sqrt(matriz.Length); ic++)
                {
                    Console.Write($"matriz[{i}, {ic}] = ");
                    matriz[i, ic] = Convert.ToInt32(Console.ReadLine());

                }
            }
            for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
            {
                diagonalPrinc += matriz[i, i] + " ";
                somaPrincipal += matriz[i, i];
            }

            for (int i = 0; i < Math.Sqrt(matriz.Length); i++)
            {
                diagonalSec += matriz[i, (int)(Math.Sqrt(matriz.Length) - 1 - i)] + " ";
                somaSecundaria += matriz[i, (int)(Math.Sqrt(matriz.Length) - 1 - i)];
            }
            Console.WriteLine("Elementos da Diagonal Principal " + diagonalPrinc);
            Console.WriteLine("Soma da Diagonal Principal " + somaPrincipal);
            Console.WriteLine("Elementos da Diagonal Secundária " + diagonalSec);
            Console.WriteLine("Soma da Diagonal Secundária " + somaSecundaria);
        }
    }
}
