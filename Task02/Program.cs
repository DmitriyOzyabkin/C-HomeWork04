// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.




int[] CreateArrayRndNum(int size, int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write('[');
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }

        else
        {
            {
                Console.Write(array[i]);
            }
        }
    }
    Console.Write(']');
}

int CountEvenInArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (IsEven(array[i])) count++;

    }
    return count;
}

bool IsEven(int num)
{
    if (num % 2 == 0) return true;

    return false;
}

Console.Write("Enter array size: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateArrayRndNum(size, 100, 1000);
int resault = CountEvenInArray(newArray);
PrintArray(newArray);
Console.Write($" => {resault}");