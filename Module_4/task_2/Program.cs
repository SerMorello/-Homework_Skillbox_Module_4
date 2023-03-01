namespace task_2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rndm = new Random();
            int sum_first = 0;
            int sum_second = 0;
            int sum_total= 0;

            Console.WriteLine("Введите число строк матрицы");
            int lines = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите число столбцов матрицы");
            int columns = Int32.Parse(Console.ReadLine());

            int[,] nums_first = new int[lines, columns];
            int[,] nums_second = new int[lines, columns];
            int[,] nums_total = new int[lines, columns];

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nums_first[i, j] = rndm.Next(-99, 100);

                    Console.Write($"{nums_first[i, j]} ");

                    sum_first = sum_first + nums_first[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех элементов первого матрицы равна {sum_first}");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nums_second[i, j] = rndm.Next(-99, 100);

                    Console.Write($"{nums_second[i, j]} ");

                    sum_second = sum_second + nums_second[i, j];
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех элементов первого матрицы равна {sum_second}");

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    nums_total[i, j] = nums_first[i,j] + nums_second[i,j];
                    Console.Write($"{nums_total[i,j]} ");
                    sum_total = sum_total + nums_total[i, j];

                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма всех элементов первого матрицы равна {sum_second}");
        }
    }
}