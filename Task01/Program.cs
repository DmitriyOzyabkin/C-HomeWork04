// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



bool IsNotValidEnter(string number)
{
    if (number == "q") return false;
    int checkSum = SumDigits(number);
    if (checkSum % 2 == 0) return false;
    return true;
}

int SumDigits(string number)
{
    int num = Convert.ToInt32(number);
    int sum = 0;
    while (true)
    {
        int digit = num % 10;
        sum += digit;
        num /= 10;
        if (num == 0)
        return sum;
        
    }
    Console.WriteLine(sum);
    return sum;
}

while (true)
{
    Console.Write("Enter number: ");
    string enteredNumber = Console.ReadLine();
    if (IsNotValidEnter(enteredNumber) == false) break;
}
