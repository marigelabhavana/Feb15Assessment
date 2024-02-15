// See https://aka.ms/new-console-template for more information

Console.WriteLine("Fibonacci Series");
int n = 10;
int a = 0, b = 1;
for (int i = 0; i < n; i++)
{
    Console.WriteLine("{0}", a);
    int c = a + b;
    a = b;
    b = c;
}