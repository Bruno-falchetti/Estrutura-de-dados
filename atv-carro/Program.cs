using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, Automovel> carros = new();
        int op;
        do
        {
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Buscar placa");
            Console.WriteLine("3 - Listar");
            Console.WriteLine("4 - Buscar por marca");
            Console.WriteLine("5 - Sair");
        
            Console.Write("Opção: ");
            op = int.Parse(Console.ReadLine());

            if (op == 1)
            {
                Console.Write("Placa: ");
                string placa = Console.ReadLine().ToUpper();

                if (carros.ContainsKey(placa))
                {
                    Console.WriteLine("Placa já cadastrada.");
                    continue;
                }
                Automovel carro = new();
                carro.Placa = placa;
                Console.Write("Marca: ");
                carro.Marca = Console.ReadLine();
                Console.Write("Modelo: ");
                carro.Modelo = Console.ReadLine();
                Console.Write("Ano: ");
                carro.Ano = int.Parse(Console.ReadLine());
                Console.Write("Cor: ");
                carro.Cor = Console.ReadLine();
                Console.Write("Valor: ");
                carro.Valor = decimal.Parse(Console.ReadLine());

                carros.Add(placa, carro);
                Console.WriteLine("Cadastrado!");
            }

            else if (op == 2)
            {
                Console.Write("Placa: ");
                string placa = Console.ReadLine().ToUpper();

                if (carros.TryGetValue(placa, out Automovel carro))
                    Mostrar(carro);
                else
                    Console.WriteLine("Não encontrado.");
            }

            else if (op == 3)
            {
                if (carros.Count == 0)
                    Console.WriteLine("Nenhum carro cadastrado.");

                foreach (Automovel carro in carros.Values)
                    Mostrar(carro);
            }

            else if (op == 4)
            {
                Console.Write("Marca: ");
                string marca = Console.ReadLine();
                bool achou = false;

                foreach (Automovel carro in carros.Values)
                    if (carro.Marca.ToLower() == marca.ToLower())
                    {
                        Mostrar(carro);
                        achou = true;
                    }

                if (!achou)
                    Console.WriteLine("Nenhum carro encontrado.");
            }

        } while (op != 5);
    }

    static void Mostrar(Automovel c)
    {
        Console.WriteLine(
            $"Placa: {c.Placa} | Marca: {c.Marca} | Modelo: {c.Modelo} | " +
            $"Ano: {c.Ano} | Cor: {c.Cor} | Valor: R$ {c.Valor:F2}");
    }
}

class Automovel
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public string Cor { get; set; }
    public decimal Valor { get; set; }
}