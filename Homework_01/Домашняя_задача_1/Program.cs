﻿// Задача 0: Напишите программу, 
// которая на вход принимает 2 числа и выдает,
// какое число больше, а какое меньше.
// a = 5; b = 7 → max = 7
// a = 2; b = 10 → max = 10
// a = -9; b = -3 → max = -3

// start

int a = -9, b = -3;
int max = 0;

if (a > b)

{
    max = a;
}

else

{
    max = b;
}

Console.WriteLine(max);

// end
