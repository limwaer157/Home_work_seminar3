// Найти кубы чисел от 1 до N
Console.Write("Число А - ");
int numA = Int32.Parse(Console.ReadLine());
int index = 1;
double result = 1;
int numB = 1;
while (index <= numA)
{
    result = index * index * index;
    index = index + 1;
    Console.WriteLine(result);
}
