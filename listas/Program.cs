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


// listas de tipos abstratos (TAD)

List<Person> people = new List<Person>();

// criar uma variavel do tipo Person
Person p1 = new Person();
p1.Name = "João";
p1.Age = 42;
p1.Nationality = CountryEnum.BR;

people.Add(p1);

//  adicionando a lista inline
people.Add(new Person()
{
    Name = "Mary",
    Age = 39,
    Nationality = CountryEnum.US
});

people.Add(new Person()
{
    Name = "Juan",
    Age = 39,
    Nationality = CountryEnum.PY
});

people.Add(new Person()
{
    Name = "Carlito",
    Age = 20,
    Nationality = CountryEnum.AR
});

// exemplo de ordenação de listas genericas
// Utilizando LINQ 
List<Person> results = people.OrderBy(p => p.Name).ToList();
 
 foreach (Person p in results)
{
    Console.WriteLine($"Nome: {p.Name} - Idade: {p.Age} - Nacionalidade: {p.Nationality}");
}




