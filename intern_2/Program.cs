﻿//Написать программу, которая будет выдавать название дня недели по заданному номеру
//3-> Среда
//5-> Пятница

Console.WriteLine("Введите число дня недели от 1-го до 7-ми: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day == 1)
{
    Console.WriteLine("Понедельник");
}

if(day == 2)
{
    Console.WriteLine("Вторник");
}

if(day == 3)
{
    Console.WriteLine("Среда");
}

if(day == 4)
{
    Console.WriteLine("Четверг");
}

if(day == 5)
{
    Console.WriteLine("Пятница");
}

if(day == 6)
{
    Console.WriteLine("Суббота");
}

if(day == 7)
{
    Console.WriteLine("Воскресение");
}