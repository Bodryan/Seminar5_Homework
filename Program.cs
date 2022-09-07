
void Zadacha34()
{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    Console.WriteLine("Введие размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;
    Console.WriteLine();

    fillArray(array, size, 100, 999);
    Console.WriteLine("Дан одномерный массив:");
    printArray(array, size);
    Console.WriteLine();
    Console.WriteLine();

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Четных чисел в массиве = {count}");
}

void Zadacha36()
{
    // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

    Console.WriteLine("Введие размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;

    fillArray(array, size, -100, 100);
    Console.WriteLine();
    Console.WriteLine("Дан одномерный массив");
    printArray(array, size);
    Console.WriteLine();
    Console.WriteLine();

    for(int i = 1; i < size; i += 2)
    {
        Console.Write($"{array[i]} + ");
        sum += array[i];
    }
    Console.WriteLine($"\b\b= {sum}");
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов стоящих на нечётных позициях = {sum}");
}

void Zadacha38()
{
    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    Console.WriteLine("Введие размер массива:");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    double result = 0;

    fillArrayDouble(array, size);
    Console.WriteLine();
    Console.WriteLine("Дан одномерный массив");
    printArrayDouble(array, size);
    Console.WriteLine();
    Console.WriteLine();

    for (int i = 0; i < size; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < size; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }

        double temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp; 
    }

    result = Math.Round(array[size -1] - array[0], 2);
    Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {array[size -1]} - {array[0]} = {result}");

}


void printArrayDouble(double[] array, int size) // Вывести массив вещественных чисел в консоль 
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}

void fillArrayDouble(double[] array, int size, int statNumber = -10, int finishNumber = 10) // Получить одномерный массив вещественных чисел
{
    Random random = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100, 2);
    }
}

void fillArray(int[] array, int size, int statNumber = -10, int finishNumber = 10) // Получить одномерный массив
{
    Random random = new Random();
    for(int i = 0; i < size; i++)
    {
        array[i] = random.Next(statNumber, finishNumber);
    }
}

void printArray(int[] array, int size) // Вывести массив в консоль
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"[{array[i]}] ");
    }
}


// Zadacha34();
// Zadacha36(); 
// Zadacha38();