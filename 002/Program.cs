// Подсчитать сумму цифр в числе
Console.Write("Введите число - ");
int numA = Int32.Parse(Console.ReadLine());
int numB = 0;
int numC = 0;
int result = 0;
int index = 0; 
while (numA > 10)
{
    numB = numA % 10;
    numA = numA / 10;
    result = numB + result ;
    if (numA < 10)
    {
    result = result + numA;
    }
}
Console.WriteLine(result);