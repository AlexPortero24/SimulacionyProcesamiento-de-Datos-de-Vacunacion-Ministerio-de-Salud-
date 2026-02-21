using System;// Clase para realizar operaciones con conjuntos de ciudadanos
using System.Collections.Generic;// Importar el espacio de nombres para utilizar HashSet

public class OperacionesConjuntos// Esta clase contiene métodos para realizar operaciones con conjuntos de ciudadanos, como obtener no vacunados, ambas dosis, solo Pfizer y solo AstraZeneca
{
    public HashSet<Ciudadano> ciudadanos = new HashSet<Ciudadano>();// Conjunto de todos los ciudadanos
    public HashSet<Ciudadano> pfizer = new HashSet<Ciudadano>();// Conjunto de ciudadanos vacunados con Pfizer
    public HashSet<Ciudadano> astra = new HashSet<Ciudadano>();// Conjunto de ciudadanos vacunados con AstraZeneca

    public void GenerarDatos()// Método para generar datos de ejemplo para los ciudadanos y sus vacunas
    {
        // 500 ciudadanos
        for (int i = 1; i <= 500; i++)// Generar 500 ciudadanos con nombres "Ciudadano 1", "Ciudadano 2", ..., "Ciudadano 500"
        {
            ciudadanos.Add(new Ciudadano("Ciudadano " + i));// Agregar cada ciudadano al conjunto de ciudadanos
        }

        // 75 Pfizer
        for (int i = 1; i <= 75; i++)// Generar 75 ciudadanos vacunados con Pfizer con nombres "Ciudadano 1", "Ciudadano 2", ..., "Ciudadano 75"
        {
            pfizer.Add(new Ciudadano("Ciudadano " + i));// Agregar cada ciudadano al conjunto de ciudadanos vacunados con Pfizer
        }

        // 75 AstraZeneca (algunos repetidos para ambas dosis)
        for (int i = 76; i < 150; i++)
        {
            astra.Add(new Ciudadano("Ciudadano " + i));// Agregar cada ciudadano al conjunto de ciudadanos vacunados con AstraZeneca
        }
    }

    public HashSet<Ciudadano> ObtenerNoVacunados()// Método para obtener el conjunto de ciudadanos que no han sido vacunados
    {
        HashSet<Ciudadano> resultado = new HashSet<Ciudadano>(ciudadanos);// Crear un nuevo conjunto con todos los ciudadanos
        resultado.ExceptWith(pfizer);// Eliminar los ciudadanos vacunados con Pfizer del conjunto de ciudadanos
        resultado.ExceptWith(astra);// Eliminar los ciudadanos vacunados con AstraZeneca del conjunto de ciudadanos
        return resultado;// Devolver el conjunto de ciudadanos que no han sido vacunados
    }

    public HashSet<Ciudadano> ObtenerAmbasDosis()// Método para obtener el conjunto de ciudadanos que han recibido ambas dosis de vacuna (Pfizer y AstraZeneca)
    {
        HashSet<Ciudadano> resultado = new HashSet<Ciudadano>(pfizer);// Crear un nuevo conjunto con los ciudadanos vacunados con Pfizer
        resultado.IntersectWith(astra);// Intersectar con los ciudadanos vacunados con AstraZeneca
        return resultado;// Devolver el conjunto de ciudadanos que han recibido ambas dosis
    }

    public HashSet<Ciudadano> ObtenerSoloPfizer()// Método para obtener el conjunto de ciudadanos que han sido vacunados solo con Pfizer
    {
        HashSet<Ciudadano> resultado = new HashSet<Ciudadano>(pfizer);// Crear un nuevo conjunto con los ciudadanos vacunados con Pfizer
        resultado.ExceptWith(astra);// Eliminar los ciudadanos vacunados con AstraZeneca
        return resultado;// Devolver el conjunto de ciudadanos vacunados solo con Pfizer
    }

    public HashSet<Ciudadano> ObtenerSoloAstra()// Método para obtener el conjunto de ciudadanos que han sido vacunados solo con AstraZeneca
    {
        HashSet<Ciudadano> resultado = new HashSet<Ciudadano>(astra);// Crear un nuevo conjunto con los ciudadanos vacunados con AstraZeneca
        resultado.ExceptWith(pfizer);// Eliminar los ciudadanos vacunados con Pfizer
        return resultado;// Devolver el conjunto de ciudadanos vacunados solo con AstraZeneca
    }

}// Esta clase se utiliza para realizar operaciones con conjuntos de ciudadanos en el programa de análisis de vacunación. Permite generar datos de ejemplo, obtener ciudadanos no vacunados, aquellos que han recibido ambas dosis, y aquellos que han sido vacunados solo con Pfizer o solo con AstraZeneca.
