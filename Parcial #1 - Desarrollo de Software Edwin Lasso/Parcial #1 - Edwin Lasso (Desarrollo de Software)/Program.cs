/* Desarrollar un programa en C# para un sistema de evaluación académica que reciba como 4 valores de entrada: 
 * la calificación del primer parcial, la calificación del segundo parcial, el porcentaje de asistencia y el nivel del curso (1, 2 o 3). 
 * El sistema deberá realizar 4 operaciones: calcular el promedio parcial sumando ambas calificaciones y dividiendo entre dos, calcular la 
 * bonificación por asistencia multiplicando el porcentaje de asistencia por 0.05, calcular la calificación final sumando el promedio parcial 
 * con la bonificación, y calcular un factor de ajuste según el nivel del curso. Asimismo, debe incluir 3 estructuras condicionales (if) con 
 * operadores lógicos (&& o ||): una para validar si el alumno reprueba por baja asistencia o mal promedio (if (Asistencia < 70 || Promedio < 60)), 
 * otra para detectar si es candidato a excelencia (if (Calificacion1 >= 90 && Calificacion2 >= 90)), y una última para mención honorífica. Adicionalmente, 
 * utilizará 1 estructura switch basada en el nivel del curso para definir la categoría del certificado. Finalmente, 
 * el programa arrojará 3 valores de salida: la calificación final obtenida, el estado académico y la categoría de certificación asignada. */
Console.WriteLine("Bienvenido al Sistema de Evaluación del Estudiante. \n Ingrese el nombre del Estudiante: "); /* Se recibe el nombre. */
string nombreEst = Console.ReadLine();
Console.WriteLine($"Ingrese la evaluación obtenida por el Estudiante {nombreEst} en el Parcial#1: "); /* Se SE RECIBE LA PRIMERA CALIFICACIÓN. */
int calificación1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine($"Ingrese la evaluación obtenida por el Estudiante {nombreEst} en el Parcial#2: "); /* Se recibe ÑLA SEGUNDA CALIFICACION. */
int calificación2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ingrese el porcentaje de asistencia del Estudiante {nombreEst}: "); /* Se recibe el porcentaje. */
int asistencia = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Seleccione el de curso del Estudiante {nombreEst}: "); /* Se recibe el TIPO DE CURSO */
Console.WriteLine($" 1. Nivel #1 \n 2. Nivel #2 \n 3. Nivel #3");
int nivel = Convert.ToInt32(Console.ReadLine());
if ((asistencia < 0 || asistencia > 100)  /* PRIMER IF PARA ASEGURAR LA NO NEGATIVIDAD*/
        || (calificación2 > 100 || calificación2 < 0)
        || (calificación1 > 100 || calificación1 < 0)){
    Console.WriteLine("VALORES NÚMERICOS INGRESADOS INVALIDOS");
} else
{
    if (nivel ==1) /* if elses para determinar el nivel de curso*/
    {
        calculos(calificación1, calificación2, asistencia, nivel, nombreEst); /* Se renvia a un metodo estatico con todos los datos para realizar las operaciones restantes */
    }
    else if (nivel ==2)
    {
        calculos(calificación1, calificación2, asistencia, nivel, nombreEst);
    }
    else if (nivel ==3)
    {
        calculos(calificación1, calificación2, asistencia, nivel, nombreEst);
    }
    else
    {
        Console.WriteLine("Nivel de Curso Invalido.");
    }
}
static void calculos (int calificación1, int calificación2, int asistencia, int nivel, string nombreEst)
{
    int promedio = (calificación2 + calificación2) / 2; /* Se CALCULO DE PROMEDIO. */
    string resultado = ($"\nEstudiante {nombreEst} \n" +  /* se fusiona todo mediante un string para solamente llamar la variable y no repetir código */
    $"Calificación Final: {promedio}");
    if (asistencia < 70 || promedio < 60) /* en caso de que el estudiante obtenga asistencia O promeido inferior*/
    {
        Console.WriteLine($"{resultado}");
        Console.WriteLine($"Estado Academico del estudiante {nombreEst}: DESAPROBADO.");
        Console.WriteLine($"*...El estudiante {nombreEst}, no cumple con los requíitos mínimos para aprobar...*");
    }
    else if (calificación1 >= 90 && calificación2 >= 90) /* en caso de que el estudiante obtenga asistencia O promeido SUPERIOR*/
    {
        Console.WriteLine($"{resultado}");
        Console.WriteLine($"Nivel de Certificación: Curso de Nivel #{nivel}");
        Console.WriteLine($"Estado Academico del estudiante {nombreEst}: APROBADO.");
        Console.WriteLine($"*...El estudiante {nombreEst}, es candidato a excelencia academica...*");
    }
    else if (((asistencia <= 100 || asistencia >= 0) /* si esta dentro e los rangos valkidos*/
        && (calificación2 >= 0 || calificación2 <= 100)
        && (calificación1 >= 0 || calificación1 <= 100)))
    {
        Console.WriteLine($"{resultado}");
        Console.WriteLine($"Nivel de Certificación: Curso de Nivel #{nivel}");
        Console.WriteLine($"Estado Academico del estudiante {nombreEst}: APROBADO.");
    }
    else /* ELSE EN CASO DE QUE POR CUALQUIER MOTIVO, ALGUN VALOR O CONDICION INVALIDA ENTRE*/
    {
        Console.WriteLine("Valores Invalidos");
    }
}