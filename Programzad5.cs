// See https://aka.ms/new-console-template for more information

int a = 21;

if (a<21)
{
    Console.WriteLine("Nie możesz zostać posłem, premierem, senatorem ani prezydentem");

}

else if (a >= 21 && a < 30)
{
    Console.WriteLine("Możesz zostać posłem");
    Console.WriteLine("Możesz zostać premierem");
}

else if (a >= 30 && a < 35)
{
    Console.WriteLine("Możesz zostać posłem");
    Console.WriteLine("Możesz zostać premierem");
    Console.WriteLine("Możesz zostać senatorem");
}

else if (a >= 35)
{
    Console.WriteLine("Możesz zostać posłem");
    Console.WriteLine("Możesz zostać premierem");
    Console.WriteLine("Możesz zostać senatorem");
    Console.WriteLine("Możesz zostać prezydentem");
}

