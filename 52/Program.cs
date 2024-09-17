/// задние 1
//Console.WriteLine("Введите первое число");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите второе число");
//int b = Convert.ToInt32(Console.ReadLine());

//string cal = Console.ReadLine();

//switch (cal)
//{
//    case "+":
//        Console.WriteLine(a + b); break;
//    case "-":
//        Console.WriteLine(a - b); break;
//    case "*":
//        Console.WriteLine(a * b); break;
//    case "/":
//        Console.WriteLine(a / b); break;
//}

/// задние 2
//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string input = Console.ReadLine();

//        int charCount = input.Length;

//        // Разделить строку на слова
//        string[] words = input.Split(new[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//        int wordCount = words.Length;

//        // Разделить строку на предложения
//        string[] sentences = input.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//        int sentenceCount = sentences.Length;

//        Console.WriteLine($"Количество символов: {charCount}");
//        Console.WriteLine($"Количество слов: {wordCount}");
//        Console.WriteLine($"Количество предложений: {sentenceCount}");
//    }
//}

/// задание 3

//using System;

//namespace MultiplicationTable
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 10; i++)
//            {
//                for (int j = 1; j <= 10; j++)
//                {
//                    Console.Write($"{i} * {j} = {i * j}\t");
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}


/// задание 4 

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите число:");
//        int number = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine($"Факториал числа {number} равен {Factorial(number)}");
//    }

//    static int Factorial(int n)
//    {
//        if (n == 0)
//            return 1;
//        else
//            return n * Factorial(n - 1);
//    }
//}

/// задание 5

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите количество чисел ряда Фибоначчи, которые нужно вывести: ");
//        int n = int.Parse(Console.ReadLine());

//        int a = 0;
//        int b = 1;

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write(a + " ");

//            int temp = a;
//            a = b;
//            b = temp + b;
//        }
//    }
//}

/// задание 6

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число n: ");
//        int n = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Простые числа от 1 до {n}:");
//        for (int i = 2; i <= n; i++)
//        {
//            bool isPrime = true;
//            for (int j = 2; j <= Math.Sqrt(i); j++)
//            {
//                if (i % j == 0)
//                {
//                    isPrime = false;
//                    break;
//                }
//            }
//            if (isPrime)
//            {
//                Console.WriteLine(i);
//            }
//        }
//    }
//}

/// задание 7

//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int targetNumber = random.Next(1, 101);
//        int userGuess = 0;
//        int attempts = 0;

//        Console.WriteLine("Угадайте число от 1 до 100:");

//        while (userGuess != targetNumber)
//        {
//            Console.Write("Введите ваше предположение: ");
//            string input = Console.ReadLine();

//            // Проверка корректности ввода
//            if (int.TryParse(input, out userGuess))
//            {
//                attempts++;

//                if (userGuess < targetNumber)
//                {
//                    Console.WriteLine("Загаданное число больше.");
//                }
//                else if (userGuess > targetNumber)
//                {
//                    Console.WriteLine("Загаданное число меньше.");
//                }
//                else
//                {
//                    Console.WriteLine($"Поздравляем! Вы угадали число {targetNumber} с {attempts} попытки(-ок).");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Введите корректное число.");
//            }
//        }
//    }
//}

/// задание 8

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Выберите фигуру для расчета площади:");
//        Console.WriteLine("1. Круг");
//        Console.WriteLine("2. Треугольник");
//        Console.WriteLine("3. Прямоугольник");
//        Console.Write("Введите номер фигуры: ");

//        string choice = Console.ReadLine();

//        switch (choice)
//        {
//            case "1":
//                CalculateCircleArea();
//                break;
//            case "2":
//                CalculateTriangleArea();
//                break;
//            case "3":
//                CalculateRectangleArea();
//                break;
//            default:
//                Console.WriteLine("Некорректный выбор.");
//                break;
//        }
//    }

//    static void CalculateCircleArea()
//    {
//        Console.Write("Введите радиус круга: ");
//        if (double.TryParse(Console.ReadLine(), out double radius))
//        {
//            double area = Math.PI * Math.Pow(radius, 2);
//            Console.WriteLine($"Площадь круга: {area:F2}");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }

//    static void CalculateTriangleArea()
//    {
//        Console.Write("Введите основание треугольника: ");
//        if (double.TryParse(Console.ReadLine(), out double baseLength))
//        {
//            Console.Write("Введите высоту треугольника: ");
//            if (double.TryParse(Console.ReadLine(), out double height))
//            {
//                double area = 0.5 * baseLength * height;
//                Console.WriteLine($"Площадь треугольника: {area:F2}");
//            }
//            else
//            {
//                Console.WriteLine("Некорректный ввод высоты.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод основания.");
//        }
//    }

//    static void CalculateRectangleArea()
//    {
//        Console.Write("Введите длину прямоугольника: ");
//        if (double.TryParse(Console.ReadLine(), out double length))
//        {
//            Console.Write("Введите ширину прямоугольника: ");
//            if (double.TryParse(Console.ReadLine(), out double width))
//            {
//                double area = length * width;
//                Console.WriteLine($"Площадь прямоугольника: {area:F2}");
//            }
//            else
//            {
//                Console.WriteLine("Некорректный ввод ширины.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод длины.");
//        }
//    }
//}

/// 9

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Выберите тип конвертации:");
//        Console.WriteLine("1. Метры в километры");
//        Console.WriteLine("2. Километры в метры");
//        Console.WriteLine("3. Килограммы в граммы");
//        Console.WriteLine("4. Граммы в килограммы");
//        Console.WriteLine("5. Цельсий в Фаренгейт");
//        Console.WriteLine("6. Фаренгейт в Цельсий");
//        Console.Write("Введите номер конвертации: ");

//        string choice = Console.ReadLine();

//        switch (choice)
//        {
//            case "1":
//                ConvertMetersToKilometers();
//                break;
//            case "2":
//                ConvertKilometersToMeters();
//                break;
//            case "3":
//                ConvertKilogramsToGrams();
//                break;
//            case "4":
//                ConvertGramsToKilograms();
//                break;
//            case "5":
//                ConvertCelsiusToFahrenheit();
//                break;
//            case "6":
//                ConvertFahrenheitToCelsius();
//                break;
//            default:
//                Console.WriteLine("Некорректный выбор.");
//                break;
//        }
//    }

//    static void ConvertMetersToKilometers()
//    {
//        Console.Write("Введите значение в метрах: ");
//        if (double.TryParse(Console.ReadLine(), out double meters))
//        {
//            double kilometers = meters / 1000;
//            Console.WriteLine($"{meters} метров = {kilometers} километров");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }

//    static void ConvertKilometersToMeters()
//    {
//        Console.Write("Введите значение в километрах: ");
//        if (double.TryParse(Console.ReadLine(), out double kilometers))
//        {
//            double meters = kilometers * 1000;
//            Console.WriteLine($"{kilometers} километров = {meters} метров");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }

//    static void ConvertKilogramsToGrams()
//    {
//        Console.Write("Введите значение в килограммах: ");
//        if (double.TryParse(Console.ReadLine(), out double kilograms))
//        {
//            double grams = kilograms * 1000;
//            Console.WriteLine($"{kilograms} килограммов = {grams} граммов");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }

//    static void ConvertGramsToKilograms()
//    {
//        Console.Write("Введите значение в граммах: ");
//        if (double.TryParse(Console.ReadLine(), out double grams))
//        {
//            double kilograms = grams / 1000;
//            Console.WriteLine($"{grams} граммов = {kilograms} килограммов");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }

//    static void ConvertCelsiusToFahrenheit()
//    {
//        Console.Write("Введите значение в градусах Цельсия: ");
//        if (double.TryParse(Console.ReadLine(), out double celsius))
//        {
//            double fahrenheit = (celsius * 9 / 5) + 32;
//            Console.WriteLine($"{celsius} градусов Цельсия = {fahrenheit} градусов Фаренгейта");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }

//    static void ConvertFahrenheitToCelsius()
//    {
//        Console.Write("Введите значение в градусах Фаренгейта: ");
//        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
//        {
//            double celsius = (fahrenheit - 32) * 5 / 9;
//            Console.WriteLine($"{fahrenheit} градусов Фаренгейта = {celsius} градусов Цельсия");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод.");
//        }
//    }
//}

/// задание 10

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число: ");
//        if (double.TryParse(Console.ReadLine(), out double number))
//        {
//            Console.Write("Введите процент, который хотите вычислить: ");
//            if (double.TryParse(Console.ReadLine(), out double percentage))
//            {
//                double result = (percentage / 100) * number;
//                Console.WriteLine($"{percentage}% от {number} равно {result}");
//            }
//            else
//            {
//                Console.WriteLine("Некорректный ввод процента.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод числа.");
//        }
//    }
//}

/// задание 11

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Выберите исходную валюту:");
//        Console.WriteLine("1. Доллар (USD)");
//        Console.WriteLine("2. Евро (EUR)");
//        Console.WriteLine("3. Йена (JPY)");
//        Console.WriteLine("4. Юань (CNY)");
//        Console.Write("Введите номер исходной валюты: ");
//        string fromCurrency = Console.ReadLine();

//        Console.WriteLine("Выберите целевую валюту:");
//        Console.WriteLine("1. Доллар (USD)");
//        Console.WriteLine("2. Евро (EUR)");
//        Console.WriteLine("3. Йена (JPY)");
//        Console.WriteLine("4. Юань (CNY)");
//        Console.Write("Введите номер целевой валюты: ");
//        string toCurrency = Console.ReadLine();

//        Console.Write("Введите сумму для конвертации: ");
//        if (double.TryParse(Console.ReadLine(), out double amount))
//        {
//            double exchangeRate = GetExchangeRate(fromCurrency, toCurrency);

//            if (exchangeRate != 0)
//            {
//                double convertedAmount = amount * exchangeRate;
//                Console.WriteLine($"Конвертированная сумма: {convertedAmount:F2}");
//            }
//            else
//            {
//                Console.WriteLine("Некорректная комбинация валют.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некорректный ввод суммы.");
//        }
//    }

//    static double GetExchangeRate(string fromCurrency, string toCurrency)
//    {
//        // Заданные курсы обмена (примерные значения, не актуальные)
//        if (fromCurrency == "1" && toCurrency == "2") return 0.85;   // USD -> EUR
//        if (fromCurrency == "1" && toCurrency == "3") return 110.0;  // USD -> JPY
//        if (fromCurrency == "1" && toCurrency == "4") return 6.5;    // USD -> CNY
//        if (fromCurrency == "2" && toCurrency == "1") return 1.11;   // EUR -> USD
//        if (fromCurrency == "2" && toCurrency == "3") return 162.28; // EUR -> JPY
//        if (fromCurrency == "2" && toCurrency == "4") return 7.88;   // EUR -> CNY
//        if (fromCurrency == "3" && toCurrency == "1") return 0.0091; // JPY -> USD
//        if (fromCurrency == "3" && toCurrency == "2") return 0.0077; // JPY -> EUR
//        if (fromCurrency == "3" && toCurrency == "4") return 0.059;  // JPY -> CNY
//        if (fromCurrency == "4" && toCurrency == "1") return 0.15;   // CNY -> USD
//        if (fromCurrency == "4" && toCurrency == "2") return 0.13;   // CNY -> EUR
//        if (fromCurrency == "4" && toCurrency == "3") return 16.95;  // CNY -> JPY

//        return 0; // Вернуть 0, если нет подходящей комбинации валют
//    }
//}

/// задание 12

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Пример массива
//        int[] numbers = { 34, 72, 13, 44, 25, 30, 10, 65, 84 };

//        // Вызов функции для поиска минимального и максимального элементов и их индексов
//        FindMinMax(numbers);
//    }

//    static void FindMinMax(int[] array)
//    {
//        if (array.Length == 0)
//        {
//            Console.WriteLine("Массив пустой.");
//            return;
//        }

//        int minValue = array[0];
//        int maxValue = array[0];
//        int minIndex = 0;
//        int maxIndex = 0;

//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < minValue)
//            {
//                minValue = array[i];
//                minIndex = i;
//            }
//            if (array[i] > maxValue)
//            {
//                maxValue = array[i];
//                maxIndex = i;
//            }
//        }

