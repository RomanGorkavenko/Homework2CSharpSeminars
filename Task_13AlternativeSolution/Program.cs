Console.Write("Введите число: "); // Ввод значения пользователем
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number > 99 ?
    $"{number} -> {number.ToString()[2]}" :
    $"{number} -> третьей цифры нет");
