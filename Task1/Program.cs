// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    Console.Write($"{message} > ");
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int input = Prompt("Введите число > ");
int integer = input;
int revers = 0;
while (integer > 0)
{
    revers = revers * 10 + integer % 10;
    integer = integer / 10;
}
if (input == revers)
{
    Console.WriteLine($"Число {input} является палиндромом");
}
else
{
    Console.WriteLine($"Число {input} не является палиндромом");
}


