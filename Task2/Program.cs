
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Prompt(string message) // метод для введения и прочитывания числа
{
    Console.WriteLine(message); 
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput); // перевод строки в число
    return result;
}

int count (int number)
{   int result =0;
    while (number >0)
        { result += number % 10;
          number = number / 10;  
        }
    return result;
}
int result = Prompt("Введите Ваше число");

Console.WriteLine("Сумма чисел в числе равна = "+ count(result));

