// Напишите программу, которая на вход принимает два числа и 
// проверяет, является ли первое число квадратом второго

int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

bool number1square = number1 * number1 == number2;

Console.WriteLine(number1square ? "Yes" : "No");

//if(number1Square == number2)
//{
//   Console.WriteLine("Number1 is the square of number2"); 
//}
//else
//{
//    Console.WriteLine("Number1 is not the square of number2");
//}