//        Console.WriteLine($"Минимальный элемент: {minValue}, его индекс: {minIndex}");
//        Console.WriteLine($"Максимальный элемент: {maxValue}, его индекс: {maxIndex}");
//    }
//}

/// задание 13

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 5, 3, 8, 4, 2, 7, 1, 6 };

//        Console.WriteLine("Исходный массив:");
//        PrintArray(array);

//        Console.WriteLine("\nСортировка по возрастанию (пузырьком):");
//        BubbleSort(array, true);
//        PrintArray(array);

//        Console.WriteLine("\nСортировка по убыванию (пузырьком):");
//        BubbleSort(array, false);
//        PrintArray(array);

//        Console.WriteLine("\nСортировка по возрастанию (вставками):");
//        InsertionSort(array, true);
//        PrintArray(array);

//        Console.WriteLine("\nСортировка по убыванию (вставками):");
//        InsertionSort(array, false);
//        PrintArray(array);

//        Console.WriteLine("\nСортировка по возрастанию (выбором):");
//        SelectionSort(array, true);
//        PrintArray(array);

//        Console.WriteLine("\nСортировка по убыванию (выбором):");
//        SelectionSort(array, false);
//        PrintArray(array);
//    }

//    // Метод для сортировки пузырьком
//    static void BubbleSort(int[] array, bool ascending)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            for (int j = 0; j < n - i - 1; j++)
//            {
//                if ((ascending && array[j] > array[j + 1]) || (!ascending && array[j] < array[j + 1]))
//                {
//                    // Swap array[j] and array[j + 1]
//                    int temp = array[j];
//                    array[j] = array[j + 1];
//                    array[j + 1] = temp;
//                }
//            }
//        }
//    }

//    // Метод для сортировки вставками
//    static void InsertionSort(int[] array, bool ascending)
//    {
//        int n = array.Length;
//        for (int i = 1; i < n; i++)
//        {
//            int key = array[i];
//            int j = i - 1;

//            while (j >= 0 && ((ascending && array[j] > key) || (!ascending && array[j] < key)))
//            {
//                array[j + 1] = array[j];
//                j = j - 1;
//            }
//            array[j + 1] = key;
//        }
//    }

//    // Метод для сортировки выбором
//    static void SelectionSort(int[] array, bool ascending)
//    {
//        int n = array.Length;
//        for (int i = 0; i < n - 1; i++)
//        {
//            int minMaxIndex = i;
//            for (int j = i + 1; j < n; j++)
//            {
//                if ((ascending && array[j] < array[minMaxIndex]) || (!ascending && array[j] > array[minMaxIndex]))
//                {
//                    minMaxIndex = j;
//                }
//            }
//            // Swap array[i] and array[minMaxIndex]
//            int temp = array[minMaxIndex];
//            array[minMaxIndex] = array[i];
//            array[i] = temp;
//        }
//    }

//    // Метод для вывода массива
//    static void PrintArray(int[] array)
//    {
//        Console.WriteLine(string.Join(", ", array));
//    }
//}

/// задание 14

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 5, 3, 8, 4, 2, 7, 1, 6 };
//        Console.WriteLine("Введите элемент для поиска:");
//        int searchElement = int.Parse(Console.ReadLine());

//        int index = FindElementIndex(array, searchElement);

//        if (index != -1)
//        {
//            Console.WriteLine($"Элемент {searchElement} найден на индексе {index}.");
//        }
//        else
//        {
//            Console.WriteLine($"Элемент {searchElement} не найден в массиве.");
//        }
//    }

//    // Метод для поиска элемента в массиве
//    static int FindElementIndex(int[] array, int element)
//    {
//        for (int i = 0; i < array.Length; i++)
//        {
//            if (array[i] == element)
//            {
//                return i; // Возвращаем индекс найденного элемента
//            }
//        }
//        return -1; // Если элемент не найден, возвращаем -1
//    }
//}

/// задание 15

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 5, 3, 8, 4, 2, 7, 1, 6 };

//        Console.WriteLine("Исходный массив:");
//        PrintArray(array);

//        Console.WriteLine("\nМассив в обратном порядке:");
//        PrintArrayInReverse(array);
//    }

//    // Метод для вывода массива
//    static void PrintArray(int[] array)
//    {
//        Console.WriteLine(string.Join(", ", array));
//    }

//    // Метод для вывода массива в обратном порядке
//    static void PrintArrayInReverse(int[] array)
//    {
//        for (int i = array.Length - 1; i >= 0; i--)
//        {
//            Console.Write(array[i]);

//            // Добавляем запятую и пробел, если это не последний элемент
//            if (i > 0)
//            {
//                Console.Write(", ");
//            }
//        }
//        Console.WriteLine();
//    }
//}

/// задание 16

//using System;

//class MatrixOperations
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите количество строк матрицы A:");
//        int rowsA = int.Parse(Console.ReadLine());

//        Console.WriteLine("Введите количество столбцов матрицы A:");
//        int colsA = int.Parse(Console.ReadLine());

//        int[,] matrixA = ReadMatrixFromUser(rowsA, colsA, "A");

//        Console.WriteLine("Введите количество строк матрицы B:");
//        int rowsB = int.Parse(Console.ReadLine());

//        Console.WriteLine("Введите количество столбцов матрицы B:");
//        int colsB = int.Parse(Console.ReadLine());

//        int[,] matrixB = ReadMatrixFromUser(rowsB, colsB, "B");

//        Console.WriteLine("Matrix A:");
//        PrintMatrix(matrixA);

//        Console.WriteLine("\nMatrix B:");
//        PrintMatrix(matrixB);

//        if (rowsA == rowsB && colsA == colsB)
//        {
//            // Сложение матриц
//            int[,] sumMatrix = AddMatrices(matrixA, matrixB);
//            Console.WriteLine("\nA + B:");
//            PrintMatrix(sumMatrix);

//            // Вычитание матриц
//            int[,] subMatrix = SubtractMatrices(matrixA, matrixB);
//            Console.WriteLine("\nA - B:");
//            PrintMatrix(subMatrix);
//        }
//        else
//        {
//            Console.WriteLine("\nСложение и вычитание матриц невозможно: размеры матриц не совпадают.");
//        }

//        // Умножение матриц
//        if (colsA == rowsB)
//        {
//            int[,] mulMatrix = MultiplyMatrices(matrixA, matrixB);
//            Console.WriteLine("\nA * B:");
//            PrintMatrix(mulMatrix);
//        }
//        else
//        {
//            Console.WriteLine("\nУмножение матриц невозможно: число столбцов матрицы A не равно числу строк матрицы B.");
//        }

//        // Транспонирование матрицы
//        int[,] transposedMatrix = TransposeMatrix(matrixA);
//        Console.WriteLine("\nTranspose of Matrix A:");
//        PrintMatrix(transposedMatrix);
//    }

//    // Метод для ввода матрицы пользователем
//    static int[,] ReadMatrixFromUser(int rows, int cols, string matrixName)
//    {
//        int[,] matrix = new int[rows, cols];

//        Console.WriteLine($"Введите элементы матрицы {matrixName}:");

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write($"Элемент [{i + 1},{j + 1}]: ");
//                matrix[i, j] = int.Parse(Console.ReadLine());
//            }
//        }

//        return matrix;
//    }

//    // Метод для печати матрицы
//    static void PrintMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }

//    // Метод для сложения матриц
//    static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
//    {
//        int rows = matrixA.GetLength(0);
//        int cols = matrixA.GetLength(1);
//        int[,] result = new int[rows, cols];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[i, j] = matrixA[i, j] + matrixB[i, j];
//            }
//        }

//        return result;
//    }

//    // Метод для вычитания матриц
//    static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
//    {
//        int rows = matrixA.GetLength(0);
//        int cols = matrixA.GetLength(1);
//        int[,] result = new int[rows, cols];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[i, j] = matrixA[i, j] - matrixB[i, j];
//            }
//        }

//        return result;
//    }

//    // Метод для умножения матриц
//    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
//    {
//        int rowsA = matrixA.GetLength(0);
//        int colsA = matrixA.GetLength(1);
//        int rowsB = matrixB.GetLength(0);
//        int colsB = matrixB.GetLength(1);

//        int[,] result = new int[rowsA, colsB];

//        for (int i = 0; i < rowsA; i++)
//        {
//            for (int j = 0; j < colsB; j++)
//            {
//                result[i, j] = 0;
//                for (int k = 0; k < colsA; k++)
//                {
//                    result[i, j] += matrixA[i, k] * matrixB[k, j];
//                }
//            }
//        }

//        return result;
//    }

//    // Метод для транспонирования матрицы
//    static int[,] TransposeMatrix(int[,] matrix)
//    {
//        int rows = matrix.GetLength(0);
//        int cols = matrix.GetLength(1);
//        int[,] result = new int[cols, rows];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[j, i] = matrix[i, j];
//            }
//        }

//        return result;
//    }
//}


/// задание 17

//using System;

//class NumberConverter
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите число в десятичной системе счисления:");
//        int decimalNumber = int.Parse(Console.ReadLine());

//        // Перевод в двоичную систему
//        string binary = Convert.ToString(decimalNumber, 2);
//        Console.WriteLine($"Число в двоичной системе: {binary}");

//        // Перевод в восьмеричную систему
//        string octal = Convert.ToString(decimalNumber, 8);
//        Console.WriteLine($"Число в восьмеричной системе: {octal}");

//        // Перевод в шестнадцатеричную систему
//        string hex = Convert.ToString(decimalNumber, 16).ToUpper();
//        Console.WriteLine($"Число в шестнадцатеричной системе: {hex}");
//    }
//}


/// задание 18

//using System;

//class NumberPyramid
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите высоту пирамиды:");
//        int height = int.Parse(Console.ReadLine());

//        PrintNumberPyramid(height);
//    }

//    // Метод для печати числовой пирамиды
//    static void PrintNumberPyramid(int height)
//    {
//        for (int i = 1; i <= height; i++)
//        {
//            // Печать пробелов для выравнивания пирамиды
//            for (int j = 1; j <= height - i; j++)
//            {
//                Console.Write(" ");
//            }

//            // Печать чисел
//            for (int k = 1; k <= i; k++)
//            {
//                Console.Write(k + " ");
//            }

//            // Печать новой строки
//            Console.WriteLine();
//        }
//    }
//}


/// задание 19

//using System;

//class SubstringSearch
//{
//    static void Main()
//    {
//        // Ввод основной строки и подстроки
//        Console.WriteLine("Введите основную строку:");
//        string mainString = Console.ReadLine();

//        Console.WriteLine("Введите подстроку для поиска:");
//        string substring = Console.ReadLine();

//        // Поиск подстроки в основной строке
//        int index = FindSubstringIndex(mainString, substring);

//        if (index != -1)
//        {
//            Console.WriteLine($"Подстрока найдена на индексе: {index}");
//        }
//        else
//        {
//            Console.WriteLine("Подстрока не найдена.");
//        }
//    }

//    // Метод для поиска подстроки в строке
//    static int FindSubstringIndex(string mainString, string substring)
//    {
//        return mainString.IndexOf(substring);
//    }
//}


/// задание 20

//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите строку:");
//        string input = Console.ReadLine();

//        // Удаление лишних пробелов из строки
//        string result = RemoveExtraSpaces(input);

//        Console.WriteLine("Результат:");
//        Console.WriteLine(result);
//    }

//    // Метод для удаления лишних пробелов из строки
//    static string RemoveExtraSpaces(string input)
//    {
//        // Используем регулярное выражение для замены нескольких пробелов одним пробелом
//        string trimmed = Regex.Replace(input, @"\s+", " ");

//        // Удаляем ведущие и завершающие пробелы
//        return trimmed.Trim();
//    }
//}

/// задание 21

//using System;

//class DateDifferenceCalculator
//{
//    static void Main()
//    {
//        // Ввод первой даты
//        Console.WriteLine("Введите первую дату (формат: yyyy-MM-dd):");
//        DateTime date1;
//        while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out date1))
//        {
//            Console.WriteLine("Некорректный формат даты. Пожалуйста, введите дату в формате yyyy-MM-dd:");
//        }

