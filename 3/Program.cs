using System;

namespace lab3_14v
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во символов, которые будут в массиве: ");
            int N = Int32.Parse(Console.ReadLine());
            int[] mas = new int[N];
            Random random = new Random();
            int rand;
            for (int i = 0; i < N; i++)
            {
                rand = random.Next(-10, 10);
                mas[i] = rand;
            }

            #region Numbe
            Console.WriteLine("Числа в массиве:");
            for (int i = 0; i < N; i++)
                Console.Write(mas[i] + " ");
            #endregion
            Console.WriteLine();
            #region "С"
            Console.WriteLine("Введите число 'С':");
            int c = Int32.Parse(Console.ReadLine());
            int num = 0;
            for (int i = 0; i < N; i++)
                if (mas[i] < c)
                {
                    num++;
                }
            Console.WriteLine("Кол-во элементов меньше 'с': " + num);
            #endregion
        }
    }
}
