// See https://aka.ms/new-console-template for more information

int temp = 41;

if (temp < 0)
{
    Console.WriteLine("Cholernie piździ");
}

else if (temp >= 0 && temp < 10)
{
    Console.WriteLine("Zimno");
}

else if (temp >= 10 && temp < 20)
{
    Console.WriteLine("Chłodno");
}

else if (temp >= 20 && temp < 30)
{
    Console.WriteLine("W sam raz");

}

else if (temp >= 30 && temp < 40)
{
    Console.WriteLine("Zaczyna być słabo, bo gorąco");
}

else if (temp >= 40)
{
    Console.WriteLine("A weź, wyprowadzam się na Alaskę");
}
