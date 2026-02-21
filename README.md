# Análisis de Vacunación COVID-19 en C# usando Conjuntos

## Descripción
Este proyecto simula y analiza la campaña de vacunación contra el COVID-19 utilizando **C#** y **operaciones de teoría de conjuntos**.  

Se generan datos ficticios de **500 ciudadanos**, de los cuales:  

- **75** recibieron la vacuna **Pfizer**  
- **75** recibieron la vacuna **AstraZeneca**  
- Algunos ciudadanos reciben **ambas dosis**  

El programa permite obtener los listados de:  

1. Ciudadanos que **no se han vacunado**  
2. Ciudadanos que han recibido **ambas dosis**  
3. Ciudadanos que recibieron **solo Pfizer**  
4. Ciudadanos que recibieron **solo AstraZeneca**

---

## Archivos del Proyecto

| Archivo                  | Descripción |
|---------------------------|------------|
| `Ciudadano.cs`            | Clase que representa a cada ciudadano con su nombre y permite comparaciones dentro de conjuntos. |
| `OperacionesConjuntos.cs` | Contiene métodos para generar los conjuntos de ciudadanos y aplicar operaciones de conjuntos para obtener los listados. |
| `Program.cs`              | Programa principal con menú interactivo para mostrar los diferentes listados según la opción seleccionada. |

---
