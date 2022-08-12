// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("How many numbers do you want to enter? Insert number: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
FillArray(array);
PrintArray(array);
GreaterThat0(array);


void FillArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Insert the number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
}

void GreaterThat0(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
    count++;
    }
}
Console.WriteLine($"{count} numbers greater than 0 entered by the user");
}