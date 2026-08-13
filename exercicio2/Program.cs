string palavra = "";

Console.Write("Digite uma palavra: ");
palavra = Console.ReadLine();

string[] letras = new string[palavra.Length];

for (int i = 0; i < palavra.Length; i++)
{
    letras[i] = palavra[i].ToString();
}

string invertida = "";

for (int i = letras.Length - 1; i >= 0; i--)
{
    invertida += letras[i];
}

if (palavra == invertida)
{
    Console.WriteLine("A palavra é um palíndromo.");
}
else
{
    Console.WriteLine("A palavra não é um palíndromo.");
}