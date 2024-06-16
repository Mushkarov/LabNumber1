namespace Lab_4_V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CounterSum = 0;
            var СounterNull = 0;
            var СounterNegative = 0;
            int[] Number = new int[15];
            
            for (int i = 0; i <= 15; i++)
            {
                var temp = 0;
                if (i < 15)
                {
                    Console.WriteLine($"Введите {i + 1} число");
                    if (int.TryParse(Console.ReadLine(), out temp))
                    {
                        Number[i] = temp;
                    }
                    else
                        Console.WriteLine("Некорректный ввод данных");
                }   
                
            }
            for (int i = 0;i < Number.Length; i++)
            {
                
                if (Number[i] < 0)
                {
                    СounterNegative ++;
                }
                if (Number[i] == 0)
                {
                    СounterNull ++;
                }
                if (Number[i] > 0)
                {
                    CounterSum = CounterSum + Number[i];
                }

            }

            Console.WriteLine("Количество отрицительных чисел = " + СounterNegative);
            Console.WriteLine("Количество чисел раных 0 = " + СounterNull);
            Console.WriteLine("Сумма всех положительных чисел - " + CounterSum);
        }
    }
}