//        // Ввод второй даты
//        Console.WriteLine("Введите вторую дату (формат: yyyy-MM-dd):");
//        DateTime date2;
//        while (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out date2))
//        {
//            Console.WriteLine("Некорректный формат даты. Пожалуйста, введите дату в формате yyyy-MM-dd:");
//        }

//        // Вычисление разницы между датами
//        TimeSpan difference = date2 - date1;
//        int daysDifference = Math.Abs(difference.Days);

//        Console.WriteLine($"Количество дней между двумя датами: {daysDifference} дней.");
//    }
//}


/// задание 22

//using System;
//using System.Text.RegularExpressions;

//class DataValidation
//{
//    static void Main()
//    {
//        // Проверка номера телефона
//        Console.WriteLine("Введите номер телефона (формат: +7 (123) 456-78-90):");
//        string phoneNumber = Console.ReadLine();
//        if (IsValidPhoneNumber(phoneNumber))
//        {
//            Console.WriteLine("Номер телефона корректен.");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный номер телефона.");
//        }

//        // Проверка электронной почты
//        Console.WriteLine("Введите адрес электронной почты (формат: example@domain.com):");
//        string email = Console.ReadLine();
//        if (IsValidEmail(email))
//        {
//            Console.WriteLine("Адрес электронной почты корректен.");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный адрес электронной почты.");
//        }
//    }

//    // Метод для проверки корректности номера телефона
//    static bool IsValidPhoneNumber(string phoneNumber)
//    {
//        // Регулярное выражение для проверки формата номера телефона
//        string pattern = @"^\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}$";
//        return Regex.IsMatch(phoneNumber, pattern);
//    }

//    // Метод для проверки корректности адреса электронной почты
//    static bool IsValidEmail(string email)
//    {
//        // Регулярное выражение для проверки формата электронной почты
//        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
//        return Regex.IsMatch(email, pattern);
//    }
//}

/// задание 23

//using System;

//class PasswordGenerator
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите желаемую длину пароля:");
//        int length;
//        while (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
//        {
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число:");
//        }

//        string password = GeneratePassword(length);
//        Console.WriteLine($"Сгенерированный пароль: {password}");
//    }

//    // Метод для генерации случайного пароля
//    static string GeneratePassword(int length)
//    {
//        const string upperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
//        const string lowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
//        const string digits = "0123456789";
//        const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

//        // Объединение всех символов в один набор
//        string allChars = upperCaseLetters + lowerCaseLetters + digits + specialChars;

//        Random random = new Random();
//        char[] password = new char[length];

//        for (int i = 0; i < length; i++)
//        {
//            // Выбор случайного символа из набора
//            password[i] = allChars[random.Next(allChars.Length)];
//        }

//        return new string(password);
//    }
//}

/// задание 24

//using System;
//using System.Collections.Generic;
//using System.Globalization;

//class ReceiptGenerator
//{
//    static void Main()
//    {
//        List<Item> items = new List<Item>();
//        string input;
//        const decimal vatRate = 0.20m; // НДС в размере 20%

//        Console.WriteLine("Введите список покупок. Введите 'stop' для завершения ввода.");

//        while (true)
//        {
//            Console.Write("Введите название товара (или 'stop' для завершения): ");
//            input = Console.ReadLine();

//            if (input.ToLower() == "stop")
//                break;

//            string itemName = input;

//            decimal itemPrice;
//            while (true)
//            {
//                Console.Write($"Введите стоимость '{itemName}': ");
//                if (decimal.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out itemPrice) && itemPrice > 0)
//                    break;
//                else
//                    Console.WriteLine("Некорректный ввод стоимости. Пожалуйста, введите положительное число.");
//            }

//            items.Add(new Item(itemName, itemPrice));
//        }

//        decimal totalAmount = CalculateTotalAmount(items);
//        decimal vatAmount = totalAmount * vatRate;

//        PrintReceipt(items, totalAmount, vatAmount);
//    }

//    // Метод для расчета общей суммы
//    static decimal CalculateTotalAmount(List<Item> items)
//    {
//        decimal total = 0;
//        foreach (var item in items)
//        {
//            total += item.Price;
//        }
//        return total;
//    }

//    // Метод для печати чека
//    static void PrintReceipt(List<Item> items, decimal totalAmount, decimal vatAmount)
//    {
//        Console.WriteLine("\nЧек:");
//        Console.WriteLine(new string('-', 30));

//        foreach (var item in items)
//        {
//            Console.WriteLine($"{item.Name,-20} {item.Price,10:C2}");
//        }

//        Console.WriteLine(new string('-', 30));
//        Console.WriteLine($"{"Итого:",-20} {totalAmount,10:C2}");
//        Console.WriteLine($"{"НДС (20%):",-20} {vatAmount,10:C2}");
//        Console.WriteLine($"{"Сумма к оплате:",-20} {totalAmount + vatAmount,10:C2}");
//        Console.WriteLine(new string('-', 30));
//    }
//}

//// Класс для хранения информации о товаре
//class Item
//{
//    public string Name { get; }
//    public decimal Price { get; }

//    public Item(string name, decimal price)
//    {
//        Name = name;
//        Price = price;
//    }
//}

/// задание 25 

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//class WordFrequencyAnalyzer
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите текст для анализа:");
//        string inputText = Console.ReadLine();

//        // Получение статистики по частоте использования слов
//        var wordFrequencies = GetWordFrequencies(inputText);

//        // Вывод статистики
//        PrintWordFrequencies(wordFrequencies);
//    }

//    // Метод для получения частоты использования слов
//    static Dictionary<string, int> GetWordFrequencies(string text)
//    {
//        // Приведение текста к нижнему регистру и удаление знаков препинания
//        string cleanedText = Regex.Replace(text.ToLower(), @"[\p{P}-[.]]+", " ");

//        // Разделение текста на слова
//        string[] words = cleanedText.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);

//        // Создание словаря для хранения частоты слов
//        var wordFrequencies = new Dictionary<string, int>();

//        foreach (var word in words)
//        {
//            if (wordFrequencies.ContainsKey(word))
//            {
//                wordFrequencies[word]++;
//            }
//            else
//            {
//                wordFrequencies[word] = 1;
//            }
//        }

//        return wordFrequencies;
//    }

//    // Метод для вывода статистики по частоте использования слов
//    static void PrintWordFrequencies(Dictionary<string, int> wordFrequencies)
//    {
//        Console.WriteLine("\nСтатистика по частоте использования слов:");
//        Console.WriteLine(new string('-', 40));

//        foreach (var pair in wordFrequencies.OrderByDescending(p => p.Value))
//        {
//            Console.WriteLine($"{pair.Key,-20} {pair.Value,5}");
//        }

//        Console.WriteLine(new string('-', 40));
//    }
//}

/// задание 26

//using System;

//class TimeCalculator
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите первое время:");
//        TimeSpan time1 = ReadTime();

//        Console.WriteLine("Введите второе время:");
//        TimeSpan time2 = ReadTime();

//        Console.WriteLine("Выберите операцию:");
//        Console.WriteLine("1. Сложение");
//        Console.WriteLine("2. Вычитание");
//        string choice = Console.ReadLine();

//        TimeSpan result;

//        switch (choice)
//        {
//            case "1":
//                result = time1.Add(time2);
//                break;

//            case "2":
//                result = time1.Subtract(time2);
//                break;

//            default:
//                Console.WriteLine("Неверный выбор.");
//                return;
//        }

//        Console.WriteLine($"Результат: {FormatTimeSpan(result)}");
//    }

//    // Метод для чтения времени от пользователя
//    static TimeSpan ReadTime()
//    {
//        int hours, minutes;
//        while (true)
//        {
//            Console.Write("Введите часы: ");
//            if (int.TryParse(Console.ReadLine(), out hours) && hours >= 0)
//                break;
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите неотрицательное число.");
//        }

//        while (true)
//        {
//            Console.Write("Введите минуты: ");
//            if (int.TryParse(Console.ReadLine(), out minutes) && minutes >= 0 && minutes < 60)
//                break;
//            Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 0 до 59.");
//        }

//        return new TimeSpan(hours, minutes, 0);
//    }

//    // Метод для форматирования TimeSpan в строку
//    static string FormatTimeSpan(TimeSpan timeSpan)
//    {
//        return $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}";
//    }
//}

/// задание 27

//using System;

//class QuadraticEquationSolver
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите коэффициенты квадратного уравнения ax^2 + bx + c = 0");

//        // Ввод коэффициентов
//        double a = ReadCoefficient("a");
//        double b = ReadCoefficient("b");
//        double c = ReadCoefficient("c");

//        // Вычисление дискриминанта
//        double discriminant = b * b - 4 * a * c;

//        // Нахождение корней уравнения
//        if (a == 0)
//        {
//            Console.WriteLine("Коэффициент 'a' не может быть равен нулю.");
//            return;
//        }

//        Console.WriteLine("Дискриминант: " + discriminant);

//        if (discriminant > 0)
//        {
//            // Два различных корня
//            double sqrtD = Math.Sqrt(discriminant);
//            double x1 = (-b + sqrtD) / (2 * a);
//            double x2 = (-b - sqrtD) / (2 * a);
//            Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
//        }
//        else if (discriminant == 0)
//        {
//            // Один корень
//            double x = -b / (2 * a);
//            Console.WriteLine($"Корень уравнения: x = {x}");
//        }
//        else
//        {
//            // Нет вещественных корней
//            Console.WriteLine("У уравнения нет вещественных корней.");
//        }
//    }

//    // Метод для чтения коэффициентов от пользователя
//    static double ReadCoefficient(string coefficientName)
//    {
//        double coefficient;
//        while (true)
//        {
//            Console.Write($"Введите коэффициент {coefficientName}: ");
//            if (double.TryParse(Console.ReadLine(), out coefficient))
//                return coefficient;
//            else
//                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
//        }
//    }
//}

/// задание 28

//using System;

//class LinearEquationSolver
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите коэффициенты системы линейных уравнений:");

//        double a1 = ReadCoefficient("a1");
//        double b1 = ReadCoefficient("b1");
//        double c1 = ReadCoefficient("c1");
//        double a2 = ReadCoefficient("a2");
//        double b2 = ReadCoefficient("b2");
//        double c2 = ReadCoefficient("c2");

//        // Определение детерминанта
//        double determinant = a1 * b2 - a2 * b1;

//        if (determinant == 0)
//        {
//            Console.WriteLine("Система уравнений либо не имеет решений, либо имеет бесконечно много решений.");
//        }
//        else
//        {
//            // Вычисление решений по формуле Крамера
//            double x = (c1 * b2 - c2 * b1) / determinant;
//            double y = (a1 * c2 - a2 * c1) / determinant;

//            Console.WriteLine($"Решение системы уравнений: x = {x}, y = {y}");
//        }
//    }

//    // Метод для чтения коэффициентов от пользователя
//    static double ReadCoefficient(string coefficientName)
//    {
//        double coefficient;
//        while (true)
//        {
//            Console.Write($"Введите коэффициент {coefficientName}: ");
//            if (double.TryParse(Console.ReadLine(), out coefficient))
//                return coefficient;
//            else
//                Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
//        }
//    }
//}

/// задание 29

//using System;
//using System.IO;

//class DiskInfo
//{
//    static void Main()
//    {
//        // Получаем массив всех дисков
//        DriveInfo[] drives = DriveInfo.GetDrives();

//        Console.WriteLine("Информация о доступных дисках:");

//        foreach (DriveInfo drive in drives)
//        {
//            // Пропускаем недоступные диски
//            if (drive.IsReady)
//            {
//                Console.WriteLine($"Диск: {drive.Name}");
//                Console.WriteLine($"  Тип: {drive.DriveType}");
//                Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
//                Console.WriteLine($"  Размер: {FormatBytes(drive.TotalSize)}");
//                Console.WriteLine($"  Свободное место: {FormatBytes(drive.AvailableFreeSpace)}");
//                Console.WriteLine($"  Общий объем: {FormatBytes(drive.TotalFreeSpace)}");
//                Console.WriteLine($"  Метка тома: {drive.VolumeLabel}");
//                Console.WriteLine();
//            }
//            else
//            {
//                Console.WriteLine($"Диск: {drive.Name} не доступен.");
//            }
//        }
//    }

