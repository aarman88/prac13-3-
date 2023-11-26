using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        try
        {
            // Чтение строк из файла
            string[] lines = File.ReadAllLines(inputFilePath);
            if (lines.Length == 0)
            {
                Console.WriteLine("Файл пуст.");
                return;
            }

            // Преобразование строк в числа
            int[] numbers = lines.Select(int.Parse).ToArray();

            // Обратный порядок чисел
            Array.Reverse(numbers);

            // Запись чисел в обратном порядке в другой файл
            File.WriteAllLines(outputFilePath, numbers.Select(num => num.ToString()));

            Console.WriteLine("Числа были записаны в файл в обратном порядке.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
