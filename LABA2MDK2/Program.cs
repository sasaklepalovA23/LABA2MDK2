using System;
using System.Linq;

namespace LABA2MDK2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== ЛАБОРАТОРНАЯ РАБОТА: МЕТОДЫ И МАССИВЫ ===");
                Console.WriteLine("Выберите вариант (1-14) или 0 для выхода:");

                if (!int.TryParse(Console.ReadLine(), out int choice)) continue;
                if (choice == 0) break;

                switch (choice)
                {
                    case 1: RunVariant1(); break;
                    case 2: RunVariant2(); break;
                    case 3: RunVariant3(); break;
                    case 4: RunVariant4(); break;
                    case 5: RunVariant5(); break;
                    case 6: RunVariant6(); break;
                    case 7: RunVariant7(); break;
                    case 8: RunVariant8(); break;
                    case 9: RunVariant9(); break;
                    case 10: RunVariant10(); break;
                    case 11: RunVariant11(); break;
                    case 12: RunVariant12(); break;
                    case 13: RunVariant13(); break;
                    case 14: RunVariant14(); break;
                    default: Console.WriteLine("Неверный вариант!"); break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        static (int max, int index) ArrMax(int[] array)
        {
            int max = array[0];
            int index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) { max = array[i]; index = i; }
            }
            return (max, index);
        }
        static void RunVariant1()
        {
            int[] arr = { 3, 15, 7, 22, 1, 8 };
            var result = ArrMax(arr);
            Console.WriteLine($"Массив: {string.Join(", ", arr)}");
            Console.WriteLine($"Макс: {result.max}, Индекс: {result.index}");
        }

     
        static double Perimeter(double a, double b, double c) => a + b + c;
        static void RunVariant2()
        {
            Console.WriteLine("Введите 3 стороны треугольника:");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"Периметр: {Perimeter(a, b, c)}");
        }

     
        static double GetPow(int num, int p) => Math.Pow(num, p);
        static void RunVariant3()
        {
            Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
            Console.Write("Степень: "); int p = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {GetPow(n, p)}");
        }

        static double Distance(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        static void RunVariant4()
        {
            Console.WriteLine("Расстояние между (0,0) и (3,4): " + Distance(0, 0, 3, 4));
        }

    
        static void MinMax(ref int a, ref int b)
        {
            if (b > a) { int temp = a; a = b; b = temp; }
        }
        static void RunVariant5()
        {
            int x = 10, y = 25;
            Console.WriteLine($"До: x={x}, y={y}");
            MinMax(ref x, ref y);
            Console.WriteLine($"После: x={x} (max), y={y} (min)");
        }

    
        static int ChangeDigits(int n) => (n % 10) * 10 + (n / 10);
        static void RunVariant6()
        {
            Console.Write("Введите двузначное число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {ChangeDigits(n)}");
        }

        static int BitwiseSum(int a, int b)
        {
            int d1 = ((a / 10) + (b / 10));
            int d2 = ((a % 10) + (b % 10)) % 10;
            return d1 * 10 + d2;
        }
        static void RunVariant7()
        {
            Console.WriteLine("Побитовая сумма 34 и 59: " + BitwiseSum(34, 59));
        }

        static int[] ArrMul(int[] a, int[] b)
        {
            int[] c = new int[a.Length];
            for (int i = 0; i < a.Length; i++) c[i] = a[i] * b[i];
            return c;
        }
        static void RunVariant8()
        {
            int[] A = { 1, 5, 6 }, B = { 2, 3, 2 };
            Console.WriteLine("Результат: " + string.Join(", ", ArrMul(A, B)));
        }

    
        static int[] MakeArr(int[] a, int[] b) => a.Concat(b).ToArray();
        static void RunVariant9()
        {
            int[] A = { 1, 2 }, B = { 3, 4 };
            Console.WriteLine("Объединенный массив: " + string.Join(", ", MakeArr(A, B)));
        }

        static long Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
        static long Combinations(int n, int k) => Factorial(n) / (Factorial(k) * Factorial(n - k));
        static void RunVariant10()
        {
            int[] candidates = { 8, 10, 11 };
            foreach (int n in candidates)
                Console.WriteLine($"Для {n} кандидатов способов: {Combinations(n, 5)}");
        }

        
        static bool Palindrome(string s) => s.SequenceEqual(s.Reverse());
        static void RunVariant11()
        {
            Console.Write("Введите слово: ");
            string s = Console.ReadLine();
            Console.WriteLine(Palindrome(s) ? "Палиндром" : "Не палиндром");
        }

     
        static string ClearSpaces(string s) => s.Replace(" ", "");
        static void RunVariant12()
        {
            Console.WriteLine("Результат: " + ClearSpaces("Удаляем все пробелы"));
        }

        static string ClearWord(string text, string word) => text.Replace(word, "");
        static void RunVariant13()
        {
            Console.WriteLine("Удаляем 'мир': " + ClearWord("Привет мир, чудный мир", "мир"));
        }

      
        static void ReverseArr(int[] arr) => Array.Reverse(arr);
        static void RunVariant14()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            ReverseArr(arr);
            Console.WriteLine("Перевернутый массив: " + string.Join(", ", arr));
        }
    }
}