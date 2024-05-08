using System.Text;

namespace DZ_2._C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
               int [] A = new int[5];
               int [,] B = new int[3, 4];


               //Вводим числа массива A
               Console.WriteLine("Введите 5 чисел массива A:");
               for (int i = 0; i < A.Length; i++)
               {
                   A[i] = Convert.ToInt32(Console.ReadLine());
               }

               //Заполняем массив В случайными числами
               Random rand = new Random();
               for (int i = 0;i < B.GetLength(0);i++) {
                   for (int j = 0;j < B.GetLength(1); j++)
                   {
                       B[i,j] = rand.Next(1,10);
                   }
               }

               //Выводим массивы на экран

               Console.WriteLine("Массив А:");
                   foreach (int  num  in A) { Console.Write(num + " "); };
               Console.WriteLine();

               Console.WriteLine("Массив В:");
               for(int i = 0;i<B.GetLength(0);i++)
               {
                   for (int j = 0; j < B.GetLength(1); j++)
                   {
                       Console.Write(B[i,j] + "\t");
                   }
                   Console.WriteLine() ;
               }

               Console.WriteLine('\n');

               //Вычисляем максимальный эллемент массивов
               int maxA = A[0];
               int maxB = B[0,0];
               int maxOverall= int.MinValue;
               foreach (int i in A) { if (i > maxA) maxA = i; }
               foreach (int i in B) { if (maxB > i) maxB = i; }
               maxOverall = Math.Max(maxA,maxB);

               Console.WriteLine("Максимальный элемент массивов А и В = " + maxOverall);

               //Вычисляем минимальный элемент массивов
               int minA = A[0];
               int minB = B[0,0];
               int minOverall= int.MaxValue;
               foreach (int i in A) { if (i < minA) minA = i; }
               foreach (int i in B) { if (i < minB) minB = i; }
               minOverall= Math.Min(minA,minB);

               Console.WriteLine("Минимальный элемент массивов А и В = "+ minOverall);

               Console.WriteLine();

               //Вычисляем суумму массивов А и В
               int summA = 0;
               int summB = 0;
               int summOverall = 0;
               foreach (int i in A) { summA += i; }
               foreach (int i in B) { summB += i; }
               summOverall = summA + summB;
               Console.WriteLine("Сумма элементов массивов А и В = " + summOverall);

               Console.WriteLine();

               //Вычисляем произведение массивов А и В
               int prodA = 1;
               int prodB = 1;
               int prodOverall = 1;
               foreach (int i in A) { prodA *= i; }
               foreach (int i in B) { prodB *= i; }
               prodOverall = prodA * prodB;
               Console.WriteLine("Произведение элементов массивов А и В = " + prodOverall);

               Console.WriteLine();

               //Вычисляем сумму четных элементов массива А
               int sumEventA = 0;
               foreach(int i in A) { if( i % 2 == 0)sumEventA += i; }
               Console.WriteLine("Сумма четных элементов массива А = " + sumEventA);
               Console.WriteLine();

               //Вычисляем сумму нечетных столбцов массива В
               int sumOddColummsB = 0;
               for(int j = 0; j < B.GetLength(1); j++)
               {
                   if (j % 2 != 0)
                   {
                       for (int i = 0; i < B.GetLength(0); i++)
                       { sumOddColummsB += B[i, j]; }
                   }
               }
               Console.WriteLine("Сумма нечетных столбцов массива В = " +  sumOddColummsB);

               Console.WriteLine("\n\n");
   


            //Задача 2

            int[,] arr = new int[5, 5];
            

            //Заполняеи массив случайными числами
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(1, 5);
                }
            }

            //Выводим массив на экран
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Находим минимальный и максимальный элемент массива
            int minRow = 0, minCol = 0;
            int maxRow = 0, maxCol = 0;
            int minValue = arr[0, 0];
            int maxValue = arr[0, 0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < minValue)
                    {
                        minValue = arr[i, j];
                        minRow = i; minCol = j;
                    }
                    if (arr[i, j] > maxValue)
                    {
                        maxValue = arr[i, j];
                        maxRow = i; maxCol = j;
                    }
                }
            }

            //Вычисляем сумму элементов между минимальным и максимальным элементом массива
            int sum = 0;
            int startRow = Math.Min(minRow, maxRow); //определяем начальную строку для суммирования
            int endRow = Math.Max(minRow, maxRow);   //определяем конечную строку для суммирования
            int startCol = Math.Min(minCol, maxCol); //определяем начальный столбец для суммирования
            int endCol = Math.Max(minCol, maxCol);   //определяес конечный столбец для суммирования

            //Запускаем цикл для нахождения суммы
            for (int i = startRow; i <= endRow; i++)
            {
                for (int j = startCol; j <= endCol; j++)
                {
                    sum += arr[i, j];
                }
            }

            Console.WriteLine("Сумма между минимальным и максимальным элементом массива = " + sum);

            Console.WriteLine("\n\n");

            //Задача 3
            //Считываем строку от пользователя
            Console.WriteLine("Введите строку дял шифрования:");
            string originalString = Console.ReadLine();

            Console.WriteLine("Введите сдвиг для шифрования:");
            int shift = int.Parse(Console.ReadLine());

            //Шифруем строку
            string encryptedString = "";
            foreach (char c in originalString)
            {
                if (char.IsLetter(c)) // прверяем является ли символ буквой
                {
                    encryptedString += Convert.ToChar(Convert.ToInt16(c) + shift);
                }
                else
                {
                    encryptedString += c;
                }
            }
            Console.WriteLine("Зашиврованная строка:" + encryptedString);

            //Дешифруем строку
            string decryptedString = "";
            foreach (char c in encryptedString)
            {
                if (char.IsLetter(c))
                {
                   decryptedString += Convert.ToChar(Convert.ToInt16(c) - shift);
                }
                else
                {
                    decryptedString += c;
                }
            }

            Console.WriteLine("Дешифрованная строка:" + decryptedString);

            Console.WriteLine("\n\n");

            //Задача 4
            Console.WriteLine("Введите арифметическое выражение:");
            string expression = Console.ReadLine();

            double result = 0;
            string number = "";
            string operation = "+"; // Начальная операция - сложение

            foreach (char symbol in expression)
            {
                if (char.IsDigit(symbol) || symbol == '.')
                {
                    number += symbol;
                }
                else if (symbol == '+' || symbol == '-')
                {
                    if (!string.IsNullOrEmpty(number))
                    {
                        if (operation == "+")
                        {
                            result += double.Parse(number);
                        }
                        else if (operation == "-")
                        {
                            result -= double.Parse(number);
                        }
                        number = "";
                    }
                    operation = symbol.ToString();
                }
            }

            // Обработка последнего числа
            if (!string.IsNullOrEmpty(number))
            {
                if (operation == "+")
                {
                    result += double.Parse(number);
                }
                else if (operation == "-")
                {
                    result -= double.Parse(number);
                }
            }

            Console.WriteLine("Результат: " + result);

            Console.WriteLine("\n\n");

            //Задача 5
            Console.WriteLine("Введите текст:");
            string intput = Console.ReadLine();

            StringBuilder output = new StringBuilder();
            bool newSentence = true;

            foreach (char i in intput)
            {
                if (newSentence && char.IsLetter(i))
                {
                    output.Append(char.ToUpper(i));
                    newSentence = false;
                }
                else { output.Append(i); }


                if (i == '.')
                {
                    newSentence = true;
                }

            }
            Console.Write("Результат:");
            Console.WriteLine(output.ToString());
            Console.WriteLine("\n\n");

            //Задание 6

            string text = "To be, or not to be, that is the question,\n " +
              "Or to take arms against a sea of troubles, \n" +
              "And by opposing end them? To die: to sleep; \n" +
              "No more; and by a sleep to say we end \n" +
              "Devoutly to be wish'd. To die, to sleep\n";
            string forbiddenWord = "die";
            int count = 0;

            int index = text.IndexOf(forbiddenWord, StringComparison.OrdinalIgnoreCase);
            while (index != -1)
            {
                string replacement = new string('*', forbiddenWord.Length);
                text = text.Remove(index, forbiddenWord.Length).Insert(index, replacement);
                count++;

                index = text.IndexOf(forbiddenWord, index + replacement.Length, StringComparison.OrdinalIgnoreCase);
            }

            Console.WriteLine(text);
            Console.WriteLine("Количество вхождений запрещенного слова: " + count);

        }
    }
}