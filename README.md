# Trabajo Final - Complejidad Temporal, Estructuras de Datos y Algoritmos

Este proyecto implementa un **buscador de coincidencias aproximadas** utilizando un **árbol BK (Burkhard–Keller Tree)** con la **distancia de Levenshtein** como métrica.

El trabajo corresponde a la materia **Complejidad Temporal, Estructuras de Datos y Algoritmos** de la UNAJ.

- **Alumno**: Federico Iván Torres
- **Comisión**: 1
- **Profesor**: Pablo José Iuliano

---

## 📌 Objetivo
El sistema permite:
- **Indexar** datos de un archivo CSV en un árbol BK.
- **Buscar coincidencias aproximadas** de cadenas de texto con un nivel de tolerancia configurable (umbral).

---

## ⚙️ Funciones de Estrategia()
En esta primera etapa se implementaron:

1. **AgregarDato**  
   Inserta un nuevo dato en el árbol BK.  
   - Si el árbol está vacío, el dato se convierte en la raíz.  
   - Si no, se calcula la distancia con el nodo actual:  
     - Si ya existe un hijo en esa distancia, se baja recursivamente.  
     - Si no existe, se crea un nuevo hijo.  

2. **Buscar**  
   Realiza una búsqueda aproximada en el árbol.  
   - Se calcula la distancia entre la palabra buscada y el nodo actual.  
   - Si la distancia es menor o igual al **umbral**, se agrega a la lista de resultados.  
   - Luego se exploran recursivamente solo los hijos que estén en el rango `[d - umbral, d + umbral]`.

---

  - Umbral 1 → permite una diferencia de 1 carácter.  

---

e.AgregarDato(arbol, new DatoDistancia(0, "olor", "desc"));
e.AgregarDato(arbol, new DatoDistancia(0, "calor", "desc"));
