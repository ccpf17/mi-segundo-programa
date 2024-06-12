// See https://aka.ms/new-console-template for more information
const string MENSAJE_NOMBRE = "¿Cómo te llamas?";
const string MENSAJE_APELLIDO = "¿Cómo te apellidas?";

string nombre;
string apellido;

Console.WriteLine(MENSAJE_NOMBRE);
nombre = Console.ReadLine();

Console.WriteLine(MENSAJE_APELLIDO);
apellido = Console.ReadLine();

string salida = "Hola " + nombre + " " + apellido;
Console.WriteLine(salida);

string respuesta;
Console.Write(nombre + " ¿Quieres que pite? (S/N)");
respuesta = Console.ReadKey().KeyChar.ToString();
if (respuesta.ToLower() == "s") 
{
    Console.WriteLine(nombre + " Has elegido pitar!");
    Console.Beep(100, 300);
}
else
{
    Console.WriteLine(nombre + " ¡Que pena! No quieres que pite");
}