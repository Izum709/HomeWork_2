// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число от 1 до 7:");
int day = int.Parse(Console.ReadLine());
if(day ==1) Console.WriteLine( "Это понедельник, иди работай ");
if(day ==2) Console.WriteLine( "Это вторник, иди работай");
if(day ==3) Console.WriteLine( "Это среда, иди работай");
if(day ==4) Console.WriteLine( "Это четверг, иди работай");
if(day ==5) Console.WriteLine( "Это пятница, иди работай");
if(day ==6) Console.WriteLine( "Это суббота, можешь отдохнуть =)");
if(day ==7) Console.WriteLine( "Это воскресенье, можешь отдохнуть, но завтра на работу!");

