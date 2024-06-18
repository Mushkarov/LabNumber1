using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
           var RandomNumbers = new Random();
            Console.WriteLine("Введите кол-во элементов по оси Х");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов по оси Y");
            int Y = int.Parse(Console.ReadLine());
            int[,] MyArray = new int[X,Y];
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < Y; j++)
                {
                    
                    MyArray[i,j] = RandomNumbers.Next(-100,100);
                    Console.Write(MyArray[i, j] + " ");
                    if (MyArray[i,j] > 0)
                    {
                      sum += MyArray[i,j];
                       
                    }

                }
                
                Console.WriteLine();
            }
            Console.WriteLine(sum);
        }
    }
}