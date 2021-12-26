// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Brenda alanis!");

var user = new User("Enrique", "Diaz");
var matematica = new Matematica();
/*user.Name = "Enrique";
user.Surname = "Diaz";*/

matematica.Numero1 = 10;
matematica.Numero2 = 5;

Console.WriteLine(user.FullName());
Console.WriteLine("Un poco de matematica...");
Console.WriteLine(matematica.Suma());
Console.WriteLine(matematica.Resta());
Console.WriteLine(matematica.Multiplicacion());
Console.WriteLine(matematica.Division());