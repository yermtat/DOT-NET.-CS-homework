#region task 1

//Задание 1
//Пользователь вводит с клавиатуры число в диапазоне от 1 до 100. Если
//число кратно 3 (делится на 3 без
//остатка) нужно вывести слово Fizz. Если число кратно 5
//нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
//вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
//вывести само число.
//Если пользователь ввел значение не в диапазоне от 1
//до 100 требуется вывести сообщение об ошибке.


//Console.WriteLine("Enter any number from 1 to 100:");
//int number = Int32.Parse(Console.ReadLine());

//if (number > 100 || number < 1)
//{
//    Console.WriteLine("Wrong number");
//}
//else if (number % 3 == 0 && number % 5 == 0)
//{
//    Console.WriteLine("Fizz Buzz");
//}
//else if (number % 3 == 0)
//{
//    Console.WriteLine("Fizz");
//}
//else if (number % 5 == 0)
//{
//    Console.WriteLine("Buzz");
//}
//else
//{
//    Console.WriteLine(number);
//}

#endregion

#region task 2

//Задание 2
//Пользователь вводит с клавиатуры показания температуры. В зависимости от 
//выбора пользователя программа переводит температуру из Фаренгейта в 
//Цельсий или наоборот.


//Console.WriteLine("Choose an option:\n1. Celsius - Farenheit\n2. Farenheit - Celsius");
//int choise = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter temperature:");
//int temp = Int32.Parse(Console.ReadLine());


//int DoOperation(int choise, int temp)
//{
//    switch (choise)
//    {
//        case 1: return temp * 9 / 5 + 32;
//        case 2: return (temp - 32) * 5 / 9;
//        default: return -1000;
//    };
//}

//int result = DoOperation(choise, temp);

//if (result == -1000)
//{
//    Console.WriteLine("Wrong option");
//}
//else
//{
//    Console.WriteLine(result);
//}

#endregion

#region task 3

//Задание 3
//Пользователь вводит с клавиатуры два числа. Нужно 
//показать все четные числа в указанном диапазоне. Если 
//границы диапазона указаны неправильно требуется произвести нормализацию 
//границ. Например, пользователь 
//ввел 20 и 11, требуется нормализация, после которой 
//начало диапазона станет равно 11, а конец 20


//Console.WriteLine("Enter start number:");
//int start = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter end number:");
//int end = Int32.Parse(Console.ReadLine());

//if (start > end)
//{
//    start += end;
//    end = start - end;
//    start = start - end;
//}

//for (int i = start; i <= end; i++)
//{
//    if (i % 2 == 0) Console.Write($"{i} ");
//}

#endregion

#region task 4

//Задание 4
//Пользователь с клавиатуры вводит шестизначное число. 
//Необходимо перевернуть число и отобразить результат. 
//Например, если введено 341256, результат 652143


//Console.WriteLine("Enter any 6-digit number:");
//int number = Int32.Parse(Console.ReadLine());

//if (number < 100000 || number > 1000000)
//{
//    Console.WriteLine("Wrong number");
//    return;
//}

//int new_number = 0;
//for (int i = 6; i > 0; i--)
//{
//    new_number += number % 10 * Convert.ToInt32(Math.Pow(10, i - 1));
//    number /= 10;
//}

//Console.WriteLine(new_number);

#endregion

#region task 5

//Задание 5
//Пользователь вводит с клавиатуры границы числового 
//диапазона. Требуется показать все числа Фибоначчи из 
//этого диапазона. Числа Фибоначчи — элементы числовой 
//последовательности, в которой первые два числа равны 0
//и 1, а каждое последующее число равно сумме двух предыдущих чисел. 
//Например, если указан диапазон 0–20,
//результат будет: 0, 1, 1, 2, 3, 5, 8, 13.


//int[] fib_numbers = new int[40];
//fib_numbers[0] = 0;
//fib_numbers[1] = 1;

//for (int i = 2;i < fib_numbers.Length; i++)
//{
//    fib_numbers[i] = fib_numbers[i - 1] + fib_numbers[i - 2];
//}


//Console.WriteLine("Enter start number:");
//int start = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter end number:");
//int end = Int32.Parse(Console.ReadLine());

//if (start > end)
//{
//    start += end;
//    end = start - end;
//    start = start - end;
//}

//for (int i = 0; i < fib_numbers.Length; i++)
//{
//   if (fib_numbers[i] >= start && fib_numbers[i] <= end)
//    {
//        Console.Write($"{fib_numbers[i]} ");
//    }
//}

#endregion

#region task 6

//Задание 6
//Даны целые положительные числа A и B (A < B). Вывести все целые числа от 
//A до B включительно; каждое
//число должно выводиться на новой строке; при этом каждое число должно 
//выводиться количество раз, равное 
//его значению. Например: если А = 3, а В = 7, то программа 
//должна сформировать в консоли следующий вывод:
//3 3 3
//4 4 4 4
//5 5 5 5 5
//6 6 6 6 6 6
//7 7 7 7 7 7 7.


//int a = 7, b = 11;

//for (int i = a; i <= b; i++)
//{
//	for (int j = 0; j < i; j++)
//	{
//        Console.Write($"{i} ");
//    }
//    Console.WriteLine();
//}

#endregion

#region task 7

//Задание 7
//Пользователь с клавиатуры вводит длину линии, символ заполнитель,
//направление линии (горизонтальная,
//вертикальная). Программа отображает линию по заданным 
//параметрам. Например: +++++.
//Параметры линии: горизонтальная линия, длина равна 
//пяти, символ заполнитель +


//Console.WriteLine("Choose an option:\n1. Horizontal\n2. Vertical");
//int choose = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter length: ");
//int length = Int32.Parse(Console.ReadLine());
//Console.WriteLine("Enter a symbol:");
//string symb = Console.ReadLine();
//Console.WriteLine();

//switch (choose)
//{
//    case 1:
//        for (int i = 0; i < length; i++)
//        {
//            Console.Write(symb);
//        }
//        break;
//    case 2:
//        for (int i = 0; i < length; i++)
//        {
//            Console.WriteLine(symb);
//        }
//        break;
//}

#endregion