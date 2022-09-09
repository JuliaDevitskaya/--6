/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


using static System.Console;
Clear();

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = int.Parse(ReadLine());
}
WriteLine($"[{String.Join(",", array)}]");

int result = Calculate(array);
WriteLine(result);



int Calculate(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}








