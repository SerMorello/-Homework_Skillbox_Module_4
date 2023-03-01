internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("Введите количество строк матрицы");
        int lines = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите количество столбцов матрицы");
        int columns = int.Parse(Console.ReadLine());

        int sum = 0;

        int[,] nums = new int[lines, columns];

        for (int i = 0; i < lines; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                nums[i, j] = random.Next(-99, 100);

                sum = sum + nums[i, j];

                Console.Write($"{nums[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Сумма всех элементов равна {sum}");

        Console.ReadKey();
    }
}