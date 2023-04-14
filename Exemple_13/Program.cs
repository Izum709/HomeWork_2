// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите целое число: ");
int number = int.Parse(Console.ReadLine());
int indNumber = Math.Abs(number);
int coint = 0;
while (indNumber > 0) 
{
    indNumber = indNumber / 10;
    coint = coint +1;
}
if (coint < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    int three = (int)(Math.Abs(number) / Math.Pow(10, coint - 3)) % 10;
    Console.WriteLine($"третье число {three}");
}
    
    




