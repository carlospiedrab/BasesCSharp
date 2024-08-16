// See https://aka.ms/new-console-template for more information

using Models;

int x = 12;

Console.WriteLine("El valor es: " + x);
Console.WriteLine($"El valor de X es: {x}");

string nombres = "Carlos";
string apellidos = "Piedra";

Console.WriteLine($"Nombre Completo: {nombres} {apellidos}");

nombres = "Ricardo";
Console.WriteLine($"Nombre Completo: {nombres.ToUpper()} {apellidos.ToUpper()}");

bool IsMayor = false;
int edad = 19;

// if(edad >= 18)
// {
//     IsMayor = true;
// }

// if(IsMayor == true)
// {
//     Console.WriteLine("Es Mayor de Edad");
// }
// else {
//     Console.WriteLine("Es Menor de Edad");
// }

IsMayor = edad >= 18;
Console.WriteLine((IsMayor) ? "Es mayor de Edad" : "Es Menor de Edad");

int kilometros = 100;
ConvertidorUnidad kilometrosAMetros = new ConvertidorUnidad(1000);
Console.WriteLine($"{kilometros} Kilometros son {kilometrosAMetros.Convertir(kilometros)} metros");

Punto p1 = new Punto();
p1.x = 7;
p1.y = 0;

Punto p2 = p1;
Console.WriteLine($"Punto 1 : {p1.x} {p1.y}");
Console.WriteLine($"Punto 2 : {p2.x} {p2.y}");
p1.x = 8;
Console.WriteLine($"Punto 1 : {p1.x} {p1.y}");
Console.WriteLine($"Punto 2 : {p2.x} {p2.y}");

// string[] personas = new string[5];
// personas[0] = "Carlos";
// personas[1] = "Ricardo";
// personas[2] = "Enrique";
// personas[3] = "Julio";
// personas[4] = "Manuel";

string[] personas = new string[] { "Carlos", "Ricardo", "Enrique", "Julio", "Manuel" };

for (int i = 0; i < personas.Length; i++)
    Console.WriteLine("nombre:" + personas[i]);

char letra;
string resultado;
Console.WriteLine("Ingrese una letra:");
letra = Convert.ToChar(Console.ReadLine());

// switch (Char.ToLower(letra))
// {
//     case 'a':
//         resultado = "La letra es una vocal";
//         break;
//     case 'e':
//         resultado = "La letra es una vocal";
//         break;
//     case 'i':
//         resultado = "La letra es una vocal";
//         break;
//     case 'o':
//         resultado = "La letra es una vocal";
//         break;
//     case 'u':
//         resultado = "La letra es una vocal";
//         break;
//     default:
//         resultado = "La letra NO es una vocal";
//         break;
// }

// switch (Char.ToLower(letra))
// {
//     case 'a':
//     case 'e':
//     case 'i':
//     case 'o':
//     case 'u':
//     resultado = "La letra es una vocal";
//     break;
//     default:
//     resultado = "La letra NO es una vocal";
//        break;
// }

resultado = letra switch
{
    'a' => "La letra es una vocal",
    'e' => "La letra es una vocal",
    'i' => "La letra es una vocal",
    'o' => "La letra es una vocal",
    'u' => "La letra es una vocal",
    _ => "La letra NO es una vocal"
};

Console.WriteLine(resultado);

Persona persona = new Persona()
{
    Id = 1,
    Nombres = "Carlos Ricardo",
    Apellidos = "Piedra Bonilla",
    Genero = Genero.Masculino,
};

Console.WriteLine($"La Persona: {persona.NombreCompleto} de genero {persona.Genero}");