// Программа, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка)

Console.Write("Enter any number, please: ");

int number = int.Parse(Console.ReadLine());

bool numbereven = number % 2 == 0;

Console.WriteLine(numbereven ? "Yes, it's even" : "No, it's odd");