//    // Метод для форматирования байтов в более читабельный формат (например, в мегабайты, гигабайты)
//    static string FormatBytes(long bytes)
//    {
//        const int scale = 1024;
//        string[] orders = { "GB", "MB", "KB", "Bytes" };
//        double max = Math.Abs(bytes);
//        foreach (var order in orders)
//        {
//            if (max < scale)
//                return $"{bytes:0.##} {order}";
//            max /= scale;
//        }
//        return $"{bytes:0.##} Bytes";
//    }
//}

/// задание 30

//using System;
//using System.IO;

//class FileOperations
//{
//    static void Main()
//    {
//        Console.WriteLine("Выберите операцию:");
//        Console.WriteLine("1. Создать файл");
//        Console.WriteLine("2. Удалить файл");
//        Console.WriteLine("3. Копировать файл");
//        Console.WriteLine("4. Переместить файл");
//        Console.Write("Введите номер операции: ");

//        string choice = Console.ReadLine();

//        switch (choice)
//        {
//            case "1":
//                CreateFile();
//                break;
//            case "2":
//                DeleteFile();
//                break;
//            case "3":
//                CopyFile();
//                break;
//            case "4":
//                MoveFile();
//                break;
//            default:
//                Console.WriteLine("Неверный выбор.");
//                break;
//        }
//    }

//    // Метод для создания файла
//    static void CreateFile()
//    {
//        Console.Write("Введите путь и имя файла для создания: ");
//        string filePath = Console.ReadLine();

//        try
//        {
//            // Создание файла и запись в него текста
//            File.WriteAllText(filePath, "Это тестовый файл.");
//            Console.WriteLine("Файл успешно создан.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    // Метод для удаления файла
//    static void DeleteFile()
//    {
//        Console.Write("Введите путь и имя файла для удаления: ");
//        string filePath = Console.ReadLine();

//        try
//        {
//            if (File.Exists(filePath))
//            {
//                File.Delete(filePath);
//                Console.WriteLine("Файл успешно удален.");
//            }
//            else
//            {
//                Console.WriteLine("Файл не найден.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    // Метод для копирования файла
//    static void CopyFile()
//    {
//        Console.Write("Введите путь и имя исходного файла: ");
//        string sourceFilePath = Console.ReadLine();

//        Console.Write("Введите путь и имя целевого файла: ");
//        string destinationFilePath = Console.ReadLine();

//        try
//        {
//            if (File.Exists(sourceFilePath))
//            {
//                File.Copy(sourceFilePath, destinationFilePath, overwrite: true);
//                Console.WriteLine("Файл успешно скопирован.");
//            }
//            else
//            {
//                Console.WriteLine("Исходный файл не найден.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }

//    // Метод для перемещения файла
//    static void MoveFile()
//    {
//        Console.Write("Введите путь и имя исходного файла: ");
//        string sourceFilePath = Console.ReadLine();

//        Console.Write("Введите путь и имя целевого файла: ");
//        string destinationFilePath = Console.ReadLine();

//        try
//        {
//            if (File.Exists(sourceFilePath))
//            {
//                File.Move(sourceFilePath, destinationFilePath);
//                Console.WriteLine("Файл успешно перемещен.");
//            }
//            else
//            {
//                Console.WriteLine("Исходный файл не найден.");
//            }
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}


/// 31

//using System;
//using System.Collections.Generic;
//using System.IO;
//using Newtonsoft.Json;

//class Program
//{
//    // Класс для хранения данных
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public string City { get; set; }
//    }

//    static void Main()
//    {
//        // Чтение данных из JSON-файла
//        string jsonFilePath = "data.json";
//        string jsonData = File.ReadAllText(jsonFilePath);

//        // Десериализация JSON в список объектов
//        List<Person> people = JsonConvert.DeserializeObject<List<Person>>(jsonData);

//        // Вывод данных в формате таблицы
//        Console.WriteLine("{0,-10} {1,-5} {2,-10}", "Name", "Age", "City");
//        Console.WriteLine(new string('-', 25));

//        foreach (var person in people)
//        {
//            Console.WriteLine("{0,-10} {1,-5} {2,-10}", person.Name, person.Age, person.City);
//        }
//    }
//}

///33


//using System;
//using System.Collections.Generic;

//class Program
//{
//    // Класс для задачи
//    public class Task
//    {
//        public string Description { get; set; }
//        public bool IsCompleted { get; set; }

//        public Task(string description)
//        {
//            Description = description;
//            IsCompleted = false;
//        }
//    }

//    // Основной класс программы
//    static class ToDoApp
//    {
//        static List<Task> tasks = new List<Task>();

//        static void Main()
//        {
//            bool exit = false;

//            while (!exit)
//            {
//                Console.Clear();
//                Console.WriteLine("Список дел:");
//                DisplayTasks();
//                Console.WriteLine("\nВыберите действие:");
//                Console.WriteLine("1. Добавить задачу");
//                Console.WriteLine("2. Удалить задачу");
//                Console.WriteLine("3. Отметить задачу как выполненную");
//                Console.WriteLine("4. Выйти");

//                string input = Console.ReadLine();

//                switch (input)
//                {
//                    case "1":
//                        AddTask();
//                        break;
//                    case "2":
//                        DeleteTask();
//                        break;
//                    case "3":
//                        MarkTaskAsCompleted();
//                        break;
//                    case "4":
//                        exit = true;
//                        break;
//                    default:
//                        Console.WriteLine("Некорректный выбор. Нажмите любую клавишу для продолжения.");
//                        Console.ReadKey();
//                        break;
//                }
//            }
//        }

//        // Метод для отображения задач
//        static void DisplayTasks()
//        {
//            if (tasks.Count == 0)
//            {
//                Console.WriteLine("Нет задач.");
//            }
//            else
//            {
//                for (int i = 0; i < tasks.Count; i++)
//                {
//                    string status = tasks[i].IsCompleted ? "[Выполнено]" : "[Не выполнено]";
//                    Console.WriteLine($"{i + 1}. {tasks[i].Description} {status}");
//                }
//            }
//        }

//        // Метод для добавления задачи
//        static void AddTask()
//        {
//            Console.WriteLine("\nВведите описание задачи:");
//            string description = Console.ReadLine();
//            tasks.Add(new Task(description));
//        }

//        // Метод для удаления задачи
//        static void DeleteTask()
//        {
//            Console.WriteLine("\nВведите номер задачи для удаления:");
//            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
//            {
//                tasks.RemoveAt(index - 1);
//            }
//            else
//            {
//                Console.WriteLine("Неверный номер задачи. Нажмите любую клавишу для продолжения.");
//                Console.ReadKey();
//            }
//        }

//        // Метод для отметки задачи как выполненной
//        static void MarkTaskAsCompleted()
//        {
//            Console.WriteLine("\nВведите номер задачи для отметки как выполненной:");
//            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
//            {
//                tasks[index - 1].IsCompleted = true;
//            }
//            else
//            {
//                Console.WriteLine("Неверный номер задачи. Нажмите любую клавишу для продолжения.");
//                Console.ReadKey();
//            }
//        }
//    }
//}


/// 34  

//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string inputFilePath = "input.txt";
//        string outputFilePath = "output.txt";

//        try
//        {
//            // Чтение текста из исходного файла
//            string text = File.ReadAllText(inputFilePath);

//            // Изменение регистра букв
//            string modifiedText = ChangeCase(text);

//            // Запись результата в новый файл
//            File.WriteAllText(outputFilePath, modifiedText);

//            Console.WriteLine("Текст успешно обработан и записан в файл: " + outputFilePath);
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Произошла ошибка: " + ex.Message);
//        }
//    }

//    // Метод для изменения регистра букв
//    static string ChangeCase(string text)
//    {
//        char[] modifiedText = new char[text.Length];

//        for (int i = 0; i < text.Length; i++)
//        {
//            char c = text[i];
//            if (char.IsLower(c))
//            {
//                modifiedText[i] = char.ToUpper(c);
//            }
//            else if (char.IsUpper(c))
//            {
//                modifiedText[i] = char.ToLower(c);
//            }
//            else
//            {
//                modifiedText[i] = c; // Если символ не является буквой, оставляем его без изменений
//            }
//        }

//        return new string(modifiedText);
//    }
//}

/// 35 


//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Получение текущего месяца и года
//        int year = DateTime.Now.Year;
//        int month = DateTime.Now.Month;

//        // Создание календаря на текущий месяц
//        DisplayCalendar(year, month);

//        // Словарь для хранения заметок по дням
//        Dictionary<int, string> notes = new Dictionary<int, string>();

//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\nВыберите действие:");
//            Console.WriteLine("1. Добавить заметку");
//            Console.WriteLine("2. Просмотреть заметки");
//            Console.WriteLine("3. Выход");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    AddNote(notes, year, month);
//                    break;
//                case "2":
//                    ViewNotes(notes);
//                    break;
//                case "3":
//                    exit = true;
//                    break;
//                default:
//                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    // Метод для отображения календаря на текущий месяц
//    static void DisplayCalendar(int year, int month)
//    {
//        Console.Clear();
//        Console.WriteLine($"Календарь на {month}/{year}");
//        Console.WriteLine("Пн Вт Ср Чт Пт Сб Вс");

//        // Определение первого дня месяца
//        DateTime firstDay = new DateTime(year, month, 1);
//        int startDayOfWeek = (int)firstDay.DayOfWeek;

//        // Сдвиг для начала недели (в C# воскресенье — первый день, поэтому сдвигаем)
//        startDayOfWeek = startDayOfWeek == 0 ? 7 : startDayOfWeek;

//        // Печать пустых строк до первого дня месяца
//        for (int i = 1; i < startDayOfWeek; i++)
//        {
//            Console.Write("   ");
//        }

//        // Вывод дней месяца
//        int daysInMonth = DateTime.DaysInMonth(year, month);
//        for (int day = 1; day <= daysInMonth; day++)
//        {
//            Console.Write($"{day,2} ");

//            if ((day + startDayOfWeek - 1) % 7 == 0)
//            {
//                Console.WriteLine(); // Перенос на новую строку после воскресенья
//            }
//        }
//        Console.WriteLine();
//    }

//    // Метод для добавления заметки
//    static void AddNote(Dictionary<int, string> notes, int year, int month)
//    {
//        Console.WriteLine("\nВведите номер дня для добавления заметки:");
//        if (int.TryParse(Console.ReadLine(), out int day) && day >= 1 && day <= DateTime.DaysInMonth(year, month))
//        {
//            Console.WriteLine("Введите заметку для дня " + day + ":");
//            string note = Console.ReadLine();

//            if (notes.ContainsKey(day))
//            {
//                notes[day] = note;
//            }
//            else
//            {
//                notes.Add(day, note);
//            }

//            Console.WriteLine("Заметка успешно добавлена.");
//        }
//        else
//        {
//            Console.WriteLine("Некорректный день.");
//        }
//    }

//    // Метод для просмотра заметок
//    static void ViewNotes(Dictionary<int, string> notes)
//    {
//        if (notes.Count == 0)
//        {
//            Console.WriteLine("\nНет заметок.");
//        }
//        else
//        {
//            Console.WriteLine("\nЗаметки:");
//            foreach (var note in notes)
//            {
//                Console.WriteLine($"День {note.Key}: {note.Value}");
//            }
//        }
//    }
//}

/// 36𓆩 Kuno 𓆪
//using System;
//using System.Collections.Generic;

//class Program
//{
//    // Класс для хранения данных о студенте
//    public class Student
//    {
//        public string Name { get; set; }
//        public Dictionary<string, List<int>> Grades { get; set; }

//        public Student(string name)
//        {
//            Name = name;
//            Grades = new Dictionary<string, List<int>>();
//        }

//        // Метод для добавления оценки по предмету
//        public void AddGrade(string subject, int grade)
//        {
//            if (Grades.ContainsKey(subject))
//            {
//                Grades[subject].Add(grade);
//            }
//            else
//            {
//                Grades[subject] = new List<int> { grade };
//            }
//        }

