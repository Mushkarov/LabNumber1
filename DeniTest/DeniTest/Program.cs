using Lab1;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace Lab1
{

    internal class Program
    {
        static void Main(string[] args)
        {  
            double C;
            double A;
            double B;
            while (true)
            {
                while (true)
                {
                    Console.WriteLine("Введите чисто А");

                    var chekOne = Console.ReadLine();
                    if (double.TryParse(chekOne, out A))
                    {
                        break;
                    }
                    Console.WriteLine("Некорректный ввод данных");
                }
                while (true)
                {
                    Console.WriteLine("Введите чисто B");
                    var chekTwo = (Console.ReadLine());
                    var R = double.TryParse(chekTwo, out B);
                    if (B != 0 & R)
                    {

                        break;
                    }
                    Console.WriteLine("Некорректный ввод данных");
                }
                var temp = (A / B) - B;
                if (temp >= -1 & temp <= 1)
                {
                    C = temp;
                    break;
                }                              
                    Console.WriteLine("Некорректно введены данные , выход за область значений");              
            }
                var I = Math.Acos(C);
                var result = I - (B / 2 * Math.Log(Math.Pow(A, 2) + Math.Pow(B, 2)));
                Console.WriteLine(result);
                Console.ReadLine();
                Console.Clear();            
        }
        
    }
  
}