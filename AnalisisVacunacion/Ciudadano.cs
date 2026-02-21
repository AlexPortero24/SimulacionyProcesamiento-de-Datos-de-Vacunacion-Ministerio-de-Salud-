using System;// Clase para representar a un ciudadano

public class Ciudadano// Esta clase representa a un ciudadano con un nombre
{
    public string Nombre { get; set; }// Propiedad para almacenar el nombre del ciudadano

    public Ciudadano(string nombre)// Constructor para inicializar el nombre del ciudadano
    {
        Nombre = nombre;// Asignar el nombre al ciudadano
    }

    public override string ToString()// Sobrescribir el método ToString para mostrar el nombre del ciudadano
    {
        return Nombre;// Devolver el nombre del ciudadano como representación de cadena
    }

    public override bool Equals(object obj)// Sobrescribir el método Equals para comparar ciudadanos por su nombre
    {
        return obj is Ciudadano ciudadano &&// Verificar si el objeto es un ciudadano y comparar sus nombres
               Nombre == ciudadano.Nombre;// Devolver true si los nombres son iguales, false en caso contrario
    }

    public override int GetHashCode()// Sobrescribir el método GetHashCode para generar un código hash basado en el nombre del ciudadano
    {
        return Nombre.GetHashCode();// Devolver el código hash del nombre del ciudadano
    }
}// Esta clase se utiliza para representar a los ciudadanos en el programa de análisis de vacunación. Cada ciudadano tiene un nombre y se pueden comparar entre sí utilizando su nombre como criterio de igualdad.