//        // Метод для вывода среднего балла по каждому предмету
//        public void DisplayGrades()
//        {
//            Console.WriteLine($"\nОценки студента {Name}:");
//            foreach (var subject in Grades)
//            {
//                double average = CalculateAverage(subject.Value);
//                Console.WriteLine($"{subject.Key}: Оценки: {string.Join(", ", subject.Value)}, Средний балл: {average:F2}");
//            }
//        }

//        // Метод для расчета среднего балла
//        private double CalculateAverage(List<int> grades)
//        {
//            int sum = 0;
//            foreach (int grade in grades)
//            {
//                sum += grade;
//            }
//            return (double)sum / grades.Count;
//        }
//    }

//    // Список студентов
//    static List<Student> students = new List<Student>();

//    static void Main()
//    {
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\nВыберите действие:");
//            Console.WriteLine("1. Добавить студента");
//            Console.WriteLine("2. Добавить оценку студенту");
//            Console.WriteLine("3. Просмотреть оценки студента");
//            Console.WriteLine("4. Выйти");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    AddStudent();
//                    break;
//                case "2":
//                    AddGradeToStudent();
//                    break;
//                case "3":
//                    ViewStudentGrades();
//                    break;
//                case "4":
//                    exit = true;
//                    break;
//                default:
//                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    // Метод для добавления студента
//    static void AddStudent()
//    {
//        Console.WriteLine("\nВведите имя студента:");
//        string name = Console.ReadLine();
//        students.Add(new Student(name));
//        Console.WriteLine("Студент добавлен.");
//    }

//    // Метод для добавления оценки студенту
//    static void AddGradeToStudent()
//    {
//        Console.WriteLine("\nВведите имя студента:");
//        string name = Console.ReadLine();
//        Student student = FindStudentByName(name);

//        if (student != null)
//        {
//            Console.WriteLine("Введите название предмета:");
//            string subject = Console.ReadLine();

//            Console.WriteLine("Введите оценку (0-100):");
//            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 0 && grade <= 100)
//            {
//                student.AddGrade(subject, grade);
//                Console.WriteLine("Оценка добавлена.");
//            }
//            else
//            {
//                Console.WriteLine("Неверный ввод оценки.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Студент не найден.");
//        }
//    }

//    // Метод для просмотра оценок студента
//    static void ViewStudentGrades()
//    {
//        Console.WriteLine("\nВведите имя студента:");
//        string name = Console.ReadLine();
//        Student student = FindStudentByName(name);

//if (student != null)
//        {
//            student.DisplayGrades();
//        }
//        else
//        {
//            Console.WriteLine("Студент не найден.");
//        }
//    }

//    // Метод для поиска студента по имени
//    static Student FindStudentByName(string name)
//    {
//        foreach (var student in students)
//        {
//            if (student.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
//            {
//                return student;
//            }
//        }
//        return null;
//    }
//}

/// 37 

//using System;
// using System.Text.RegularExpressions;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;

//class Program
//{
//    // Класс для хранения информации о контакте
//    public class Contact
//    {
//        public string Name { get; set; }
//        public string Phone { get; set; }
//        public string Email { get; set; }

//        public Contact(string name, string phone, string email)
//        {
//            Name = name;
//            Phone = phone;
//            Email = email;
//        }

//        public override string ToString()
//        {
//            return $"Имя: {Name}, Телефон: {Phone}, Email: {Email}";
//        }
//    }

//    // Список для хранения всех контактов
//    static List<Contact> contacts = new List<Contact>();

//    static void Main()
//    {
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\nВыберите действие:");
//            Console.WriteLine("1. Добавить контакт");
//            Console.WriteLine("2. Удалить контакт");
//            Console.WriteLine("3. Редактировать контакт");
//            Console.WriteLine("4. Найти контакт");
//            Console.WriteLine("5. Вывести все контакты");
//            Console.WriteLine("6. Выход");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    AddContact();
//                    break;
//                case "2":
//                    DeleteContact();
//                    break;
//                case "3":
//                    EditContact();
//                    break;
//                case "4":
//                    FindContact();
//                    break;
//                case "5":
//                    DisplayAllContacts();
//                    break;
//                case "6":
//                    exit = true;
//                    break;
//                default:
//                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    // Метод для добавления контакта
//    static void AddContact()
//    {
//        Console.WriteLine("\nВведите имя:");
//        string name = Console.ReadLine();

//        Console.WriteLine("Введите телефон (формат: +7XXXXXXXXXX):");
//        string phone = Console.ReadLine();
//        if (!IsValidPhone(phone))
//        {
//            Console.WriteLine("Некорректный номер телефона.");
//            return;
//        }

//        Console.WriteLine("Введите email:");
//        string email = Console.ReadLine();
//        if (!IsValidEmail(email))
//        {
//            Console.WriteLine("Некорректный email.");
//            return;
//        }

//        contacts.Add(new Contact(name, phone, email));
//        Console.WriteLine("Контакт добавлен.");
//    }

//    // Метод для удаления контакта
//    static void DeleteContact()
//    {
//        Console.WriteLine("\nВведите имя контакта, который хотите удалить:");
//        string name = Console.ReadLine();
//        Contact contact = FindContactByName(name);

//        if (contact != null)
//        {
//            contacts.Remove(contact);
//            Console.WriteLine("Контакт удалён.");
//        }
//        else
//        {
//            Console.WriteLine("Контакт не найден.");
//        }
//    }

//    // Метод для редактирования контакта
//    static void EditContact()
//    {
//        Console.WriteLine("\nВведите имя контакта для редактирования:");
//        string name = Console.ReadLine();
//        Contact contact = FindContactByName(name);

//        if (contact != null)
//        {
//            Console.WriteLine("Что вы хотите изменить?");
//            Console.WriteLine("1. Имя");
//            Console.WriteLine("2. Телефон");
//            Console.WriteLine("3. Email");
//            string choice = Console.ReadLine();

//switch (choice)
//            {
//                case "1":
//                    Console.WriteLine("Введите новое имя:");
//                    contact.Name = Console.ReadLine();
//                    break;
//                case "2":
//                    Console.WriteLine("Введите новый телефон (формат: +7XXXXXXXXXX):");
//                    string phone = Console.ReadLine();
//                    if (IsValidPhone(phone))
//                    {
//                        contact.Phone = phone;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Некорректный номер телефона.");
//                    }
//                    break;
//                case "3":
//                    Console.WriteLine("Введите новый email:");
//                    string email = Console.ReadLine();
//                    if (IsValidEmail(email))
//                    {
//                        contact.Email = email;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Некорректный email.");
//                    }
//                    break;
//                default:
//                    Console.WriteLine("Некорректный выбор.");
//                    break;
//            }

//            Console.WriteLine("Контакт успешно обновлён.");
//        }
//        else
//        {
//            Console.WriteLine("Контакт не найден.");
//        }
//    }

//    // Метод для поиска контакта по имени
//    static void FindContact()
//    {
//        Console.WriteLine("\nВведите имя для поиска:");
//        string name = Console.ReadLine();
//        Contact contact = FindContactByName(name);

//        if (contact != null)
//        {
//            Console.WriteLine(contact);
//        }
//        else
//        {
//            Console.WriteLine("Контакт не найден.");
//        }
//    }

//    // Метод для вывода всех контактов
//    static void DisplayAllContacts()
//    {
//        if (contacts.Count == 0)
//        {
//            Console.WriteLine("\nНет контактов.");
//        }
//        else
//        {
//            Console.WriteLine("\nВсе контакты:");
//            foreach (var contact in contacts)
//            {
//                Console.WriteLine(contact);
//            }
//        }
//    }

//    // Метод для поиска контакта по имени
//    static Contact FindContactByName(string name)
//    {
//        foreach (var contact in contacts)
//        {
//            if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
//            {
//                return contact;
//            }
//        }
//        return null;
//    }

//    // Валидация номера телефона
//    static bool IsValidPhone(string phone)
//    {
//        // Регулярное выражение для номеров формата +[код страны][номер]
//        return Regex.IsMatch(phone, @"^\+\d{1,15}$");
//    }

//    // Валидация email
//    static bool IsValidEmail(string email)
//    {
//        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
//    }
//}


/// 38 

//using System;

//class TicTacToe
//{
//    static char[,] board = {
//        { '1', '2', '3' },
//        { '4', '5', '6' },
//        { '7', '8', '9' }
//    };

//    static char currentPlayer = 'X';
//    static bool gameEnded = false;

//    static void Main()
//    {
//        int turnCount = 0;

//        // Основной игровой цикл
//        while (!gameEnded && turnCount < 9)
//        {
//            Console.Clear();
//            DisplayBoard();
//            Console.WriteLine($"Ход игрока {currentPlayer}. Введите номер ячейки (или 's' для сдачи):");
//            string input = Console.ReadLine();

//            if (input.ToLower() == "s")
//            {
//                Console.WriteLine($"Игрок {currentPlayer} сдался. Игрок {SwitchPlayer()} выигрывает!");
//                gameEnded = true;
//                break;
//            }

//            if (int.TryParse(input, out int cellNumber) && cellNumber >= 1 && cellNumber <= 9)
//            {
//                if (MakeMove(cellNumber))
//                {
//                    turnCount++;
//                    gameEnded = CheckForWinner();

//                    if (!gameEnded)
//                    {
//                        SwitchPlayer();
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Ячейка уже занята. Попробуйте снова.");
//                    Console.ReadLine();
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный ввод. Введите число от 1 до 9 или 's' для сдачи.");
//                Console.ReadLine();
//            }
//        }

//        if (!gameEnded)
//        {
//            Console.Clear();
//            DisplayBoard();
//            Console.WriteLine("Ничья!");
//        }
//    }

//    // Метод для отображения игровой доски
//    static void DisplayBoard()
//    {
//        Console.WriteLine("-------------");
//        for (int i = 0; i < 3; i++)
//        {
//            Console.WriteLine($"| {board[i, 0]} | {board[i, 1]} | {board[i, 2]} |");
//            Console.WriteLine("-------------");
//        }
//    }

//    // Метод для совершения хода
//    static bool MakeMove(int cellNumber)
//    {
//        int row = (cellNumber - 1) / 3;
//        int col = (cellNumber - 1) % 3;

//        if (board[row, col] != 'X' && board[row, col] != 'O')
//        {
//            board[row, col] = currentPlayer;
//            return true;
//        }

//        return false;
//    }

//    // Метод для смены текущего игрока
//    static char SwitchPlayer()
//    {
//        return currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
//    }

//    // Метод для проверки победы
//    static bool CheckForWinner()
//    {
//        // Проверка строк и столбцов
//        for (int i = 0; i < 3; i++)
//        {
//            if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
//            {
//                return true;
//            }

//            if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
//            {
//                return true;
//            }
//        }

//        // Проверка диагоналей
//        if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
//        {
//            return true;
//        }

//        if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
//        {
//            return true;
//        }

//        return false;
//    }
//}


/// 39 

//using System;

//class BullsAndCows
//{
//    static Random random = new Random();
//    static void Main()
//    {
//        string secretNumber = GenerateSecretNumber();
//        int attempts = 0;
//        bool guessed = false;

//        Console.WriteLine("Игра 'Быки и коровы'!");
//        Console.WriteLine("Угадайте 4-значное число (цифры не повторяются).");

//        while (!guessed)
//        {
//            Console.Write("Введите ваше предположение: ");
//            string guess = Console.ReadLine();

//            if (IsValidGuess(guess))
//            {
//                attempts++;
//                (int bulls, int cows) = GetBullsAndCows(secretNumber, guess);

//                if (bulls == 4)
//                {
//                    guessed = true;
//                    Console.WriteLine($"Поздравляем! Вы угадали число {secretNumber} за {attempts} попыток.");
//                }
//                else
//                {
//                    Console.WriteLine($"{bulls} быков, {cows} коров.");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Неверный ввод. Убедитесь, что вы ввели 4 уникальные цифры.");
//            }
//        }
//    }

