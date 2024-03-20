// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)

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

int[] ReverseArray(int[] array)
{
    
}
int[] initArray = CreateArrayRndNum(6, 1, 10);

PrintArray(initArray);
Console.Write($" => [reversed array]");

