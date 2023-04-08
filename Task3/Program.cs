//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда 
//5 -> Пятница

var Mon = "Monday";
var Tue = "Tuesday";
var Wen = "Среда";
var Thu = "Четверг";
var Fri = "Пятница";
var St= "Суббота";
var Sn = "Воскресенье";

System.Console.WriteLine("Введите день недели");

 var input = int.Parse(Console.ReadLine());

 if (input == 1)
 {
    System.Console.WriteLine(Mon);
 }
 else if (input == 2)
 {
System.Console.WriteLine(Tue);
 }
 else if (input == 3)
 {
System.Console.WriteLine(Wen);
 }
 else if (input == 4)
 {
System.Console.WriteLine(Thu);
 }
 else if (input == 5)
 {
System.Console.WriteLine(Fri);
 }
 else if (input == 6)
 {
System.Console.WriteLine(St);
 }
 else if (input == 7)
 {
System.Console.WriteLine(Sn);
 }
 else 
 {
    System.Console.WriteLine("Введено некоректное число");
 }

