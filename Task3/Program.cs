// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int volue = Prompt("Введите число");
Math.Pow(volue,2);   
int i = 1;
while (i <= volue)
{
double r =  Math.Pow(i,3);
Console.WriteLine($"Куб числа {i} от 1 до введенного равен {r}");
i++;
} 



