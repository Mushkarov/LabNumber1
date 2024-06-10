namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Для решения задачи будем использовать уравнение окружности х ^ 2 + y ^ 2.
            // Так как R = 1, то уравнение принимает вид х ^ 2 + y ^ 2 = 1
            //2.Определяем условие, при котором точка будет находиться внутри
            // заштрихованной области: (x > 0.5) и (х ^ 2 + y ^ 2 < 1).
            //3.Определяем условие, при котором точка будет находиться вне
            // заштрихованной области: (x < 0.5) или (х ^ 2 + y ^ 2 > 1)
            while (true)
            {
                Console.WriteLine("Введите значение Х");
                var temp = Console.ReadLine();
                if (!double.TryParse(temp, out double X))
                {
                    Console.WriteLine("Некорректный ввод данный");
                    continue;
                }
                if (X < 0.5)
                {
                    Console.WriteLine("Точка находится вне заштрихованной области");
                    continue;
                }
                if (X == 0.5)
                {
                    Console.WriteLine("Точка находится на границе");
                    continue;
                }
                Console.WriteLine("Введите значение Y");
                temp = Console.ReadLine();
                if (!double.TryParse(temp, out double Y))
                {
                    Console.WriteLine("Некорректный ввод данный");
                    continue;
                }
                if (X > 0.5 && (Math.Pow(X, 2) + Math.Pow(Y, 2)) < 1)
                {
                    Console.WriteLine("Точка находтся внутри заштрихованной области");
                    continue;
                }
                if ((Math.Pow(X, 2) + Math.Pow(Y, 2)) > 1)
                {

                    Console.WriteLine("Точка находится вне заштрихованной области");
                }
            }
        }
    }
}