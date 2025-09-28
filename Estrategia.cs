
using System;
using System.Collections.Generic;
using tp1;

namespace tpfinal
{

    public class Estrategia
    {
        private int CalcularDistancia(string str1, string str2)
        {
            return Utils.calculateLevenshteinDistance(str1, str2);
        }

        public String Consulta1(ArbolGeneral<DatoDistancia> arbol)
        {
            List<String> hojas = new List<String>();

            // si es hoja añado a la lista
            if (arbol.esHoja())
            {
                hojas.Add(arbol.getDatoRaiz().ToString());
            }

            // si no es hoja recorro los hijos
            else
            {
                foreach (var hijo in arbol.getHijos())
                {
                    String subHojas = "";

                    // sigo con los hijos (esto porque no es hoja)
                    subHojas = Consulta1(hijo);

                    // agrego a la lista todas los textos de las hojas
                    // ["txt1", "txt2", ...] + ["txt3, txt4, txt5", ...]
                    hojas.Add(subHojas);
                }
            }
            return String.Join("\n", hojas);
        }


        public String Consulta2(ArbolGeneral<DatoDistancia> arbol)
        {
            List<String> recorridos = new List<String>();

            // Recorro los hijos
            String raiz = arbol.getDatoRaiz().ToString() + " -> ";
            foreach (var hijo in arbol.getHijos())
            {   
                recorrerHastaHoja(hijo, raiz, recorridos);
            }

            return String.Join("\n", recorridos);
        }



        public String Consulta3(ArbolGeneral<DatoDistancia> arbol)
        {
            return arbol.recorridoPorNiveles();
        }

        public void AgregarDato(ArbolGeneral<DatoDistancia> arbol, DatoDistancia dato)
        {
            // calculo distancia entre el texto de la raíz y del dato
            int distancia = CalcularDistancia(arbol.getDatoRaiz().texto, dato.texto);
            dato.distancia = distancia; // problema 1

            // verificar si hay hijos con esa distancia
            ArbolGeneral<DatoDistancia> hijo_encontrado = null;
            foreach (var hijo in arbol.getHijos())
            {
                if (hijo.getDatoRaiz().distancia == distancia) // problema 2
                {
                    hijo_encontrado = hijo;
                    // salgo del for each
                    break;
                }
            }

            // agrego hijo o sigo bajando el arbol
            if (hijo_encontrado != null)
            {
                AgregarDato(hijo_encontrado, dato);
            }
            else
            {
                ArbolGeneral<DatoDistancia> nuevoSubarbol = new ArbolGeneral<DatoDistancia>(dato);
                arbol.agregarHijo(nuevoSubarbol);
            }
        }

        public void Buscar(ArbolGeneral<DatoDistancia> arbol, string elementoABuscar, int umbral, List<DatoDistancia> collected)
        {
            // calculo distancia entre el texto de la raíz y del dato
            int distancia = CalcularDistancia(arbol.getDatoRaiz().texto, elementoABuscar);

            // si es menor al umbral la distancia entonces hay coincidencia
            if (distancia <= umbral)
            {
                collected.Add(arbol.getDatoRaiz());
            }

            // recorro los hijos para encontrar mas coincidencias
            int limiteInferior = distancia - umbral;
            int limiteSuperior = distancia + umbral;
            foreach (var hijo in arbol.getHijos())
            {
                int distanciaHijo = hijo.getDatoRaiz().distancia;

                // si está dentro del umbral seguir buscando (para no tener que buscar el arbol completo))
                if (distanciaHijo >= limiteInferior && distanciaHijo <= limiteSuperior)
                {
                    Buscar(hijo, elementoABuscar, umbral, collected);
                }
            }
        }

        private void recorrerHastaHoja(ArbolGeneral<DatoDistancia> arbol, String camino, List<String> recorridos)
        {

            // si es hoja añado a la lista
            if (arbol.esHoja())
            {
                camino += arbol.getDatoRaiz().ToString();
                recorridos.Add(camino);
            }

            // si no es hoja recorro los hijos
            else
            {
                foreach (var hijo in arbol.getHijos())
                {
                    // problema ocurrido: estaba modificando el camino del
                    // parámetro entonces se duplicaba la raiz en
                    // el output. se arregló generando una nueva
                    // variable por cada iteración.
                    String nuevo_camino = camino + arbol.getDatoRaiz().ToString() + " -> ";

                    recorrerHastaHoja(hijo, nuevo_camino, recorridos);
                }
            }
        }
    }
}