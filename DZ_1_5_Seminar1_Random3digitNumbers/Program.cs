// Напишите программу, которая принимает на вход трёхзначное число
// на выходе показывает последнюю цифру этого числа.

int inputNumber = new Random().Next(100, 1000);
int outputNumber = inputNumber % 10;

Console.WriteLine("Random number: " + inputNumber);
Console.WriteLine("Last digit of the number: " + outputNumber);
