// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите количество элементов массива:");
int size = Convert.ToInt32(Console.ReadLine());
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
double min = Double.MaxValue;
double max = Double.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
    {
        max = numbers[a];
    }
    if (numbers[a] < min)
    {
        min = numbers[a];
    }
}
Console.WriteLine($"В массиве {numbers.Length} элементов. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min: #.##}");
void FillArrayRandomNumbers(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] numbers)
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