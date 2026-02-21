using System;// Programa principal para analizar la vacunación de ciudadanos utilizando conjuntos
using System.Collections.Generic;// Importar el espacio de nombres para utilizar HashSet

class Program// Esta clase contiene el método Main, que es el punto de entrada del programa. Permite al usuario interactuar con un menú para ver diferentes conjuntos de ciudadanos según su estado de vacunación.
{
    static void Main()// Método principal del programa
    {
        OperacionesConjuntos op = new OperacionesConjuntos();// Crear una instancia de la clase OperacionesConjuntos para manejar los datos de los ciudadanos y sus vacunas
        op.GenerarDatos();// Generar datos de ejemplo para los ciudadanos y sus vacunas

        bool salir = false;// Variable para controlar el bucle del menú

        while (!salir)// Bucle para mostrar el menú de opciones hasta que el usuario decida salir
        {
            Console.WriteLine("\n===== MENÚ DE OPCIONES =====");// Mostrar el menú de opciones al usuario
            Console.WriteLine("1. Ver ciudadanos NO vacunados");// Opción para ver el conjunto de ciudadanos que no han sido vacunados
            Console.WriteLine("2. Ver ciudadanos con AMBAS dosis");// Opción para ver el conjunto de ciudadanos que han recibido ambas dosis
            Console.WriteLine("3. Ver ciudadanos con SOLO Pfizer");// Opción para ver el conjunto de ciudadanos que han sido vacunados solo con Pfizer
            Console.WriteLine("4. Ver ciudadanos con SOLO AstraZeneca");// Opción para ver el conjunto de ciudadanos que han sido vacunados solo con AstraZeneca
            Console.WriteLine("5. Salir");// Opción para salir del programa
            Console.Write("Seleccione una opción: ");// Pedir al usuario que seleccione una opción del menú

            string opcion = Console.ReadLine();// Leer la opción seleccionada por el usuario

            switch (opcion)// Estructura de control para ejecutar la acción correspondiente según la opción seleccionada por el usuario
            {
                case "1":// Si el usuario selecciona la opción 1, mostrar el conjunto de ciudadanos que no han sido vacunados
                    MostrarConjunto(op.ObtenerNoVacunados(), "No vacunados");// Llamar al método MostrarConjunto para mostrar el conjunto de ciudadanos no vacunados con el título "No vacunados"
                    break;// Romper el switch para evitar ejecutar las demás opciones
                case "2":// Si el usuario selecciona la opción 2, mostrar el conjunto de ciudadanos que han recibido ambas dosis
                    MostrarConjunto(op.ObtenerAmbasDosis(), "Ambas dosis");// Llamar al método MostrarConjunto para mostrar el conjunto de ciudadanos con ambas dosis con el título "Ambas dosis"
                    break;
                case "3":// Si el usuario selecciona la opción 3, mostrar el conjunto de ciudadanos que han sido vacunados solo con Pfizer
                    MostrarConjunto(op.ObtenerSoloPfizer(), "Solo Pfizer");// Llamar al método MostrarConjunto para mostrar el conjunto de ciudadanos vacunados solo con Pfizer con el título "Solo Pfizer"
                    break;
                case "4":// Si el usuario selecciona la opción 4, mostrar el conjunto de ciudadanos que han sido vacunados solo con AstraZeneca
                    MostrarConjunto(op.ObtenerSoloAstra(), "Solo AstraZeneca");// Llamar al método MostrarConjunto para mostrar el conjunto de ciudadanos vacunados solo con AstraZeneca con el título "Solo AstraZeneca"
                    break;
                case "5":// Si el usuario selecciona la opción 5, salir del programa
                    salir = true;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:// Si el usuario selecciona una opción inválida
                    Console.WriteLine("Opción inválida. Intente de nuevo.");// Mostrar un mensaje de error indicando que la opción seleccionada no es válida
                    break;// Romper el switch para evitar ejecutar las demás opciones
            }
        }
    }// Método para mostrar un conjunto de ciudadanos con un título específico

    static void MostrarConjunto(HashSet<Ciudadano> conjunto, string titulo)// Este método recibe un conjunto de ciudadanos y un título, y muestra la información del conjunto en la consola
    {
        Console.WriteLine($"\n===== {titulo.ToUpper()} =====");// Mostrar el título del conjunto en mayúsculas para resaltar la sección
        Console.WriteLine("Total: " + conjunto.Count);// Mostrar el total de ciudadanos en el conjunto utilizando la propiedad Count del HashSet
        int contador = 1;// Variable para numerar los ciudadanos al mostrarlos en la consola
        foreach (var c in conjunto)// Bucle para iterar sobre cada ciudadano en el conjunto y mostrar su información
        {
            Console.WriteLine($"{contador}. {c}");// Mostrar el número del ciudadano seguido de su información (en este caso, su nombre) utilizando el método ToString de la clase Ciudadano
            contador++;// Incrementar el contador para numerar el siguiente ciudadano
        }
    }
}// Este programa permite al usuario analizar la vacunación de ciudadanos utilizando conjuntos. El usuario puede seleccionar diferentes opciones para ver los ciudadanos que no han sido vacunados, aquellos que han recibido ambas dosis, y aquellos que han sido vacunados solo con Pfizer o solo con AstraZeneca. La información se muestra en la consola de manera clara y organizada.