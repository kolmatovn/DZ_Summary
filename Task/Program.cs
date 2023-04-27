/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */


using System;
using static System.Console;

Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(ReadLine());
string[] stringArray = new string[m];

void GetArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = ReadLine();
    }
}

string[] FindElementLength(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] rez = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}

void printArray(string[] array)
{
    Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Write(array[i] + ", "); 
    }
    Write("]");
}

GetArray(stringArray);
printArray(stringArray);
Write(" -> ");
printArray(FindElementLength(stringArray));