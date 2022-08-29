// See https://aka.ms/new-console-template for more information

int a = 160;

if (a > 0 && a < 150)
{
    Console.WriteLine("Jesteś krasnoludem");
}

else if (a >= 150 && a < 180)
{
    Console.WriteLine("Jesteś przeciętnego wzrostu");
}

else if (a >= 180)
{
    Console.WriteLine("Jesteś żyrafą");
}

else
{
    Console.WriteLine("Wzrost nie może być liczbą ujemną");
}