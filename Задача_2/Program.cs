//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите ваше число: ");
string midNum = Console.ReadLine()??"";

if (midNum.Length >= 3)
{
    Console.WriteLine(midNum[2]);
}
else
{
    Console.WriteLine("Третьего числа нет");
}
