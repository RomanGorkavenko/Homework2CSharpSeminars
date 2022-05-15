Console.Write("Введите число: "); // Ввод значения пользователем
int dayWeek = Convert.ToInt32(Console.ReadLine());

if (dayWeek == 6 || dayWeek == 7)
{
    Console.WriteLine("{0} -> да", dayWeek);
}
else
{
    Console.WriteLine("{0} -> нет", dayWeek);
}

// Console.WriteLine(dayWeek == 6 || dayWeek == 7 ? // Альрернативное решение
//     $"{dayWeek} -> да" :
//     $"{dayWeek} -> нет");