// Напишите программу, которая на вход принимает число и выдаёт его квадрат
//  (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Укажите число > ");  // Вывод на экран фразы 
string value;                       // Объявление переменной типа строка
value = Console.ReadLine();         // Считываем с консоли строку
int number = Convert.ToInt32(value);// Преобразование строки в целое
System.Console.WriteLine(number);   // Вывод преобразованного значения
int result = number * number;       // Вычисление квадрата (результата)
System.Console.WriteLine("Введенное число " + number + " квадрат которого " + result);
System.Console.WriteLine($"Введенное число {number} квадрат которого {result}");

