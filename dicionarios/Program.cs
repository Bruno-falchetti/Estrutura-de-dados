using System.Collections;
using System.Linq.Expressions;
using System.Reflection.Metadata;

Hashtable phoneBook = new Hashtable(){
    {"Edson Arantes do Nascimento", "0000"},
    {"Ronaldo Nazario dos Santos", "1111"},
    { "Flavio Bolsonaro", "2222"}   
};

// adicionando em tempo de execução
phoneBook["Acelino Popo de Freitas"] = "3333";

// tratando possivel erro de duplicidade de chave

try
{
    phoneBook.Add("Edson Arantes do Nascimento", "0000");
}

catch (System.ArgumentException ae)
{
    Console.WriteLine ("Chave ja existente" + ae);
}
catch(System.Exception ex)
{
    Console.WriteLine ( "Erro imprevisto."+ ex.Message);
};

Console.WriteLine ("Caderninho de telefone:");
    if (phoneBook.Count == 0){
        Console.WriteLine("Agenda Vazia");    
}
else
{
    int i = 1;
    foreach (DictionaryEntry entry in phoneBook){
        Console.WriteLine ($"{i}. {entry.Key} - {entry.Value}");
        i++; 
    }
}

Console.WriteLine ("");
Console.WriteLine ("Busca por nome: ");
string name = Console.ReadLine ();

if ( phoneBook.Contains(name))
{
    string number = (string)phoneBook[name];
    Console.WriteLine(name + " - " + number);
}
else
{
    Console.WriteLine ($"{name} não encontrado");
}


// dicionarios

Dictionary< string, string> dic =
        new Dictionary<string, string>()
        {
            {"Dom Pedro II", "123456"},
            {"Joaquim José ", "112244"},
        };

string value = dic["Dom Pedro II"];
dic["Dom Pedro II"] = "111";
foreach(KeyValuePair<string, string> pair in dic)
{
    Console.WriteLine ( "" + pair.Key + "" + pair.Value);
}