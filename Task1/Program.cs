// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Prompt(string message)
{
    Console.WriteLine(message); 
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}



int action (int firstNumber, int secondNumber)
{ 
    int result = 1;
    for (int i = 0; i < secondNumber; i++)
        {result*= firstNumber;
        }
    return result;
}


int firstNumber = Prompt("Введите первое число");
int secondNumber = Prompt("Введите второе число");

int result = action(firstNumber, secondNumber);
Console.WriteLine($"{firstNumber} в степени {secondNumber} = {result} ");

