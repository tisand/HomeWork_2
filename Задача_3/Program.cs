﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int day = int.Parse(Console.ReadLine());
if (day > 0 & day < 6)
{
    Console.WriteLine("Будний день");
}
else if (day >= 6 & day <= 7)
{
    Console.WriteLine("Выходной");
}
else
{
    Console.WriteLine("Введите пожалуйста корректное число!");
}