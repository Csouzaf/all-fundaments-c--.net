// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text;
using fundaments;

Console.WriteLine("Hello, World!");

bool b = new(); // Resultado false
int i = new(); //Resultado 0
double d = new(); //Resultado 0.0

//Values

Console.WriteLine("Max of int:{0}", int.MaxValue);
Console.WriteLine("Min of int:{0}", int.MinValue);
Console.WriteLine("double.Epsilon:{0}", double.Epsilon);

Console.WriteLine();

//Char vai retornar métodos true ou false
char myNumber = '1';
char myChar = 'a';
Console.WriteLine("char.IsDigit = Vai representar um número:{0}", char.IsDigit(myNumber));
Console.WriteLine("char.IsLetter = Vai representar uma letra:{0}", char.IsLetter(myChar));
Console.WriteLine("char.IsWhiteSpace = Vai representar espaços que possuem a mesma quantidade de chars contando com o index :{0}", char.IsWhiteSpace("Nome como", 4));

Console.WriteLine();

//Parse
double doub = double.Parse("99.884");
int inteiro = int.Parse("1234");
Console.WriteLine("Transformou a string em um double: {0}", doub);
Console.WriteLine("Transformou a string em um inteiro: {0}", inteiro);

Console.WriteLine();

//TryParse
var vamosVer = bool.TryParse("True", out bool result);
Console.WriteLine("Vamos verificar se a variável com bool de valor 'True' vai retornar verdadeiro ou falso:{0}", vamosVer);
Console.WriteLine("O ParseTry tem por definição o => out com o tipo que nesse caso é um bool e retorna o mesmo valor que foi tentado passar: {0}", result);

Console.WriteLine();

var inte = int.TryParse("Numero Inteiro", out int resultado);
Console.WriteLine(inte);
Console.WriteLine(resultado);

Console.WriteLine();

//Date

DateTime dateTime = new(2024, 02, 16);
Console.WriteLine("A data de hoje com o construtor definido é: {0}, e dia {1}", dateTime.Date ,dateTime.DayOfWeek);

Console.WriteLine();

var dateTimeNow = DateTime.Now;
Console.WriteLine("A data de agora: {0} com DateTime.UtcNow não usa parentênses pois nao pode ser um método", dateTimeNow);
Console.WriteLine("O dia de hoje é: {0}",dateTimeNow.DayOfWeek);
Console.WriteLine("Adicionando mais dois meses a frente que será: {0}",dateTimeNow.AddMonths(2));
Console.WriteLine("Formatando a data com dateTimeNow: {0} para padrão Brasil:{1}",dateTimeNow, dateTimeNow.ToString("dd/MM/yyyy HH:mm:ss"));

Console.WriteLine();

var timeSpan = new TimeSpan(21, 2, 3);
Console.WriteLine(timeSpan);

Console.WriteLine();

//String Manipulação

string firstName = "Caique";
string lastName = " Fonseca";
Console.WriteLine("Tamanho da variável: {0} é :{1}", firstName, firstName.Length);
Console.WriteLine("Colocar a variável: {0} como Maíscula, ficando: {1}", firstName, firstName.ToUpper());
Console.WriteLine("Colocar a variável: {0} como Minúscula, ficando: {1}", firstName, firstName.ToLower());
Console.WriteLine("Verificar se é verdadeiro que a variável: {0} contém a letra 'a': {1}", firstName, firstName.Contains('a'));
Console.WriteLine("Recorte letras da variável: {0}, e não adicione nada, ficando: {1}", firstName, firstName.Replace("que", ""));
Console.WriteLine("Recorte letras da variável e adicione uma nova string: {0}, ficando: {1}", firstName, firstName.Replace("e", "Fonseca"));
Console.WriteLine("Concatenar as variáveis acima com método Concat: {0}", string.Concat(firstName, lastName));
Console.WriteLine("Verifica se a variável: {0} possui o mesmo valor de string que foi lhe dado: {1}", firstName, firstName.Equals("Caique"));
Console.WriteLine("Insira uma nova string a partir da variável: {0} buscando (a posição que se quer, o novo valor) resultando em: {1}", firstName, firstName.Insert(6, " Souza Fonseca"));

string split = "Divisão de strings.";

string[] splits = split.Split(' ');

