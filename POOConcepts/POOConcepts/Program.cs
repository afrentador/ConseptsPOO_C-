

using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1984, 3, 29));
	Console.WriteLine(new Date(1986, 9, 7));
    Console.WriteLine(new Date(2010, 11, 30));
}
catch (Exception erro)
{
	Console.WriteLine(erro.Message);
}