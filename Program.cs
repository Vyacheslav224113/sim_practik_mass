﻿// Задание 1. Совместная работа
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.

// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// тип_данных[] имяМассива =
int[] array = {11, 22, 33, 44, 55, 66, 77, 88, 99 };
int numberForSearch = 4;
bool isFound = false; // число не найдено
// точка старта, условие, увеличение счетчика;
for(int i = 0; i < array.Length; i++)
{
    if(numberForSearch == array[i])
    {
        isFound = true;
        break;
    }
}
if(isFound)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}