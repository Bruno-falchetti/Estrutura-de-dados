// Aqui criamos uma clase de tipo de dado
// abstrato
 
public class Person
{   
    public string Name { get; set; }
    public int Age { get; set; }
    public CountryEnum Nationality { get; set; }

}
//enum = enumerador
// difere de classe. É uma lista de valores
public enum CountryEnum
{
    BR, US, AR, PY
}