foreach(var percorrerSplit in splits)
{
    Console.WriteLine("Será dividido a string:{0} cortando cada palavra, ficando :{1}", split, percorrerSplit);
}

string split2 = "Divisão de strings2.";

string[] splits2 = split2.Split(' ', '.');

foreach(var percorrerSplit in splits2)
{
    Console.WriteLine($"Será dividido a string: {split2}, cortando cada palavra e cortando o '.', ficando: {percorrerSplit}");
}


Console.WriteLine();

string firstName2 = "Caique";
string middleName2 = "Souza";
string lastName2 = "  Fonseca";
string name = firstName2.Trim() + middleName2.Replace(middleName2, "**") + lastName2.Trim();

Console.WriteLine($"O método trim recorta espaços vazios a esquerda e a direita, ficando: {name}, perceba q o último nome juntou");

Console.WriteLine();

//Igualdade de String 
string s1 = "Hellö!";
string s2 = "HELLÖ!";
Console.WriteLine("s1 = {0}", s1);
Console.WriteLine("s2 = {0}", s2);
Console.WriteLine();
// Check the results of changing the default compare rules.
Console.WriteLine("Verifica de forma sensitiva se: s1={0} ,s2={1}, se s1 é igual a s2: {2}", s1, s2, s1.Equals(s2));
Console.WriteLine("Verifica a igualdade ignorando a forma sensitiva e não pode ser usado para comparar palavras com caracteres especiais como ö.. porém dá mais performace : s1 é igual a s2: {0}", s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
Console.WriteLine("Verifica a igualdade ignorando a forma sensitiva e pode ser usado para comparar palavras com caracteres especiais como ö...: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}", s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));
Console.WriteLine();

//Introdução ao LINQ
int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

Console.WriteLine("Verifica a partir de uma variável (a) se o array numbers onde a < 10 então select o 'a'");
var queryLinq = from a in numbers where a < 10 select a;

foreach(var a in queryLinq)
{
    Console.WriteLine(a);
}

//Verificar se um objeto é int ou string
Console.WriteLine();
Console.WriteLine("Verifica se o objeto é um inteiro ou string");

object inteiro1 = 123;
object string1 = "String sou";
bool booleano = true;

if(inteiro1 is string myString1){
    Console.WriteLine($"{myString1} is a string");
}

if (inteiro1 is int myInt1)
{
    Console.WriteLine($"{myInt1} is an int");
}

if (string1 is string myString2)
{
    Console.WriteLine($"{myString2} is a string");
}

if(inteiro1 is not string)
{
    Console.WriteLine($"{inteiro1} is not a string");
}

if(booleano)
{
    Console.WriteLine($"Se o {booleano} for true então aparece aqui");
    Console.WriteLine($"{booleano} is true");
}

if(!booleano)
{
    Console.WriteLine($"O operador ! é usado para negar um booleano. Se o {booleano} for true, então cai aqui");
    Console.WriteLine($"{booleano} is false");
}

// Console.Write("Enter your favorite day of the week: ");
// DayOfWeek favDay;
// try
// {
//     favDay = (DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
// }
// catch (Exception)
// {
//     Console.WriteLine("Bad input!");
//     return;
// }

// switch (favDay)
// {
//     case DayOfWeek.Sunday:
//     Console.WriteLine("Football!!");
//     break;
//     case DayOfWeek.Monday:
//     Console.WriteLine("Another day, another dollar");
//     break;
//     case DayOfWeek.Tuesday:
//     Console.WriteLine("At least it is not Monday");
//     break;
//     case DayOfWeek.Wednesday:
//     Console.WriteLine("A fine day.");
//     break;
//     case DayOfWeek.Thursday:
//     Console.WriteLine("Almost Friday...");
//     break;
//     case DayOfWeek.Friday:
//     Console.WriteLine("Yes, Friday rules!");
//     break;
//     case DayOfWeek.Saturday:
//     Console.WriteLine("Great day indeed.");
//     break;
// }
Console.WriteLine();

var foo = 5;
switch (foo)
{
    case 1:
    //do something
    goto case 2;
    case 2:
    //do something else
    break;
    case 3:
    //yet another action
    goto default;
    default:
    //default action
    break;
}
Console.WriteLine();
Console.WriteLine("----Capítulo 4---");
Console.WriteLine();

Chapterfour chapterfour = new Chapterfour();
chapterfour.capituloQuatro();
