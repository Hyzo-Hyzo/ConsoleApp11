using System.IO;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1(1-3)
            //1
            string file = "D:\\visualST\\ConsoleApp11\\ConsoleApp11\\test.txt";
            //File.Create(file); // створити файл
            string rez = File.ReadAllText(file); // зчитати весь текст з файлу
            Console.WriteLine("Rezult: " + rez);
            if (File.Exists(file))
            {
                string rez1 = File.ReadAllText(file);
                Console.WriteLine("Вміст файлу:");
                Console.WriteLine(rez1);
            }
            else
            {
                Console.WriteLine("Файл не існує. Помилка!");
            }
            //2
            Console.WriteLine("Введіть 10 елементів:");

            string[] elements = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Елемент {i + 1}: ");
                elements[i] = Console.ReadLine();
            }
            try
            {
                using (StreamWriter input = new StreamWriter(file))
                {
                    foreach (string element in elements)
                    {
                        input.WriteLine(element);
                    }
                }

                Console.WriteLine("Елементи  збережено ");
            }
            catch (Exception notfound)
            {
                Console.WriteLine($"Помилка при збереженні  у файлі: {notfound.Message}");
            }
            //3
            Console.WriteLine("Ваші введені елементи");           

            foreach (string element in elements)
            {
                Console.WriteLine(element);
            }

            // task4
            Random random = new Random();
            int[] numbers = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                numbers[i] = random.Next(1, 10001);
            }

            string evenNumbersFile = "D:\\visualST\\ConsoleApp11\\ConsoleApp11\\even_numbers.txt";
            string oddNumbersFile = "D:\\visualST\\ConsoleApp11\\ConsoleApp11\\odd_numbers.txt";

            using (StreamWriter evenWriter = new StreamWriter(evenNumbersFile))
            using (StreamWriter oddWriter = new StreamWriter(oddNumbersFile))
            {
                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        evenWriter.WriteLine(number);
                    }
                    else
                    {
                        oddWriter.WriteLine(number);
                    }
                }
            }

            int evenCount = CountNumbers(evenNumbersFile);
            int oddCount = CountNumbers(oddNumbersFile);

            Console.WriteLine("Статистика:");
            Console.WriteLine($"Загальна кількість чисел: {numbers.Length}");
            Console.WriteLine($"Кількість парних чисел: {evenCount}");
            Console.WriteLine($"Кількість непарних чисел: {oddCount}");

            Console.ReadLine();
        }

        static int CountNumbers(string fileName)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(fileName))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }

            return count;



        }
    }
}