// See https://aka.ms/new-console-template for more information

int mat = 80;
int fiz = 71;
int chem = 0;

int suma = mat + fiz + chem;

int matfiz = mat + fiz;
int matchem = mat + chem;

if ((mat>70 && fiz>55 && chem>40 && suma>180) || (matfiz>150) || (matchem>150))
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}

else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}
