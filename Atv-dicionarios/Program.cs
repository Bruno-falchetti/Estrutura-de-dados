using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        Dictionary<string, string> produtos = new Dictionary<string, string>
        {
            { "5900000000000", "A1" },
            { "5901111111111", "B5" },
            { "5902222222222", "C9" }
        };

        produtos["5903333333333"] = "D7";

        try
        {
            produtos.Add("5904444444444", "A3");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Este código de barras já está cadastrado.");
        }

        
        Console.WriteLine("Todos os produtos:");

        if (produtos.Count == 0)
        {
            Console.WriteLine("Nenhum produto cadastrado.");
        }
        else
        {
            foreach (KeyValuePair<string, string> produto in produtos)
            {
                Console.WriteLine($"- Código de barras: {produto.Key} | Localização: {produto.Value}");
            }
        }

        
        Console.Write("Digite o código de barras para pesquisar: ");
        string codigoBarras = Console.ReadLine();

        
        if (produtos.TryGetValue(codigoBarras, out string localizacao))
        {
            Console.WriteLine($"O produto está localizado em: {localizacao}.");
        }
        else
        {
            Console.WriteLine("O produto não existe.");
        }
    }
}