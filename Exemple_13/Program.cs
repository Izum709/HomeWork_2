// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//  что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


        Console.Write("Введите целое число: ");
        int number = int.Parse(Console.ReadLine());

        // Получаем абсолютное значение числа
        int absNumber = Math.Abs(number);

        // Считаем количество цифр в числе
        int numDigits = 0;
        while (absNumber > 0) {
            absNumber /= 10;
            numDigits++;
        }

        // Если число содержит меньше трех цифр, значит, он не имеет третьей цифры
        if (numDigits < 3) {
            Console.WriteLine("третьей цифры нет");
        }
        // В противном случае мы можем взять третью справа цифру
        else {
            int digit = (int)(Math.Abs(number) / Math.Pow(10, numDigits - 3)) % 10;
            Console.WriteLine(digit);
        }



