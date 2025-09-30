# Trabajo Final - Complejidad Temporal, Estructuras de Datos y Algoritmos

Este proyecto implementa un **buscador de coincidencias aproximadas** utilizando un **árbol BK (Burkhard–Keller Tree)** con la **distancia de Levenshtein** como métrica.

El trabajo corresponde a la materia **Complejidad Temporal, Estructuras de Datos y Algoritmos** de la UNAJ.

- **Alumno**: Federico Iván Torres
- **Comisión**: 1
- **Profesor**: Pablo José Iuliano

---

## Objetivo
El sistema permite:
- **Indexar** datos de un archivo CSV en un árbol BK.
- **Buscar coincidencias aproximadas** de cadenas de texto con un nivel de tolerancia configurable (umbral).

---

## Funciones de Estrategia()
En esta primera etapa se implementaron:

1. **AgregarDato**: Inserta un nuevo dato en el árbol BK.

   -> Si el árbol está vacío, el dato se convierte en la raíz.  
   -> Si no, se calcula la distancia con el nodo actual:  
     ---> Si ya existe un hijo en esa distancia, se baja recursivamente.  
     ---> Si no existe, se crea un nuevo hijo.  

3. **Buscar**: Realiza una búsqueda aproximada en el árbol.
   
   -> Se calcula la distancia entre la palabra buscada y el nodo actual.  
   -> Si la distancia es menor o igual al **umbral**, se agrega a la lista de resultados.  
   -> Luego se exploran recursivamente solo los hijos que estén en el rango `[d - umbral, d + umbral]`.

5. **Consulta `1`**: Devuelve todas las **hojas del árbol BK** en un texto.

   -> Se recorre el árbol recursivamente y se concatenan esas hojas en un string.  

7. **Consulta `2`**: Devuelve todos los **caminos desde la raíz hasta cada hoja**.

   -> Se arma una lista temporal con el recorrido actual.  
   -> Cada vez que se llega a una hoja, se agrega ese camino completo al texto resultado.  

8. **Consulta `3`**: Devuelve los datos de los nodos del árbol **agrupados por nivel**.
   
   -> Se recorre el árbol y se concatenan los nodos de cada nivel en el texto.
   -> Es básicamente un recorrido por nivel.


---
