// See https://aka.ms/new-console-template for more information

int a = 40;
int b = 55;
int c = 65;

if (a>b && a>c) //liczba a największa
{
    if (a < (b + c))
    {
        Console.WriteLine("Można zbudować trójkąt");
    }
    else
    {
        Console.WriteLine("Nie można zbudować trójkata");
    }
}

else if (b>a && b>c) //liczba b największa
{
    if (b < (a + c))
    {
        Console.WriteLine("Można zbudować trójkąt");
    }
    else
    {
        Console.WriteLine("Nie można zbudować trójkata");
    }
}

else //liczba c największa
{
    if (c < (a + b))
    {
        Console.WriteLine("Można zbudować trójkąt");
    }
    else
    {
        Console.WriteLine("Nie można zbudować trójkata");
    }
}
