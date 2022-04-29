// Программа, которая на вход принимает число (N),
// на выходе показывает все чётные числа от 1 до N

Console.Write("Enter a number, please => ");

int n = int.Parse(Console.ReadLine());

for(int i = 2; i <= n; i=i+2)
{
    Console.Write(i + " ");
}
