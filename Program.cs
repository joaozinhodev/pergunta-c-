// See https://aka.ms/new-console-template for more information
Console.WriteLine("ai vai uma perguntinha");


Console.WriteLine("quanto e a raiz quadrada de 4 ?");
    
var conta = 0;
try
{
     conta = int.Parse(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Escreve direito o alignigena");
}

if (conta != 2)
{
    Console.WriteLine("ta errado maninho");
}
else if (conta == 2)
{
    Console.WriteLine("ta certo maninho");     
}