//    // Генерация случайного 4-значного числа с уникальными цифрами
//    static string GenerateSecretNumber()
//    {
//        string number;
//        do
//        {
//            number = random.Next(1000, 10000).ToString();
//        } while (!HasUniqueDigits(number));
//        return number;
//    }

//    // Проверка на уникальность цифр в числе
//    static bool HasUniqueDigits(string number)
//    {
//        return number.Length == number.Distinct().Count();
//    }

//    // Проверка, является ли ввод действительным
//    static bool IsValidGuess(string guess)
//    {
//        return guess.Length == 4 && guess.All(char.IsDigit) && HasUniqueDigits(guess);
//    }

//    // Подсчет быков и коров
//    static (int bulls, int cows) GetBullsAndCows(string secretNumber, string guess)
//    {
//        int bulls = 0, cows = 0;

//        for (int i = 0; i < secretNumber.Length; i++)
//        {
//            if (secretNumber[i] == guess[i])
//            {
//                bulls++;
//            }
//            else if (secretNumber.Contains(guess[i]))
//            {
//                cows++;
//            }
//        }

//        return (bulls, cows);
//    }
//}


/// 40 

//using System;
//using System.Collections.Generic;
//using System.IO;

//class ATM
//{
//    static Dictionary<string, string> users = new Dictionary<string, string>();
//    static decimal balance = 0m;

//    static void Main()
//    {
//        LoadUsers();
//        bool isAuthenticated = Authenticate();

//        if (isAuthenticated)
//        {
//            Console.WriteLine("Вы вошли в систему. Добро пожаловать!");
//            bool exit = false;

//            while (!exit)
//            {
//                Console.WriteLine("\nВыберите действие:");
//                Console.WriteLine("1. Внести средства");
//                Console.WriteLine("2. Снять средства");
//                Console.WriteLine("3. Просмотреть баланс");
//                Console.WriteLine("4. Выйти");

//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        Deposit();
//                        break;
//                    case "2":
//                        Withdraw();
//                        break;
//                    case "3":
//                        ViewBalance();
//                        break;
//                    case "4":
//                        exit = true;
//                        Console.WriteLine("Вы вышли из системы.");
//                        break;
//                    default:
//                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                        break;
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("Неверный номер телефона или пароль.");
//        }
//    }

//    // Загрузка данных пользователей из файла
//    static void LoadUsers()
//    {
//        string filePath = "users.txt";
//        if (File.Exists(filePath))
//        {
//            foreach (var line in File.ReadLines(filePath))
//            {
//                var parts = line.Split(':');
//                if (parts.Length == 2)
//                {
//                    users[parts[0]] = parts[1];
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("Файл с данными пользователей не найден.");
//        }
//    }

//    // Аутентификация пользователя
//    static bool Authenticate()
//    {
//        Console.Write("Введите номер телефона: ");
//        string phoneNumber = Console.ReadLine();

//        Console.Write("Введите пароль: ");
//        string password = Console.ReadLine();

//        return users.TryGetValue(phoneNumber, out string storedPassword) && storedPassword == password;
//    }

//    // Внесение средств
//    static void Deposit()
//    {
//        Console.Write("Введите сумму для внесения: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
//        {
//            balance += amount;
//            Console.WriteLine($"Внесено {amount:C}. Баланс: {balance:C}");
//        }
//        else
//        {
//            Console.WriteLine("Некорректная сумма.");
//        }
//    }

//    // Снятие средств
//    static void Withdraw()
//    {
//        Console.Write("Введите сумму для снятия: ");
//        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
//        {
//            if (amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Снято {amount:C}. Баланс: {balance:C}");
//            }
//            else
//            {
//                Console.WriteLine("Недостаточно средств.");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Некорректная сумма.");
//        }
//    }

//    // Просмотр баланса
//    static void ViewBalance()
//    {
//        Console.WriteLine($"Ваш баланс: {balance:C}");
//    }
//}


/// 41


//using System;
//using System.IO;

//class CsvReader
//{
//    static void Main()
//    {
//        Console.Write("C:\\Users\\kuno_\\Downloads\\example_1.5kb.csv");
//        string filePath = Console.ReadLine();

//        if (File.Exists(filePath))
//        {
//            DisplayCsvFile(filePath);
//        }
//        else
//        {
//            Console.WriteLine("Файл не найден.");
//        }
//    }

//    // Метод для отображения содержимого CSV-файла в виде таблицы
//    static void DisplayCsvFile(string filePath)
//    {
//        using (StreamReader reader = new StreamReader(filePath))
//        {
//            string line;
//            int lineNumber = 0;

//            while ((line = reader.ReadLine()) != null)
//            {
//                string[] values = line.Split(',');

//                if (lineNumber == 0)
//                {
//                    // Заголовок
//                    PrintHeader(values);
//                }
//                else
//                {
//                    // Данные
//                    PrintRow(values);
//                }

//                lineNumber++;
//            }
//        }
//    }

//    // Метод для печати заголовка таблицы
//    static void PrintHeader(string[] headers)
//    {
//        Console.WriteLine("+-------------------------+");
//        Console.Write("|");
//        foreach (var header in headers)
//        {
//            Console.Write($" {header.PadRight(25)} |");
//        }
//        Console.WriteLine();
//        Console.WriteLine("+-------------------------+");
//    }

//    // Метод для печати строки таблицы
//    static void PrintRow(string[] values)
//    {
//        Console.Write("|");
//        foreach (var value in values)
//        {
//            Console.Write($" {value.PadRight(25)} |");
//        }
//        Console.WriteLine();
//        Console.WriteLine("+-------------------------+");
//    }
//}

/// 42 

//using System;

//class TemperatureCalculator
//{
//    static void Main()
//    {
//        const int daysInWeek = 7;
//        decimal[] temperatures = new decimal[daysInWeek];
//        decimal totalTemperature = 0m;

//        Console.WriteLine("Введите температуру за каждый день недели.");

//        for (int i = 0; i < daysInWeek; i++)
//        {
//            Console.Write($"День {i + 1}: ");
//            while (true)
//            {
//                string input = Console.ReadLine();

//                if (decimal.TryParse(input, out decimal temperature))
//                {
//                    temperatures[i] = temperature;
//                    totalTemperature += temperature;
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите числовое значение.");
//                }
//            }
//        }

//        decimal averageTemperature = totalTemperature / daysInWeek;
//        Console.WriteLine($"\nСредняя температура за неделю: {averageTemperature:F2}°C");
//    }
//}


/// 43 

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;

//class SnakeGame
//{
//    static int screenWidth = 20;
//    static int screenHeight = 10;
//    static List<Point> snake = new List<Point>();
//    static Point food;
//    static Point direction;
//    static Random random = new Random();
//    static bool gameRunning = true;
//    static int score = 0;
//    static string playerName;
//    static List<int> highScores = new List<int>();

//    static void Main()
//    {
//        Console.CursorVisible = false;
//        Console.Write("Введите ваше имя: ");
//        playerName = Console.ReadLine();

//        // Load high scores from file if exists
//        LoadHighScores();

//        do
//        {
//            InitializeGame();
//            while (gameRunning)
//            {
//                Input();
//                Logic();
//                Draw();
//                Thread.Sleep(500); // Adjust speed of the game
//            }

//            Console.SetCursorPosition(0, screenHeight + 1);
//            Console.WriteLine($"Игра окончена! Ваш счет: {score}");
//            UpdateHighScores(score);

//            // Display high scores
//            Console.WriteLine("Текущие рекорды:");
//            DisplayHighScores();

//            Console.WriteLine("Нажмите любую клавишу для начала новой игры или Esc для выхода.");
//        }
//        while (Console.ReadKey(true).Key != ConsoleKey.Escape);

//        SaveHighScores();
//    }

//    static void InitializeGame()
//    {
//        snake.Clear();
//        snake.Add(new Point(screenWidth / 2, screenHeight / 2));
//        direction = new Point(1, 0);
//        food = GenerateFood();
//        score = 0;
//        gameRunning = true;
//    }

//    static void Input()
//    {
//        if (Console.KeyAvailable)
//        {
//            var key = Console.ReadKey(true).Key;
//            switch (key)
//            {
//                case ConsoleKey.UpArrow:
//                    if (direction.Y == 0) direction = new Point(0, -1);
//                    break;
//                case ConsoleKey.DownArrow:
//                    if (direction.Y == 0) direction = new Point(0, 1);
//                    break;
//                case ConsoleKey.LeftArrow:
//                    if (direction.X == 0) direction = new Point(-1, 0);
//                    break;
//                case ConsoleKey.RightArrow:
//                    if (direction.X == 0) direction = new Point(1, 0);
//                    break;
//            }
//        }
//    }

//    static void Logic()
//    {
//        Point head = snake.First();
//        Point newHead = new Point(head.X + direction.X, head.Y + direction.Y);

//        if (newHead.Equals(food))
//        {
//            snake.Insert(0, newHead);
//            food = GenerateFood();
//            score += 10; // Increase score when food is eaten
//        }
//        else
//        {
//            snake.Insert(0, newHead);
//            snake.RemoveAt(snake.Count - 1);
//        }

//        if (newHead.X < 0 || newHead.X >= screenWidth || newHead.Y < 0 || newHead.Y >= screenHeight || snake.Skip(1).Any(p => p.Equals(newHead)))
//        {
//            gameRunning = false;
//        }
//    }

//    static void Draw()
//    {
//        Console.Clear();

//        // Draw grid
//        DrawGrid();

//        // Draw snake
//        foreach (var point in snake)
//        {
//            Console.SetCursorPosition(point.X * 2 + 1, point.Y + 1);
//            Console.Write("■");
//        }

//        // Draw food
//        Console.SetCursorPosition(food.X * 2 + 1, food.Y + 1);
//        Console.Write("●");
//    }

//    static void DrawGrid()
//    {
//        for (int y = 0; y < screenHeight; y++)
//        {
//            for (int x = 0; x < screenWidth; x++)
//            {
//                Console.SetCursorPosition(x * 2, y + 1);
//                Console.Write("┼");
//            }
//        }

//        // Draw top border
//        Console.SetCursorPosition(0, 0);
//        Console.Write("┌" + new string('─', screenWidth * 2 - 1) + "┐");

//        // Draw bottom border
//        Console.SetCursorPosition(0, screenHeight + 1);
//        Console.Write("└" + new string('─', screenWidth * 2 - 1) + "┘");

//// Draw side borders
//        for (int y = 1; y <= screenHeight; y++)
//        {
//            Console.SetCursorPosition(0, y);
//            Console.Write("│");
//            Console.SetCursorPosition(screenWidth * 2, y);
//            Console.Write("│");
//        }
//    }

//    static Point GenerateFood()
//    {
//        Point newFood;
//        do
//        {
//            newFood = new Point(random.Next(screenWidth), random.Next(screenHeight));
//        } while (snake.Contains(newFood));
//        return newFood;
//    }

//    static void UpdateHighScores(int score)
//    {
//        highScores.Add(score);
//        highScores = highScores.OrderByDescending(s => s).Take(5).ToList(); // Keep top 5 scores
//    }

//    static void DisplayHighScores()
//    {
//        for (int i = 0; i < highScores.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {highScores[i]}");
//        }
//    }

//    static void LoadHighScores()
//    {
//        string filePath = "highscores.txt";
//        if (System.IO.File.Exists(filePath))
//        {
//            string[] lines = System.IO.File.ReadAllLines(filePath);
//            highScores = lines.Select(line => int.Parse(line)).ToList();
//        }
//    }

//    static void SaveHighScores()
//    {
//        string filePath = "highscores.txt";
//        System.IO.File.WriteAllLines(filePath, highScores.Select(score => score.ToString()));
//    }

//    struct Point
//    {
//        public int X;
//        public int Y;

//        public Point(int x, int y)
//        {
//            X = x;
//            Y = y;
//        }

//        public override bool Equals(object obj)
//        {
//            if (obj is Point p)
//            {
//                return X == p.X && Y == p.Y;
//            }
//            return false;
//        }

//        public override int GetHashCode()
//        {
//            return X.GetHashCode() ^ Y.GetHashCode();
//        }
//    }
//}

