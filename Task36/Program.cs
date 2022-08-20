//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6]-> 0

Console.WriteLine("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
int sum = 0;
for (int a = 0; a < numbers.Length; a += 2)
    sum = sum + numbers[a];

Console.WriteLine($"В массиве {numbers.Length} элементов, сумма элементов на нечётных позициях = {sum}");
void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length - 1) Console.Write($"{numbers[i]}, ");
        else Console.Write(numbers[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}