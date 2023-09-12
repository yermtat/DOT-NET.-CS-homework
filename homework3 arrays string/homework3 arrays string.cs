
#region task 1

/*Задание 1
Объявить одномерный(5 элементов) массив с именем A и двумерный массив (3 строки, 4 столбца) дробных чисел с именем B. 
Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а
двумерный массив В случайными числами с помощью
циклов. Вывести на экран значения массивов: массива
А в одну строку, массива В — в виде матрицы. Найти в
данных массивах общий максимальный элемент, минимальный элемент, общую сумму всех элементов, общее
произведение всех элементов, сумму четных элементов
массива А, сумму нечетных столбцов массива В.*/


//float[] A = new float[5];
//float[,] B = new float[3, 4];

//Console.WriteLine("Enter 5 numbers: ");

//for (int i = 0; i < A.Length; i++)
//{
//    float.TryParse(Console.ReadLine(), out A[i]);
//}

//Random rnd = new Random();

//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < B.GetLength(1); j++)
//    {
//        B[i, j] = (float)Math.Round(rnd.NextDouble(), 1) + rnd.Next(0, 10);
//    }
//}


//for (int i = 0; i < A.Length; ++i)
//{
//    Console.Write($"{A[i]} ");
//}
//Console.WriteLine('\n');

//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < B.GetLength(1); j++)
//    {
//        Console.Write($"{B[i, j]}\t");
//    }
//    Console.WriteLine();
//}


//int length = default;


//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < B.GetLength(1); j++)
//    {
//        for (int k = 0; k < A.Length; k++)
//        {
//            if (B[i, j] == A[k])
//            {
//                length++;
//            }
//        }
//    }
//}


//float[] common = new float[length];
//int count = 0;

//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < B.GetLength(1); j++)
//    {
//        for (int k = 0; k < A.Length; k++)
//        {
//            if (B[i, j] == A[k])
//            {
//                common[count++] = A[k];
//            }
//        }
//    }
//}


//for (int i = 0; i < common.Length; ++i)
//{
//    Console.Write($"{common[i]} ");
//}
//Console.WriteLine('\n');

//Console.WriteLine($"Common max element: {common.Max()}, min element: {common.Min()}");


//float summ = 0;
//float multi = 1;

//for (int i = 0; i < A.Length; ++i)
//{
//    summ += A[i];
//    multi *= A[i];
//}
//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < B.GetLength(1); j++)
//    {
//        summ += B[i, j];
//        multi *= B[i, j];
//    }
//}

//Console.WriteLine($"Summ of the elements: {summ}\nMultiplication of the elements: {multi}");

//float evenSummA = 0;
//float oddSummColB = 0;

//for (int i = 0; i < A.Length; i++)
//{
//    if (A[i] % 2 == 0)
//    {
//        evenSummA += A[i];
//    }
//}
//for (int i = 0; i < B.GetLength(0); i++)
//{
//    for (int j = 0; j < B.GetLength(1); j++)
//    {
//        if ((j + 1) % 2 != 0)
//        {
//            oddSummColB += B[i, j];
//        }
//    }
//}
//Console.WriteLine($"Summ of even A numbers: {evenSummA}, summ of odd columns B numbers: {oddSummColB}");
#endregion

#region task 2

/*Задание 2
Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100. 
Определить сумму элементов массива, расположенных 
между минимальным и максимальным элементами.*/


//int[,] multiArr = new int[5, 5];

//Random rnd = new Random();

//for (int i = 0; i < multiArr.GetLength(0); i++)
//{
//	for (int j = 0; j < multiArr.GetLength(1); j++)
//	{
//		multiArr[i, j] = rnd.Next(-100, 100);
//	}
//}

//showArr(multiArr);

//int max = multiArr[0, 0], min = multiArr[0, 0];
//int maxIndI = 0, maxIndJ = 0, minIndI = 0, minIndJ = 0;

//for (int i = 0; i < multiArr.GetLength(0); i++)
//{
//	for (int j = 0; j < multiArr.GetLength(1); j++)
//	{
//		if (multiArr[i, j] > max)
//		{
//			maxIndI = i;
//			maxIndJ= j;
//			max = multiArr[i, j];
//		}
//	}
//}

//for (int i = 0; i < multiArr.GetLength(0); i++)
//{
//    for (int j = 0; j < multiArr.GetLength(1); j++)
//    {
//        if (multiArr[i, j] < min)
//        {
//            minIndI = i;
//            minIndJ = j;
//			min = multiArr[i, j];	
//        }
//    }
//}

//int tmpI = 0, tmpJ = 0, tmpMin = min, tmpMax = max, tmp = 0;

//if (minIndI > maxIndI)
//{
//	tmpI = minIndI;
//	minIndI = maxIndI;
//	maxIndI = tmpI;

//	tmpJ = minIndJ;
//	minIndJ = maxIndJ;
//	maxIndJ = tmpJ;

//    tmp = tmpMin;
//    tmpMin = tmpMax;
//    tmpMax = tmp;
//}

//else if (minIndI == maxIndI && minIndJ > maxIndJ)
//{
//    tmpJ = minIndJ;
//    minIndJ = maxIndJ;
//    maxIndJ = tmpJ;

//    tmp = tmpMin;
//    tmpMin = tmpMax;
//    tmpMax = tmp;
//}


//int summ = 0;

