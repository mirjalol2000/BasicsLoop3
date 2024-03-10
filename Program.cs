// See https://aka.ms/new-console-template for more information
Console.Write("Enter number : ");
int num = Convert.ToInt32(Console.ReadLine());

int p = 1;
for (int i = 1; i <= num; i++)
{
    p *= i;
}
Console.WriteLine($"{num} faktorial = "+p);
