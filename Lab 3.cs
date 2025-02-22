List<string> estudiantes = new List<string>();
List<double> calificaciones = new List<double>();

// FUNCION PARA AGREGAR ESTUDIANTE
string AggEstudiante()
{
    Console.Write("Ingrese el nombre del estudiante: ");
    string nombre = Console.ReadLine();
    Console.Write("Ingrese la calificación del estudiante: ");
    double calificacion = double.Parse(Console.ReadLine());
    estudiantes.Add(nombre);
    calificaciones.Add(calificacion);
    return "Estudiante agregado correctamente.";
}

// FUNCION PARA MOSTRAR LISTA DE ESTUDIANTES
string MostEstudiante()
{
    if (estudiantes.Count == 0)
    {
        return "No hay estudiantes registrados.";
    }
    else
    {
        string listaEstudiantes = "\nLista de estudiantes:\n";
        for (int i = 0; i < estudiantes.Count; i++)
        {
            listaEstudiantes += $"{estudiantes[i]} - Calificación: {calificaciones[i]}\n";
        }
        return listaEstudiantes;
    }
}

// FUNCION PARA CALCULAR PROMEDIO DE CALIFICACIONES
string Calc()
{
    if (calificaciones.Count == 0)
    {
        return "No hay calificaciones registradas.";
    }
    else
    {
        double suma = 0;
        foreach (double calificacion in calificaciones)
        {
            suma += calificacion;
        }
        double promedio = suma / calificaciones.Count;
        return $"El promedio de calificaciones es: {promedio}";
    }
}

// FUNCION PARA MOSTRAR ESTUDIANTE CON LA CALIFICACION MAS ALTA
string MejorCalificacion()
{
    if (calificaciones.Count == 0)
    {
        return "No hay calificaciones registradas.";
    }
    else
    {
        double maxCalificacion = calificaciones[0];
        string estudianteMax = estudiantes[0];
        for (int i = 1; i < calificaciones.Count; i++)
        {
            if (calificaciones[i] > maxCalificacion)
            {
                maxCalificacion = calificaciones[i];
                estudianteMax = estudiantes[i];
            }
        }
        return $"El estudiante con la calificación más alta es: {estudianteMax} con {maxCalificacion}";
    }
}

// MENÚ PRINCIPAL

Console.WriteLine("Bienvenido al sistema de gestión de estudiantes.");

while (true)
{
    Console.WriteLine("\n1. Agregar estudiante");
    Console.WriteLine("2. Mostrar lista de estudiantes");
    Console.WriteLine("3. Calcular promedio de calificaciones");
    Console.WriteLine("4. Mostrar estudiante con la calificación más alta");
    Console.WriteLine("5. Salir");
    Console.Write("Seleccione una opción: ");
    int opcion = int.Parse(Console.ReadLine());

    string resultado;

    switch (opcion)
    {
        case 1:
            resultado = AggEstudiante();
            break;
        case 2:
            resultado = MostEstudiante();
            break;
        case 3:
            resultado = Calc();
            break;
        case 4:
            resultado = MejorCalificacion();
            break;
        case 5:
            Console.WriteLine("Saliendo del sistema...");
            return;
        default:
            resultado = "Opción no válida. Intente de nuevo.";
            break;
    }

    Console.WriteLine(resultado);
}
