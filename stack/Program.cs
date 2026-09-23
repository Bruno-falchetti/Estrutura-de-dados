using System.Collections.Generic;

// Push() -> Insere um elemento no topo da pilha
// POP() -> Remove um elemento do topo e o retorna
//Peek() -> Retorna o elemento do topo sem removê-lo

// Stack<char> caracteres = [];

// foreach(char c in "")
// {
//     caracteres.Push(c);
// }

// // Desempilhando

// string invertido = string.Empty;
// while(caracteres.Count > 0)
// {
//     invertido += caracteres.Pop();
// }

// Console.WriteLine(invertido);

Stack<char> palavra = [];
string invertido = string.Empty;
Console.WriteLine("Digite uma palavra:");
string? entrada = Console.ReadLine();

foreach (char c in entrada)
{
    palavra.Push(c);
}

while(palavra.Count > 0)
{
    invertido += palavra.Pop();
}

if(invertido == entrada){
    Console.WriteLine("Esta palavra é um palíndromo");
} else {
    Console.WriteLine("Esta palavra não é um palíndromo");
}

