using DeniTest;
using MyLib;
using System.ComponentModel.DataAnnotations;
using System.Threading.Channels;

namespace DeniTest
{

    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 0;
            var c = (a / b) - b;           
            var v = b / 2 * Math.Log((Math.Pow(5, 2)) + (Math.Pow(2.35, 2)));
            var result = Math.Acos(c) - v;
            Console.WriteLine(result);

        }
    }
  
}