/// 44

//using System;
//using System.IO;
//using System.Linq;

//class Program
//{
//    static string directoryPath = @"C:\Users\kuno_\source\repos\52\52\bin\Debug\net8.0"; // Замените на путь к вашей директории

//    static void Main()
//    {
//        if (!Directory.Exists(directoryPath))
//        {
//            Console.WriteLine("Указанная директория не существует.");
//            return;
//        }

//        FileSystemWatcher watcher = new FileSystemWatcher();
//        watcher.Path = directoryPath;
//        watcher.Filter = "*.txt"; // Отслеживаем только текстовые файлы

//        watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;

//        watcher.Changed += OnChanged;
//        watcher.Created += OnChanged;
//        watcher.Deleted += OnDeleted;

//        watcher.EnableRaisingEvents = true;

//        Console.WriteLine("Отслеживание изменений. Нажмите любую клавишу для выхода.");
//        Console.ReadKey();
//    }

//    private static void OnChanged(object source, FileSystemEventArgs e)
//    {
//        string filePath = e.FullPath;
//        string fileName = Path.GetFileNameWithoutExtension(filePath);
//        string extension = Path.GetExtension(filePath);
//        string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
//        string backupFileName = $"{fileName}_{timestamp}{extension}";
//        string backupFilePath = Path.Combine(Path.GetDirectoryName(filePath), backupFileName);

//        try
//        {
//            File.Copy(filePath, backupFilePath);
//            Console.WriteLine($"Файл изменен: {filePath}. Создана копия: {backupFilePath}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка при создании копии файла: {ex.Message}");
//        }
//    }

//    private static void OnDeleted(object source, FileSystemEventArgs e)
//    {
//        Console.WriteLine($"Файл удален: {e.FullPath}");
//    }
//}

/// 45 

//using System;
//using System.Collections.Generic;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string reportPath = "report.txt";

//        Console.WriteLine("Отчет по выполнению задач");

//        // Ввод данных
//        List<Task> tasks = new List<Task>();
//        string addMore;

//        do
//        {
//            Console.Write("Введите название задачи: ");
//            string name = Console.ReadLine();

//            Console.Write("Введите описание задачи: ");
//            string description = Console.ReadLine();

//            Console.Write("Введите статус задачи (Выполнена/Не выполнена): ");
//            string status = Console.ReadLine();

//            tasks.Add(new Task(name, description, status));

//            Console.Write("Хотите добавить еще одну задачу? (да/нет): ");
//            addMore = Console.ReadLine().ToLower();
//        }
//        while (addMore == "да");

//        // Генерация отчета
//        GenerateReport(tasks, reportPath);

//        Console.WriteLine($"Отчет сохранен в файл: {reportPath}");
//    }

//    static void GenerateReport(List<Task> tasks, string filePath)
//    {
//        using (StreamWriter writer = new StreamWriter(filePath))
//        {
//            writer.WriteLine("Отчет по выполнению задач");
//            writer.WriteLine(new string('=', 40));
//            writer.WriteLine();

//            foreach (var task in tasks)
//            {
//                writer.WriteLine($"Название: {task.Name}");
//                writer.WriteLine($"Описание: {task.Description}");
//                writer.WriteLine($"Статус: {task.Status}");
//                writer.WriteLine(new string('-', 40));
//            }
//        }
//    }
//}

//class Task
//{
//    public string Name { get; }
//    public string Description { get; }
//    public string Status { get; }

//    public Task(string name, string description, string status)
//    {
//        Name = name;
//        Description = description;
//        Status = status;
//    }
//}

/// 46 

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static List<Visitor> visitors = new List<Visitor>();

//    static void Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Меню учета посетителей мероприятия:");
//            Console.WriteLine("1. Добавить посетителя");
//            Console.WriteLine("2. Отметить присутствие");
//            Console.WriteLine("3. Вывести список посетителей");
//            Console.WriteLine("4. Выйти");
//            Console.Write("Выберите действие: ");

//            switch (Console.ReadLine())
//            {
//                case "1":
//                    AddVisitor();
//                    break;
//                case "2":
//                    MarkPresence();
//                    break;
//                case "3":
//                    DisplayVisitors();
//                    break;
//                case "4":
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор, попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    static void AddVisitor()
//    {
//        Console.Write("Введите имя посетителя: ");
//        string name = Console.ReadLine();

//        Console.Write("Введите email посетителя: ");
//        string email = Console.ReadLine();

//        visitors.Add(new Visitor(name, email));
//        Console.WriteLine("Посетитель добавлен. Нажмите любую клавишу для возврата в меню.");
//        Console.ReadKey();
//    }

//    static void MarkPresence()
//    {
//        Console.Write("Введите email посетителя для отметки присутствия: ");
//        string email = Console.ReadLine();

//        var visitor = visitors.FirstOrDefault(v => v.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
//        if (visitor != null)
//        {
//            visitor.IsPresent = true;
//            Console.WriteLine("Присутствие отмечено. Нажмите любую клавишу для возврата в меню.");
//        }
//        else
//        {
//            Console.WriteLine("Посетитель с таким email не найден.");
//        }
//        Console.ReadKey();
//    }

//    static void DisplayVisitors()
//    {
//        Console.WriteLine("Список посетителей:");
//        Console.WriteLine("Имя\t\tEmail\t\t\tПрисутствует");

//        foreach (var visitor in visitors)
//        {
//            Console.WriteLine($"{visitor.Name}\t{visitor.Email}\t{(visitor.IsPresent ? "Да" : "Нет")}");
//        }

//        Console.WriteLine("Нажмите любую клавишу для возврата в меню.");
//        Console.ReadKey();
//    }
//}

//class Visitor
//{
//    public string Name { get; }
//    public string Email { get; }
//    public bool IsPresent { get; set; }

//    public Visitor(string name, string email)
//    {
//        Name = name;
//        Email = email;
//        IsPresent = false;
//    }
//}

/// 47

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Threading.Tasks;

//class Program
//{
//    static List<ScheduledTask> tasks = new List<ScheduledTask>();

//    static async Task Main()
//    {
//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Меню планировщика задач:");
//            Console.WriteLine("1. Создать задачу");
//            Console.WriteLine("2. Вывести список задач");
//            Console.WriteLine("3. Выйти");
//            Console.Write("Выберите действие: ");

//            switch (Console.ReadLine())
//            {
//                case "1":
//                    await CreateTask();
//                    break;
//                case "2":
//                    DisplayTasks();
//                    break;
//                case "3":
//                    return;
//                default:
//                    Console.WriteLine("Неверный выбор, попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    static async Task CreateTask()
//    {
//        Console.Write("Введите описание задачи: ");
//        string description = Console.ReadLine();

//        Console.Write("Введите дату и время выполнения задачи (формат: ГГГГ-ММ-ДД ЧЧ:ММ): ");
//        DateTime executionTime;
//        if (!DateTime.TryParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", null, System.Globalization.DateTimeStyles.None, out executionTime))
//        {
//            Console.WriteLine("Неверный формат даты и времени.");
//            return;
//        }

//        if (executionTime <= DateTime.Now)
//        {
//            Console.WriteLine("Дата и время выполнения должны быть в будущем.");
//            return;
//        }

//        var task = new ScheduledTask(description, executionTime);
//        tasks.Add(task);

//        // Start monitoring task
//        Task.Run(() => MonitorTask(task));

//        Console.WriteLine("Задача создана и будет запущена в назначенное время. Нажмите любую клавишу для возврата в меню.");
//        Console.ReadKey();
//    }

//    static void DisplayTasks()
//    {
//        Console.WriteLine("Список задач:");
//        Console.WriteLine("Описание\t\tДата и время выполнения\t\tСтатус");

//        foreach (var task in tasks)
//        {
//            Console.WriteLine($"{task.Description}\t\t{task.ExecutionTime.ToString("yyyy-MM-dd HH:mm")}\t\t{(task.IsCompleted ? "Выполнена" : "Не выполнена")}");
//        }

//        Console.WriteLine("Нажмите любую клавишу для возврата в меню.");
//        Console.ReadKey();
//    }

//    static async Task MonitorTask(ScheduledTask task)
//    {
//        var delay = task.ExecutionTime - DateTime.Now;
//        if (delay.TotalMilliseconds > 0)
//        {
//            await Task.Delay(delay);
//        }

//        // Notify user
//        Console.Beep();
//        Console.WriteLine($"Задача '{task.Description}' должна быть выполнена сейчас!");

//        task.IsCompleted = true;
//    }
//}

//class ScheduledTask
//{
//    public string Description { get; }
//    public DateTime ExecutionTime { get; }
//    public bool IsCompleted { get; set; }

//    public ScheduledTask(string description, DateTime executionTime)
//    {
//        Description = description;
//        ExecutionTime = executionTime;
//        IsCompleted = false;
//    }
//}

/// 48
//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Product
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//    public int QuantitySold { get; set; }

//    public decimal TotalSales()
//    {
//        return Price * QuantitySold;
//    }
//}

//class SalesAnalyzer
//{
//    public List<Product> Products { get; set; }

//    public SalesAnalyzer()
//    {
//        Products = new List<Product>();
//    }

//    public void AddProduct(string name, decimal price, int quantitySold)
//    {
//        Products.Add(new Product { Name = name, Price = price, QuantitySold = quantitySold });
//    }

//    public decimal TotalRevenue()
//    {
//        return Products.Sum(p => p.TotalSales());
//    }

//    public void PrintStatistics()
//    {
//        Console.WriteLine("Статистика продаж:");
//        foreach (var product in Products)
//        {
//            Console.WriteLine($"Товар: {product.Name}, Продано: {product.QuantitySold}, Общая сумма: {product.TotalSales()} руб.");
//        }
//        Console.WriteLine($"Общая сумма всех продаж: {TotalRevenue()} руб.");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        SalesAnalyzer salesAnalyzer = new SalesAnalyzer();
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\nМеню:");
//            Console.WriteLine("1. Ввести проданный товар");
//            Console.WriteLine("2. Посмотреть статистику продаж");
//            Console.WriteLine("3. Выход");
//            Console.Write("Выберите действие: ");

//            string choice = Console.ReadLine();

//            switch (choice)
//            {
//                case "1":
//                    Console.Write("Введите название товара: ");
//                    string name = Console.ReadLine();

//                    Console.Write("Введите цену товара: ");
//                    decimal price;
//                    while (!decimal.TryParse(Console.ReadLine(), out price) || price < 0)
//                    {
//                        Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное число.");
//                    }

//                    Console.Write("Введите количество проданных единиц: ");
//                    int quantity;
//                    while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0)
//                    {
//                        Console.WriteLine("Неверный ввод. Пожалуйста, введите положительное целое число.");
//                    }

//                    salesAnalyzer.AddProduct(name, price, quantity);
//                    Console.WriteLine("Товар добавлен.");
//                    break;

//                case "2":
//                    salesAnalyzer.PrintStatistics();
//                    break;

//                case "3":
//                    exit = true;
//                    Console.WriteLine("Выход из программы...");
//                    break;

//                default:
//                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }
//}

/// 49

//using System;
//using System.Collections.Generic;

//class HangmanGame
//{
//    private string secretWord;
//    private char[] guessedWord;
//    private HashSet<char> wrongGuesses;
//    private int attemptsLeft;
//    private readonly int maxAttempts = 6;

//    public HangmanGame(string word)
//    {
//        secretWord = word.ToLower();
//        guessedWord = new string('_', secretWord.Length).ToCharArray();
//        wrongGuesses = new HashSet<char>();
//        attemptsLeft = maxAttempts;
//    }

//    public void Play()
//    {
//        while (attemptsLeft > 0 && !WordGuessed())
//        {
//            Console.Clear();
//            DisplayHangman();
//            DisplayGameState();
//            char guess = GetPlayerGuess();
//            ProcessGuess(guess);
//        }

//        Console.Clear();
//        DisplayHangman();
//        if (WordGuessed())
//        {
//            Console.WriteLine($"Поздравляю! Вы угадали слово: {secretWord}");
//        }
//        else
//        {
//            Console.WriteLine($"Вы проиграли. Загаданное слово было: {secretWord}");
//        }
//    }

