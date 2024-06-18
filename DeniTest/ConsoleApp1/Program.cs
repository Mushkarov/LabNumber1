namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите количество строк : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("введите количество столбцов : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[,] mas = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = r.Next(100);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
                {
                    Console.ReadKey(true);
                }
      
            }
        }
    }
}