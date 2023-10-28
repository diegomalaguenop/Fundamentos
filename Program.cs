//ejercicio 1
for(int i = 1; i <=255; i++) {
    Console.WriteLine(i);
}

Console.WriteLine("---------------");

//ejercicio 2
for (int j = 1; j <= 100; j++)
{
    if ((j % 3 == 0 || j % 5 == 0) && !(j % 3 == 0 && j % 5 == 0))
    {
        Console.WriteLine(j);
    }
}

Console.WriteLine("---------------");

//ejercicio 3
for (int y = 1; y <= 100; y++)
{
    if (y % 3 == 0 && y % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (y % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (y % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(y);
    }
}

Console.WriteLine("---------------");

//ejercicio 4
int z = 1;
while (z <= 100)
{
    if (z % 3 == 0 && z % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (z % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (z % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(z);
    }
    z++;
}

