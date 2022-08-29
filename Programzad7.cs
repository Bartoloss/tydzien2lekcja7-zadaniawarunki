// See https://aka.ms/new-console-template for more information

int a = 25;
int b = 63;
int c = 79;

if (a > b && a > c)
{
    Console.WriteLine("Liczba a jest największa z podanych");
}

else if (b > a && b > c)
{
    Console.WriteLine("Liczba b jest największa z podanych");
}

else
{
    Console.WriteLine("Liczba c jest największa z podanych");
}