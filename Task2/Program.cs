//Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли второе число квадратом первого.
//a = 5; b = 25 -> да 
//a = 2 b = 10 -> нет 
//a = 9; b = -3 -> нет 
//a = -3 b = 9 -> да


Console.Write("Укажите число > ");  // Вывод на экран фразы 
string value;                       // Объявление переменной типа строка
value = Console.ReadLine();         // Считываем с консоли строку
int numberA = Convert.ToInt32(value);

Console.Write("Укажите второе число > ");  // Вывод на экран фразы                       // Объявление переменной типа строка
value = Console.ReadLine();         // Считываем с консоли строку
int numberB = Convert.ToInt32(value);
if (numberB == numberA * numberA)
{
    System.Console.WriteLine("Да является");
}
else
{
    System.Console.WriteLine("Нет не является ");
}

