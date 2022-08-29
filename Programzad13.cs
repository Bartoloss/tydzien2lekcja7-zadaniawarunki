// See https://aka.ms/new-console-template for more information

Console.WriteLine("Podaj pierwszą liczbę:");

string a = Console.ReadLine();

Console.WriteLine("Podaj drugą liczbę:");

string b = Console.ReadLine();

Console.WriteLine("Podaj numer operacji do wykonania: ");
Console.WriteLine("1.Dodawanie");
Console.WriteLine("2.Odejmowanie");
Console.WriteLine("3.Mnożenie");
Console.WriteLine("4.Dzielenie");

string choice = Console.ReadLine();

int chosenOption = 0;
int aa;
int bb;

Int32.TryParse(a, out aa);
Int32.TryParse(b, out bb);
Int32.TryParse(choice, out chosenOption);

if (chosenOption == 1)
{
    int c = aa + bb;
    Console.WriteLine($"Wynik dodawania to {c}");
}

else if (chosenOption == 2)
{
    int d = aa - bb;
    Console.WriteLine($"Wynik odejmowania to {d}");
}

else if(chosenOption == 3)
{
    int e = aa * bb;
    Console.WriteLine($"Wynik mnożenia to {e}");
}

else if(chosenOption == 4)
{
    int f = aa / bb;
    Console.WriteLine($"Wynik dzielenia to {f}");
}

else
{
    Console.WriteLine("Spróbuj jeszcze raz. Wybierz numer od 1 do 4.");
}