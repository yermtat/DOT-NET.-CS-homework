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

interface Isort
{
    void SortAsc();
    void SortDesc();
    void SortByParam(bool isAsc);

}