//    private void DisplayHangman()
//    {
//        Console.WriteLine("  +---+");
//        Console.WriteLine("  |   |");
//        Console.WriteLine($"  {(attemptsLeft <= 5 ? "O" : " ")}   |"); // Голова
//        Console.WriteLine($" {(attemptsLeft <= 3 ? "/" : " ")}{(attemptsLeft <= 4 ? "|" : " ")}{(attemptsLeft <= 2 ? "\\" : " ")}  |"); // Руки и тело
//        Console.WriteLine($" {(attemptsLeft <= 1 ? "/" : " ")} {(attemptsLeft == 0 ? "\\" : " ")}  |"); // Ноги
//        Console.WriteLine("      |");
//        Console.WriteLine("=========");
//    }

//    private void DisplayGameState()
//    {
//        Console.WriteLine("\nСлово: " + new string(guessedWord));
//        Console.WriteLine($"Ошибочные буквы: {string.Join(", ", wrongGuesses)}");
//        Console.WriteLine($"Осталось попыток: {attemptsLeft}\n");
//    }

//    private char GetPlayerGuess()
//    {
//        Console.Write("Введите букву: ");
//        char guess;
//        while (!char.TryParse(Console.ReadLine().ToLower(), out guess) || !char.IsLetter(guess))
//        {
//            Console.WriteLine("Неверный ввод. Введите одну букву.");
//        }
//        return guess;
//    }

//    private void ProcessGuess(char guess)
//    {
//        if (secretWord.Contains(guess))
//        {
//            for (int i = 0; i < secretWord.Length; i++)
//            {
//                if (secretWord[i] == guess)
//                {
//                    guessedWord[i] = guess;
//                }
//            }
//        }
//        else
//        {
//            if (!wrongGuesses.Contains(guess))
//            {
//                wrongGuesses.Add(guess);
//                attemptsLeft--;
//            }
//            else
//            {
//                Console.WriteLine("Вы уже вводили эту букву.");
//                Console.ReadKey();
//            }
//        }
//    }

//    private bool WordGuessed()
//    {
//        return !new string(guessedWord).Contains('_');
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "программа", "компьютер", "интерфейс", "алгоритм", "разработка" };
//        Random random = new Random();
//        string wordToGuess = words[random.Next(words.Length)];

//        HangmanGame game = new HangmanGame(wordToGuess);
//        game.Play();
//    }
//}

/// 50

//using System;
//using System.Collections.Generic;

//class Survey
//{
//    public string Title { get; set; }
//    public List<Question> Questions { get; set; }

//    public Survey(string title)
//    {
//        Title = title;
//        Questions = new List<Question>();
//    }

//    public void AddQuestion(Question question)
//    {
//        Questions.Add(question);
//    }

//    public void ConductSurvey()
//    {
//        Console.WriteLine($"Опрос: {Title}\n");
//        foreach (var question in Questions)
//        {
//            question.Ask();
//        }
//    }

//    public void DisplayResults()
//    {
//        Console.WriteLine($"\nРезультаты опроса: {Title}\n");
//        foreach (var question in Questions)
//        {
//            question.DisplayResult();
//        }
//    }
//}

//class Question
//{
//    public string Text { get; set; }
//    public List<string> Options { get; set; }
//    public List<int> Responses { get; set; }

//    public Question(string text, List<string> options)
//    {
//        Text = text;
//        Options = options;
//        Responses = new List<int>();
//        for (int i = 0; i < options.Count; i++)
//        {
//            Responses.Add(0); // Инициализация ответов
//        }
//    }

//    public void Ask()
//    {
//        Console.WriteLine(Text);
//        for (int i = 0; i < Options.Count; i++)
//        {
//            Console.WriteLine($"{i + 1}. {Options[i]}");
//        }

//        int choice = GetValidChoice();
//        Responses[choice - 1]++;
//    }

//    private int GetValidChoice()
//    {
//        int choice;
//        do
//        {
//            Console.Write("Ваш выбор (введите номер): ");
//        } while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > Options.Count);

//        return choice;
//    }

//    public void DisplayResult()
//    {
//        Console.WriteLine($"\nВопрос: {Text}");
//        for (int i = 0; i < Options.Count; i++)
//        {
//            Console.WriteLine($"{Options[i]}: {Responses[i]} голос(ов)");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Survey survey = new Survey("Опрос о предпочтениях программирования");

//        // Добавляем вопросы
//        survey.AddQuestion(new Question("Какой язык программирования вы предпочитаете?", new List<string> { "C#", "Python", "Java", "JavaScript" }));
//        survey.AddQuestion(new Question("Сколько лет вы программируете?", new List<string> { "Менее 1 года", "1-3 года", "3-5 лет", "Более 5 лет" }));

//        // Проводим опрос
//        survey.ConductSurvey();

//        // Отображаем результаты
//        survey.DisplayResults();
//    }
//}


/// 51 


//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.IO;
//using System.Linq;

//class WeatherData
//{
//    public DateTime Date { get; set; }
//    public double Temperature { get; set; }
//    public double Precipitation { get; set; }
//}

//class Program
//{
//    static void Main()
//    {
//        // Путь к CSV-файлу
//        string filePath = "test.csv";

//        // Чтение и парсинг данных из файла
//        List<WeatherData> weatherData = ReadWeatherData(filePath);

//        // Анализ данных
//        var monthlyStats = AnalyzeWeatherData(weatherData);

//        // Вывод статистики
//        DisplayStatistics(monthlyStats);
//    }

//    static List<WeatherData> ReadWeatherData(string filePath)
//    {
//        var weatherData = new List<WeatherData>();

//        // Чтение файла
//        var lines = File.ReadAllLines(filePath);
//        foreach (var line in lines.Skip(1)) // Пропускаем заголовок
//        {
//            var fields = line.Split(';'); // Убедитесь, что разделитель соответствует CSV-файлу
//            var date = DateTime.ParseExact(fields[0].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture); // Убираем пробелы
//            var temperature = double.Parse(fields[1].Trim(), CultureInfo.InvariantCulture);
//            var precipitation = double.Parse(fields[2].Trim(), CultureInfo.InvariantCulture);

//            weatherData.Add(new WeatherData
//            {
//                Date = date,
//                Temperature = temperature,
//                Precipitation = precipitation
//            });
//        }

//        return weatherData;
//    }


//    static Dictionary<int, (double avgTemp, double totalPrecip, int days)> AnalyzeWeatherData(List<WeatherData> weatherData)
//    {
//        // Группировка данных по месяцам и расчет статистики
//        var monthlyStats = weatherData
//            .GroupBy(data => data.Date.Month)
//            .ToDictionary(
//                g => g.Key,
//                g => (
//                    avgTemp: g.Average(data => data.Temperature),
//                    totalPrecip: g.Sum(data => data.Precipitation),
//                    days: g.Count()
//                )
//            );

//        return monthlyStats;
//    }

//    static void DisplayStatistics(Dictionary<int, (double avgTemp, double totalPrecip, int days)> monthlyStats)
//    {
//        Console.WriteLine("Статистика по месяцам:");
//        foreach (var month in monthlyStats)
//        {
//            Console.WriteLine($"Месяц {month.Key}:");
//            Console.WriteLine($"  Средняя температура: {month.Value.avgTemp:F2}°C");
//            Console.WriteLine($"  Общее количество осадков: {month.Value.totalPrecip:F2} мм");
//            Console.WriteLine($"  Количество дней: {month.Value.days}");
//        }
//    }
//}



/// 52 

//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Book
//{
//    public int Id { get; set; }
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Year { get; set; }
//    public string Genre { get; set; }

//    public override string ToString()
//    {
//        return $"ID: {Id}, Название: {Title}, Автор: {Author}, Год: {Year}, Жанр: {Genre}";
//    }
//}

//class Library
//{
//    private List<Book> books;
//    private int nextId;

//    public Library()
//    {
//        books = new List<Book>();
//        nextId = 1;
//    }

//    public void AddBook(string title, string author, int year, string genre)
//    {
//        books.Add(new Book
//        {
//            Id = nextId++,
//            Title = title,
//            Author = author,
//            Year = year,
//            Genre = genre
//        });
//        Console.WriteLine("Книга добавлена.");
//    }

//    public void RemoveBook(int id)
//    {
//        var book = books.FirstOrDefault(b => b.Id == id);
//        if (book != null)
//        {
//            books.Remove(book);
//            Console.WriteLine("Книга удалена.");
//        }
//        else
//        {
//            Console.WriteLine("Книга с таким ID не найдена.");
//        }
//    }

//    public void EditBook(int id, string title, string author, int year, string genre)
//    {
//        var book = books.FirstOrDefault(b => b.Id == id);
//        if (book != null)
//        {
//            book.Title = title;
//            book.Author = author;
//            book.Year = year;
//            book.Genre = genre;
//            Console.WriteLine("Книга обновлена.");
//        }
//        else
//        {
//            Console.WriteLine("Книга с таким ID не найдена.");
//        }
//    }

//    public void SearchBooks(string query)
//    {
//        var results = books.Where(b => b.Title.Contains(query, StringComparison.OrdinalIgnoreCase) ||
//                                       b.Author.Contains(query, StringComparison.OrdinalIgnoreCase) ||
//                                       b.Genre.Contains(query, StringComparison.OrdinalIgnoreCase));

//        if (results.Any())
//        {
//            Console.WriteLine("Результаты поиска:");
//            foreach (var book in results)
//            {
//                Console.WriteLine(book);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Книги не найдены.");
//        }
//    }

//    public void ListAllBooks()
//    {
//        if (books.Any())
//        {
//            Console.WriteLine("Список всех книг:");
//            foreach (var book in books)
//            {
//                Console.WriteLine(book);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Библиотека пуста.");
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Library library = new Library();
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("\nМеню:");
//            Console.WriteLine("1. Добавить книгу");
//            Console.WriteLine("2. Удалить книгу");
//            Console.WriteLine("3. Редактировать книгу");
//            Console.WriteLine("4. Найти книгу");
//            Console.WriteLine("5. Показать все книги");
//            Console.WriteLine("6. Выход");
//            Console.Write("Выберите действие: ");

//            string choice = Console.ReadLine();
//            switch (choice)
//            {
//                case "1":
//                    AddBook(library);
//                    break;

//                case "2":
//                    RemoveBook(library);
//                    break;

//                case "3":
//                    EditBook(library);
//                    break;

//                case "4":
//                    SearchBooks(library);
//                    break;

//                case "5":
//                    library.ListAllBooks();
//                    break;

//                case "6":
//                    exit = true;
//                    Console.WriteLine("Выход...");
//                    break;

//                default:
//                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
//                    break;
//            }
//        }
//    }

//    static void AddBook(Library library)
//    {
//        Console.Write("Введите название: ");
//        string title = Console.ReadLine();

//        Console.Write("Введите автора: ");
//        string author = Console.ReadLine();

//        Console.Write("Введите год издания: ");
//        int year = int.Parse(Console.ReadLine());

//        Console.Write("Введите жанр: ");
//        string genre = Console.ReadLine();

//        library.AddBook(title, author, year, genre);
//    }

//    static void RemoveBook(Library library)
//    {
//        Console.Write("Введите ID книги для удаления: ");
//        int id = int.Parse(Console.ReadLine());
//        library.RemoveBook(id);
//    }

//    static void EditBook(Library library)
//    {
//        Console.Write("Введите ID книги для редактирования: ");
//        int id = int.Parse(Console.ReadLine());

//        Console.Write("Введите новое название: ");
//        string title = Console.ReadLine();

//        Console.Write("Введите нового автора: ");
//        string author = Console.ReadLine();

//        Console.Write("Введите новый год издания: ");
//        int year = int.Parse(Console.ReadLine());

//        Console.Write("Введите новый жанр: ");
//        string genre = Console.ReadLine();

//        library.EditBook(id, title, author, year, genre);
//    }

//    static void SearchBooks(Library library)
//    {
//        Console.Write("Введите название, автора или жанр для поиска: ");
//        string query = Console.ReadLine();
//        library.SearchBooks(query);
//    }
//}