//for (int i = minIndI; i <= maxIndI; i++)
//{
//	for (int j = 0; j <= multiArr.GetLength(1) - 1; j++)
//	{
//		if (i == minIndI && j <= minIndJ) continue;
//		if (multiArr[i, j] == tmpMax) break;
//		summ += multiArr[i, j];
//	}
//}


//Console.WriteLine($"min: {min}, max: {max}");
//Console.WriteLine($"summ: {summ}");


#endregion

#region task 3

/*Задание 3
Пользователь вводит строку с клавиатуры. Необходимо зашифровать данную строку используя шифр Цезаря. 
Из Википедии:
Шифр Цезаря — это вид шифра подстановки, в котором каждый символ в открытом тексте заменяется 
символом, находящимся на некотором постоянном числе 
позиций левее или правее него в алфавите. Например,
в шифре со сдвигом вправо на 3, A была бы заменена на 
D, B станет E, и так далее.
Подробнее тут: https://en.wikipedia.org/wiki/Caesar_
cipher.
Кроме механизма шифровки, реализуйте механизм 
расшифрования.*/


//Console.WriteLine("Enter any english string: ");
//string str = Console.ReadLine();
//Console.Write("Enter a key number: ");

//Int32.TryParse(Console.ReadLine(),out int key);

//char[] strChar = str.ToCharArray();

//for (int i = 0; i < strChar.Length; i++)
//{
//    if (strChar[i] >= 'A' && strChar[i] <= 'Z' || strChar[i] >= 'a' && strChar[i] <= 'z')
//    {
//        if (strChar[i] <= 'Z' && strChar[i] > 'Z' - key)
//        {
//            strChar[i] = (char)('A' - 1 + (key - ('Z' - strChar[i])));
//        }
//        else if (strChar[i] > 'z' - key)
//        {
//            strChar[i] = (char)('a' - 1 + (key - ('z' - strChar[i])));
//        }
//        else
//        {
//            strChar[i] += (char)key;
//        }
//    }
//}

//string newStr = new string(strChar);
//Console.WriteLine(newStr);


//for (int i = 0; i < strChar.Length; i++)
//{
//    if (strChar[i] >= 'A' && strChar[i] <= 'Z' || strChar[i] >= 'a' && strChar[i] <= 'z')
//    {
//        if (strChar[i] < 'A' + key)
//        {
//            strChar[i] = (char)('Z' + 1 - (key - (strChar[i] - 'A')));
//        }
//        else if (strChar[i] >= 'a' && strChar[i] < 'a' + key)
//        {
//            strChar[i] = (char)('z' + 1 - (key - (strChar[i] - 'a')));
//        }
//        else
//        {
//            strChar[i] -= (char)key;
//        }
//    }
//}

//string newStr2 = new string(strChar);
//Console.WriteLine(newStr2);

#endregion

#region task 4

/* Задание 4
Создайте приложение, которое производит операции 
над матрицами:
■ Умножение матрицы на число;
■ Сложение матриц;
■ Произведение матриц.*/


//int[,] Arr = new int[5, 5];

//Random rnd = new Random();

//for (int i = 0; i < Arr.GetLength(0); i++)
//{
//    for (int j = 0; j < Arr.GetLength(1); j++)
//    {
//        Arr[i, j] = rnd.Next(0, 10);
//    }
//}

//showArr(Arr);

//int[,] multiArr = new int[5, 5], summArr = new int[5, 5];
//int number = 5;

//for (int i = 0; i < Arr.GetLength(0); i++)
//{
//    for (int j = 0; j < Arr.GetLength(1); j++)
//    {
//        multiArr[i, j] = Arr[i, j] * number;
//    }
//}

//Console.WriteLine();
//showArr(multiArr);

//for (int i = 0; i < summArr.GetLength(0); i++)
//{
//    for (int j = 0; j < summArr.GetLength(1); j++)
//    {
//        summArr[i, j] = Arr[i, j] + multiArr[i, j];
//    }
//}

//Console.WriteLine();
//showArr(summArr);

//int[,] multiMatrix = new int[Arr.GetLength(0), multiArr.GetLength(1)];

//for (int i = 0; i < multiMatrix.GetLength(0); i++)
//{
//    for (int j = 0; j < multiMatrix.GetLength(1); j++)
//    {
//        for (int k = 0; k < Arr.GetLength(1); k++)
//        {
//            multiMatrix[i, j] += Arr[i, k] * multiArr[k, j];
//        }
//    }
//}

//Console.WriteLine();
//showArr(multiMatrix);

#endregion

#region task 5

/*Задание 5
Пользователь с клавиатуры вводит в строку арифметическое выражение. Приложение должно посчитать 
его результат. Необходимо поддерживать только две 
операции: +и –.*/

Console.WriteLine("Enter an expression + or -: ");
string exp = Console.ReadLine();

int find_index = -1, exp_number = 0, result = 0;

//string[] expArr = exp.Split('+');

//foreach (string s in expArr)
//{

//}

for (int i = 0; i < exp.Length; i++)
{
    if (exp[i] == '+' || i == exp.Length - 1)
    {
        result += Int32.Parse(exp[(find_index+1)..i]);
        find_index= i;
    }
    else if (exp[i] == '-')
    {
        result -= Int32.Parse(exp[(find_index + 1)..i]);
        find_index = i;
    }
}

Console.WriteLine($"Result: {result}");

#endregion



void showArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}