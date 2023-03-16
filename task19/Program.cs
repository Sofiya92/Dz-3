// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Неверное число");
    return;
}

if (GetDigit(number, 1) == GetDigit(number, 5) && GetDigit(number, 2) == GetDigit(number, 4))
    Console.WriteLine("Палиндром");
else
    Console.WriteLine("Не палиндром");

int GetDigit(int num, int digitNum)
{
    return (num / Convert.ToInt32(Math.Pow(10, digitNum-1))) % 10;
}
