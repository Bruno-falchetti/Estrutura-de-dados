using System.Collections;
using System.Globalization;
ArrayList arrayList = new ArrayList();


//adicionando itens a lista
arrayList.Add(5);

// Adicionando quantias de itens a lista

arrayList.AddRange(new int[] { 1, 2, 3 });

arrayList.Insert (3, 7.8);


// percorrendo itens da lista de forma generica 
foreach (object obj in arrayList)
{
    Console.WriteLine(obj);
};



// listas genericas 

List<double> numbers = new List<double>();

Console.WriteLine("Digite sair para encerrar.");

bool run = true;

do
{
    Console.WriteLine("Digite um numero: ");
    string numberStr = Console.ReadLine();

    if (numberStr.Equals("sair"))
    {
        run = false;
        Console.WriteLine("Encerrando o processo.");
        break;
    }
    else
    {
        if (!double.TryParse(
            numberStr,
            System.Globalization.NumberStyles.Float,
            new NumberFormatInfo(),
            out double number)){
                Console.WriteLine("Valor digitado não é um numero.");
                continue;   
                }
        numbers.Add(number);
        Console.WriteLine("A media dos valores informados é: " + numbers.Average());
    }

} while (run);
