// See https://aka.ms/new-console-template for more information
const string MENSAJE_NOMBRE = "¿Cómo te llamas?";
const string MENSAJE_APELLIDO = "¿Cómo te apellidas?";

string nombre;
string apellido = "Pareja";

Console.WriteLine(MENSAJE_NOMBRE);
nombre = Console.ReadLine();

Console.WriteLine(MENSAJE_APELLIDO);
apellido = Console.ReadLine();

string salida = "Hola " + nombre + " " + apellido;
Console.WriteLine(salida);
