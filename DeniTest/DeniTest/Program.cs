using Lab1;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Lab1
{

    internal class Program
    {
        static void Main(string[] args)
        {


                
                double C = 0;
                double A = 0;
                double B = 0;
           for (var i = 0; i == A; i++)
            {
                
               
                Console.WriteLine("Введите чисто А");
                
                var chek = double.Parse(Console.ReadLine());
                if (chek != 0)
                {
                    A = chek;
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод данных");

                    i--;
                }
            }

            Console.WriteLine("Введите чисто B");
            var chek1 = double.Parse(Console.ReadLine());
            if (chek1 != 0)
            {
                B = chek1;
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных");

            }
            var chek3 = (A / B) - B;
            if (chek3 >= -1 & chek3 <= 1)
            {
                C = chek;
            }
            else
            {
                Console.WriteLine("Некорректный ввод данных");
            }
            var I = Math.Acos(C);
            var result = I - (B / 2 * Math.Log(Math.Pow(A, 2) + Math.Pow(B, 2)));
            Console.WriteLine(result);
            Console.ReadLine();
            Console.Clear();


        }
        
    }
  
}