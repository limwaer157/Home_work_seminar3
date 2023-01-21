//  Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Веддите число А - ");
int numA =Int32.Parse(Console.ReadLine());
int numB = 1;
int index = 1 ;
int numC = 0;
int numD = 0;

  while (index <= numA)
  {
    numB = index * index * index;
    numC = (numB % 10) % 2;
    index = index + 1;
    if (numC < 1) 
    {
     Console.WriteLine(numB);
    }
  }


