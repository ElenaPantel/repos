// Программа, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

int max = number1;
int min = number2;

if (number2 > max) max = number2;
if (number1 < number2) min = number1;

Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);
