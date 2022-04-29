// Программа, которая на вход принимает одно число (N), 
// на выходе показывает все целые числа в промежутке от -N до N

Console.Write("Enter an integer number, please => ");

int n = int.Parse(Console.ReadLine());

for(int i = -n; i <= n; i++)
{
    Console.Write(i + " ");
}
