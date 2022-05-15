
Console.Write("Введите число: "); // Ввод значения пользователем
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.Write("{0} -> ", number);
    Console.Write(numberArray[2]);
}
else
{
    Console.Write("{0} -> ", number);
    Console.Write("третьей цифры нет");
}
