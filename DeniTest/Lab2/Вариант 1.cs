namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В зашрихованный области, Если Х меньше - 0,4 и х"2 + y"2 < 1 
            //На границе шриховки Х == 0,4 или Х == -1 , а Y == 0
            //Вне зашотхованной области , Если Х больше -0,4 или х"2 + y"2 > 1
            while (true)
            {
                Console.WriteLine("Введите значение Х");
                var temp = Console.ReadLine();
                if (!double.TryParse(temp, out double X))
                {
                    Console.WriteLine("Некорректный ввод данный");
                    continue;
                }
 
                Console.WriteLine("Введите значение Y");
                temp = Console.ReadLine();
                if (!double.TryParse(temp, out double Y))
                {
                    Console.WriteLine("Некорректный ввод данный");
                    continue;
                }
                if(X < -0.4 && Math.Pow(X, 2) + Math.Pow(Y, 2) < 1)
                {
                    Console.WriteLine("Точка находится в заштрихованной области");
                }
                else
                {
                    if (X > -0.4 || Math.Pow(X, 2) + Math.Pow(Y, 2) > 1)
                    {

                        Console.WriteLine("Точка находится вне области");
                    }
                    else 
                    {
                        Console.WriteLine("Точка на границе");
                    }
                }
            }
        }
    }
}