/*Задание 1
Создайте интерфейс IOutput. В нём должно быть два
метода:
■ void Show() — отображает информацию;
■ void Show(string info) — отображает информацию и
информационное сообщение, которое было указано
в параметре info.
Создайте класс Array (массив целого типа) с необходимыми методами. Этот класс должен имплементировать
интерфейс IOutput.
Метод Show() — отображает на экран элементы массива.
Метод Show(string info) — отображает на экран элементы массива и информационное сообщение, указанное
в параметре info.
Напишите код для тестирования полученной функциональности.*/



//Array arr = new();
//arr.Show();
//arr.Show("\"Never gonna give you up never gonna let you down never gonna run around and desert you\" Rick Astley");

/*Задание 2
Создайте интерфейс IMath. В нём должно быть четыре метода:
■ int Max() — возвращает максимум;
■ int Min() — возвращает минимум;
■ float Avg() — возвращает среднеарифметическое;
■ bool Search(int valueToSearch) — ищет valueSearch
внутри контейнера данных. Возвращает true, если
значение найдено. Возвращает false, если значение
не найдено.
*/

//Console.WriteLine(arr.Min());
//Console.WriteLine(arr.Max());
//Console.WriteLine(arr.Avg());
//Console.WriteLine(arr.Search(5));
//Console.WriteLine(arr.Search(45));


/*Задание 3
Создайте интерфейс ISort. В нём должно быть два
метода
■ void SortAsc() — сортировка по возрастанию;
■ void SortDesc() — сортировка по убыванию;
■ void SortByParam(bool isAsc) — сортировка в зависимости от переданного параметра. Если isAsc равен
true, сортируем по возрастанию. Если isAsc равен false,
сортируем по убыванию.
*/

class Array : IOutput, IMath, Isort
{
    private int[] arr;
    private static Random rnd = new Random();

    public Array()
    {
        arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
    }

    public Array(int range)
    {
        arr = new int[10];

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(0, range);
        }
    }

    public void Show()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Show();
        Console.WriteLine(info);
    }

    public int Max()
    {
        return arr.Max();
    }

    public int Min()
    {
        return arr.Min();
    }

    public float Avg()
    {
        return (float)arr.Average();
    }

    public bool Search(int valueToSearch)
    {
        return arr.Contains(valueToSearch);
    }

    public void SortAsc()
    {
        int i, j, tmp;
        for (i = 0; i < arr.Length; i++)
        {
            tmp = arr[i];
            for (j = i - 1; j >= 0 && arr[j] > tmp; j--)
            {
                arr[j + 1] = arr[j];
            }
            arr[j + 1] = tmp;
        }
    }

    public void SortDesc()
    {
        int i, j, tmp;
        for (i = 0; i < arr.Length; i++)
        {
            tmp = arr[i];
            for (j = i - 1; j >= 0 && arr[j] < tmp; j--)
            {
                arr[j + 1] = arr[j];
            }
            arr[j + 1] = tmp;
        }
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc) SortAsc();
        else SortDesc();
    }
}
