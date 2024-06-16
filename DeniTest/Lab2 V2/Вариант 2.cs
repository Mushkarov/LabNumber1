namespace Lab2_V2
{
    internal class Program
    {
        //Если Х больше 0.5 , то не заштрихованный 
        //Если Х меньше 0.5 , но х"2 + у"2 < 1 , то не заштрихованный
        //Eсли Х меньше 0.5 , но х"2 + у"2 > 1 , и у > 0 , то не заштрихованный
        // Если Х меньше 0.5 и х"2 + у"2 > 1 , и у < 0 , то зашрихованный
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите значение Х");
                var temp = Console.ReadLine();
                if (!double.TryParse(temp, out double X))
                {
                    Console.WriteLine("Некорректный ввод данный");
                    continue;
                }
               if (X > 0.5)
               {
                    Console.WriteLine("Точка находится вне заштрихованной области");
                }

                Console.WriteLine("Введите значение Y");
                temp = Console.ReadLine();
                if (!double.TryParse(temp, out double Y))
                {
                    Console.WriteLine("Некорректный ввод данный");
                    continue;
                }
                if (Math.Pow(X , 2) + Math.Pow(Y , 2) < 1)
                {
                    Console.WriteLine("Точка находится вне заштрихованной области");
                }
                if (Math.Pow(X, 2) + Math.Pow(Y, 2) > 1 && Y > 0)
                {
                    Console.WriteLine("Точка находится вне заштрихованной области");
                }
                if (Math.Pow(X, 2) + Math.Pow(Y, 2) > 1 && Y < 0 && X < 0.5)
                {
                    Console.WriteLine("Точка находится в заштрихованной области");
                }
                if (Math.Pow(X, 2) + Math.Pow(Y, 2) == 1 && X < 0.5 && Y < 0)
                {
                    Console.WriteLine("Точка находитсмя на границе");
                }
                if ( X < -1 && Y == 0  | X == 0 && Y < -1)
                {
                    Console.WriteLine("Точка находитсмя на границе");
                }
                if (X == 0.5 && Math.Pow(X, 2) + Math.Pow(Y, 2) > 1 && Y < -0.5)
                {
                    Console.WriteLine("Точка находитсмя на границе");

                }


            }
        }
    }
}