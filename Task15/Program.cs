﻿// Задача 15: напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 
Console.Clear();
int [] week = {1, 2, 3, 4, 5, 6, 7};
Console.WriteLine($"Уважаемый пользователь, введите число, обозначающее день недли, от {1} до {7}: ");
int day = int.Parse(Console.ReadLine());
int n = week.Length;           // Запрос данных о размере массива.
int find = day;                // Искомое число day - номер дня недели.
int index = 0;                 // Начать исследование с нулевого элемента массива. 
while(index < n)               // Цикл проверки элементов массива. 
{
    if(week[index] == find)    
        if(index > 4)          // Если заданное число в ячейках 5 или 6, то это выходной. 
        {
            Console.WriteLine($"День недели с номером {day} является выходным."); 
        }
        else                   // Если искомое число в ячейках (0, 4) - рабочий день. 
        {
            Console.WriteLine($"День недели с номером {day} не является выходным.");
            break;             // Остановить проверку при первом совпадении чисел. 
        }
index++;                       // Перейти к проверке следующего элемента массива. 
}
