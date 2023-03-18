

Console.Write("Ingrese una palabra: ");
string palabra = Console.ReadLine();

if (EsPalindromo(palabra))
{
    Console.WriteLine($"{palabra} es un palíndromo");
}
else
{
    Console.WriteLine($"{palabra} no es un palíndromo");
}
    
bool EsPalindromo(string palabra)
{
    palabra = palabra.ToLower(); 

    int longitud = palabra.Length;
    for (int i = 0; i < longitud / 2; i++)
    {
        if (palabra[i] != palabra[longitud - i - 1])
        {
            return false; 
        }
    }
    return true; 
}