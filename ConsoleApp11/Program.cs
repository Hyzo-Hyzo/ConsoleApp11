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



          

        }
    }
}