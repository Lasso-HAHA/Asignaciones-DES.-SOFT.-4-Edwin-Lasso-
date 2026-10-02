/* Desarrollar un programa en C# que convierta una temperatura ingresada en grados Celsius a Fahrenheit y determine su categoría climática. 
 * El sistema recibirá como 1 valor de entrada: la temperatura en grados Celsius (double). Realizará 3 operaciones: convertir la temperatura a Fahrenheit 
 * multiplicando por 1.8 y sumando 32, calcular la temperatura en Kelvin sumando 273.15, y calcular un factor de ajuste térmico basado en el valor del switch. 
 * Utilizará 1 estructura switch para asignar un código numérico de categoría climática según el tramo de la temperatura ingresada. Finalmente, arrojará 2 valores de salida: 
 * la temperatura convertida en grados Fahrenheit y la categoría climática asignada.
 * fahrenheit = (celsius * 1.8) + 32
kelvin = celsius + 273.15
factorAjusteTermico = celsius * factorSwitch
*/

using System.Runtime.CompilerServices;

Console.WriteLine("----------Bienvenido al Sistema de Conversión Climatica---------------. \n Ingrese el la temperatura en C° (Celsius): "); /* SE REICBEN CELSIUS*/
double celsius = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Seleccione el Ajuste Termico Actual"); /* se selecciona ajuste termico*/
Console.WriteLine($" 1. Categoría #1 \n 2. Categoría #2 \n 3. Categoría #3");
int AJUSTE = Convert.ToInt32(Console.ReadLine());

double farenheit = (celsius*1.8) +32; /* CALKCULOS GENERALES*/
double kelvin = celsius + 273.15;
double factorAjusteTermico = celsius * AJUSTE;
string RESULTADOS = ($"La temperatura en Celius actual es de = {celsius}°\n" + /* STRING QUE JUNTA TODO*/
                    $"La temperatura Actual convertida a Fraenheti es de = {farenheit}°\n" +
                    $"La temperatura Actual convertida a Kelvin es de = {kelvin}°\n" +
                    $"Categoría Climatica Actual = {AJUSTE}\n" +
                    $"Ajuste termico acorde a la categoría en C° = {factorAjusteTermico}");

switch (AJUSTE) /* switch conajustesr*/
{
    case 1:
        Console.WriteLine($"{RESULTADOS}");
        break;
    case 2:
        Console.WriteLine($"{RESULTADOS}");
        break;
    case 3:
        Console.WriteLine($"{RESULTADOS}");
        break;
    default:
        Console.WriteLine("Condiciones Climaticas Invalidas.");
        break;
}